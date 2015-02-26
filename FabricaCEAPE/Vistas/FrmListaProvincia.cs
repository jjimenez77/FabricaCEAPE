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
    public partial class FrmListaProvincia : Form
    {
        public FrmListaProvincia()
        {
            InitializeComponent();
            this.cbPais.ComboBox.DataSource = DatosPais.getPaises();
            this.cbPais.ComboBox.ValueMember = "id";
            this.cbPais.ComboBox.DisplayMember = "nombre";
            Actualizar();
        }

        private void Actualizar()
        {            
            provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.ComboBox.SelectedValue);        
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
            FrmEditarProvincia p = new FrmEditarProvincia(0);
            p.ShowDialog();
            Actualizar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarProvincia edit = new FrmEditarProvincia(((Provincia)provinciaBindingSource.Current).Id);
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
                Provincia p = (Provincia)provinciaBindingSource.Current;
                if (!DatosProvincia.enUso(p.Id))
                {
                    p.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + p.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosProvincia.Modificar(p);
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

        private void cbPais_DropDownClosed_1(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void provinciaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = provinciaDataGridView.CurrentRow.Index;
                    FrmEditarProvincia edit = new FrmEditarProvincia(((Provincia)provinciaDataGridView.Rows[seleccion].DataBoundItem).Id);
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
