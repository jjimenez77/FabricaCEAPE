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
    public partial class FrmEditarMarca : Form
    {
        int id;
        public FrmEditarMarca(int id)
        {
            InitializeComponent();
            this.id = id;
            if (id == 0)
            {
                marcaBindingSource.Add(new Marca());
            }
            else
            {
                marcaBindingSource.Add(DatosMarca.getMarca(id));

                Marca m = (Marca)marcaBindingSource.Current;

                if (m.Nombre != "")
                {
                    this.Text = "Editar " + m.Nombre;
                }  
            }     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AltaMarca_Load(object sender, EventArgs e)
        {

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

                Marca m = (Marca)marcaBindingSource.Current;
                m.Activo = true;
                if (m.Id == 0)
                {
                    DatosMarca.Crear(m);
                }
                else
                {
                    DatosMarca.Modificar(m);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre de la marca";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosMarca.existeMarca(id, nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
            else if (DatosMarca.existe(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "La marca ya existe";
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
            //else if (Char.IsPunctuation(e.KeyChar)) //puede no requerir puntuaciones la marca, si se requiere descomentar
            //{
            //    e.Handled = false;
            //}
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
                error = "Ingrese el nombre de la marca";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            return resultados;
        }
    }
}
