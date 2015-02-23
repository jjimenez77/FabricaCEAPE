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
            cbSelector.Items.Add("Nombre");
            cbSelector.Items.Add("Lote");
            cbSelector.Items.Add("Codigo de barra");

            cbSelector.SelectedIndex = 0;
            this.txtBuscar.Focus();
        }

        private void Actualizar()
        {
            try
            {
                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {
                    productoBindingSource.DataSource = DatosProducto.getProductos();
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
            FrmEditarProducto p = new FrmEditarProducto(0);
            p.ShowDialog();
            Actualizar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarProducto edit = new FrmEditarProducto(((Producto)productoBindingSource.Current).IdProducto);
                edit.ShowDialog();
                Actualizar();
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
                    productoBindingSource.DataSource = DatosProducto.getProductos();
                }

                if (cbSelector.SelectedIndex == 0)
                {
                    productoBindingSource.DataSource = DatosProducto.BuscarProducto(txtBuscar.Text);
                }

                else if (cbSelector.SelectedIndex == 1)
                {
                    productoBindingSource.DataSource = DatosProducto.BuscarByLote(txtBuscar.Text);
                }

                else if (cbSelector.SelectedIndex == 2)
                {
                    productoBindingSource.DataSource = DatosProducto.BuscarByCodigoBarra(txtBuscar.Text);
                }
            }

            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
            }
        }

        private void productoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion =productoDataGridView.CurrentRow.Index;
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
    }
}
