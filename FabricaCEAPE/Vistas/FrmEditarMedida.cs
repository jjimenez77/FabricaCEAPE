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
    public partial class FrmEditarZona : Form
    {
        public FrmEditarZona(int id)
        {
            InitializeComponent();

            if (id == 0)
            {
                medidaBindingSource.Add(new Medida());
            }
            else
            {
                medidaBindingSource.Add(DatosMedida.getMedida(id));

                Medida m = (Medida)medidaBindingSource.Current;

                if (m.Nombre != "")
                {
                    this.Text = "Editar " + m.Nombre;
                }  
            }
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

                Medida m = (Medida)medidaBindingSource.Current;
                m.Activo = true;
                if (m.Id == 0)
                {
                    DatosMedida.Crear(m);
                }
                else
                {
                    DatosMedida.Modificar(m);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));


        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre de la medida";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(abreviacionTextBox.Text))
            {
                error = "Ingrese la abreviacion de la medida";

                errorProvider1.SetError(abreviacionTextBox, error);
                resultados = false;
            }

            return resultados;
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                error = "Ingrese el nombre de la medida";
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

        private void abreviacionTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(abreviacionTextBox))
            {
                error = "Ingrese la abreviacion de la medida";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                abreviacionTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }
    }
}
