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
    public partial class FrmListaLocalidad : Form
    {
        public FrmListaLocalidad()
        {
            InitializeComponent();
            this.cbPais.ComboBox.DataSource = DatosPais.getPaises();
            this.cbPais.ComboBox.ValueMember = "id";
            this.cbPais.ComboBox.DisplayMember = "nombre";

            ActualizarCBProvincia();
            Actualizar();            
        }

        private void Actualizar()
        {
            try
            {
                if (cbPais.ComboBox.SelectedValue == null || cbProvincia.ComboBox.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.ComboBox.SelectedValue);
                }
            }
            catch
            {
            }
        }

        private void ActualizarCBProvincia()
        {
            this.cbProvincia.ComboBox.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.ComboBox.SelectedValue);
            this.cbProvincia.ComboBox.ValueMember = "id";
            this.cbProvincia.ComboBox.DisplayMember = "nombre";
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
            FrmEditarLocalidad l = new FrmEditarLocalidad(0);
            l.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmEditarLocalidad edit = new FrmEditarLocalidad(((Localidad)localidadBindingSource.Current).Id);
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
                Localidad l = (Localidad)localidadBindingSource.Current;
                l.Activo = false;

                if (MessageBox.Show("¿Esta seguro de borrar a " + l.Nombre + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosLocalidad.Modificar(l);
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

        private void cbPais_DropDownClosed_1(object sender, EventArgs e)
        {
            ActualizarCBProvincia();
            Actualizar();
        }

        private void cbProvincia_DropDownClosed_1(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void localidadDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = localidadDataGridView.CurrentRow.Index;
                    FrmEditarLocalidad edit = new FrmEditarLocalidad(((Localidad)localidadDataGridView.Rows[seleccion].DataBoundItem).Id);
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
