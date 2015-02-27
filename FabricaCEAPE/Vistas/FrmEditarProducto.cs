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
    public partial class FrmEditarProducto : Form
    {
        int id;
        public FrmEditarProducto(int id)
        {
            InitializeComponent();
            this.id = id;
            if (id == 0)
            {
                productoBindingSource.Add(new Producto());
            }
            else
            {
                productoBindingSource.Add(DatosProducto.getProducto(id));

                Producto p = (Producto)productoBindingSource.Current;

                if (p.Nombre != "")
                {
                    this.Text = "Editar " + p.Nombre;
                }
            }
        }
                
        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre del producto";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosProducto.existProductoN(id, nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
            else if (DatosProducto.existe(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "El producto ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Producto p = (Producto)productoBindingSource.Current;
                p.Activo = true;
                if (p.IdProducto == 0)
                {
                    DatosProducto.Crear(p);
                }
                else
                {
                    DatosProducto.Modificar(p);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre del producto";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            return resultados;
        }
    }
}
