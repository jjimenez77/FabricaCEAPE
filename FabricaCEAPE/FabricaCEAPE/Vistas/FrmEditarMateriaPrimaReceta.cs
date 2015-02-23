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
    public partial class FrmEditarMateriaPrimaReceta : Form
    {
        public FrmEditarMateriaPrimaReceta(int id)
        {
            InitializeComponent();

            if (id == 0)
            {
                materiaPrimaRecetaBindingSource.Add(new MateriaPrimaReceta());
            }
            else
            {
                materiaPrimaRecetaBindingSource.Add(DatosMateriaPrimaReceta.getMateriaPrimaReceta(id));

                MateriaPrimaReceta mpr = (MateriaPrimaReceta)materiaPrimaRecetaBindingSource.Current;

                if (mpr.Nombre != "")
                {
                    this.Text = "Editar " + mpr.Nombre;
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

                MateriaPrimaReceta mpr = (MateriaPrimaReceta)materiaPrimaRecetaBindingSource.Current;
                if (mpr.Id == 0)
                {
                    DatosMateriaPrimaReceta.Crear(mpr);
                }
                else
                {
                    DatosMateriaPrimaReceta.Modificar(mpr);
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

            if (string.IsNullOrEmpty(nombreWaterMarkTextBox.Text))
            {
                error = "Ingrese el nombre de la materia prima";

                errorProvider1.SetError(nombreWaterMarkTextBox, error);
                resultados = false;
            }

            return resultados;
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
            if (!Validacion.esCadenaNumeroPunto(nombreWaterMarkTextBox) || nombreWaterMarkTextBox.Text.Trim() == String.Empty)
            {
                error = "Ingrese el nombre de la materia prima";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }
    }
}
