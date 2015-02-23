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
    public partial class FrmEditarCliente : Form
    {
        int id;
        bool fechaInicio = false;

        public FrmEditarCliente(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();

            this.id = id;

            this.fechaInicioDateTimePicker.MaxDate = DateTime.Today.AddDays(1);

            if (id == 0)
            {
                Actualizar2();
                clienteBindingSource.Add(new Cliente());
            }
            else
            {
                Actualizar();
                fechaInicio = true;
                clienteBindingSource.Add(DatosCliente.getCliente(id));

                cbZona.SelectedItem = ((Cliente)clienteBindingSource.Current).Zona;
                cbZona.SelectedValue = ((Cliente)clienteBindingSource.Current).Zona.IdZona;

                cbLocalidad.SelectedItem = ((Zona)zonaBindingSource.Current).Localidad;
                cbLocalidad.SelectedValue = ((Zona)zonaBindingSource.Current).Localidad.Id;

                cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
                cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

                cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
                cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

                Cliente c = (Cliente)clienteBindingSource.Current;

                if (c.Nombre != "")
                {
                    this.Text = "Editar " + c.Nombre;
                }  
            }
        }

        private void Actualizar()
        {
            try
            {
                Cliente c = DatosCliente.getCliente(id);

                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais(c.Zona.Localidad.Provincia.Pais.Id);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia(c.Zona.Localidad.Provincia.Id);
                    if (cbLocalidad.SelectedValue == null)
                    {
                        zonaBindingSource.DataSource = null;
                    }
                    else
                    {
                        zonaBindingSource.DataSource = DatosZona.getZonasPorLocalidad(c.Zona.Localidad.Id);
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
                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.SelectedValue);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.SelectedValue);
                    if (cbLocalidad.SelectedValue == null)
                    {
                        zonaBindingSource.DataSource = null;
                    }
                    else
                    {
                        zonaBindingSource.DataSource = DatosZona.getZonasPorLocalidad((int)cbZona.SelectedValue);
                    }
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
                    zonaBindingSource.DataSource = null;
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

                if (cbLocalidad.SelectedValue == null)
                {
                    zonaBindingSource.DataSource = null;
                }
                else
                {
                    ActualizarCbZona();
                }
            }
            catch
            {
            }
        }

        private void ActualizarCbZona()
        {
            try
            {
                zonaBindingSource.DataSource = DatosZona.getZonasPorLocalidad((int)cbLocalidad.SelectedValue);
            }
            catch
            {

            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPais_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCBProvincia();
            if (cbZona.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbZona, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbZona, "Seleccione la zona");
            }
        }

        private void cbProvincia_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCbLocalidad();
            if (cbZona.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbZona, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbZona, "Seleccione la zona");
            }
        }

        private void cbLocalidad_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCbZona();
            if (cbZona.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbZona, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbZona, "Seleccione la zona");
            }
        }

        private void cbZona_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbZona.SelectedIndex == -1)
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
            //else if (Char.IsPunctuation(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            else
            {
                e.Handled = true;
            }
        }

        private void nombreWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumeroPunto(nombreWaterMarkTextBox) || nombreWaterMarkTextBox.Text.Trim() == String.Empty)
            {
                error = "Ingrese el nombre del cliente";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void nombreDeContactoWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreDeContactoWaterMarkTextBox))
            {
                error = "Ingrese el nombre de contacto";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreDeContactoWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }  
        }

        private void nombreDeContactoWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cuitWaterMarkTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cuitWaterMarkTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(cuitWaterMarkTextBox))
            {
                error = "Ingrese el numero de CUIL/CUIT";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                cuitWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
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
                error = "Ingrese el numero de telefono";
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
                error = "Ingrese el numero de celular";
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
                error = "Ingrese el correo electronico";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoWaterMarkTextBox.BackColor = colorOk;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Cliente c = (Cliente)clienteBindingSource.Current;
                c.Zona = (Zona)cbZona.SelectedItem;
                c.Activo = true;
                c.FechaInicio = fechaInicioDateTimePicker.Value;
                if (c.Id == 0)
                {
                    DatosCliente.Crear(c);
                }
                else
                {
                    DatosCliente.Modificar(c);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreWaterMarkTextBox.Text))
            {
                error = "Ingrese el nombre del cliente";

                errorProvider1.SetError(nombreWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(nombreDeContactoWaterMarkTextBox.Text))
            {
                error = "Ingrese el nombre de contacto";

                errorProvider1.SetError(nombreDeContactoWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(cuitWaterMarkTextBox.Text))
            {
                error = "Ingrese el numero de CUIL/CUIT";

                errorProvider1.SetError(cuitWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroTelefonoWaterMarkTextBox.Text))
            {
                error = "Ingrese el numero de telefono";

                errorProvider1.SetError(numeroTelefonoWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroCelularWaterMarkTextBox.Text))
            {
                error = "Ingrese el numero de celular";

                errorProvider1.SetError(numeroCelularWaterMarkTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoWaterMarkTextBox.Text))
            {
                error = "Ingrese el correo electronico";

                errorProvider1.SetError(correoElectronicoWaterMarkTextBox, error);
                resultados = false;
            }

            if (fechaInicio == false)
            {
                error = "Seleccione la fecha de inicio de transacciones";
                errorProvider1.SetError(fechaInicioDateTimePicker, error);
                resultados = false;
            }
            else
            {
                fechaInicioDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaInicioDateTimePicker, String.Empty);
            }

            if (string.IsNullOrEmpty(direccionWaterMarkTextBox.Text)) //verifica si es nulo o vacio, verifica si es nullo o espacio
            {
                error = "Ingrese la direccion";

                errorProvider1.SetError(direccionWaterMarkTextBox, error);
                resultados = false;
            }

            if (cbZona.SelectedIndex < 0)
            {
                error = "Seleccione la zona";

                errorProvider1.SetError(cbZona, error);
                resultados = false;
            }

            return resultados;
        }

        private void fechaInicioDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaInicio = true;
            fechaInicioDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaInicioDateTimePicker, String.Empty);
        }

        private void fechaInicioDateTimePicker_DropDown_1(object sender, EventArgs e)
        {
            fechaInicio = true;
            fechaInicioDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaInicioDateTimePicker, String.Empty);
        }
    }
}
