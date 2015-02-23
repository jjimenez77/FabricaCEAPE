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
    public partial class FrmEditarIngredienteReceta : Form
    {
        int idReceta;
        public FrmEditarIngredienteReceta(int id, int idReceta)
        {
            InitializeComponent();
            this.idReceta = idReceta;
            medidaBindingSource.DataSource = DatosMedida.getMedidas();
            materiaPrimaRecetaBindingSource.DataSource = DatosMateriaPrimaReceta.getMateriaPrimaRecetas();

            if (id == 0)
            {
                ingredienteRecetaBindingSource.Add(new IngredienteReceta());
            }
            else
            {
                ingredienteRecetaBindingSource.Add(DatosIngredienteReceta.getIngredienteReceta(id));

                cbMedida1.SelectedItem = ((IngredienteReceta)ingredienteRecetaBindingSource.Current).Medida;
                cbMedida1.SelectedValue = ((IngredienteReceta)ingredienteRecetaBindingSource.Current).Medida.Id;

                cbMateriaPrimaReceta.SelectedItem = ((IngredienteReceta)ingredienteRecetaBindingSource.Current).Nombre;
                cbMateriaPrimaReceta.SelectedValue = ((IngredienteReceta)ingredienteRecetaBindingSource.Current).Nombre.Id;

                IngredienteReceta ir = (IngredienteReceta)ingredienteRecetaBindingSource.Current;

                if (ir.Nombre.Nombre != "")
                {
                    this.Text = "Editar " + ir.Nombre.Nombre;
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

                IngredienteReceta ir = (IngredienteReceta)ingredienteRecetaBindingSource.Current;
                ir.Medida = (Medida)cbMedida1.SelectedItem;
                ir.Nombre = (MateriaPrimaReceta)cbMateriaPrimaReceta.SelectedItem;

                Receta r = new Receta();
                r.Id = idReceta;
                ir.Receta = r;

                if (ir.Id == 0)
                {
                    DatosIngredienteReceta.Crear(ir);
                }
                else
                {
                    DatosIngredienteReceta.Modificar(ir);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(textBox2))
            {
                error = "Ingrese la descripcion del ingrediente";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                textBox2.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            } 
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumero(textBox3) || textBox3.Text == "0")
            {
                error = "Ingrese la cantidad";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                textBox3.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
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

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                error = "Ingrese la descripcion del ingrediente";

                errorProvider1.SetError(textBox2, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(textBox3.Text) || textBox3.Text == "0")
            {
                error = "Ingrese la cantidad";

                errorProvider1.SetError(textBox3, error);
                resultados = false;
            }
            return resultados;
        }
    }
}
