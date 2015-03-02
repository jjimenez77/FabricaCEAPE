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
        bool crearModificar; //crear = true //modificar = false
        bool seleccionaProducto = false;
        public FrmEditarReceta(int id, bool crearModificar) //
        {
            InitializeComponent();
            this.id = id;
            this.crearModificar = crearModificar;

            productoBindingSource.DataSource = DatosProducto.getProductos();
            Actualizar();
            
            if (id == 0)
            {
                recetaBindingSource.Add(new Receta());
            }
            else
            {
                recetaBindingSource.Add(DatosReceta.getReceta(id));

                cbProducto.SelectedItem = ((Receta)recetaBindingSource.Current).Producto;
                cbProducto.SelectedValue = ((Receta)recetaBindingSource.Current).Producto.IdProducto;

                Receta r = (Receta)recetaBindingSource.Current;

                if (!crearModificar)
                {
                    this.Text = "Editar receta de " + r.Producto.Nombre;
                }  
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
            //if (MessageBox.Show("¿Esta seguro de borrar a " + r.Producto.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            if (crearModificar)
            {
                DatosReceta.Modificar(r);
            }
            Close();
            //}
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Receta r = (Receta)recetaBindingSource.Current;
                r.Producto = (Producto)cbProducto.SelectedItem;
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

        /*private void nombreTextBox_Validating(object sender, CancelEventArgs e)
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
        }*/

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
                observacionesTextBox.BackColor = Color.White;
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
                tiempoTextBox.BackColor = Color.White;
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
                temperaturaTextBox.BackColor = Color.White;
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
                otrosTextBox.BackColor = Color.White;
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

            //if (seleccionaProducto == false)
            //{
            //    error = "Seleccione un producto";
            //    errorProvider1.SetError(cbProducto, error);
            //    resultados = false;
            //}
            //else
            //{
            //    errorProvider1.SetError(cbProducto, String.Empty);
            //}

            if (DatosReceta.existeReceta(id, (int)cbProducto.SelectedValue))
            {
                errorProvider1.SetError(cbProducto, String.Empty);
            }
            else if (DatosReceta.existe((int)cbProducto.SelectedValue))
            {
                error = "Ya existe una receta para este producto";

                errorProvider1.SetError(cbProducto, error);
                resultados = false;
            }
            else
            {
                errorProvider1.SetError(cbProducto, String.Empty);
            }

            if (string.IsNullOrEmpty(observacionesTextBox.Text))
            {
                observacionesTextBox.BackColor = Color.White;
                error = "Ingrese alguna observacion";

                errorProvider1.SetError(observacionesTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(tiempoTextBox.Text))
            {
                tiempoTextBox.BackColor = Color.White;
                error = "Ingrese el tiempo recomendado";

                errorProvider1.SetError(tiempoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(temperaturaTextBox.Text))
            {
                temperaturaTextBox.BackColor = Color.White;
                error = "Ingrese la temperatura recomendada";

                errorProvider1.SetError(temperaturaTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(otrosTextBox.Text))
            {
                otrosTextBox.BackColor = Color.White;
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

        private void btnCancelarr_Click(object sender, EventArgs e)
        {
            Receta r = (Receta)recetaBindingSource.Current;
            r.Activo = false;

            DatosReceta.Modificar(r);
            Close();
        }

        private void cbProducto_DropDownClosed(object sender, EventArgs e)
        {
            //seleccionaProducto = true;

            if (DatosReceta.existeReceta(id, (int)cbProducto.SelectedValue))
            {
                errorProvider1.SetError(cbProducto, String.Empty);
            }
            else if (DatosReceta.existe((int)cbProducto.SelectedValue))
            {
                errorProvider1.SetError(cbProducto, "Ya existe una receta para este producto");
            }   
            else
            {
                errorProvider1.SetError(cbProducto, String.Empty);
            }
        }
    }
}
