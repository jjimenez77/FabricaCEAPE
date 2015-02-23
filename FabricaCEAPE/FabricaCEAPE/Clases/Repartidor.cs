using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Repartidor : Persona
    {
        Zona zona;

        public Repartidor()
        {
        }

        public Repartidor(int id, string nombre, string apellido, bool sexo, DateTime fechaNacimiento, string numeroTelefono, string numeroCelular, string correoElectronico, string correoElectronicoAlternativo, string tipoDocumento, string numeroDocumento, DateTime fechaIngreso, string direccion, Localidad localidad, Zona zona, bool activo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.FechaNacimiento = fechaNacimiento;
            this.NumeroTelefono = numeroTelefono;
            this.NumeroCelular = numeroCelular;
            this.CorreoElectronico = correoElectronico;
            this.CorreoElectronicoAlternativo = correoElectronicoAlternativo;            
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.FechaIngreso = fechaIngreso;
            this.Direccion = direccion;
            this.Localidad = localidad;
            this.zona = zona;
            this.Activo = activo;
        }

        public Zona Zona
        {
            get { return zona; }
            set { zona = value; }
        }
    }
}
