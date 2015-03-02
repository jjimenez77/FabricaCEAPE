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
    public partial class FrmEditarPais : Form
    {
        int id;
        public FrmEditarPais(int id)
        {
            InitializeComponent();
            this.id = id;
            if (id == 0)
            {
                paisBindingSource.Add(new Pais());
            }
            else
            {
                paisBindingSource.Add(DatosPais.getPais(id));

                Pais p = (Pais)paisBindingSource.Current;

                if (p.Nombre != "")
                {
                    this.Text = "Editar " + p.Nombre;
                }  
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Pais p = (Pais)paisBindingSource.Current;
                p.Activo = true;
                if (p.Id == 0)
                {
                    DatosPais.Crear(p);
                }
                else
                {
                    DatosPais.Modificar(p);
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

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre del pais";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosPais.existPaisN(id, nombreTextBox.Text))
            {
                nombreTextBox.BackColor = colorOk;
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
            else if (DatosPais.existe(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "El pais ya existe";
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
                error = "Ingrese el nombre del pais";
                nombreTextBox.BackColor = Color.White;
                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            return resultados;
        }
    }
}
