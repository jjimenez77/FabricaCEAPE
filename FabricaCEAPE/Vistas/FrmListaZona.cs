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
    public partial class FrmListaZona : Form
    {
        public FrmListaZona()
        {
            InitializeComponent();
            Actualizar();
        }

        private void Actualizar()
        {
            zonaBindingSource.DataSource = DatosZona.getZonas();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void zonaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = zonaDataGridView.CurrentRow.Index;
                    FrmEditarZonaa edit = new FrmEditarZonaa(((Zona)zonaDataGridView.Rows[seleccion].DataBoundItem).IdZona);
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
            FrmEditarZonaa z = new FrmEditarZonaa(0);
            z.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarZonaa edit = new FrmEditarZonaa(((Zona)zonaBindingSource.Current).IdZona);
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
                Zona z = (Zona)zonaBindingSource.Current;
                if (!DatosZona.enUso(z.IdZona))
                {
                    z.Activo = false;

                    if (MessageBox.Show("¿Esta seguro de eliminar a " + z.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DatosZona.Modificar(z);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
