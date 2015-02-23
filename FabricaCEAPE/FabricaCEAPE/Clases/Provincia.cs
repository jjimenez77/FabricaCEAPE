using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Provincia
    {
        int id;
        string nombre;
        Pais pais;
        bool activo;

        public Provincia()
        {
        }

        public Provincia(int id, string nombre, Pais pais, bool activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.pais = pais;
            this.activo = activo;
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

        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
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
