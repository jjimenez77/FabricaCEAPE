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
    public partial class FrmEditarUsuario : Form
    {
        int id;
        bool fechaNacimiento = false;

        public FrmEditarUsuario(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();
            departamentoBindingSource.DataSource = DatosDepartamento.getDepartamentos();

            this.id = id;

            this.fechaNacimientoDateTimePicker.MaxDate = DateTime.Today.AddYears(-16);
            this.fechaIngresoDateTimePicker.MaxDate = DateTime.Today.AddDays(1);

            if(id == 0)
            {
                Actualizar2();
                loginBindingSource.Add(new Login());
                usuarioBindingSource.Add(new Usuario());
            }
            else
            {
                Actualizar();
                fechaNacimiento = true;

                usuarioBindingSource.Add(DatosUsuario.getUsuario(id));
                Usuario u = (Usuario)usuarioBindingSource.Current;

                //int idUsuario = (int)DatosUsuario.getUsuario(id).Login.Id;
                int idUsuario = u.Login.Id;
                
                if(u.Sexo)
                {
                    rbtnM.Select();
                }
                else
                {
                    rbtnF.Select();
                }

                if(u.TipoUsuario)
                {
                    rbtnAd.Select();
                }
                else
                {
                    rbtnMo.Select();
                }

                if(u.TipoDocumento == "DNI")
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

                int idLogin = (int)DatosLogin.getLogin(idUsuario).Id;

                loginBindingSource.Add(DatosLogin.getLogin(loginBindingSource.Add(DatosLogin.getLogin((int)DatosUsuario.getUsuario(id).Login.Id))));
                //primero tomo el id del usuario a modificar. 
                //tomo el id del login que el usuario a moficar tiene asignado
                //llamo el metodo getLogin por medio del id login obtenida
                //
                //int idUsuario = (int)DatosUsuario.getUsuario(id).Login.Id;
                //int idLogin = (int)DatosLogin.getLogin(idUsuario).Id;

                cbLocalidad.SelectedItem = ((Usuario)usuarioBindingSource.Current).Localidad;
                cbLocalidad.SelectedValue = ((Usuario)usuarioBindingSource.Current).Localidad.Id;

                cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
                cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

                cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
                cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

                cbDepartamento.SelectedItem = ((Usuario)usuarioBindingSource.Current).Departamento;
                cbDepartamento.SelectedValue = ((Usuario)usuarioBindingSource.Current).Departamento.Id;

                if (u.Nombre != "")
                {
                    this.Text = "Editar " + u.Nombre;
                }    
            }
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

        private void Actualizar2()
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
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.SelectedValue);
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
        
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
           // FrmPrincipal usu = new FrmPrincipal();

            try
            {
                if (!validaciones())
                    return;

                Login l = (Login)loginBindingSource.Current;
                Usuario u = (Usuario)usuarioBindingSource.Current;

                u.Localidad = (Localidad)cbLocalidad.SelectedItem;
                u.Departamento = (Departamento)cbDepartamento.SelectedItem;
                
                if (rbtnAd.Checked)
                {
                    u.TipoUsuario = true;
                }
                else if(rbtnMo.Checked)
                {
                    u.TipoUsuario = false;
                }

                if (rbtnM.Checked)
                {
                    u.Sexo = true; 
                }
                else if(rbtnF.Checked)
                {
                    u.Sexo = false;
                }

                if(tipoDocumentoDropbox.SelectedIndex == 0)
                {
                    u.TipoDocumento = "DNI";
                }
                else if(tipoDocumentoDropbox.SelectedIndex == 1)
                {
                    u.TipoDocumento = "PASAPORTE";
                }
                else
                {
                    u.TipoDocumento = "OTRO";
                }
                     
                u.Activo = true;
                l.Activo = true;
                u.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
                u.FechaIngreso = fechaIngresoDateTimePicker.Value;

                if (u.Id == 0)
                {
                    DatosLogin.Crear(l);
                    u.Login = DatosLogin.getUltimoLogin();
                    DatosUsuario.Crear(u);
                }
                else
                {
                    DatosUsuario.Modificar(u);
                    DatosLogin.Modificar(l);
                }
               // usu.Actualizar();
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
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
                numeroTelefonoTextBox.BackColor = colorOk;
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
                numeroCelularTextBox.BackColor = colorOk;
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
                correoElectronicoTextBox.BackColor = colorOk;
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
                correoElectronicoAlternativoTextBox.BackColor = colorOk;
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

        private void tipoDocumentoDropbox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tipoDocumentoDropbox.SelectedIndex == -1)
            {
                error = "Seleccione el tipo de documento";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
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
                numeroDocumentoTextBox.BackColor = colorOk;
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

        private void departamentoDropbox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbDepartamento.SelectedIndex == -1)
            {
                error = "Seleccione el departamento de trabajo";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
        }

        private void nombreUsuarioTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNombreUsuario(usuarioTextBox1))
            {
                usuarioTextBox1.BackColor = Color.White;
                error = "Ingrese el nombre de usuario";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosLogin.existeNombre(id, usuarioTextBox1.Text))
            {
                usuarioTextBox1.BackColor = colorOk;
                errorProvider1.SetError(usuarioTextBox1, String.Empty);
            }
            else if (DatosLogin.existe(usuarioTextBox1.Text))
            {
                usuarioTextBox1.BackColor = Color.White;
                error = "El nombre de usuario ya existe, elija otro";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                usuarioTextBox1.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void contrasenaTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esContrasena(contrasenaTextBox1))
            {
                contrasenaTextBox1.BackColor = Color.White;
                error = "Ingrese la contrasena (solo 8 caracteres como maximo)";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                contrasenaTextBox1.BackColor = colorOk;
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

        private void nombreUsuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else
            {
                e.Handled = true;
            }
        }

        private void rbtnAd_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnMo, String.Empty);
        }

        private void rbtnMo_CheckedChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnMo, String.Empty);
        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnF, String.Empty);
        }

        private void rbtnF_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnF, String.Empty);
        }

        private void tipoDocumentoDropbox_DropDownClosed(object sender, EventArgs e)
        {
            if (tipoDocumentoDropbox.SelectedIndex >= 0)
            {
                errorProvider1.SetError(tipoDocumentoDropbox, String.Empty);
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

            if (rbtnAd.Checked || rbtnMo.Checked)
            {
                resultados = true;
                errorProvider1.SetError(rbtnMo, String.Empty);
            }
            else
            {
                error = "Seleccione el tipo de usuario";

                errorProvider1.SetError(rbtnMo, error);
                resultados = true;
            }

            if (rbtnM.Checked || rbtnF.Checked)
            {
                resultados = true;
                errorProvider1.SetError(rbtnF, String.Empty);
            }   
            else
            {
                error = "Seleccione el sexo";

                errorProvider1.SetError(rbtnF, error);
                resultados = false;
            }

            if (fechaNacimiento == false)
            {
                error = "Seleccione la fecha de nacimiento";
                errorProvider1.SetError(fechaNacimientoDateTimePicker, error);
                resultados = false;
            }
            else
            {
                fechaNacimientoDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaNacimientoDateTimePicker, String.Empty);
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

            if(tipoDocumentoDropbox.SelectedIndex < 0)
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

            if (string.IsNullOrEmpty(usuarioTextBox1.Text)) 
            {
                error = "Ingrese el nombre de usuario";

                errorProvider1.SetError(usuarioTextBox1, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(contrasenaTextBox1.Text))
            {
                error = "Ingrese la contraseña";

                errorProvider1.SetError(contrasenaTextBox1, error);
                resultados = false;
            }
            return resultados;
        }

        private void fechaNacimientoDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaNacimiento = true;
            fechaNacimientoDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaNacimientoDateTimePicker, String.Empty);
        }
    }
}
