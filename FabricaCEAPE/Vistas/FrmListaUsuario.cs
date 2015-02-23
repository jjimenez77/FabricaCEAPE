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
    public partial class FrmListaUsuario : Form
    {
        public FrmListaUsuario()
        {
            InitializeComponent();
            Actualizar();
            cbSelector.Items.Add("Nombre");
            cbSelector.Items.Add("Apellido");
            cbSelector.Items.Add("Departamento");
            cbSelector.Items.Add("Numero de documento");

            cbSelector.SelectedIndex = 0;
            this.txtBuscar.Focus();
        }

        private void Actualizar()
        {
            try
            {
                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {
                    usuarioBindingSource.DataSource = DatosUsuario.getUsuarios();
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
            //usuarioDataGridView.Columns[5].DefaultCellStyle.Format = "(###) ###-####";
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuario u = (Usuario)usuarioBindingSource.Current;
                u.Activo = false;

                if (MessageBox.Show("¿Esta seguro de dar de baja a " + u.Nombre +"?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosUsuario.Modificar(u);
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
                FrmEditarUsuario edit = new FrmEditarUsuario(((Usuario)usuarioBindingSource.Current).Id);
                edit.ShowDialog();
                Actualizar();
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario p = new FrmEditarUsuario(0);
            p.ShowDialog();
            Actualizar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void usuarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = usuarioDataGridView.CurrentRow.Index;
                    FrmEditarUsuario edit = new FrmEditarUsuario(((Usuario)usuarioDataGridView.Rows[seleccion].DataBoundItem).Id);
                    edit.ShowDialog();
                    Actualizar();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void usuarioDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the column is the Artist column, check the 
            // value. 
            //this.usuarioDataGridView.Columns[5].DefaultCellStyle.ForeColor            
            //this.usuarioDataGridView.Columns[5].DefaultCellStyle.Format = "(###) ###-####";


            //if (this.usuarioDataGridView.Columns[5].Name == "Numero de telefono")
            //{
            //    if (e.Value != null)
            //    {
            //        // Check for the string "pink" in the cell.
            //        string stringValue = (string)e.Value;
            //        stringValue = stringValue.ToLower();
            //        //if ((stringValue.IndexOf("pink") > -1))
            //        //{
            //            e.CellStyle.BackColor = Color.Pink;
            //        //}

            //    }
            //}
           
          //  usuarioDataGridView.Columns[5].DefaultCellStyle.Format = "(###) ###-####";
           // usuarioDataGridView.Columns[6].DefaultCellStyle.Format = "(###)#######";

            //this.usuarioDataGridView.Columns[5].DefaultCellStyle.Format = "n2";

       

            //else if (this.usuarioDataGridView.Columns[e.ColumnIndex].Name == "Release Date")
            //{
            //    //ShortFormDateFormat(e);
            //}
        }

        private void cbSelector_DropDownClosed(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Actualizar();

            if (cbSelector.SelectedIndex == 0)
            {
                txtBuscar.ToolTipText = "Buscar usuario por nombre";
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                txtBuscar.ToolTipText = "Buscar usuario por apellido";
            }
            else if (cbSelector.SelectedIndex == 2)
            {
                txtBuscar.ToolTipText = "Buscar usuario por departamento";
            }
            else 
            {
                txtBuscar.ToolTipText = "Buscar por numero de documento";
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

                if (cbSelector.SelectedIndex == 0)
                {
                    usuarioBindingSource.DataSource = DatosUsuario.getUsuariosPorNombre(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    usuarioBindingSource.DataSource = DatosUsuario.getUsuariosPorApellido(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 2)
                {
                    usuarioBindingSource.DataSource = DatosUsuario.getUsuariosPorDepartamento(txtBuscar.Text);
                }
                else if (cbSelector.SelectedIndex == 3)
                {
                    usuarioBindingSource.DataSource = DatosUsuario.getUsuariosPorNumeroDeDocumento(txtBuscar.Text);
                }
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");
                Actualizar();
            }
        }
    }
}
