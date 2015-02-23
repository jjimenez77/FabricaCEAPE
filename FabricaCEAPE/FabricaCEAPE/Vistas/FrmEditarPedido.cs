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
    public partial class FrmEditarPedido : Form
    {
        int id;
        public FrmEditarPedido(int id)
        {
            InitializeComponent();
            this.id = id; 
            Actualizar();

            pedidoBindingSource.Add(DatosPedido.getPedido(id));           

            this.cbDepartamento.ComboBox.DataSource = DatosDepartamento.getDepartamentos();
            this.cbDepartamento.ComboBox.ValueMember = "id";
            this.cbDepartamento.ComboBox.DisplayMember = "nombre";

            Pedido p = (Pedido)pedidoBindingSource.Current;

            if (p.Concepto != "")
            {
                this.Text = "Editar " + p.Concepto;
            }       
            this.conceptoTextBox.TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Concepto", true));
        }

        private void Actualizar()
        {
            articuloPedidoBindingSource.DataSource = DatosArticuloPedido.getArticulosPedidosPorPedido(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Pedido p = (Pedido)pedidoBindingSource.Current;

            if (MessageBox.Show("¿Esta seguro de eliminar el pedido?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatosPedido.Eliminar(p);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                DateTime fechaEmitido = DateTime.Now;

                Pedido p = (Pedido)pedidoBindingSource.Current;

                p.FechaEmitido = fechaEmitido;
                p.Departamento = (Departamento)cbDepartamento.SelectedItem;
                p.Activo = true;

                DatosPedido.Modificar(p);
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarArticuloPedido ap = new FrmEditarArticuloPedido(0, ((Pedido)pedidoBindingSource.Current).Id);
            ap.ShowDialog();
            Actualizar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarArticuloPedido edit = new FrmEditarArticuloPedido(((ArticuloPedido)articuloPedidoBindingSource.Current).Id, ((Pedido)pedidoBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloPedido ap = (ArticuloPedido)articuloPedidoBindingSource.Current;

                if (MessageBox.Show("¿Esta seguro de borrar a " + ap.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosArticuloPedido.Eliminar(ap);
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void conceptoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(conceptoTextBox.TextBox))
            {
                error = "Ingrese el concepto de pedido";
                e.Cancel = true;
                errorProvider1.SetError(conceptoTextBox.TextBox, error);
            }
            else
            {
                conceptoTextBox.BackColor = colorOk;
                errorProvider1.SetError(conceptoTextBox.TextBox, String.Empty);
            }   
        }

        private void descripcionTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(descripcionTextBox))
            {
                error = "Ingrese la descripcion del pedido";
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

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(conceptoTextBox.Text))
            {
                error = "Ingrese el concepto de pedido";

                errorProvider1.SetError(conceptoTextBox.TextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                error = "Ingrese la descripcion del pedido";

                errorProvider1.SetError(descripcionTextBox, error);
                resultados = false;
            }
            return resultados;
        }

        private void articuloPedidoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = articuloPedidoDataGridView.CurrentRow.Index;
                    FrmEditarArticuloPedido edit = new FrmEditarArticuloPedido(((ArticuloPedido)articuloPedidoDataGridView.Rows[seleccion].DataBoundItem).Id, ((Pedido)pedidoBindingSource.Current).Id);
                    edit.ShowDialog();
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }
    }
}
