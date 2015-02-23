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
    public partial class FrmVerPedido : Form
    {
        int id;
        public FrmVerPedido(int id)
        {
            InitializeComponent();
            this.id = id;
            Actualizar();

            pedidoBindingSource.Add(DatosPedido.getPedido(id));
            Pedido p = (Pedido)pedidoBindingSource.Current;

            this.txtDeptoDestino.Text = p.Departamento.Nombre;
            this.txtDeptoOrigen.Text = p.Usuario.Departamento.Nombre;
            this.txtConcepto.Text = p.Concepto;
            this.txtDescripcion.Text = p.Descripcion;
            if (p.Concepto != "")
            {
                this.Text = "Pedido de " + p.Concepto;
            }    
        }

        private void Actualizar()
        {
            articuloPedidoBindingSource.DataSource = DatosArticuloPedido.getArticulosPedidosPorPedido(id);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Usuario u = DatosUsuario.getUsuarioPorLogin(GlobalClass.GlobalVar);

            Pedido p = (Pedido)pedidoBindingSource.Current;

            if (p.Departamento.Nombre == u.Departamento.Nombre && p.Activo)
            {
                p.Activo = false;
            }

            DatosPedido.Modificar(p);
            Close();
        }
    }
}
