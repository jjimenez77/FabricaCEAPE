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
    public partial class FrmListaTipoEnvasado : Form
    {
        public FrmListaTipoEnvasado()
        {
            InitializeComponent();
            Actualizar();
        }

        private void Actualizar()
        {
            tipoEnvasadoBindingSource.DataSource = DatosTipoEnvasado.getTipoEnvasados();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditTipoEnvasado p = new FrmEditTipoEnvasado(0);
            p.ShowDialog();
            Actualizar(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditTipoEnvasado edit = new FrmEditTipoEnvasado(((TipoEnvasado)tipoEnvasadoBindingSource.Current).IdTipoEnvasado);
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
                TipoEnvasado p = (TipoEnvasado)tipoEnvasadoBindingSource.Current;
                p.Activo = false;

                if (MessageBox.Show("¿Esta seguro de borrar a " + p.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosTipoEnvasado.Modificar(p);
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void tipoEnvasadoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = tipoEnvasadoDataGridView.CurrentRow.Index;
                    FrmEditTipoEnvasado edit = new FrmEditTipoEnvasado(((TipoEnvasado)tipoEnvasadoDataGridView.Rows[seleccion].DataBoundItem).IdTipoEnvasado);
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
