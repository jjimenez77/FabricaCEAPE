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
    public partial class FrmSalidaStock : Form
    {
        public FrmSalidaStock()
        {
            InitializeComponent();
            Actualizar();
            this.txtBuscar.Focus();
        }

        public void Actualizar()
        {
            productoBindingSource.DataSource = DatosProducto.getProductos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
                return;

            try
            {
                Producto prod = (Producto)productoBindingSource.Current;
                prod.Stock = Int32.Parse(waterMarkTextBox1.Text);

                if (MessageBox.Show("Esta seguro de querer descontar esta cantidad" + " [ " + prod.Stock + " ] " + " del stock de este producto" + " [ " + prod.Nombre + " ] " + "?", "Reposicion de Stock", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    int cantidadDesc = Convert.ToInt32(label3.Text) - Convert.ToInt32(waterMarkTextBox1.Text);
                    DatosProducto.ActualizarStock(((Producto)productoBindingSource.Current).IdProducto, cantidadDesc);

                    MessageBox.Show("El monto" + " [ " + prod.Stock + " ] " + " se desconto del stock con exito!!", "Confirmacion");
                    Actualizar();
                    this.Close();
                }
            }
            catch
            {

                //return result;

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

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                listBox1.DataSource = DatosProducto.BuscarProducto(txtBuscar.Text);
            }

            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = ((Producto)listBox1.SelectedItem).Nombre.ToString();
            label3.Text = ((Producto)listBox1.SelectedItem).Stock.ToString();

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
