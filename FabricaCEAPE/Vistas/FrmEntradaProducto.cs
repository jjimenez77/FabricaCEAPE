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
    public partial class FrmEntradaProducto : Form
    {
        public FrmEntradaProducto()
        {
            InitializeComponent();
            Actualizar();
            this.txtBuscar.Focus();
        }

        public void Actualizar()
        {
            productoTerminadoBindingSource.DataSource = DatosProductoTerminado.getProductosTerminados();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                listBox1.DataSource = DatosProductoTerminado.BuscarProducto(txtBuscar.Text);
            }

            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
                return;
            try
            {
                ProductoTerminado prod = (ProductoTerminado)productoTerminadoBindingSource.Current;
                prod.Stock = Int32.Parse(waterMarkTextBox1.Text);

                if (MessageBox.Show("Esta seguro de querer agregar esta cantidad" + " [ " + prod.Stock + " ] " + " al stock de este producto" + " [ " + prod.Producto.Nombre + " ] " + "?", "Entrada de Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    int cantidad = Convert.ToInt32(waterMarkTextBox1.Text) + Convert.ToInt32(label3.Text);
                    DatosProductoTerminado.InsertarStock(((ProductoTerminado)productoTerminadoBindingSource.Current).IdProductoTerminado, cantidad);

                    MessageBox.Show("El monto" + " [ " + prod.Stock + " ] " + " se añadio al stock con exito!!", "Confirmacion");
                    Actualizar();
                    this.Close();
                }
            }
            catch
            {
                //DialogResult result = MessageBox.Show("Ingrese todos los campos, !Son Obligatorios!!", "Verificacion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                //if (result == DialogResult.Cancel)
                //{
                //    this.Close();
                //}

                //else if (result == DialogResult.Retry)
                //{
                //    return;

                //}
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = ((ProductoTerminado)listBox1.SelectedItem).Producto.Nombre.ToString();
            label3.Text = ((ProductoTerminado)listBox1.SelectedItem).Stock.ToString();

            if (Convert.ToInt32(label3.Text) >= 20)
            {
                label3.BackColor = Color.Transparent;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(label3, "Esta con Stock por debajo de lo normal");
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void waterMarkTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void waterMarkTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Validacion.esNumero(waterMarkTextBox1))
            {
                errorProvider1.SetError(waterMarkTextBox1, String.Empty);
            }
            else
            {
                errorProvider1.SetError(waterMarkTextBox1, "Introduzca la cantidad de cajas");
                waterMarkTextBox1.BackColor = colorOk;
            }
        }

        private bool validaciones()
        {
            bool result = true;

            if (string.IsNullOrEmpty(waterMarkTextBox1.Text))
            {
                errorProvider1.SetError(waterMarkTextBox1, "El ingreso de cajas es obligatorio");
                result = false;
            }
            return result;
        }
    }
}
