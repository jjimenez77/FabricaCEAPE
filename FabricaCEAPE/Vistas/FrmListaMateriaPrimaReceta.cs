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
    public partial class FrmListaMateriaPrimaReceta : Form
    {
        public FrmListaMateriaPrimaReceta()
        {
            InitializeComponent();

            this.txtBuscar.Focus();

            Actualizar();
        }

        private void Actualizar()
        {
            materiaPrimaRecetaBindingSource.DataSource = DatosMateriaPrimaReceta.getMateriaPrimaRecetas();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarMateriaPrimaReceta mpr = new FrmEditarMateriaPrimaReceta(0);
            mpr.ShowDialog();
            Actualizar(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarMateriaPrimaReceta edit = new FrmEditarMateriaPrimaReceta(((MateriaPrimaReceta)materiaPrimaRecetaBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void materiaPrimaRecetaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = materiaPrimaRecetaDataGridView.CurrentRow.Index;
                    FrmEditarMateriaPrimaReceta edit = new FrmEditarMateriaPrimaReceta(((MateriaPrimaReceta)materiaPrimaRecetaDataGridView.Rows[seleccion].DataBoundItem).Id);
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

                materiaPrimaRecetaBindingSource.DataSource = DatosMateriaPrimaReceta.getMateriaPrimaPorNombre(txtBuscar.Text);
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }
    }
}
