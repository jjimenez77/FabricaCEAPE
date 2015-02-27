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
    public partial class FrmEditarControlPCC : Form
    {
        bool fechaElaboracionCaja = false;
        bool fechaVencimientoCaja = false;

        public FrmEditarControlPCC(int id)
        {
            InitializeComponent();
            productoBindingSource.DataSource = DatosProducto.getProductos();

            this.fechaElaboracionCajaDateTimePicker.MaxDate = DateTime.Today;
            this.fechaVencimientoCajaDateTimePicker.MinDate = DateTime.Today.AddDays(1);

            if (id == 0)
            {
                controlPCCBindingSource.Add(new ControlPCC());
            }
            else
            {
                fechaElaboracionCaja = true;
                fechaVencimientoCaja = true;

                controlPCCBindingSource.Add(DatosControlPCC.getControlPCC(id));

                cbProducto.SelectedItem = ((ControlPCC)controlPCCBindingSource.Current).Producto;
                cbProducto.SelectedValue = ((ControlPCC)controlPCCBindingSource.Current).Producto.IdProducto;

                ControlPCC c = (ControlPCC)controlPCCBindingSource.Current;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                DateTime hora = DateTime.Now;
                Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);

                ControlPCC c = (ControlPCC)controlPCCBindingSource.Current;
                c.Producto = (Producto)cbProducto.SelectedItem;
                c.Usuario = u;
                c.FechaElaboracionCaja = fechaElaboracionCajaDateTimePicker.Value;
                c.FechaVencimientoCaja = fechaVencimientoCajaDateTimePicker.Value;
                c.Hora = hora;

                string a = c.Producto.ToString();
                MessageBox.Show(a);
                string a1 = c.Usuario.ToString();
                MessageBox.Show(a1);
                string a2 = c.PesoNeto.ToString();
                MessageBox.Show(a2);
                string a3 = c.UnidadPorCaja.ToString();
                MessageBox.Show(a3);
                string a4 = c.FechaElaboracionCaja.ToString();
                MessageBox.Show(a4);
                string a5 = c.FechaVencimientoCaja.ToString();
                MessageBox.Show(a5);
                string a6 = c.LotePouch.ToString();
                MessageBox.Show(a6);
                string a7 = c.LoteCaja.ToString();
                MessageBox.Show(a7);
                string a8 = c.RneRnpa.ToString();
                MessageBox.Show(a8);
                string a9 = c.ColorFormaOlor.ToString();
                MessageBox.Show(a9);
                string a10 = c.Densidad.ToString();
                MessageBox.Show(a10);
                string a11 = c.SecadoHumedad.ToString();
                MessageBox.Show(a11);
                string a12 = c.EnvasadoGranel.ToString();
                MessageBox.Show(a12);
                string a13 = c.EnvasadoPouch1.ToString();
                MessageBox.Show(a13);
                string a14 = c.EnvasadoPouch2.ToString();
                MessageBox.Show(a14);
                string a15 = c.Observaciones.ToString();
                MessageBox.Show(a15);
                string a16 = c.Hora.ToString();
                MessageBox.Show(a16);

                if (c.IdControlPCC == 0)
                {
                    DatosControlPCC.Crear(c);
                }
                else
                {
                    DatosControlPCC.Modificar(c);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(pesoNetoTextBox.Text))
            {
                pesoNetoTextBox.BackColor = Color.White;
                error = "Ingrese el peso";

                errorProvider1.SetError(pesoNetoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(unidadPorCajaTextBox.Text) || unidadPorCajaTextBox.Text == "0")
            {
                unidadPorCajaTextBox.BackColor = Color.White;
                error = "Ingrese las unidades por caja";

                errorProvider1.SetError(unidadPorCajaTextBox, error);
                resultados = false;
            }

            if (fechaElaboracionCaja == false)
            {
                error = "Seleccione la fecha de elaboracion de la caja";
                errorProvider1.SetError(fechaElaboracionCajaDateTimePicker, error);
                resultados = false;
            }
            else
            {
                fechaElaboracionCajaDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaElaboracionCajaDateTimePicker, String.Empty);
            }

            if (fechaVencimientoCaja == false)
            {
                error = "Seleccione la fecha de vencimiento de la caja";
                errorProvider1.SetError(fechaVencimientoCajaDateTimePicker, error);
                resultados = false;
            }
            else
            {
                fechaVencimientoCajaDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaVencimientoCajaDateTimePicker, String.Empty);
            }

            if (string.IsNullOrEmpty(lotePouchTextBox.Text))
            {
                lotePouchTextBox.BackColor = Color.White;
                error = "Ingrese el numero de lote";

                errorProvider1.SetError(lotePouchTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(loteCajaTextBox.Text))
            {
                loteCajaTextBox.BackColor = Color.White;
                error = "Ingrese el numero de lote";

                errorProvider1.SetError(loteCajaTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(densidadTextBox.Text))
            {
                densidadTextBox.BackColor = Color.White;
                error = "Ingrese la densidad";

                errorProvider1.SetError(densidadTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(secadoHumedadTextBox.Text))
            {
                secadoHumedadTextBox.BackColor = Color.White;
                error = "Ingrese la humedad";

                errorProvider1.SetError(secadoHumedadTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(observacionesTextBox.Text))
            {
                observacionesTextBox.BackColor = Color.White;
                error = "Ingrese las observaciones";

                errorProvider1.SetError(observacionesTextBox, error);
                resultados = false;
            }

            return resultados;
        }

        private void pesoNetoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pesoNetoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumero(pesoNetoTextBox) || pesoNetoTextBox.Text == "0")
            {
                pesoNetoTextBox.BackColor = Color.White;
                error = "Ingrese el peso";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                pesoNetoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void unidadPorCajaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void unidadPorCajaTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumero(unidadPorCajaTextBox) || unidadPorCajaTextBox.Text == "0")
            {
                unidadPorCajaTextBox.BackColor = Color.White;
                error = "Ingrese las unidades por caja";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                unidadPorCajaTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void lotePouchTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lotePouchTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(lotePouchTextBox))
            {
                lotePouchTextBox.BackColor = Color.White;
                error = "Ingrese el numero de lote del pouch";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                lotePouchTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void loteCajaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void loteCajaTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(loteCajaTextBox))
            {
                loteCajaTextBox.BackColor = Color.White;
                error = "Ingrese el numero de lote de la caja";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                loteCajaTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void densidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void densidadTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumero(densidadTextBox) || densidadTextBox.Text == "0")
            {
                densidadTextBox.BackColor = Color.White;
                error = "Ingrese la densidad";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                densidadTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void secadoHumedadTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void secadoHumedadTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumero(secadoHumedadTextBox) || secadoHumedadTextBox.Text == "0")
            {
                secadoHumedadTextBox.BackColor = Color.White;
                error = "Ingrese la humedad";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                secadoHumedadTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void observacionesTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void observacionesTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(observacionesTextBox))
            {
                observacionesTextBox.BackColor = Color.White;
                error = "Ingrese alguna observacion";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                observacionesTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void fechaElaboracionCajaDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaElaboracionCaja = true;
            fechaElaboracionCajaDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaElaboracionCajaDateTimePicker, String.Empty);
        }

        private void fechaVencimientoCajaDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaVencimientoCaja = true;
            fechaVencimientoCajaDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaVencimientoCajaDateTimePicker, String.Empty);
        }
    }
}
