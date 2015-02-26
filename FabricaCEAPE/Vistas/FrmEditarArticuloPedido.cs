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
    public partial class FrmEditarArticuloPedido : Form
    {
        int idPedido;

        public FrmEditarArticuloPedido(int id, int idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
            medidaBindingSource.DataSource = DatosMedida.getMedidas();

            if (id == 0)
            {
                articuloPedidoBindingSource.Add(new ArticuloPedido());
            }
            else
            {
                articuloPedidoBindingSource.Add(DatosArticuloPedido.getArticuloPedido(id));

                cbMedida.SelectedItem = ((ArticuloPedido)articuloPedidoBindingSource.Current).Medida;
                cbMedida.SelectedValue = ((ArticuloPedido)articuloPedidoBindingSource.Current).Medida.Id;

                ArticuloPedido ap = (ArticuloPedido)articuloPedidoBindingSource.Current;

                if (ap.Nombre != "")
                {
                    this.Text = "Editar " + ap.Nombre;
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

                ArticuloPedido ap = (ArticuloPedido)articuloPedidoBindingSource.Current;
                ap.Medida = (Medida)cbMedida.SelectedItem;

                Pedido p = new Pedido();
                p.Id = idPedido;
                ap.Pedido =  p;

                if (ap.Id == 0)
                {
                    DatosArticuloPedido.Crear(ap);
                }
                else
                {
                    DatosArticuloPedido.Modificar(ap);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                error = "Ingrese el nombre del articulo";
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

        private void descripcionTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(descripcionTextBox))
            {
                error = "Ingrese la descripcion del articulo";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                descripcionTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            } 
        }

        private void descripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsPunctuation(e.KeyChar))
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

        private void cantidadTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumero(cantidadTextBox) || cantidadTextBox.Text == "0")
            {
                error = "Ingrese la cantidad";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                cantidadTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
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

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre del articulo";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                error = "Ingrese la descripcion del articulo";

                errorProvider1.SetError(descripcionTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(cantidadTextBox.Text) || cantidadTextBox.Text == "0")
            {
                error = "Ingrese la cantidad";

                errorProvider1.SetError(cantidadTextBox, error);
                resultados = false;
            }
            return resultados;
        }
    }
}
