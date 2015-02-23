using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Medida
    {
        int id;
        string nombre;
        string abreviacion;
        bool activo;

        public Medida()
        { }

        public Medida(int id, string nombre, string abreviacion, bool activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.abreviacion = abreviacion;
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

        public string Abreviacion
        {
            get { return abreviacion; }
            set { abreviacion = value; }
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
