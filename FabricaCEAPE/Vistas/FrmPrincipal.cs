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
        int id = GlobalClass.GlobalVar;
       // Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);        
        public FrmPrincipal()
        {
            InitializeComponent();
            //Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);
            paisBindingSource.DataSource = DatosPais.getPaises();
            this.fechaNacimientoDateTimePicker.MaxDate = DateTime.Today.AddYears(-16);

            Actualizar();
            Usuario u = (Usuario)usuarioBindingSource.Current;

            int idUsuario = u.Login.Id;

            if (u.TipoDocumento == "DNI")
            {
                tipoDocumentoDropbox.Text = "DNI";
            }
            else if (u.TipoDocumento == "PASAPORTE")
            {
                tipoDocumentoDropbox.Text = "PASAPORTE";
            }
            else
            {
                tipoDocumentoDropbox.Text = "OTRO";
            }

            cbLocalidad.SelectedItem = ((Usuario)usuarioBindingSource.Current).Localidad;
            cbLocalidad.SelectedValue = ((Usuario)usuarioBindingSource.Current).Localidad.Id;

            cbProvincia.SelectedItem = ((Localidad)localidadBindingSource.Current).Provincia;
            cbProvincia.SelectedValue = ((Localidad)localidadBindingSource.Current).Provincia.Id;

            cbPais.SelectedItem = ((Provincia)provinciaBindingSource.Current).Pais;
            cbPais.SelectedValue = ((Provincia)provinciaBindingSource.Current).Pais.Id;

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
                btnMateriaPrimaReceta.Visible = true;
                btnProductoTerminado.Visible = true;
                btnProducto.Visible = true;
                btnTipoProducto.Visible = true;
                btnControlCalidad.Visible = true;
                toolStripSeparator3.Visible = true;
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
                    btnMateriaPrimaReceta.Visible = false;
                    btnProductoTerminado.Visible = false;
                    btnProducto.Visible = false;
                    btnTipoProducto.Visible = false;
                    btnControlCalidad.Visible = false;
                    toolStripSeparator3.Visible = false;
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
                    btnMateriaPrimaReceta.Visible = true;
                    btnProductoTerminado.Visible = true;
                    btnProducto.Visible = true;
                    btnTipoProducto.Visible = true;
                    btnControlCalidad.Visible = true;
                    toolStripSeparator3.Visible = false;
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
                    btnMateriaPrimaReceta.Visible = false;
                    btnProductoTerminado.Visible = false;
                    btnProducto.Visible = false;
                    btnTipoProducto.Visible = false;
                    btnControlCalidad.Visible = false;
                    toolStripSeparator3.Visible = false;
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

        public void Actualizar()
        {
            usuarioBindingSource.Add(DatosUsuario.getUsuario(id));
            Usuario u = (Usuario)usuarioBindingSource.Current;
            try
            {
                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais(u.Localidad.Provincia.Pais.Id);

                //if (cbProvincia.SelectedValue == null)
                //{
                //    localidadBindingSource.DataSource = null;
                //}
                //else
                //{
                    localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia(u.Localidad.Provincia.Id);
                //}
            }
            catch
            {
            }
        }        

        private void ActualizarCBProvincia()
        {
            try
            {
                provinciaBindingSource.DataSource = DatosProvincia.getProvinciasPorPais((int)cbPais.SelectedValue);

                if (cbProvincia.SelectedValue == null)
                {
                    localidadBindingSource.DataSource = null;
                }
                else
                {
                    ActualizarCbLocalidad();
                }
            }
            catch
            {
            }
        }

        private void ActualizarCbLocalidad()
        {
            try
            {
                localidadBindingSource.DataSource = DatosLocalidad.getLocalidadesPorProvincia((int)cbProvincia.SelectedValue);
            }
            catch
            {

            }
        }

        private void cbPais_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCBProvincia();
            if (cbLocalidad.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbLocalidad, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbLocalidad, "Seleccione la localidad");
            }
        }

        private void cbProvincia_DropDownClosed(object sender, EventArgs e)
        {
            ActualizarCbLocalidad();
            if (cbLocalidad.SelectedIndex >= 0)
            {
                errorProvider1.SetError(cbLocalidad, String.Empty);
            }
            else
            {
                errorProvider1.SetError(cbLocalidad, "Seleccione la localidad");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(nombreTextBox))
            {
                nombreTextBox.BackColor = Color.White;
                error = "Ingrese el nombre";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void apellidoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadena(apellidoTextBox))
            {
                apellidoTextBox.BackColor = Color.White;
                error = "Ingrese el apellido";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                apellidoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void numeroTelefonoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esTelefono(numeroTelefonoTextBox))
            {
                numeroTelefonoTextBox.BackColor = Color.White;
                error = "Ingrese el numero de telefono";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioNT(id, numeroTelefonoTextBox.Text))
            {
                errorProvider1.SetError(numeroTelefonoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeTelefono(numeroTelefonoTextBox.Text))
            {
                numeroTelefonoTextBox.BackColor = Color.White;
                error = "El numero de telefono ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroTelefonoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void numeroCelularTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esTelefono(numeroCelularTextBox))
            {
                numeroCelularTextBox.BackColor = Color.White;
                error = "Ingrese el numero de celular";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioNC(id, numeroCelularTextBox.Text))
            {
                errorProvider1.SetError(numeroCelularTextBox, String.Empty);
            }
            else if (DatosUsuario.existeCelular(numeroCelularTextBox.Text))
            {
                numeroCelularTextBox.BackColor = Color.White;
                error = "El numero de celular ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroCelularTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void correoElectronicoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esEmail(correoElectronicoTextBox))
            {
                correoElectronicoTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioCE(id, correoElectronicoTextBox.Text))
            {
                errorProvider1.SetError(correoElectronicoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeCorreoE(correoElectronicoTextBox.Text))
            {
                correoElectronicoTextBox.BackColor = Color.White;
                error = "El correo electronico ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void correoElectronicoAlternativoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esEmail(correoElectronicoAlternativoTextBox))
            {
                correoElectronicoAlternativoTextBox.BackColor = Color.White;
                error = "Ingrese el correo electronico alternativo";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioCEA(id, correoElectronicoAlternativoTextBox.Text))
            {
                errorProvider1.SetError(correoElectronicoAlternativoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeCorreoEA(correoElectronicoAlternativoTextBox.Text))
            {
                correoElectronicoAlternativoTextBox.BackColor = Color.White;
                error = "El correo electronico alternativo ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                correoElectronicoAlternativoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void numeroDocumentoTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(numeroDocumentoTextBox))
            {
                numeroDocumentoTextBox.BackColor = Color.White;
                error = "Ingrese el numero de documento";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else if (DatosUsuario.existeUsuarioND(id, numeroDocumentoTextBox.Text))
            {
                errorProvider1.SetError(numeroDocumentoTextBox, String.Empty);
            }
            else if (DatosUsuario.existeDocumento(numeroDocumentoTextBox.Text))
            {
                numeroDocumentoTextBox.BackColor = Color.White;
                error = "El numero de documento ingresado ya existe";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                numeroDocumentoTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumeroPunto(direccionTextBox) || direccionTextBox.Text.Trim() == String.Empty)
            {
                direccionTextBox.BackColor = Color.White;
                error = "Ingrese la direccion";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                direccionTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void localidadDropbox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cbLocalidad.SelectedIndex == -1)
            {
                error = "Seleccione la localidad";
                e.Cancel = false;
                errorProvider1.SetError((Control)sender, error);
            }
        }

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
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void numeroTelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numeroDocumentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void direccionTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
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

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(apellidoTextBox.Text))
            {
                error = "Ingrese el apellido";

                errorProvider1.SetError(apellidoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroTelefonoTextBox.Text))
            {
                error = "Ingrese el numero de telefono";

                errorProvider1.SetError(numeroTelefonoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroCelularTextBox.Text))
            {
                error = "Ingrese el numero de celular";

                errorProvider1.SetError(numeroCelularTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoTextBox.Text))
            {
                error = "Ingrese el correo electronico";

                errorProvider1.SetError(correoElectronicoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(correoElectronicoAlternativoTextBox.Text))
            {
                error = "Ingrese el correo electronico alternativo";

                errorProvider1.SetError(correoElectronicoAlternativoTextBox, error);
                resultados = false;
            }

            if (tipoDocumentoDropbox.SelectedIndex < 0)
            {
                error = "Seleccione el tipo de documento";

                errorProvider1.SetError(tipoDocumentoDropbox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(numeroDocumentoTextBox.Text))
            {
                error = "Ingrese el numero de documento";

                errorProvider1.SetError(numeroDocumentoTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(direccionTextBox.Text)) //verifica si es nulo o vacio, verifica si es nullo o espacio
            {
                error = "Ingrese la direccion";

                errorProvider1.SetError(direccionTextBox, error);
                resultados = false;
            }

            if (cbLocalidad.SelectedIndex < 0)
            {
                error = "Seleccione la localidad";

                errorProvider1.SetError(cbLocalidad, error);
                resultados = false;
            }
            return resultados;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;

                Usuario u = (Usuario)usuarioBindingSource.Current;

                u.Localidad = (Localidad)cbLocalidad.SelectedItem;

                if (tipoDocumentoDropbox.SelectedIndex == 0)
                {
                    u.TipoDocumento = "DNI";
                }
                else if (tipoDocumentoDropbox.SelectedIndex == 1)
                {
                    u.TipoDocumento = "PASAPORTE";
                }
                else
                {
                    u.TipoDocumento = "OTRO";
                }

                u.Activo = true;
                u.FechaNacimiento = fechaNacimientoDateTimePicker.Value;

                DatosUsuario.Modificar(u);
                Actualizar();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }
    }
}
