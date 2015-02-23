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
    public partial class FrmListaProducto : Form
    {
        public FrmListaProducto()
        {
            InitializeComponent();
            Actualizar();
        }

        private void Actualizar()
        {
            productoBindingSource.DataSource = DatosProducto.getProductos();
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
            FrmEditarProducto p = new FrmEditarProducto(0);
            p.ShowDialog();
            Actualizar(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarProducto edit = new FrmEditarProducto(((Producto)productoBindingSource.Current).IdProducto);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó ");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = (Producto)productoBindingSource.Current;
                p.Activo = false;

                if (MessageBox.Show("¿Esta seguro de borrar a " + p.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosProducto.Modificar(p);
                    Actualizar();
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

        private void productoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = productoDataGridView.CurrentRow.Index;
                    FrmEditarProducto edit = new FrmEditarProducto(((Producto)productoDataGridView.Rows[seleccion].DataBoundItem).IdProducto);
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
