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
        bool fechaElaboracion = false;
        bool fechaCaducidad = false;
        private decimal resultado1 = 0;

        public FrmEditarProducto(int id)
        {
            InitializeComponent();
            tipoProductoBindingSource.DataSource = DatosTipoProducto.getTipoProductos();
            medidaBindingSource.DataSource = DatosMedida.getMedidas();
            tipoEnvasadoBindingSource.DataSource = DatosTipoEnvasado.getTipoEnvasados();
            seleccionProductoBindingSource.DataSource = DatosSeleccionProducto.getSeleccionProductos();

            this.fechaElaboracionDateTimePicker.MaxDate = DateTime.Today;
            this.fechaVencimientoDateTimePicker.MinDate = DateTime.Today.AddDays(1);

            if (id == 0)
            {
                productoBindingSource.Add(new Producto());
            }
            else
            {
                fechaElaboracion = true;
                fechaCaducidad = true;

                productoBindingSource.Add(DatosProducto.getProducto(id));

                cbTipoProducto.SelectedItem = ((Producto)productoBindingSource.Current).Tipo;
                cbTipoProducto.SelectedValue = ((Producto)productoBindingSource.Current).Tipo.IdTipoProducto;

                cbMedida.SelectedItem = ((Producto)productoBindingSource.Current).UnidadM;
                cbMedida.SelectedValue = ((Producto)productoBindingSource.Current).UnidadM.Id;

                cbCalidad.SelectedItem = ((Producto)productoBindingSource.Current).SelProducto;
                cbCalidad.SelectedValue = ((Producto)productoBindingSource.Current).SelProducto.IdSeleccionProducto;

                cbEnvasado.SelectedItem = ((Producto)productoBindingSource.Current).Envasado;
                cbEnvasado.SelectedValue = ((Producto)productoBindingSource.Current).Envasado.IdTipoEnvasado;

                Producto p = (Producto)productoBindingSource.Current;

                if (p.Nombre != "")
                {
                    this.Text = "Editar " + p.Nombre;
                }  
            }
        }

        public void Actualizar()
        {
            productoBindingSource.DataSource = DatosProducto.getProductos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;
                float gramaje;
                gramaje = float.Parse(waterMarkTextBox2.Text);

                Producto p = (Producto)productoBindingSource.Current;
                p.Tipo = (TipoProducto)cbTipoProducto.SelectedItem;
                p.UnidadM = (Medida)cbMedida.SelectedItem;
                p.Envasado = (TipoEnvasado)cbEnvasado.SelectedItem;
                p.SelProducto = (SeleccionProducto)cbCalidad.SelectedItem;
                p.FechaElaboracion = fechaElaboracionDateTimePicker.Value;
                p.FechaVencimiento = fechaVencimientoDateTimePicker.Value;

                p.Gramaje = float.Parse(waterMarkTextBox2.Text);


                if (p.IdProducto == 0) //o null
                {
                    if (!DatosProducto.Existe(nombreWaterMarkTextBox.Text))
                    {
                        try
                        {
                            if (MessageBox.Show("Esta seguro de querer dar de alta el nuevo producto?   " + " [ " + p.Nombre + " ] ", "Dar de Alta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                DatosProducto.Crear(p);
                                MessageBox.Show("Los datos del producto con el nombre " + p.Nombre + " " + "se crearon con exito!!", "Confirmacion");
                                Actualizar();
                            }
                        }
                        catch
                        {
                            DialogResult result = MessageBox.Show("Ingrese todos los campos, !Son Obligatorios!!", "Verificacion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.Cancel)
                            {
                                this.Close();
                            }

                            else if (result == DialogResult.Retry)
                            {
                                return;

                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("El Producto con el siguiente nombre " + " [ " + p.Nombre + " ] " + "ya existe", "Verificacion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);

                        if (result == DialogResult.Cancel)
                        {
                            this.Close();
                        }

                        else if (result == DialogResult.Retry)
                        {
                            //MessageBox.Show("Vuelva a Intentarlo");
                            return;

                        }
                    }


                }
                else
                {
                    if (MessageBox.Show("Esta seguro de querer modificar el producto? " + " [ " + p.Nombre + " ] ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        DatosProducto.Modificar(p);
                        MessageBox.Show("Los datos del producto con el nombre " + p.Nombre + " " + "se modificaron con exito!!", "Confirmacion");
                        Actualizar();
                    }
                }
                Close();   
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void waterMarkTextBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal subTotal = Convert.ToDecimal(this.waterMarkTextBox2.Text) * Convert.ToDecimal(waterMarkTextBox4.Text);
                this.resultado1 += subTotal;
                this.resultado1 = resultado1 * Convert.ToDecimal(waterMarkTextBox5.Text) / 1000;
                this.waterMarkTextBox1.Text = "" + resultado1.ToString("#0.00#");
            }

            catch
            { }
        }

        private void waterMarkTextBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void waterMarkTextBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void loteProductoTerminadoWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void waterMarkTextBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void waterMarkTextBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void codigoBarraProductoWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nombreWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Validacion.esCadena(nombreWaterMarkTextBox))
            {
                errorProvider1.SetError(nombreWaterMarkTextBox, String.Empty);
                nombreWaterMarkTextBox.BackColor = colorOk;
            }
            else
            {
                errorProvider1.SetError(nombreWaterMarkTextBox, "Introduzca el nombre del producto");
            }
        }

        private void waterMarkTextBox5_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacion.esNumero(waterMarkTextBox5) || waterMarkTextBox5.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox5, "Introduzca la cantidad de cajas");
            }
            else
            {
                errorProvider1.SetError(waterMarkTextBox5, String.Empty);
                waterMarkTextBox5.BackColor = colorOk;
            }
        }

        private void waterMarkTextBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacion.esNumero(waterMarkTextBox4) || waterMarkTextBox4.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox4, "Introduzca la cantidad");
            }
            else
            {
                errorProvider1.SetError(waterMarkTextBox4, String.Empty);
                waterMarkTextBox4.BackColor = colorOk;
            }
        }

        private void loteProductoTerminadoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Validacion.esNumero(loteProductoTerminadoWaterMarkTextBox))
            {
                errorProvider1.SetError(loteProductoTerminadoWaterMarkTextBox, String.Empty);
                loteProductoTerminadoWaterMarkTextBox.BackColor = colorOk;
            }
            else
            {
                errorProvider1.SetError(loteProductoTerminadoWaterMarkTextBox, "Introduzca el lote");
            }
        }

        private void waterMarkTextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacion.esNumero(waterMarkTextBox3) || waterMarkTextBox3.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox3, "Introduzca el stock");
            }
            else
            {
                errorProvider1.SetError(waterMarkTextBox3, String.Empty);
                waterMarkTextBox3.BackColor = colorOk;
            }
        }

        private void waterMarkTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacion.esNumero(waterMarkTextBox2) || waterMarkTextBox2.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox2, "Introduzca el gramaje");
            }
            else
            {
                errorProvider1.SetError(waterMarkTextBox2, String.Empty);
                waterMarkTextBox2.BackColor = colorOk;
            }
        }

        private void codigoBarraProductoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Validacion.esNumero(codigoBarraProductoWaterMarkTextBox))
            {
                errorProvider1.SetError(codigoBarraProductoWaterMarkTextBox, String.Empty);
                codigoBarraProductoWaterMarkTextBox.BackColor = Color.Honeydew;
            }
            else
            {
                errorProvider1.SetError(codigoBarraProductoWaterMarkTextBox, "Introduzca el codigo de barra");
            }
        }

        private bool validaciones()
        {
            bool result = true;

            if (string.IsNullOrEmpty(nombreWaterMarkTextBox.Text))
            {
                errorProvider1.SetError(nombreWaterMarkTextBox, "El nombre es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(waterMarkTextBox5.Text) || waterMarkTextBox5.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox5, "El campo de cajas por tarima es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(waterMarkTextBox4.Text) || waterMarkTextBox4.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox4, "El campo de unidad por caja es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(waterMarkTextBox2.Text) || waterMarkTextBox2.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox2, "El campo de gramaje es obligatorio");
                result = false;

            }

            if (string.IsNullOrEmpty(loteProductoTerminadoWaterMarkTextBox.Text))
            {
                errorProvider1.SetError(loteProductoTerminadoWaterMarkTextBox, "El campo de lote es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(waterMarkTextBox3.Text) || waterMarkTextBox3.Text == "0")
            {
                errorProvider1.SetError(waterMarkTextBox3, "El campo de stock es obligatorio");
                result = false;
            }

            if (fechaElaboracion == false)
            {
                errorProvider1.SetError(fechaElaboracionDateTimePicker, "Seleccione la fecha de elaboracion de la materia prima");
                result = false;
            }
            else
            {
                fechaElaboracionDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaElaboracionDateTimePicker, String.Empty);
            }

            if (fechaCaducidad == false)
            {
                errorProvider1.SetError(fechaVencimientoDateTimePicker, "Seleccione la fecha de elaboracion de la materia prima");
                result = false;
            }
            else
            {
                fechaVencimientoDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaVencimientoDateTimePicker, String.Empty);
            }

            if (string.IsNullOrEmpty(codigoBarraProductoWaterMarkTextBox.Text))
            {
                errorProvider1.SetError(codigoBarraProductoWaterMarkTextBox, "El campo de codigo de barra es obligatorio");
                result = false;
            }
            return result;
        }

        private void fechaElaboracionDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaElaboracion = true;
            fechaElaboracionDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaElaboracionDateTimePicker, String.Empty);
        }

        private void fechaVencimientoDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaCaducidad = true;
            fechaVencimientoDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaVencimientoDateTimePicker, String.Empty);
        }
    }
}
