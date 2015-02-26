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
    public partial class FrmEditarTipoProducto : Form
    {
        public FrmEditarTipoProducto(int id)
        {
            InitializeComponent();

            if (id == 0)
            {
                tipoProductoBindingSource.Add(new TipoProducto());
            }
            else
            {
                tipoProductoBindingSource.Add(DatosTipoProducto.getTipoProducto(id));

                TipoProducto tp = (TipoProducto)tipoProductoBindingSource.Current;

                if (tp.Nombre != "")
                {
                    this.Text = "Editar " + tp.Nombre;
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

                TipoProducto p = (TipoProducto)tipoProductoBindingSource.Current;
                p.Activo = true;
                if (p.IdTipoProducto == 0)
                {
                    DatosTipoProducto.Crear(p);
                }
                else
                {
                    DatosTipoProducto.Modificar(p);
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
                error = "Ingrese el nombre del tipo de producto";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosTipoProducto.existe(nombreWaterMarkTextBox.Text))
            {
                error = "El tipo de producto ya existe";
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
                error = "Ingrese el nombre del tipo de productos";

                errorProvider1.SetError(nombreWaterMarkTextBox, error);
                resultados = false;
            }

            return resultados;
        }
    }
}
