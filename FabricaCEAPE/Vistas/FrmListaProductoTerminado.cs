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
    public partial class FrmListaProductoTerminado : Form
    {
        public FrmListaProductoTerminado()
        {
            InitializeComponent();
            
            cbSelector.Items.Add("Nombre");
            cbSelector.Items.Add("Lote");
            cbSelector.Items.Add("Codigo de barra");

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
                    productoTerminadoBindingSource.DataSource = DatosProductoTerminado.getProductosTerminados();
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
            FrmEditarProductoTerminado p = new FrmEditarProductoTerminado(0);
            p.ShowDialog();
            Actualizar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarProductoTerminado edit = new FrmEditarProductoTerminado(((ProductoTerminado)productoTerminadoBindingSource.Current).IdProductoTerminado);
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
                ProductoTerminado p = (ProductoTerminado)productoTerminadoBindingSource.Current;
                if (!DatosProductoTerminado.enUso(p.IdProductoTerminado))
                {
                    if (MessageBox.Show("¿Esta seguro de eliminar a " + p.Producto.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosProductoTerminado.Eliminar(p);
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSelector_DropDownClosed(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Actualizar();

            if (cbSelector.SelectedIndex == 0)
            {
                txtBuscar.ToolTipText = "Buscar producto por nombre";
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                txtBuscar.ToolTipText = "Buscar producto por lote";
            }
            else
            {
                txtBuscar.ToolTipText = "Buscar producto por codigo de barra";
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

                if (cbSelector.SelectedIndex == 0)
                {
                    productoTerminadoBindingSource.DataSource = DatosProductoTerminado.BuscarProducto(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    productoTerminadoBindingSource.DataSource = DatosProductoTerminado.BuscarByLote(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 2)
                {
                    productoTerminadoBindingSource.DataSource = DatosProductoTerminado.BuscarByCodigoBarra(txtBuscar.Text);
                }
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }

        private void productoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion =productoDataGridView.CurrentRow.Index;
                    FrmEditarProductoTerminado edit = new FrmEditarProductoTerminado(((ProductoTerminado)productoDataGridView.Rows[seleccion].DataBoundItem).IdProductoTerminado);
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
