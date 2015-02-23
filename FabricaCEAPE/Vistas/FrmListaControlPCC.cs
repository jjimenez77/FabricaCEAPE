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
    public partial class FrmListaControlPCC : Form
    {
        public FrmListaControlPCC()
        {
            InitializeComponent();

            cbSelector.Items.Add("Producto");
            cbSelector.Items.Add("Usuario");

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
                    controlPCCBindingSource.DataSource = DatosControlPCC.getControles();
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
            FrmEditarControlPCC c = new FrmEditarControlPCC(0);
            c.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarControlPCC edit = new FrmEditarControlPCC(((ControlPCC)controlPCCBindingSource.Current).IdControlPCC);
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
                ControlPCC c = (ControlPCC)controlPCCBindingSource.Current;

                if (MessageBox.Show("¿Esta seguro de dar de baja a " + c.Producto.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosControlPCC.Eliminar(c);
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
                    controlPCCBindingSource.DataSource = DatosControlPCC.getControlesPorProducto(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    controlPCCBindingSource.DataSource = DatosControlPCC.getControlesPorUsuario(txtBuscar.Text);
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
