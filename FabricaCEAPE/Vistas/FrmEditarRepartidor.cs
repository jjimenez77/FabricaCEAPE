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
    public partial class FrmEditarRepartidor : Form
    {
        int id;
        bool fechaNacimiento = false;

        public FrmEditarRepartidor(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();
            paisBindingSource2.DataSource = DatosPais.getPaises();

            this.id = id;

            this.fechaNacimientoDateTimePicker.MaxDate = DateTime.Today.AddYears(-16);
            this.fechaIngresoDateTimePicker.MaxDate = DateTime.Today.AddDays(1);

            if (id == 0)
            {
                Actualizar2();
                repartidorBindingSource.Add(new Repartidor());
            }
            else
            {
                Actualizar();
                fechaNacimiento = true;

                repartidorBindingSource.Add(DatosRepartidor.getRepartido(id));
                Repartidor r = (Repartidor)repartidorBindingSource.Current;

                repartidorBindingSource.Add(r);

                if (r.Sexo)
                {
                    rbtnM.Select();
                }
                else
                {
                    rbtnF.Select();
                }

                if (r.TipoDocumento == "DNI")
                {
                    tipoDocumentoDropbox.Text = "DNI";
                }
                else if (r.TipoDocumento == "PASAPORTE")
                {
                    tipoDocumentoDropbox.Text = "PASAPORTE";
                }
                else
                {
                    tipoDocumentoDropbox.Text = "OTRO";
                }

                //localidad
                cbLocalidad.SelectedItem = ((Repartidor)repartidorBindingSource.Current).Localidad;
                cbLocalidad.SelectedValue = ((Repartidor)repartidorBindingSource.Current).Localidad.Id;

                cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
                cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

                cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
                cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

                //zona
                cbZona2.SelectedItem = ((Repartidor)repartidorBindingSource.Current).Zona;
                cbZona2.SelectedValue = ((Repartidor)repartidorBindingSource.Current).Zona.IdZona;

                cbLocalidad2.SelectedItem = ((Zona)zonaBindingSource2.Current).Localidad;
                cbLocalidad2.SelectedValue = ((Zona)zonaBindingSource2.Current).Localidad.Id;

                cbProvincia2.SelectedItem = ((Localidad)localidadBindingSource2.Current).Provincia;
                cbProvincia2.SelectedValue = ((Localidad)localidadBindingSource2.Current).Provincia.Id;

                cbPais2.SelectedItem = ((Provincia)provinciaBindingSource2.Current).Pais;
                cbPais2.SelectedValue = ((Provincia)provinciaBindingSource2.Current).Pais.Id;

                if (r.Nombre != "")
                {
                    this.Text = "Editar " + r.Nombre;
                }     
            }
        }

        private void Actualizar()
        {
            try
            {
                Repartidor r = DatosRepartidor.getRepartido(id);

                //se puede utilizar el metodo de arriba, pero este abajo es mas conveniente. pero el otro es menos codigo.//
                //repartidorBindingSource.Add(DatosRepartidor.getRepartido(id)); 
                //Repartidor r = (Repartidor)repartidorBindingSource.Current;

                //localidad
                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais(r.Localidad.Provincia.Pais.Id);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia(r.Localidad.Provincia.Id);
                }

                //zona
                provinciaBindingSource2.DataSource = DatosProvincia.getProvinciasPorPais(r.Zona.Localidad.Provincia.Pais.Id);
                if (cbProvincia2.SelectedValue == null)
                {
                    localidadBindingSource2.DataSource = null;
                }
                else
                {
                    localidadBindingSource2.DataSource = DatosLocalidad.getLocalidadesPorProvincia(r.Zona.Localidad.Provincia.Id);
                    if (cbLocalidad2.SelectedValue == null)
                    {
                        zonaBindingSource2.DataSource = null;
                    }
                    else
                    {
                        zonaBindingSource2.DataSource = DatosZona.getZonasPorLocalidad(r.Zona.Localidad.Id);
                    }
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
                //localidad
                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.SelectedValue);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.SelectedValue);
                }

                //zona
                provinciaBindingSource2.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.SelectedValue);

                if (cbProvincia2.SelectedValue == null)
                {
                    localidadBindingSource2.DataSource = null;
                }
                else
                {
                    localidadBindingSource2.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.SelectedValue);
                    if (cbLocalidad2.SelectedValue == null)
                    {
                        zonaBindingSource2.DataSource = null;
                    }
                    else
                    {
                        zonaBindingSource2.DataSource = DatosZona.getZonasPorLocalidad((int)cbZona2.SelectedValue);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ActualizarCBProvincia2()
        {
            try
            {
                provinciaBindingSource2.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais2.SelectedValue);

                if (cbProvincia2.SelectedValue == null)
                {
                    localidadBindingSource2.DataSource = null;
                    zonaBindingSource2.DataSource = null;
                }
                else
                {
                    ActualizarCbLocalidad2();
                }
            }
            catch
            {
            }
        }

        private void ActualizarCbLocalidad2()
        {
            try
            {
                localidadBindingSource2.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia2.SelectedValue);

                if (cbLocalidad2.SelectedValue == null)
                {
                    zonaBindingSource2.DataSource = null;
                }
                else
                {
                    ActualizarCbZona2();
                }
            }
            catch
            {
            }
        }

        private void ActualizarCbZona2()
        {
            try
            {
                zonaBindingSource2.DataSource = DatosZona.getZonasPorLocalidad((int)cbLocalidad2.SelectedValue);
            }
            catch
            {

            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

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

        private void cbLocalidad_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbLocalidad.SelectedIndex == -1)
            {
                error = "Seleccione la localidad";
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, error);
            }
        }

        private void cbPais2_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCBProvincia2();
            if (cbZona2.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbZona2, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbZona2, "Seleccione la zona");
            }
        }

        private void cbProvincia2_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCbLocalidad2();
            if (cbZona2.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbZona2, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbZona2, "Seleccione la zona");
            }
        }

        private void cbLocalidad2_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCbZona2();
            if (cbZona2.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbZona2, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbZona2, "Seleccione la zona");
            }
        }

        private void cbZona2_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbZona2.SelectedIndex == -1)
            {
                error = "Seleccione la zona";
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, error);
            }
        }

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

        private void nombreWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreWaterMarkTextBox))
            {
                nombreWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el nombre";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }  
        }

        private void apellidoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(apellidoWaterMarkTextBox))
            {
                apellidoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el apellido";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                apellidoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnF, String.Empty);
        }

        private void rbtnF_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnF, String.Empty);
        }

        private void numeroTelefonoWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void numeroTelefonoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esTelefono(numeroTelefonoWaterMarkTextBox))
            {
                numeroTelefonoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el numero de telefono";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosRepartidor.existeRepartidorNT(id, numeroTelefonoWaterMarkTextBox.Text))
            {
                numeroTelefonoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError(numeroTelefonoWaterMarkTextBox, String.Empty);
            }
            else if (DatosRepartidor.existeTelefono(numeroTelefonoWaterMarkTextBox.Text))
            {
                numeroTelefonoWaterMarkTextBox.BackColor = Color.White;
                error = "El numero de telefono ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroTelefonoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void numeroCelularWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esTelefono(numeroCelularWaterMarkTextBox))
            {
                numeroCelularWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el numero de celular";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosRepartidor.existeRepartidorNC(id, numeroCelularWaterMarkTextBox.Text))
            {
                numeroCelularWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError(numeroCelularWaterMarkTextBox, String.Empty);
            }
            else if (DatosRepartidor.existeCelular(numeroCelularWaterMarkTextBox.Text))
            {
                numeroCelularWaterMarkTextBox.BackColor = Color.White;
                error = "El numero de celular ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroCelularWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void correoElectronicoWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void correoElectronicoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esEmail(correoElectronicoWaterMarkTextBox))
            {
                correoElectronicoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosRepartidor.existeRepartidorCE(id, correoElectronicoWaterMarkTextBox.Text))
            {
                correoElectronicoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError(correoElectronicoWaterMarkTextBox, String.Empty);
            }
            else if (DatosRepartidor.existeCorreoE(correoElectronicoWaterMarkTextBox.Text))
            {
                correoElectronicoWaterMarkTextBox.BackColor = Color.White;
                error = "El correo electronico ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void correoElectronicoAlternativoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esEmail(correoElectronicoAlternativoWaterMarkTextBox))
            {
                correoElectronicoAlternativoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico alternativo";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosRepartidor.existeRepartidorCEA(id, correoElectronicoAlternativoWaterMarkTextBox.Text))
            {
                correoElectronicoAlternativoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError(correoElectronicoAlternativoWaterMarkTextBox, String.Empty);
            }
            else if (DatosRepartidor.existeCorreoEA(correoElectronicoAlternativoWaterMarkTextBox.Text))
            {
                correoElectronicoAlternativoWaterMarkTextBox.BackColor = Color.White;
                error = "El correo electronico alternativo ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoAlternativoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void tipoDocumentoDropbox_DropDownClosed(object sender, EventArgs e)
        {
            if (tipoDocumentoDropbox.SelectedIndex >= 0)
            {
                errorProvider1.SetError(tipoDocumentoDropbox, String.Empty);
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

        private void numeroDocumentoWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void numeroDocumentoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(numeroDocumentoWaterMarkTextBox))
            {
                numeroDocumentoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el numero de documento";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosRepartidor.existeRepartidorND(id, numeroDocumentoWaterMarkTextBox.Text))
            {
                correoElectronicoAlternativoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError(numeroDocumentoWaterMarkTextBox, String.Empty);
            }
            else if (DatosRepartidor.existeDocumento(numeroDocumentoWaterMarkTextBox.Text))
            {
                numeroDocumentoWaterMarkTextBox.BackColor = Color.White;
                error = "El de numero documento ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroDocumentoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void direccionWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void direccionWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumeroPunto(direccionWaterMarkTextBox) || direccionWaterMarkTextBox.Text.Trim() == String.Empty)
            {
                direccionWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese la direccion";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                direccionWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreWaterMarkTextBox.Text))
            {
                nombreWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el nombre";

                errorProvider1.SetError(nombreWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(apellidoWaterMarkTextBox.Text))
            {
                apellidoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el apellido";

                errorProvider1.SetError(apellidoWaterMarkTextBox, error);
                resultados = false;
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

            if (string.IsNullOrEmpty(numeroTelefonoWaterMarkTextBox.Text))
            {
                error = "Ingrese el numero de telefono";

                numeroCelularWaterMarkTextBox.BackColor = Color.White;
                errorProvider1.SetError(numeroTelefonoWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroCelularWaterMarkTextBox.Text))
            {
                numeroCelularWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el numero de celular";

                errorProvider1.SetError(numeroCelularWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoWaterMarkTextBox.Text))
            {
                correoElectronicoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico";

                errorProvider1.SetError(correoElectronicoWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoAlternativoWaterMarkTextBox.Text))
            {
                correoElectronicoAlternativoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico alternativo";

                errorProvider1.SetError(correoElectronicoAlternativoWaterMarkTextBox, error);
                resultados = false;
            }

            if (tipoDocumentoDropbox.SelectedIndex < 0)
            {
                error = "Seleccione el tipo de documento";

                errorProvider1.SetError(tipoDocumentoDropbox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroDocumentoWaterMarkTextBox.Text))
            {
                numeroDocumentoWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese el numero de documento";

                errorProvider1.SetError(numeroDocumentoWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(direccionWaterMarkTextBox.Text)) //verifica si es nulo o vacio, verifica si es nullo o espacio
            {
                direccionWaterMarkTextBox.BackColor = Color.White;
                error = "Ingrese la direccion";

                errorProvider1.SetError(direccionWaterMarkTextBox, error);
                resultados = false;
            }

            if (cbLocalidad.SelectedIndex < 0)
            {
                error = "Seleccione la localidad";

                errorProvider1.SetError(cbLocalidad, error);
                resultados = false;
            }

            if (cbZona2.SelectedIndex < 0)
            {
                error = "Seleccione la zona de trabajo";

                errorProvider1.SetError(cbZona2, error);
                resultados = false;
            }
            return resultados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Repartidor r = (Repartidor)repartidorBindingSource.Current;

                r.Localidad = (Localidad)cbLocalidad.SelectedItem;
                r.Zona = (Zona)cbZona2.SelectedItem;

                if (rbtnM.Checked)
                {
                    r.Sexo = true;
                }
                else if (rbtnF.Checked)
                {
                    r.Sexo = false;
                }

                if (tipoDocumentoDropbox.SelectedIndex == 0)
                {
                    r.TipoDocumento = "DNI";
                }
                else if (tipoDocumentoDropbox.SelectedIndex == 1)
                {
                    r.TipoDocumento = "PASAPORTE";
                }
                else
                {
                    r.TipoDocumento = "OTRO";
                }

                r.Activo = true;
                r.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
                r.FechaIngreso = fechaIngresoDateTimePicker.Value;

                if (r.Id == 0)
                {
                    DatosRepartidor.Crear(r);
                }
                else
                {
                    DatosRepartidor.Modificar(r);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void fechaNacimientoDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaNacimiento = true;
            fechaNacimientoDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaNacimientoDateTimePicker, String.Empty);
        }
    }
}
