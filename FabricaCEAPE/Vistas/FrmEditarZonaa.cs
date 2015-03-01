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
    public partial class FrmEditarZonaa : Form
    {
        int id;
        bool errorr = true;
        public FrmEditarZonaa(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();

            this.id = id;


            if (id == 0)
            {
                Actualizar2();
                zonaBindingSource.Add(new Zona());
            }
            else
            {
                Actualizar();
                zonaBindingSource.Add(DatosZona.getZona(id));

                cbLocalidad.SelectedItem = ((Zona)zonaBindingSource.Current).Localidad;
                cbLocalidad.SelectedValue = ((Zona)zonaBindingSource.Current).Localidad.Id;

                cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
                cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

                cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
                cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

                Zona z = (Zona)zonaBindingSource.Current;

                if (z.Nombre != "")
                {
                    this.Text = "Editar " + z.Nombre;
                }     
            }
        }

        private void Actualizar()
        {
            try
            {
                Zona z = DatosZona.getZona(id);

                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais(z.Localidad.Provincia.Pais.Id);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia(z.Localidad.Provincia.Id);
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

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));


        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre de la zona";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }
            
            if (cbLocalidad.SelectedIndex < 0)
            {
                error = "Seleccione la localidad";

                errorProvider1.SetError(cbLocalidad, error);
                resultados = false;
            }

            if(!errorr)
            {
                resultados = false;
            }

            return resultados;
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

        private void cbPais_DropDownClosed_1(object sender, EventArgs e)
        {
            ActualizarCBProvincia();
            if (cbLocalidad.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbLocalidad, String.Empty);
                checarExitencia();
            }
            else
            {
                errorProvider1.SetError(cbLocalidad, "Seleccione la localidad");
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
        }

        private void cbProvincia_DropDownClosed_1(object sender, EventArgs e)
        {
            ActualizarCbLocalidad();
            if (cbLocalidad.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbLocalidad, String.Empty);
                checarExitencia();
            }
            else
            {
                errorProvider1.SetError(cbLocalidad, "Seleccione la localidad");
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
        }

        private void checarExitencia()
        {
            if (cbLocalidad.SelectedIndex >= 0)
            {
                if (DatosZona.existe(nombreTextBox.Text, (int)cbLocalidad.SelectedValue))
                {
                    nombreTextBox.BackColor = Color.White;
                    string error = "La zona ya existe en la localidad seleccionada";
                    errorProvider1.SetError(nombreTextBox, error);
                    errorr = false;
                }
                else
                {
                    nombreTextBox.BackColor = colorOk;
                    errorProvider1.SetError(nombreTextBox, String.Empty);
                    errorr = true;
                }
                if (DatosZona.existeZonaN(id, nombreTextBox.Text, (int)cbLocalidad.SelectedValue))
                {
                    nombreTextBox.BackColor = colorOk;
                    errorProvider1.SetError(nombreTextBox, String.Empty);
                    errorr = true;
                }                
            }
        }

        private void cbLocalidad_Validating_1(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbLocalidad.SelectedIndex == -1)
            {
                error = "Seleccione la localidad";
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, error);
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Zona z = (Zona)zonaBindingSource.Current;
                z.Activo = true;
                z.Localidad = (Localidad)cbLocalidad.SelectedItem;

                if (z.IdZona == 0)
                {
                    DatosZona.Crear(z);
                }
                else
                {
                    DatosZona.Modificar(z);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void nombreTextBox_Validating_1(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                error = "Ingrese el nombre de la zona";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            } 
        }

        private void cbLocalidad_DropDownClosed(object sender, EventArgs e)
        {
            checarExitencia();
        }
    }
}