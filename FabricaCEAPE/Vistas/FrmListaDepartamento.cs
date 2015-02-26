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
    public partial class FrmListaDepartamento : Form
    {
        public FrmListaDepartamento()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            departamentoBindingSource.DataSource = DatosDepartamento.getDepartamentos();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarDepartamento d = new FrmEditarDepartamento(0);
            d.ShowDialog();
            Actualizar();  
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            FrmEditarDepartamento edit = new FrmEditarDepartamento(((Departamento)departamentoBindingSource.Current).Id);
            edit.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Departamento d = (Departamento)departamentoBindingSource.Current;
                if (!DatosDepartamento.enUso(d.Id))
                {
                    d.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + d.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosDepartamento.Modificar(d);
                        Actualizar();
                    }
                }
                else
                {
                    MessageBox.Show("El objeto seleccionado no puede ser eliminado");
                }
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

        private void departamentoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = departamentoDataGridView.CurrentRow.Index;
                    FrmEditarDepartamento edit = new FrmEditarDepartamento(((Departamento)departamentoDataGridView.Rows[seleccion].DataBoundItem).Id);
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
