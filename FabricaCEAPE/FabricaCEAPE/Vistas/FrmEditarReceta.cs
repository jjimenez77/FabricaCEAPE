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
    public partial class FrmEditarReceta : Form
    {
        int id;
        public FrmEditarReceta(int id)
        {
            InitializeComponent();
            this.id = id;

            Actualizar();

            recetaBindingSource.Add(DatosReceta.getReceta(id));

            Receta r = (Receta)recetaBindingSource.Current;

            if(r.Nombre != "")
            {
                this.Text = "Editar receta de " + r.Nombre;
            }            
        }

        private void Actualizar()
        {
            ingredienteRecetaBindingSource.DataSource = DatosIngredienteReceta.getIngredientesRecetaPorReceta(id);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Receta r = (Receta)recetaBindingSource.Current;
            r.Activo = false;
            if (MessageBox.Show("¿Esta seguro de borrar a " + r.Nombre, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatosReceta.Modificar(r);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Receta r = (Receta)recetaBindingSource.Current;
                r.Activo = true;

                DatosReceta.Modificar(r);
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            FrmEditarIngredienteReceta ir = new FrmEditarIngredienteReceta(0, ((Receta)recetaBindingSource.Current).Id);
            ir.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarIngredienteReceta edit = new FrmEditarIngredienteReceta(((IngredienteReceta)ingredienteRecetaBindingSource.Current).Id, ((Receta)recetaBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                IngredienteReceta ir = (IngredienteReceta)ingredienteRecetaBindingSource.Current;

                if (MessageBox.Show("Esta seguro de borrar a " + ir.Nombre, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosIngredienteReceta.Eliminar(ir);
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                error = "Ingrese el nombre de la receta";
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

        private void observacionesTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(observacionesTextBox))
            {
                error = "Ingrese alguna observacion";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                observacionesTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }  
        }

        private void tiempoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(tiempoTextBox))
            {
                error = "Ingrese el tiempo recomendado";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                tiempoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }  
        }

        private void temperaturaTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(temperaturaTextBox))
            {
                error = "Ingrese la temperatura recomendada";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                temperaturaTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }  
        }

        private void otrosTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(otrosTextBox))
            {
                error = "Ingrese alguna observacion extra";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                otrosTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }  
        }

        private void otrosTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre de la receta";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(observacionesTextBox.Text))
            {
                error = "Ingrese alguna observacion";

                errorProvider1.SetError(observacionesTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(tiempoTextBox.Text))
            {
                error = "Ingrese el tiempo recomendado";

                errorProvider1.SetError(tiempoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(temperaturaTextBox.Text))
            {
                error = "Ingrese la temperatura recomendada";

                errorProvider1.SetError(temperaturaTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(otrosTextBox.Text))
            {
                error = "Ingrese alguna otra observacion";

                errorProvider1.SetError(otrosTextBox, error);
                resultados = false;
            }
            return resultados;
        }

        private void ingredienteRecetaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = ingredienteRecetaDataGridView.CurrentRow.Index;
                    FrmEditarIngredienteReceta edit = new FrmEditarIngredienteReceta(((IngredienteReceta)ingredienteRecetaDataGridView.Rows[seleccion].DataBoundItem).Id, ((Receta)recetaBindingSource.Current).Id);
                    edit.ShowDialog();
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarIngredienteReceta ir = new FrmEditarIngredienteReceta(0, ((Receta)recetaBindingSource.Current).Id);
            ir.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmEditarIngredienteReceta edit = new FrmEditarIngredienteReceta(((IngredienteReceta)ingredienteRecetaBindingSource.Current).Id, ((Receta)recetaBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                IngredienteReceta ir = (IngredienteReceta)ingredienteRecetaBindingSource.Current;

                if (MessageBox.Show("¿Esta seguro de borrar a " + ir.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosIngredienteReceta.Eliminar(ir);
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
