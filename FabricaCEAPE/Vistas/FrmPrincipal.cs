using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;
using System.Runtime.InteropServices;

namespace FabricaCEAPE.Vistas
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
            Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);

            label1.Text = u.Nombre + " " + u.Apellido;

            if (u.TipoUsuario)
                label2.Text = "Administrador";
            else
                label2.Text = "Moderado";

            if (u.Sexo)
                label3.Text = "Masculino";
            else
                label3.Text = "Femenino";

            label4.Text = u.FechaNacimiento.ToShortDateString();

            label5.Text = u.NumeroTelefono;

            label6.Text = String.Format("{0:(###) ###-####}", Convert.ToInt64(u.NumeroCelular));

            label7.Text = u.CorreoElectronico;

            label8.Text = u.CorreoElectronicoAlternativo;

            label9.Text = u.TipoDocumento + " " + u.NumeroDocumento;

            label11.Text = u.Direccion + " - " + u.Localidad.Nombre;

            label12.Text = u.Departamento.Nombre;

            label13.Text = u.Login.Usuario;

            //Tipo de usuario botones a mostrar
            if (u.TipoUsuario)
            {
                //MenuToolStrip
                menuStrip.Visible = true;
                ABMToolStripMenuItem.Visible = true;
                paisToolStripMenuItem.Visible = true;
                provinciasToolStripMenuItem.Visible = true;
                localidadesToolStripMenuItem.Visible = true;
                medidasToolStripMenuItem.Visible = true;
                zonaToolStripMenuItem.Visible = true;
                tipoDeEnvasadoToolStripMenuItem.Visible = true;
                //
                //admin
                btnUsuario.Visible = true;
                btnDepartamento.Visible = true;
                toolStripSeparator1.Visible = true;
                //
                //materia prima
                btnMateriaPrima.Visible = true;
                btnTipoMP.Visible = true;
                btnProveedores.Visible = true;
                btnMarca.Visible = true;
                toolStripSeparator2.Visible = true;
                //
                //produccion
                btnRecetas.Visible = true;
                btnProducto.Visible = true;
                btnTipoProducto.Visible = true;
                toolStripSeparator4.Visible = true;
                //
                //producto terminado
                btnCliente.Visible = true;
                btnRepartidor.Visible = true;
                btnSalidaStock.Visible = true;
                btnEntradaStock.Visible = true;
                btnDespachoStock.Visible = true;

                this.Text = "Administrador :: Sistema CEAPE";
            }
            else
            {
                this.Text = u.Login.Usuario + " - " + u.Departamento.Nombre + " :: Sistema CEAPE";

                //Botones de materia prima
                if (u.Departamento.Id == 1)
                {
                    //MenuToolStrip
                    menuStrip.Visible = true;
                    ABMToolStripMenuItem.Visible = true;
                    paisToolStripMenuItem.Visible = true;
                    provinciasToolStripMenuItem.Visible = true;
                    localidadesToolStripMenuItem.Visible = true;
                    medidasToolStripMenuItem.Visible = true;
                    zonaToolStripMenuItem.Visible = false;
                    tipoDeEnvasadoToolStripMenuItem.Visible = false;
                    //
                    //admin
                    btnUsuario.Visible = false;
                    btnDepartamento.Visible = false;
                    toolStripSeparator1.Visible = false;
                    //
                    //materia prima
                    btnMateriaPrima.Visible = true;
                    btnTipoMP.Visible = true;
                    btnProveedor.Visible = true;
                    btnMarca.Visible = true;
                    toolStripSeparator2.Visible = false;
                    //
                    //produccion
                    btnRecetas.Visible = false;
                    btnProducto.Visible = false;
                    btnTipoProducto.Visible = false;
                    toolStripSeparator4.Visible = false;
                    //
                    //producto terminado
                    btnCliente.Visible = false;
                    btnRepartidor.Visible = false;
                    btnSalidaStock.Visible = false;
                    btnEntradaStock.Visible = false;
                    btnDespachoStock.Visible = false;
                }
                //Botones de produccion
                else if (u.Departamento.Id == 2)
                {
                    //MenuToolStrip
                    menuStrip.Visible = true;
                    ABMToolStripMenuItem.Visible = true;
                    paisToolStripMenuItem.Visible = false;
                    provinciasToolStripMenuItem.Visible = false;
                    localidadesToolStripMenuItem.Visible = false;
                    medidasToolStripMenuItem.Visible = true;
                    zonaToolStripMenuItem.Visible = false;
                    tipoDeEnvasadoToolStripMenuItem.Visible = true;
                    //
                    //admin
                    btnUsuario.Visible = false;
                    btnDepartamento.Visible = false;
                    toolStripSeparator1.Visible = false;
                    //
                    //materia prima
                    btnMateriaPrima.Visible = false;
                    btnTipoMP.Visible = false;
                    btnProveedor.Visible = false;
                    btnMarca.Visible = false;
                    toolStripSeparator2.Visible = false;
                    //
                    //produccion
                    btnRecetas.Visible = true;
                    btnProducto.Visible = true;
                    btnTipoProducto.Visible = true;
                    toolStripSeparator4.Visible = true;
                    //
                    //producto terminado
                    btnCliente.Visible = false;
                    btnRepartidor.Visible = false;
                    btnSalidaStock.Visible = false;
                    btnEntradaStock.Visible = false;
                    btnDespachoStock.Visible = false;
                }
                //Botones de producto terminado
                else if (u.Departamento.Id == 3)
                {
                    //MenuToolStrip
                    menuStrip.Visible = true;
                    ABMToolStripMenuItem.Visible = true;
                    paisToolStripMenuItem.Visible = true;
                    provinciasToolStripMenuItem.Visible = true;
                    localidadesToolStripMenuItem.Visible = true;
                    medidasToolStripMenuItem.Visible = false;
                    zonaToolStripMenuItem.Visible = true;
                    tipoDeEnvasadoToolStripMenuItem.Visible = false;
                    //
                    //admin
                    btnUsuario.Visible = false;
                    btnDepartamento.Visible = false;
                    toolStripSeparator1.Visible = false;
                    //
                    //materia prima
                    btnMateriaPrima.Visible = false;
                    btnTipoMP.Visible = false;
                    btnProveedor.Visible = false;
                    btnMarca.Visible = false;
                    toolStripSeparator2.Visible = false;
                    //
                    //produccion
                    btnRecetas.Visible = false;
                    btnProducto.Visible = false;
                    btnTipoProducto.Visible = false;
                    toolStripSeparator4.Visible = false;
                    //
                    //producto terminado
                    btnCliente.Visible = true;
                    btnRepartidor.Visible = true;
                    btnSalidaStock.Visible = true;
                    btnEntradaStock.Visible = true;
                    btnDespachoStock.Visible = true;
                }
            }

            btnTipoMP.Text = "Tipos de" + Environment.NewLine + "materia prima";
            btnTipoProducto.Text = "Tipos de" + Environment.NewLine + "producto";
            btnMateriaPrimaReceta.Text = "Materia prima" + Environment.NewLine + "de recetas";

            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.Snow;
                    break;
                }
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           // MDIClientSupport.SetBevel(this, false);
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaPais))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaPais();
            form1.MdiParent = this;
            form1.Show();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaProvincia))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaProvincia();
            form1.MdiParent = this;
            form1.Show();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaLocalidad))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaLocalidad();
            form1.MdiParent = this;
            form1.Show();
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaProveedor))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaProveedor();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaUsuario))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaUsuario();
            form1.MdiParent = this;
            form1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaMateriaPrima))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaMateriaPrima();
            form1.MdiParent = this;
            form1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaMarca))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaMarca();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaDepartamento))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaDepartamento();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaPedido))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaPedido();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaReceta))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaReceta();
            form1.MdiParent = this;
            form1.Show();
        }

        private void FrmPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                tableLayoutPanel1.SendToBack();
            }
            else
            {
                tableLayoutPanel1.BringToFront();
            }
        }

        private void btnSalirS_Click_1(object sender, EventArgs e)
        {
            Hide();
            FrmLogin p = new FrmLogin();
            p.ShowDialog();
            Close();
        }

        private void btnTipoMP_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaTipoMateriaPrima))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaTipoMateriaPrima();
            form1.MdiParent = this;
            form1.Show();
        }

        private void zonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaZona))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaZona();
            form1.MdiParent = this;
            form1.Show();
        }

        public static class MDIClientSupport
        {
            [DllImport("user32.dll")]
            private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32.dll")]
            private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

            [DllImport("user32.dll", ExactSpelling = true)]
            private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

            private const int GWL_EXSTYLE = -20;
            private const int WS_EX_CLIENTEDGE = 0x200;
            private const uint SWP_NOSIZE = 0x0001;
            private const uint SWP_NOMOVE = 0x0002;
            private const uint SWP_NOZORDER = 0x0004;
            private const uint SWP_NOREDRAW = 0x0008;
            private const uint SWP_NOACTIVATE = 0x0010;
            private const uint SWP_FRAMECHANGED = 0x0020;
            private const uint SWP_SHOWWINDOW = 0x0040;
            private const uint SWP_HIDEWINDOW = 0x0080;
            private const uint SWP_NOCOPYBITS = 0x0100;
            private const uint SWP_NOOWNERZORDER = 0x0200;
            private const uint SWP_NOSENDCHANGING = 0x0400;

            //private static bool SetBevel(this Form form, bool show)
            //{
            //    foreach (Control c in form.Controls)
            //    {
            //        MdiClient client = c as MdiClient;
            //        if (client != null)
            //        {
            //            int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);

            //            if (show)
            //            {
            //                windowLong |= WS_EX_CLIENTEDGE;
            //            }
            //            else
            //            {
            //                windowLong &= ~WS_EX_CLIENTEDGE;
            //            }

            //            SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);

            //            // Update the non-client area.
            //            SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0,
            //                SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
            //                SWP_NOOWNERZORDER | SWP_FRAMECHANGED);

            //            return true;
            //        }
            //    }
            //    return false;
            //}
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaCliente))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaCliente();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnRepartidor_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaRepartidor))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaRepartidor();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaTipoProducto))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaTipoProducto();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnSalidaStock_Click(object sender, EventArgs e)
        {
            FrmSalidaStock ep = new FrmSalidaStock();
            ep.ShowDialog();
        }

        private void btnEntradaStock_Click(object sender, EventArgs e)
        {
            FrmEntradaProducto ep = new FrmEntradaProducto();
            ep.ShowDialog();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaMedida))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaMedida();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnDespachoStock_Click(object sender, EventArgs e)
        {
            FrmEntregaProducto ep = new FrmEntregaProducto(0);
            ep.ShowDialog();            

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaProductoTerminado))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaProductoTerminado();
            form1.MdiParent = this;
            form1.Show();
        }

        private void tipoDeEnvasadoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaTipoEnvasado))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaTipoEnvasado();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaProducto))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaProducto();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnControlCalidad_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaControlPCC))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaControlPCC();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnMateriaPrimaReceta_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmListaMateriaPrimaReceta))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new FrmListaMateriaPrimaReceta();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
