using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricaCEAPE.Clases
{
    class Zona
    {
        int idZona;
        string nombre;
        Localidad localidad;
        bool activo;

        public Zona()
        {

        }
        public Zona(int idZona, string nombre,Localidad localidad, bool activo)
        {
            this.idZona = idZona;
            this.nombre = nombre;
            this.localidad = localidad;
            this.activo = activo;
        }

        public int IdZona
        {
            get { return idZona; }
            set { idZona = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public string Zone
        {
            get { return localidad.Nombre; }
            set { localidad.Nombre = value; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}


