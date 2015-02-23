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
    public partial class FrmListaPais : Form
    {
        public FrmListaPais()
        {
            InitializeComponent();

            this.txtBuscar.Focus();

            Actualizar();
        }

        private void Actualizar()
        {
            paisBindingSource.DataSource = DatosPais.getPaises();
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
            FrmEditarPais p = new FrmEditarPais(0);
            p.ShowDialog();
            Actualizar(); 
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmEditarPais edit = new FrmEditarPais(((Pais)paisBindingSource.Current).Id);
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
                Pais p = (Pais)paisBindingSource.Current;
                p.Activo = false;

                if (MessageBox.Show("¿Esta seguro de borrar a " + p.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosPais.Modificar(p);
                    Actualizar();
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

        private void paisDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = paisDataGridView.CurrentRow.Index;
                    FrmEditarPais edit = new FrmEditarPais(((Pais)paisDataGridView.Rows[seleccion].DataBoundItem).Id);
                    edit.ShowDialog();
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    Actualizar();
                }

                paisDataGridView.DataSource = DatosPais.getPaisPorNombre(txtBuscar.Text);
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }
    }
}
