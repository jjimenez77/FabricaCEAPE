using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Proveedor
    {
        int id;
        string nombre;
        string nombreDeContacto;
        string cuit;
        string numeroTelefono;
        string numeroCelular;
        string correoElectronico;
        DateTime fechaInicio;
        string direccion;
        Localidad localidad;
        bool activo;

        public Proveedor()
        { }

        public Proveedor(int id, string nombre, string nombreDeContacto, string cuit, string numeroTelefono, string numeroCelular, string correoElectronico, DateTime fechaInicio, string direccion, Localidad localidad, bool activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.nombreDeContacto = nombreDeContacto;
            this.cuit = cuit;
            this.numeroTelefono = numeroTelefono;
            this.numeroCelular = numeroCelular;
            this.correoElectronico = correoElectronico;
            this.fechaInicio = fechaInicio;
            this.direccion = direccion;
            this.localidad = localidad;
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

        public string NombreDeContacto
        {
            get { return nombreDeContacto; }
            set { nombreDeContacto = value; }
        }

        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }

        public string NumeroCelular
        {
            get { return numeroCelular; }
            set { numeroCelular = value; }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
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

        public override string ToString()
        {
            return nombre;
        }
    }
}
