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
    public partial class FrmListaMedida : Form
    {
        public FrmListaMedida()
        {
            InitializeComponent();
            Actualizar();
        }

        private void Actualizar()
        {
            medidaBindingSource.DataSource = DatosMedida.getMedidas();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmListaMedida_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarZona m = new FrmEditarZona(0);
            m.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarZona edit = new FrmEditarZona(((Medida)medidaBindingSource.Current).Id);
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
                Medida m = (Medida)medidaBindingSource.Current;
                m.Activo = false;

                if (MessageBox.Show("¿Esta seguro de borrar a " + m.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosMedida.Modificar(m);
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void medidaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = medidaDataGridView.CurrentRow.Index;
                    FrmEditarZona edit = new FrmEditarZona(((Medida)medidaDataGridView.Rows[seleccion].DataBoundItem).Id);
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
