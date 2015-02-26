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
using System.Collections;

namespace FabricaCEAPE.Vistas
{
    public partial class FrmListaReceta : Form
    {
        public FrmListaReceta()
        {
            InitializeComponent();

            cbSelector.Items.Add("Nombre");
            cbSelector.Items.Add("Usuario creador");

            cbSelector.SelectedIndex = 0;
            this.txtBuscar.Focus();

            Actualizar();
        }

        private void Actualizar()
        {
            try
            {
                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {
                    recetaBindingSource.DataSource = DatosReceta.getRecetas();
                }
            }
            catch
            {
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DateTime fechaCreacion = DateTime.Now;
            Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);

            Receta receta = new Receta();
            receta.Producto = (Producto)DatosProducto.getProducto(1);
            receta.Observaciones = "";
            receta.Tiempo = "";
            receta.Temperatura = "";
            receta.Otros = "";
            receta.FechaCreacion = fechaCreacion;
            receta.Usuario = (Usuario)DatosUsuario.getUsuario(u.Id);
            receta.Activo = true;
            DatosReceta.Crear(receta);

            FrmEditarReceta r = new FrmEditarReceta((int)DatosReceta.getUltimaReceta(), true);
            r.ShowDialog();
            Actualizar(); 
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Receta r = (Receta)recetaBindingSource.Current;
                r.Activo = false;

                if (MessageBox.Show("¿Esta seguro de borrar a " + r.Producto.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosReceta.Modificar(r);
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmEditarReceta edit = new FrmEditarReceta(((Receta)recetaBindingSource.Current).Id, false);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    Actualizar();
                }

                if (cbSelector.SelectedIndex == 0)
                {
                    recetaBindingSource.DataSource = DatosReceta.getRecetaPorNombre(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    recetaBindingSource.DataSource = DatosReceta.getRecetaPorUsuario(txtBuscar.Text);
                }
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }

        private void dgRecetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = dgRecetas.CurrentRow.Index;
                    FrmEditarReceta edit = new FrmEditarReceta(((Receta)dgRecetas.Rows[seleccion].DataBoundItem).Id, false);
                    edit.ShowDialog();
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void cbSelector_DropDownClosed(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Actualizar();

            if (cbSelector.SelectedIndex == 0)
            {
                txtBuscar.ToolTipText = "Buscar receta por nombre";
            }
            else
            {
                txtBuscar.ToolTipText = "Buscar receta por usuario creador";
            }
        }
    }
}
