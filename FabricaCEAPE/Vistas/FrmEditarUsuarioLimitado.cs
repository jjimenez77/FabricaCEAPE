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
    public partial class FrmEditarUsuarioLimitado : Form
    {
        int id;
        public FrmEditarUsuarioLimitado(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();

            this.id = id;

            this.fechaNacimientoDateTimePicker.MaxDate = DateTime.Today.AddYears(-16);
           
            Actualizar();

            usuarioBindingSource.Add(DatosUsuario.getUsuario(id));
            Usuario u = (Usuario)usuarioBindingSource.Current;

            //int idUsuario = (int)DatosUsuario.getUsuario(id).Login.Id;
            int idUsuario = u.Login.Id;

            if (u.TipoDocumento == "DNI")
            {
                tipoDocumentoDropbox.Text = "DNI";
            }
            else if (u.TipoDocumento == "PASAPORTE")
            {
                tipoDocumentoDropbox.Text = "PASAPORTE";
            }
            else
            {
                tipoDocumentoDropbox.Text = "OTRO";
            }
                
            cbLocalidad.SelectedItem = ((Usuario)usuarioBindingSource.Current).Localidad;
            cbLocalidad.SelectedValue = ((Usuario)usuarioBindingSource.Current).Localidad.Id;

            cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
            cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

            cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
            cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

            if (u.Nombre != "")
            {
                this.Text = "Editar " + u.Nombre;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Usuario u = (Usuario)usuarioBindingSource.Current;

                u.Localidad = (Localidad)cbLocalidad.SelectedItem;               

                if (tipoDocumentoDropbox.SelectedIndex == 0)
                {
                    u.TipoDocumento = "DNI";
                }
                else if (tipoDocumentoDropbox.SelectedIndex == 1)
                {
                    u.TipoDocumento = "PASAPORTE";
                }
                else
                {
                    u.TipoDocumento = "OTRO";
                }

                u.Activo = true;
                u.FechaNacimiento = fechaNacimientoDateTimePicker.Value;

                DatosUsuario.Modificar(u);
                 
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

        private void Actualizar()
        {
            try
            {
                Usuario u = DatosUsuario.getUsuario(id);

                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais(u.Localidad.Provincia.Pais.Id);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia(u.Localidad.Provincia.Id);
                }
            }
            catch
            {
            }
        }

        private void ActualizarCBProvincia()
        {
            try
            {
                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.SelectedValue);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    ActualizarCbLocalidad();
                }
            }
            catch
            {
            }
        }

        private void ActualizarCbLocalidad()
        {
            try
            {
                localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.SelectedValue);
            }
            catch
            {

            }
        }

        private void cbPais_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCBProvincia();
            if (cbLocalidad.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbLocalidad, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbLocalidad, "Seleccione la localidad");
            }
        }

        private void cbProvincia_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCbLocalidad();
            if (cbLocalidad.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbLocalidad, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbLocalidad, "Seleccione la localidad");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void apellidoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(apellidoTextBox))
            {
                apellidoTextBox.BackColor = Color.White;
                error = "Ingrese el apellido";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                apellidoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void numeroTelefonoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esTelefono(numeroTelefonoTextBox))
            {
                numeroTelefonoTextBox.BackColor = Color.White;
                error = "Ingrese el numero de telefono";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioNT(id, numeroTelefonoTextBox.Text))
            {
                errorProvider1.SetError(numeroTelefonoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeTelefono(numeroTelefonoTextBox.Text))
            {
                numeroTelefonoTextBox.BackColor = Color.White;
                error = "El numero de telefono ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroTelefonoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void numeroCelularTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esTelefono(numeroCelularTextBox))
            {
                numeroCelularTextBox.BackColor = Color.White;
                error = "Ingrese el numero de celular";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioNC(id, numeroCelularTextBox.Text))
            {
                errorProvider1.SetError(numeroCelularTextBox, String.Empty);
            }
            else if (DatosUsuario.existeCelular(numeroCelularTextBox.Text))
            {
                numeroCelularTextBox.BackColor = Color.White;
                error = "El numero de celular ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroCelularTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void correoElectronicoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esEmail(correoElectronicoTextBox))
            {
                correoElectronicoTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioCE(id, correoElectronicoTextBox.Text))
            {
                errorProvider1.SetError(correoElectronicoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeCorreoE(correoElectronicoTextBox.Text))
            {
                correoElectronicoTextBox.BackColor = Color.White;
                error = "El correo electronico ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void correoElectronicoAlternativoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esEmail(correoElectronicoAlternativoTextBox))
            {
                correoElectronicoAlternativoTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico alternativo";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioCEA(id, correoElectronicoAlternativoTextBox.Text))
            {
                errorProvider1.SetError(correoElectronicoAlternativoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeCorreoEA(correoElectronicoAlternativoTextBox.Text))
            {
                correoElectronicoAlternativoTextBox.BackColor = Color.White;
                error = "El correo electronico alternativo ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoAlternativoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }
        
        private void numeroDocumentoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(numeroDocumentoTextBox))
            {
                numeroDocumentoTextBox.BackColor = Color.White;
                error = "Ingrese el numero de documento";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioND(id, numeroDocumentoTextBox.Text))
            {
                errorProvider1.SetError(numeroDocumentoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeDocumento(numeroDocumentoTextBox.Text))
            {
                numeroDocumentoTextBox.BackColor = Color.White;
                error = "El numero de documento ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroDocumentoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumeroPunto(direccionTextBox) || direccionTextBox.Text.Trim() == String.Empty)
            {
                direccionTextBox.BackColor = Color.White;
                error = "Ingrese la direccion";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                direccionTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void localidadDropbox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbLocalidad.SelectedIndex == -1)
            {
                error = "Seleccione la localidad";
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, error);
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

        private void numeroTelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numeroDocumentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void direccionTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(apellidoTextBox.Text))
            {
                error = "Ingrese el apellido";

                errorProvider1.SetError(apellidoTextBox, error);
                resultados = false;
            }    

            if (string.IsNullOrEmpty(numeroTelefonoTextBox.Text))
            {
                error = "Ingrese el numero de telefono";

                errorProvider1.SetError(numeroTelefonoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroCelularTextBox.Text))
            {
                error = "Ingrese el numero de celular";

                errorProvider1.SetError(numeroCelularTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoTextBox.Text))
            {
                error = "Ingrese el correo electronico";

                errorProvider1.SetError(correoElectronicoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoAlternativoTextBox.Text))
            {
                error = "Ingrese el correo electronico alternativo";

                errorProvider1.SetError(correoElectronicoAlternativoTextBox, error);
                resultados = false;
            }

            if (tipoDocumentoDropbox.SelectedIndex < 0)
            {
                error = "Seleccione el tipo de documento";

                errorProvider1.SetError(tipoDocumentoDropbox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroDocumentoTextBox.Text))
            {
                error = "Ingrese el numero de documento";

                errorProvider1.SetError(numeroDocumentoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(direccionTextBox.Text)) //verifica si es nulo o vacio, verifica si es nullo o espacio
            {
                error = "Ingrese la direccion";

                errorProvider1.SetError(direccionTextBox, error);
                resultados = false;
            }

            if (cbLocalidad.SelectedIndex < 0)
            {
                error = "Seleccione la localidad";

                errorProvider1.SetError(cbLocalidad, error);
                resultados = false;
            }
            return resultados;
        }
    }
}
