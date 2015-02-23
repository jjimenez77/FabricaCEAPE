using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Localidad
    {
        int id;
        string nombre;
        Provincia provincia;
        bool activo;

        public Localidad()
        {
        }

        //public Localidad(int id, string nombre, bool activo)
        //{
        //    this.id = id;
        //    this.nombre = nombre;
        //    this.activo = activo;
        //}

        public Localidad(int id, string nombre, Provincia provincia, bool activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.provincia = provincia;
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

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
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
