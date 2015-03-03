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
    public partial class FrmEditarProveedor : Form
    {
        int id;
        bool fechaInicio = false;

        public FrmEditarProveedor(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();

            this.id = id;

            this.fechaInicioDateTimePicker.MaxDate = DateTime.Today.AddDays(1);

            if (id == 0)
            {
                Actualizar2();
                proveedorBindingSource.Add(new Proveedor());
            }
            else
            {
                Actualizar();
                fechaInicio = true;
                proveedorBindingSource.Add(DatosProveedor.getProveedor(id));

                cbLocalidad.SelectedItem = ((Proveedor)proveedorBindingSource.Current).Localidad;
                cbLocalidad.SelectedValue = ((Proveedor)proveedorBindingSource.Current).Localidad.Id;

                cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
                cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

                cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
                cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

                Proveedor p = (Proveedor)proveedorBindingSource.Current;

                if (p.Nombre != "")
                {
                    this.Text = "Editar " + p.Nombre;
                }  
            }
        }

        private void Actualizar()
        {
            try
            {
                Proveedor p = DatosProveedor.getProveedor(id);

                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais(p.Localidad.Provincia.Pais.Id);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia(p.Localidad.Provincia.Id);
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
                Proveedor p = DatosProveedor.getProveedor(id);

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

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Proveedor p = (Proveedor)proveedorBindingSource.Current;
                p.Localidad = (Localidad)cbLocalidad.SelectedItem;
                p.Activo = true;
                p.FechaInicio = fechaInicioDateTimePicker.Value;
                if (p.Id == 0)
                {
                    DatosProveedor.Crear(p);
                }
                else
                {
                    DatosProveedor.Modificar(p);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
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

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre del proveedor";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }


            if (string.IsNullOrEmpty(nombreDeContactoTextBox.Text))
            {
                nombreDeContactoTextBox.BackColor = Color.White;
                error = "Ingrese el nombre de contacto";

                errorProvider1.SetError(nombreDeContactoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(cuitTextBox.Text))
            {
                cuitTextBox.BackColor = Color.White;
                error = "Ingrese el numero de CUIL/CUIT";

                errorProvider1.SetError(cuitTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroTelefonoTextBox.Text))
            {
                numeroTelefonoTextBox.BackColor = Color.White;
                error = "Ingrese el numero de telefono";

                errorProvider1.SetError(numeroTelefonoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroCelularTextBox.Text))
            {
                numeroCelularTextBox.BackColor = Color.White;
                error = "Ingrese el numero de celular";

                errorProvider1.SetError(numeroCelularTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoTextBox.Text))
            {
                correoElectronicoTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico";

                errorProvider1.SetError(correoElectronicoTextBox, error);
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

            if (string.IsNullOrEmpty(direccionTextBox.Text)) //verifica si es nulo o vacio, verifica si es nullo o espacio
            {
                direccionTextBox.BackColor = Color.White;
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

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumeroPunto(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre del proveedor";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosProveedor.existeProveedorN(id, nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
            else if (DatosProveedor.existeNombre(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "El nombre de proveedor ya existe";
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

        private void nombreDeContactoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreDeContactoTextBox))
            {
                nombreDeContactoTextBox.BackColor = Color.White;
                error = "Ingrese el nombre contacto";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreDeContactoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }  
        }

        private void nombreDeContactoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cuitTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumeroCUIT(cuitTextBox))
            {
                cuitTextBox.BackColor = Color.White;
                error = "Ingrese el numero de CUIL/CUIT, solo 11 numeros";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosProveedor.existeProveedorC(id, cuitTextBox.Text))
            {
                cuitTextBox.BackColor = colorOk;
                errorProvider1.SetError(cuitTextBox, String.Empty);
            }
            else if (DatosProveedor.existeC(cuitTextBox.Text))
            {
                cuitTextBox.BackColor = Color.White;
                error = "El numero de CUIL/CUIT ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                cuitTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void cuitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            //else if (Char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            else
            {
                e.Handled = true;
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
            else if (DatosProveedor.existeProveedorNT(id, numeroTelefonoTextBox.Text))
            {
                numeroTelefonoTextBox.BackColor = colorOk;
                errorProvider1.SetError(numeroTelefonoTextBox, String.Empty);
            }
            else if (DatosProveedor.existeNumeroTelefono(numeroTelefonoTextBox.Text))
            {
                numeroTelefonoTextBox.BackColor = Color.White;
                error = "El numero de telefono ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroTelefonoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
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
            else if (DatosProveedor.existeProveedorCO(id, correoElectronicoTextBox.Text))
            {
                correoElectronicoTextBox.BackColor = colorOk;
                errorProvider1.SetError(correoElectronicoTextBox, String.Empty);
            }
            else if (DatosProveedor.existeCorreoE(correoElectronicoTextBox.Text))
            {
                correoElectronicoTextBox.BackColor = Color.White;
                error = "El correo electronico ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void correoElectronicoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (DatosProveedor.existeProveedorNC(id, numeroCelularTextBox.Text))
            {
                numeroCelularTextBox.BackColor = colorOk;
                errorProvider1.SetError(numeroCelularTextBox, String.Empty);
            }
            else if (DatosProveedor.existeNumeroCelular(numeroCelularTextBox.Text))
            {
                numeroCelularTextBox.BackColor = Color.White;
                error = "El numero de celular ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroCelularTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
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

        private void fechaInicioDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaInicio = true;
            fechaInicioDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaInicioDateTimePicker, String.Empty);
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
    }
}
