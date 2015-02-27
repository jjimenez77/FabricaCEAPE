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
    public partial class FrmEditarProductoTerminado : Form
    {
        bool fechaElaboracion = false;
        bool fechaCaducidad = false;
        private decimal resultado1 = 0;

        public FrmEditarProductoTerminado(int id)
        {
            InitializeComponent();
            productoBindingSource.DataSource = DatosProducto.getProductos();
            tipoProductoBindingSource.DataSource = DatosTipoProducto.getTipoProductos();
            medidaBindingSource.DataSource = DatosMedida.getMedidas();
            tipoEnvasadoBindingSource.DataSource = DatosTipoEnvasado.getTipoEnvasados();
            seleccionProductoBindingSource.DataSource = DatosSeleccionProducto.getSeleccionProductos();

            this.fechaElaboracionDateTimePicker.MaxDate = DateTime.Today;
            this.fechaVencimientoDateTimePicker.MinDate = DateTime.Today.AddDays(1);

            if (id == 0)
            {
                productoTerminadoBindingSource.Add(new ProductoTerminado());
            }
            else
            {
                fechaElaboracion = true;
                fechaCaducidad = true;

                productoTerminadoBindingSource.Add(DatosProductoTerminado.getProductoTerminado(id));

                cbNombreProducto.SelectedItem = ((ProductoTerminado)productoTerminadoBindingSource.Current).Producto;
                cbNombreProducto.SelectedValue = ((ProductoTerminado)productoTerminadoBindingSource.Current).Producto.IdProducto;

                cbTipoProducto.SelectedItem = ((ProductoTerminado)productoTerminadoBindingSource.Current).Tipo;
                cbTipoProducto.SelectedValue = ((ProductoTerminado)productoTerminadoBindingSource.Current).Tipo.IdTipoProducto;

                cbMedida.SelectedItem = ((ProductoTerminado)productoTerminadoBindingSource.Current).UnidadM;
                cbMedida.SelectedValue = ((ProductoTerminado)productoTerminadoBindingSource.Current).UnidadM.Id;

                cbCalidad.SelectedItem = ((ProductoTerminado)productoTerminadoBindingSource.Current).SelProducto;
                cbCalidad.SelectedValue = ((ProductoTerminado)productoTerminadoBindingSource.Current).SelProducto.IdSeleccionProducto;

                cbEnvasado.SelectedItem = ((ProductoTerminado)productoTerminadoBindingSource.Current).Envasado;
                cbEnvasado.SelectedValue = ((ProductoTerminado)productoTerminadoBindingSource.Current).Envasado.IdTipoEnvasado;

                ProductoTerminado p = (ProductoTerminado)productoTerminadoBindingSource.Current;

                /*string a = p.Producto.ToString();
                MessageBox.Show(a);
                string a1 = p.Tipo.ToString();
                MessageBox.Show(a1);
                string a2 = p.UnidadM.ToString();
                MessageBox.Show(a2);
                string a3 = p.Envasado.ToString();
                MessageBox.Show(a3);
                string a4 = p.SelProducto.ToString();
                MessageBox.Show(a4);
                string a5 = p.FechaElaboracion.ToString();
                MessageBox.Show(a5);
                string a6 = p.FechaVencimiento.ToString();
                MessageBox.Show(a6);
                string a7 = p.Gramaje.ToString();
                MessageBox.Show(a7);
                string a8 = p.CajasPorTarima.ToString();
                MessageBox.Show(a8);
                string a9 = p.UnidadPorCaja.ToString();
                MessageBox.Show(a9);
                string a10 = p.LoteProductoTerminado;
                MessageBox.Show(a10);
                string a11 = p.Stock.ToString();
                MessageBox.Show(a11);
                string a12 = p.KgPorTarima.ToString();
                MessageBox.Show(a12);
                string a13 = p.CodigoBarraProducto;
                MessageBox.Show(a13);*/

                if (p.Producto.Nombre != "")
                {
                    this.Text = "Editar " + p.Producto.Nombre;
                }
            }
        }

        public void Actualizar()
        {
            productoTerminadoBindingSource.DataSource = DatosProductoTerminado.getProductosTerminados();
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
                int gramaje;
                gramaje = int.Parse(waterMarkTextBox2.Text);

                ProductoTerminado p = (ProductoTerminado)productoTerminadoBindingSource.Current;
                p.Producto = (Producto)cbNombreProducto.SelectedItem;
                p.Tipo = (TipoProducto)cbTipoProducto.SelectedItem;
                p.UnidadM = (Medida)cbMedida.SelectedItem;
                p.Envasado = (TipoEnvasado)cbEnvasado.SelectedItem;
                p.SelProducto = (SeleccionProducto)cbCalidad.SelectedItem;
                p.FechaElaboracion = fechaElaboracionDateTimePicker.Value;
                p.FechaVencimiento = fechaVencimientoDateTimePicker.Value;
                p.Gramaje = int.Parse(waterMarkTextBox2.Text);
                p.CajasPorTarima = int.Parse(waterMarkTextBox5.Text);
                p.UnidadPorCaja = int.Parse(waterMarkTextBox4.Text);
                p.LoteProductoTerminado = loteProductoTerminadoWaterMarkTextBox.Text;
                p.Stock = int.Parse(waterMarkTextBox3.Text);
                p.KgPorTarima = decimal.Parse(waterMarkTextBox1.Text);
                p.CodigoBarraProducto = codigoBarraProductoWaterMarkTextBox.Text;
                

                if (p.IdProductoTerminado == 0) //o null
                {
                    if (!DatosProductoTerminado.Existe(cbNombreProducto.Text))
                    {
                        try
                        {
                            if (MessageBox.Show("Esta seguro de querer dar de alta el nuevo producto?   " + " [ " + p.Producto.Nombre + " ] ", "Dar de Alta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                DatosProductoTerminado.Crear(p);
                                MessageBox.Show("Los datos del producto con el nombre " + p.Producto.Nombre + " " + "se crearon con exito!!", "Confirmacion");
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
                        DialogResult result = MessageBox.Show("El Producto con el siguiente nombre " + " [ " + p.Producto.Nombre + " ] " + "ya existe", "Verificacion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);

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
                    if (MessageBox.Show("Esta seguro de querer modificar el producto? " + " [ " + p.Producto.Nombre + " ] ", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        DatosProductoTerminado.Modificar(p);
                        MessageBox.Show("Los datos del producto con el nombre " + p.Producto.Nombre + " " + "se modificaron con exito!!", "Confirmacion");
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

        private void waterMarkTextBox5_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacion.esNumero(waterMarkTextBox5) || waterMarkTextBox5.Text == "0")
            {
                waterMarkTextBox5.BackColor = Color.White;
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
                waterMarkTextBox4.BackColor = Color.White;
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
                loteProductoTerminadoWaterMarkTextBox.BackColor = Color.White;
                errorProvider1.SetError(loteProductoTerminadoWaterMarkTextBox, "Introduzca el lote");
            }
        }

        private void waterMarkTextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacion.esNumero(waterMarkTextBox3) || waterMarkTextBox3.Text == "0")
            {
                waterMarkTextBox3.BackColor = Color.White;
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
                waterMarkTextBox2.BackColor = Color.White;
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
                codigoBarraProductoWaterMarkTextBox.BackColor = Color.White;
            }
            else
            {
                errorProvider1.SetError(codigoBarraProductoWaterMarkTextBox, "Introduzca el codigo de barra");
                codigoBarraProductoWaterMarkTextBox.BackColor = colorOk;
            }
        }

        private bool validaciones()
        {
            bool result = true;
            
            if (string.IsNullOrEmpty(waterMarkTextBox5.Text) || waterMarkTextBox5.Text == "0")
            {
                waterMarkTextBox5.BackColor = Color.White;
                errorProvider1.SetError(waterMarkTextBox5, "El campo de cajas por tarima es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(waterMarkTextBox4.Text) || waterMarkTextBox4.Text == "0")
            {
                waterMarkTextBox4.BackColor = Color.White;
                errorProvider1.SetError(waterMarkTextBox4, "El campo de unidad por caja es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(waterMarkTextBox2.Text) || waterMarkTextBox2.Text == "0")
            {
                waterMarkTextBox2.BackColor = Color.White;
                errorProvider1.SetError(waterMarkTextBox2, "El campo de gramaje es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(loteProductoTerminadoWaterMarkTextBox.Text))
            {
                loteProductoTerminadoWaterMarkTextBox.BackColor = Color.White;
                errorProvider1.SetError(loteProductoTerminadoWaterMarkTextBox, "El campo de lote es obligatorio");
                result = false;
            }

            if (string.IsNullOrEmpty(waterMarkTextBox3.Text) || waterMarkTextBox3.Text == "0")
            {
                waterMarkTextBox3.BackColor = Color.White;
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
