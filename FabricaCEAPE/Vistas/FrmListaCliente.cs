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
    public partial class FrmListaCliente : Form
    {
        public FrmListaCliente()
        {
            InitializeComponent();
            Actualizar();
            cbSelector.Items.Add("Nombre");
            cbSelector.Items.Add("Contacto");
            cbSelector.Items.Add("CUIT/CUIL");
            cbSelector.Items.Add("Zona");

            cbSelector.SelectedIndex = 0;
            this.txtBuscar.Focus();
        }

        private void Actualizar()
        {
            try
            {
                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {
                    clienteBindingSource.DataSource = DatosCliente.getClientes();// DatosProveedor.getProveedoresPorPais((int)cbPais.ComboBox.SelectedValue);
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
            FrmEditarCliente p = new FrmEditarCliente(0);
            p.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarCliente edit = new FrmEditarCliente(((Cliente)clienteBindingSource.Current).Id);
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
                Cliente c = (Cliente)clienteBindingSource.Current;
                if (!DatosCliente.enUso(c.Id))
                {
                    c.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + c.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosCliente.Modificar(c);
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

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    FrmEditarCliente edit = new FrmEditarCliente(((Cliente)clienteBindingSource.Current).Id);
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
                if(txtBuscar.Text == "")
                {
                    clienteBindingSource.DataSource = DatosCliente.getClientes();
                }

                if (cbSelector.SelectedIndex == 0)
                {
                    clienteBindingSource.DataSource = DatosCliente.BuscarNombreCliente(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    clienteBindingSource.DataSource = DatosCliente.BuscarContacto(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 2)
                {
                    clienteBindingSource.DataSource = DatosCliente.BuscarCuit(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 3)
                {
                    clienteBindingSource.DataSource = DatosCliente.BuscarZona(txtBuscar.Text);
                }

            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSelector_DropDownClosed(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Actualizar();

            if (cbSelector.SelectedIndex == 0)
            {
                txtBuscar.ToolTipText = "Buscar cliente por nombre";
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                txtBuscar.ToolTipText = "Buscar cliente por nombre de contacto";
            }
            else if (cbSelector.SelectedIndex == 2)
            {
                txtBuscar.ToolTipText = "Buscar cliente por numero de CUIT/CUIL";
            }
            else
            {
                txtBuscar.ToolTipText = "Buscar cliente por zona";
            }
        }
    }
}
