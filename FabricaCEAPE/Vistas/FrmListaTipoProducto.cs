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
    public partial class FrmListaTipoProducto : Form
    {
        public FrmListaTipoProducto()
        {
            InitializeComponent();
            Actualizar();
        }

        private void Actualizar()
        {
            tipoProductoBindingSource.DataSource = DatosTipoProducto.getTipoProductos();
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
            FrmEditarTipoProducto p = new FrmEditarTipoProducto(0);
            p.ShowDialog();
            Actualizar(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarTipoProducto edit = new FrmEditarTipoProducto(((TipoProducto)tipoProductoBindingSource.Current).IdTipoProducto);
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
                TipoProducto p = (TipoProducto)tipoProductoBindingSource.Current;
                if (!DatosTipoProducto.enUso(p.Id))
                {
                    p.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + p.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosTipoProducto.Modificar(p);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tipoProductoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = tipoProductoDataGridView.CurrentRow.Index;
                    FrmEditarTipoProducto edit = new FrmEditarTipoProducto(((TipoProducto)tipoProductoDataGridView.Rows[seleccion].DataBoundItem).IdTipoProducto);
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
