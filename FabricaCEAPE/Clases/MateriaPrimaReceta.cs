using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class MateriaPrimaReceta
    {
        int id;
        string nombre;

        public MateriaPrimaReceta()
        { }

        public MateriaPrimaReceta(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
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

        public override string ToString()
        {
            return nombre;
        }
    }
}
