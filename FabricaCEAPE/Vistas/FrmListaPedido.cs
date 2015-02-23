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
    public partial class FrmListaPedido : Form
    {
        public FrmListaPedido()
        {
            InitializeComponent();

            cbSelector.Items.Add("Concepto");
            cbSelector.Items.Add("Descripcion");
            cbSelector.Items.Add("Departamento");

            cbSelector.SelectedIndex = 0;
            this.txtBuscar.Focus();

            this.btnRecibidos.Checked = true;
            this.btnEnviados.Checked = false;

            if(this.btnRecibidos.Checked == true)
            {
                Actualizar();
            }
            else
            {
                ActualizarEnviados();
            }
        }

        private void Actualizar()
        {
            try
            {
                Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);
                Departamento d = DatosDepartamento.getDepartamento(u.Departamento.Id);

                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {

                    pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoRecibidosUsuarioId(d.Id);
                }
            }
            catch
            {
            }            
        }

        private void ActualizarEnviados()
        {
            try
            {
                Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);

                if (txtBuscar.Text == "Buscar" || txtBuscar.Text == "")
                {
                    pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoEnviadosUsuarioId(u.Id);
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
            DateTime fechaEmitido = DateTime.Now;
            Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);

            Pedido pedido = new Pedido();
            pedido.Concepto = "";
            pedido.Descripcion = "";
            pedido.FechaEmitido = fechaEmitido;
            pedido.Usuario = (Usuario)DatosUsuario.getUsuario(u.Id);
            pedido.Departamento = (Departamento)DatosDepartamento.getDepartamento(1);
            pedido.Activo = true;
            DatosPedido.Crear(pedido);

            FrmEditarPedido p = new FrmEditarPedido((int)DatosPedido.getUltimoPedido());
            p.ShowDialog();

            if (this.btnRecibidos.Checked == true)
            {
                Actualizar();
            }
            else
            {
                ActualizarEnviados();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnRecibidos_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            this.btnRecibidos.Checked = true;
            this.btnEnviados.Checked = false;

            if (this.btnRecibidos.Checked == true)
            {
                Actualizar();
            }
            else
            {
                ActualizarEnviados();
            }

            if (cbSelector.SelectedIndex == 0)
            {
                if (this.btnEnviados.Checked == true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por concepto";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por concepto";
                }
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                if (this.btnEnviados.Checked == true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por descripcion";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por descripcion";
                }
            }
            else
            {
                txtBuscar.ToolTipText = "Buscar pedido recibido por departamento de origen";
            }
        }

        private void btnEnviados_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            this.btnRecibidos.Checked = false;
            this.btnEnviados.Checked = true;

            if (this.btnRecibidos.Checked == true)
            {
                Actualizar();
            }
            else
            {
                ActualizarEnviados();
            }

            if (cbSelector.SelectedIndex == 0)
            {
                if (this.btnEnviados.Checked == true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por concepto";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por concepto";
                }
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                if (this.btnEnviados.Checked == true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por descripcion";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por descripcion";
                }
            }
            else
            {
                if (this.btnEnviados.Checked == true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por departamento de destino";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por departamento de origen";
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVerPedido ver = new FrmVerPedido(((Pedido)pedidoBindingSource.Current).Id);
                ver.ShowDialog();

                if (this.btnRecibidos.Checked == true)
                {
                    Actualizar();
                }
                else
                {
                    ActualizarEnviados();
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void pedidoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    int seleccion = pedidoDataGridView.CurrentRow.Index;
                    FrmVerPedido ver = new FrmVerPedido(((Pedido)pedidoDataGridView.Rows[seleccion].DataBoundItem).Id);
                    ver.ShowDialog();

                    if (this.btnRecibidos.Checked == true)
                    {
                        Actualizar();
                    }
                    else
                    {
                        ActualizarEnviados();
                    }
                }
            }
            catch
            {
                MessageBox.Show("No seleccionó nada");
            }
        }

        private void pedidoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (pedidoDataGridView.Rows[e.RowIndex].Cells[1].Value != null && !string.IsNullOrWhiteSpace(pedidoDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()))
            //{
                if (pedidoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() == "No leido")
                    pedidoDataGridView.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Yellow };
            //}
            //else
            //{
            //    pedidoDataGridView.Rows[e.RowIndex].Cells[3].Style = pedidoDataGridView.DefaultCellStyle;
            //}
        }

        private void cbSelector_DropDownClosed(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

            if (this.btnRecibidos.Checked == true)
            {
                Actualizar();
            }
            else
            {
                ActualizarEnviados();
            }

            if (cbSelector.SelectedIndex == 0)
            {
                if(this.btnEnviados.Checked ==  true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por concepto";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por concepto";
                }
            }
            else if (cbSelector.SelectedIndex == 1)
            {
                if (this.btnEnviados.Checked == true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por descripcion";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por descripcion";
                }
            }
            else
            {
                if (this.btnEnviados.Checked == true)
                {
                    txtBuscar.ToolTipText = "Buscar pedido enviado por departamento de destino";
                }
                else
                {
                    txtBuscar.ToolTipText = "Buscar pedido recibido por departamento de origen";
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);
            Departamento d = DatosDepartamento.getDepartamento(u.Departamento.Id);
            try
            {
                if (txtBuscar.Text == "")
                {
                    if (this.btnRecibidos.Checked == true)
                    {
                        Actualizar();
                    }
                    else
                    {
                        ActualizarEnviados();
                    }
                }

                if (cbSelector.SelectedIndex == 0)
                {                                
                    if (this.btnEnviados.Checked == true)
                    {
                        pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoEnviadosUsuarioIdConcepto(u.Id, txtBuscar.Text);
                    }
                    else
                    {
                        pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoRecibidosUsuarioIdConcepto(d.Id, txtBuscar.Text);    
                    }
                }
                else if (cbSelector.SelectedIndex == 1)
                {
                    if (this.btnEnviados.Checked == true)
                    {
                        pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoEnviadosUsuarioIdDescripcion(u.Id, txtBuscar.Text);
                    }
                    else
                    {
                        pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoRecibidosUsuarioIdDescripcion(d.Id, txtBuscar.Text);
                    }
                }
                else if (cbSelector.SelectedIndex == 2)
                {
                    if (this.btnEnviados.Checked == true)
                    {
                        pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoEnviadosUsuarioIdDepartamentoDestino(u.Id, txtBuscar.Text);
                    }
                    else
                    {
                        pedidoBindingSource.DataSource = DatosPedido.getPedidosPorEstadoRecibidosUsuarioIdDepartamentoOrigen(d.Id, txtBuscar.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se encontro nada en su busqueda");

                if (this.btnRecibidos.Checked == true)
                {
                    Actualizar();
                }
                else
                {
                    ActualizarEnviados();
                }
            }
        }
    }
}
