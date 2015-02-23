using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class ArticuloPedido
    {
        int id; 
        string nombre;      
        double cantidad;
        string descripcion;
        Medida medida;
        Pedido pedido;

        public ArticuloPedido()
        { }

        public ArticuloPedido(int id, string nombre, double cantidad, string descripcion, Medida medida, Pedido pedido)
        {
            this.id = id; 
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.medida = medida;
            this.pedido = pedido;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Medida Medida
        {
            get { return medida; }
            set { medida = value; }
        }
        public Pedido Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }
    }
}
