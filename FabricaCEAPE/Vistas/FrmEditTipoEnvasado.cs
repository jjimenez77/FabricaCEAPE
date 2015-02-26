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
    public partial class FrmEditTipoEnvasado : Form
    {
        public FrmEditTipoEnvasado(int id)
        {
            InitializeComponent();

            if (id == 0)
            {
                tipoEnvasadoBindingSource.Add(new TipoEnvasado());
            }
            else
            {
                tipoEnvasadoBindingSource.Add(DatosTipoEnvasado.getTipoEnvasado(id));

                TipoEnvasado te = (TipoEnvasado)tipoEnvasadoBindingSource.Current;

                if (te.Nombre != "")
                {
                    this.Text = "Editar " + te.Nombre;
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

                TipoEnvasado p = (TipoEnvasado)tipoEnvasadoBindingSource.Current;
                p.Activo = true;
                if (p.IdTipoEnvasado == 0)
                {
                    DatosTipoEnvasado.Crear(p);
                }
                else
                {
                    DatosTipoEnvasado.Modificar(p);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

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
                error = "Ingrese el nombre del tipo de envasado";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosTipoEnvasado.existe(nombreWaterMarkTextBox.Text))
            {
                error = "El tipo de envasado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreWaterMarkTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreWaterMarkTextBox.Text))
            {
                error = "Ingrese el nombre del tipo de producto";

                errorProvider1.SetError(nombreWaterMarkTextBox, error);
                resultados = false;
            }

            return resultados;
        }
    }
}
