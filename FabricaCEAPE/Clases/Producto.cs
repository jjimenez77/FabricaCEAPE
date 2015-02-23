using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Producto
    {
        private int idProducto;
        private string nombre;
        private bool activo;

        public Producto()
        {
        }

        public Producto(int idProducto, string nombre, bool activo)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.activo = activo;
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
