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
    public partial class FrmEditarLocalidad : Form
    {
        int id;
        bool errorr = true;
        public FrmEditarLocalidad(int id)
        {
            InitializeComponent();
            paisBindingSource.DataSource = DatosPais.getPaises();
            this.id = id;
            if (id == 0)
            {
                ActualizarCB();

                localidadBindingSource.Add(new Localidad());
                paisBindingSource.DataSource = DatosPais.getPaises();
            }
            else
            {
                Actualizar();
                localidadBindingSource.Add(DatosLocalidad.getLocalidad(id));

                cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
                cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

                cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
                cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

                Localidad l = (Localidad)localidadBindingSource.Current;

                if (l.Nombre != "")
                {
                    this.Text = "Editar " + l.Nombre;
                }  
            }
        }

        private void Actualizar()
        {
            provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais(DatosLocalidad.getLocalidad(id).Provincia.Pais.Id);
        }
        
        public void ActualizarCB()
        {
            provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.SelectedValue);
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

                Localidad l = (Localidad)localidadBindingSource.Current;
                l.Provincia = (Provincia)cbProvincia.SelectedItem;
                l.Activo = true;
                if (l.Id == 0)
                {
                    DatosLocalidad.Crear(l);
                }
                else
                {
                    DatosLocalidad.Modificar(l);
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
            ActualizarCB();
            if (cbProvincia.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbProvincia, String.Empty);
                checarExitencia();
            }
            else
            {
                errorProvider1.SetError(cbProvincia, "Seleccione la provincia");
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre de la localidad";
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

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre de la localidad";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            if (cbProvincia.SelectedIndex < 0)
            {
                error = "Seleccione la provincia";

                errorProvider1.SetError(cbProvincia, error);
                resultados = false;
            }

            checarExitencia();
            if (!errorr)
            {
                resultados = false;
            }

            return resultados;
        }

        private void cbProvincia_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbProvincia.SelectedIndex == -1)
            {
                error = "Seleccione la provincia";
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, error);
            }
        }

        private void checarExitencia()
        {
            if (cbProvincia.SelectedIndex >= 0)
            {
                if (DatosLocalidad.existe(nombreTextBox.Text, (int)cbProvincia.SelectedValue))
                {
                    nombreTextBox.BackColor = Color.White;
                    string error = "La localidad ya existe en la provincia seleccionada";
                    errorProvider1.SetError(nombreTextBox, error);
                    errorr = false;
                }
                else
                {
                    nombreTextBox.BackColor = colorOk;
                    errorProvider1.SetError(nombreTextBox, String.Empty);
                    errorr = true;
                }
                if (DatosLocalidad.existeLocalidadN(id, nombreTextBox.Text, (int)cbProvincia.SelectedValue))
                {
                    nombreTextBox.BackColor = colorOk;
                    errorProvider1.SetError(nombreTextBox, String.Empty);
                    errorr = true;
                }
            }
        }

        private void cbProvincia_DropDownClosed(object sender, EventArgs e)
        {
            checarExitencia();
        }
    }
}
