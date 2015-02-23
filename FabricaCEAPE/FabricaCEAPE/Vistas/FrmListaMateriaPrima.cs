using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;

namespace FabricaCEAPE.Vistas
{
    public partial class FrmListaMateriaPrima : Form
    {
        public FrmListaMateriaPrima()
        {
            InitializeComponent();

            cbSelector.Items.Add("Nombre");
            cbSelector.Items.Add("Proveedor");
            cbSelector.Items.Add("Tipo de materia prima");
            
            cbSelector.SelectedIndex = 0;
            this.txtBuscar.Focus();            

            Actualizar();
        }

        private void Actualizar()
        {
            try
            {
                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {
                    materiaPrimaBindingSource.DataSource = DatosMateriaPrima.getMateriasPrimas();//getMateriaPrimaPorTipo((int)cbTipoMateriaPrimas.ComboBox.SelectedValue);
                }
            }
            catch
            {
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarMateriaPrima mp = new FrmEditarMateriaPrima(0);
            mp.ShowDialog();
            Actualizar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarMateriaPrima edit = new FrmEditarMateriaPrima(((MateriaPrima)materiaPrimaBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrima mp = (MateriaPrima)materiaPrimaBindingSource.Current;
                mp.Activo = false;

                if (MessageBox.Show("¿Esta seguro de dar de baja a " + mp.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosMateriaPrima.Modificar(mp);
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbTipoMateriaPrimas_DropDownClosed(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Actualizar();

            if (cbSelector.SelectedIndex == 0)
            {
                txtBuscar.ToolTipText = "Buscar materia prima por nombre";
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                txtBuscar.ToolTipText = "Buscar materia prima por proveedor";
            }
            else
            {
                txtBuscar.ToolTipText = "Buscar materia prima por tipo de materia prima";
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    Actualizar();
                }

                if(cbSelector.SelectedIndex == 0)
                {
                    materiaPrimaBindingSource.DataSource = DatosMateriaPrima.getMateriasPrimasPorNombre(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    materiaPrimaBindingSource.DataSource = DatosMateriaPrima.getMateriasPrimasPorProveedor(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 2)
                {
                    materiaPrimaBindingSource.DataSource = DatosMateriaPrima.getMateriasPrimasPorTipo(txtBuscar.Text);
                }
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }

        private void materiaPrimaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = materiaPrimaDataGridView.CurrentRow.Index;
                    FrmEditarMateriaPrima edit = new FrmEditarMateriaPrima(((MateriaPrima)materiaPrimaDataGridView.Rows[seleccion].DataBoundItem).Id);
                    edit.ShowDialog();
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }
    }
}
