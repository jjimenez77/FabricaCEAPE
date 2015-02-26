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
    public partial class FrmListaTipoMateriaPrima : Form
    {
        public FrmListaTipoMateriaPrima()
        {
            InitializeComponent();
            Actualizar();
        }

        private void Actualizar()
        {
            tipoMateriaPrimaBindingSource.DataSource = DatosTipoMateriaPrima.getTiposMateriaPrima();
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

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarTipoMateriaPrima t = new FrmEditarTipoMateriaPrima(0);
            t.ShowDialog();
            Actualizar(); 
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmEditarTipoMateriaPrima edit = new FrmEditarTipoMateriaPrima(((TipoMateriaPrima)tipoMateriaPrimaBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó ");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                TipoMateriaPrima t = (TipoMateriaPrima)tipoMateriaPrimaBindingSource.Current;
                if (!DatosTipoMateriaPrima.enUso(t.Id))
                {
                    t.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + t.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosTipoMateriaPrima.Modificar(t);
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

        private void paisDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = paisDataGridView.CurrentRow.Index;
                    FrmEditarTipoMateriaPrima edit = new FrmEditarTipoMateriaPrima(((TipoMateriaPrima)paisDataGridView.Rows[seleccion].DataBoundItem).Id);
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
