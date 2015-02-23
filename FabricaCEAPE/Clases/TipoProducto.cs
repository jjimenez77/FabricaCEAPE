using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class TipoProducto
    {
        int idTipoProducto;
        string nombre;
        bool activo;


        public TipoProducto()
        {
        }
        public TipoProducto(int idTipoProducto, string nombre, bool activo)
        {
            this.idTipoProducto = idTipoProducto;
            this.nombre = nombre;
            this.activo = activo;
        }

        public int IdTipoProducto
        {
            get { return idTipoProducto; }
            set { idTipoProducto = value; }
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
