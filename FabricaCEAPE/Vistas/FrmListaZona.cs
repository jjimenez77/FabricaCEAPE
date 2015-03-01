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
            this.cbPais.ComboBox.DataSource = DatosPais.getPaises();
            this.cbPais.ComboBox.ValueMember = "id";
            this.cbPais.ComboBox.DisplayMember = "nombre";
            Actualizar();
        }

        private void Actualizar()
        {

            try
            {
                if (cbPais.ComboBox.SelectedValue == null || cbProvincia.ComboBox.SelectedValue == null || cbLocalidad.ComboBox.SelectedValue == null)
                {
                    zonaBindingSource.DataSource = null;
                }
                else
                {
                    zonaBindingSource.DataSource = DatosZona.getZonasPorLocalidad((int)cbLocalidad.ComboBox.SelectedValue);
                }
            }
            catch
            {
            }
        }

        private void ActualizarCBProvincia()
        {
            if (cbPais.ComboBox.SelectedValue != null)
            {
                this.cbProvincia.ComboBox.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.ComboBox.SelectedValue);
                this.cbProvincia.ComboBox.ValueMember = "id";
                this.cbProvincia.ComboBox.DisplayMember = "nombre";
            }
        }

        private void ActualizarCBLocalidad()
        {
            if (cbProvincia.ComboBox.SelectedValue != null)
            {
                this.cbLocalidad.ComboBox.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.ComboBox.SelectedValue);
                this.cbLocalidad.ComboBox.ValueMember = "id";
                this.cbLocalidad.ComboBox.DisplayMember = "nombre";
            }
            else
            {
                this.cbLocalidad.ComboBox.DataSource = null;
            }
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

        private void cbPais_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCBProvincia();
            ActualizarCBLocalidad();            
            Actualizar();
        }

        private void cbProvincia_DropDownClosed(object sender, EventArgs e)
        {            
            ActualizarCBLocalidad();
            Actualizar();
        }

        private void cbLocalidad_DropDownClosed(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
