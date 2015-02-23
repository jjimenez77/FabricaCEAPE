using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class DetalleEntrega
    {
        //private EntregaProductoTerminado entrega;
        private int idEntrega;
        Producto producto;
        private int cantidad;

        List<EntregaProductoTerminado> itemProductoTerminado;

        public DetalleEntrega()
        {
            itemProductoTerminado = new List<EntregaProductoTerminado>();
        }
        /*public DetalleEntrega(EntregaProductoTerminado entrega)
        {
            this.Entrega = entrega;
        }*/

        public DetalleEntrega(Producto producto, int cantidad)
        {
            //this.idEntrega = idEntrega;
            this.Product = producto;
            this.cantidad = cantidad;
        }

        public DetalleEntrega(int idEntrega, Producto producto, int cantidad, List<EntregaProductoTerminado> itemProductoTerminado)
        {
            this.idEntrega = idEntrega;
            this.Product = producto;
            this.cantidad = cantidad;
            this.ItemProductoTerminado = itemProductoTerminado;
        }

        public int IdEntrega
        {
            get { return idEntrega; }
            set { idEntrega = value; }
        }


        /*public EntregaProductoTerminado Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }*/

        public List<EntregaProductoTerminado> ItemProductoTerminado
        {
            get { return itemProductoTerminado; }
            set { itemProductoTerminado = value; }
        }


        public Producto Product
        {
            get { return producto; }
            set { producto = value; }
        }


        public string NombreProducto
        {
            get { return producto.Nombre; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
