using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Clases
{
    class Cliente
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
        Zona zona;
        bool activo;

        public Cliente()
        { }

        public Cliente(int id, string nombre, string nombreDeContacto, string cuit, string numeroTelefono, string numeroCelular, string correoElectronico, DateTime fechaInicio, string direccion, Zona zona, bool activo)
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
            this.zona = zona;
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

        public Zona Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public string Localidadd
        {
            get { return zona.Localidad.Nombre; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
