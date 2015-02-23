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
    public partial class FrmListaRepartidor : Form
    {
        public FrmListaRepartidor()
        {
            InitializeComponent();
            Actualizar();
        }

        private void Actualizar()
        {
            try
            {
                repartidorBindingSource.DataSource = DatosRepartidor.getRepartidores();
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
            //repartidorDataGridView.Columns[5].DefaultCellStyle.Format = "(###) ###-####";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarRepartidor r = new FrmEditarRepartidor(0);
            r.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarRepartidor edit = new FrmEditarRepartidor(((Repartidor)repartidorBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Repartidor r = (Repartidor)repartidorBindingSource.Current;
                r.Activo = false;

                if (MessageBox.Show("¿Esta seguro de borrar a " + r.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosRepartidor.Modificar(r);
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void repartidorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = repartidorDataGridView.CurrentRow.Index;
                    FrmEditarRepartidor edit = new FrmEditarRepartidor(((Repartidor)repartidorBindingSource.Current).Id);
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
