using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class SeleccionProducto
    {
        int idSeleccion;
        string nombre;
        string observacion;

        public SeleccionProducto()
        {

        }
        public SeleccionProducto(int idSeleccion, string nombre, string observacion)
        {
            this.idSeleccion = idSeleccion;
            this.nombre = nombre;
            this.observacion = observacion;

        }

        public int IdSeleccionProducto
        {
            get { return idSeleccion; }
            set { idSeleccion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
