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
    public partial class FrmListaMarca : Form
    {
        public FrmListaMarca()
        {
            InitializeComponent();

            this.txtBuscar.Focus();

            Actualizar();

            //ScrollableControl ctl = dtgMarcas.Controls;

            //if (dtgMarcas.VerticalScrollingOffset > dtgMarcas..width(DataGridViewElementStates.Visible))

            //{
            //dtgMarcas.Width = dtgMarcas.colum.Width;
            //}

           // VScrollBar vb = sender as VScrollBar;

            //DataGridViewColumn column = dtgMarcas.Columns[0];
            ////column.Width = 200;
            //dtgMarcas.Width = 200 + column.Width;

        }

        private void Actualizar()
        {
            marcaBindingSource.DataSource = DatosMarca.getMarcas();
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
            FrmEditarMarca m = new FrmEditarMarca(0);
            m.ShowDialog();
            Actualizar();   
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmEditarMarca edit = new FrmEditarMarca(((Marca)marcaBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Marca m = (Marca)marcaBindingSource.Current;
                if (!DatosMarca.enUso(m.Id))
                {
                    m.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + m.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosMarca.Modificar(m);
                        Actualizar();
                    }
                }
                else
                {
                    MessageBox.Show("El objeto seleccionado no puede ser eliminado");
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = dtgMarcas.CurrentRow.Index;
                    FrmEditarMarca edit = new FrmEditarMarca(((Marca)dtgMarcas.Rows[seleccion].DataBoundItem).Id);
                    edit.ShowDialog();
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
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

                dtgMarcas.DataSource = DatosMarca.getMarcasPorNombre(txtBuscar.Text);
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }
    }
}
