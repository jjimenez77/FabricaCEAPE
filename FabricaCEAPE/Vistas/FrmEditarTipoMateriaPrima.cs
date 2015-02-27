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
    public partial class FrmEditarTipoMateriaPrima : Form
    {
        int id;
        public FrmEditarTipoMateriaPrima(int id)
        {
            InitializeComponent();
            this.id = id;
            if (id == 0)
            {
                tipoMateriaPrimaBindingSource.Add(new TipoMateriaPrima());
            }
            else
            {
                tipoMateriaPrimaBindingSource.Add(DatosTipoMateriaPrima.getTipoMateriaPrima(id));

                TipoMateriaPrima tmp = (TipoMateriaPrima)tipoMateriaPrimaBindingSource.Current;

                if (tmp.Nombre != "")
                {
                    this.Text = "Editar " + tmp.Nombre;
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
                TipoMateriaPrima t = (TipoMateriaPrima)tipoMateriaPrimaBindingSource.Current;
                t.Activo = true;
                if (t.Id == 0)
                {
                    DatosTipoMateriaPrima.Crear(t);
                }
                else
                {
                    DatosTipoMateriaPrima.Modificar(t);
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
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre del tipo de materia prima";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            return resultados;
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre del tipo de materia prima";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosTipoMateriaPrima.existeTipoMateriaPrimaN(id, nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, String.Empty);
            }
            else if (DatosTipoMateriaPrima.existe(nombreTextBox.Text))
            {
                nombreTextBox.BackColor = Color.White;
                error = "El tipo de materia prima ya existe";
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
    }
}
