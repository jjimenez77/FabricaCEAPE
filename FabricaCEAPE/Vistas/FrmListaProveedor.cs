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
    public partial class FrmListaProveedor : Form
    {
        public FrmListaProveedor()
        {
            InitializeComponent();
            Actualizar();
            cbSelector.Items.Add("Nombre");
            cbSelector.Items.Add("Contacto");
            cbSelector.Items.Add("CUIT/CUIL");
            cbSelector.Items.Add("Provincia");
            cbSelector.Items.Add("Pais");

            cbSelector.SelectedIndex = 0;
            this.txtBuscar.Focus();
        }

        private void Actualizar()
        {
            try
            {
                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {
                proveedorBindingSource.DataSource = DatosProveedor.getProveedores();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarProveedor p = new FrmEditarProveedor(0);
            p.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmEditarProveedor edit = new FrmEditarProveedor(((Proveedor)proveedorBindingSource.Current).Id);
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
                Proveedor p = (Proveedor)proveedorBindingSource.Current;
                if (!DatosProveedor.enUso(p.Id))
                {
                    p.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + p.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosProveedor.Modificar(p);
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
            txtBuscar.Text = "";
            Actualizar();

            if (cbSelector.SelectedIndex == 0)
            {
                txtBuscar.ToolTipText = "Buscar proveedor por nombre";
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                txtBuscar.ToolTipText = "Buscar proveedor por nombre de contacto";
            }
            else if (cbSelector.SelectedIndex == 2)
            {
                txtBuscar.ToolTipText = "Buscar proveedor por numero de CUIT/CUIL";
            }
            else if (cbSelector.SelectedIndex == 3)
            {
                txtBuscar.ToolTipText = "Buscar proveedor por provincia";
            }
            else
            {
                txtBuscar.ToolTipText = "Buscar proveedor por pais";
            }
        }

        private void proveedorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = proveedorDataGridView.CurrentRow.Index;
                    FrmEditarProveedor edit = new FrmEditarProveedor(((Proveedor)proveedorDataGridView.Rows[seleccion].DataBoundItem).Id);
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
                    proveedorBindingSource.DataSource = DatosProveedor.getProveedores();
                }

                if (cbSelector.SelectedIndex == 0)
                {
                    proveedorBindingSource.DataSource = DatosProveedor.getProveedoresPorNombre(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    proveedorBindingSource.DataSource = DatosProveedor.getProveedoresPorContacto(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 2)
                {
                    proveedorBindingSource.DataSource = DatosProveedor.getProveedoresPorCuit(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 3)
                {
                    proveedorBindingSource.DataSource = DatosProveedor.getProveedoresPorProvincia(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 4)
                {
                    proveedorBindingSource.DataSource = DatosProveedor.getProveedoresPorPais(txtBuscar.Text);
                }
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }
    }
}
