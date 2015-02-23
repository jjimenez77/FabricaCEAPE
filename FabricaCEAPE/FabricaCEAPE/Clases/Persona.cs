using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Persona
    {
        int id;
        string nombre;
        string apellido;
        bool sexo;
        DateTime fechaNacimiento;
        string numeroTelefono;
        string numeroCelular;        
        string correoElectronico;
        string correoElectronicoAlternativo;
        string tipoDocumento;
        string numeroDocumento;
        DateTime fechaIngreso;
        string direccion;
        Localidad localidad;
        bool activo;

        public Persona()
        {
        }

        public Persona(int id, string nombre, string apellido, bool sexo, DateTime fechaNacimiento, string numeroTelefono, string numeroCelular, string correoElectronico, string correoElectronicoAlternativo, string tipoDocumento, string numeroDocumento, DateTime fechaIngreso, string direccion, Localidad localidad, bool activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
            this.numeroTelefono = numeroTelefono;
            this.numeroCelular = numeroCelular;
            this.correoElectronico = correoElectronico;
            this.correoElectronicoAlternativo = correoElectronicoAlternativo;            
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.fechaIngreso = fechaIngreso;
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

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Sexos
        {
            get
            {
                if (sexo)
                {
                    return "Masculino";
                }
                else
                {
                    return "Femenino";
                }
            }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
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

        public string CorreoElectronicoAlternativo
        {
            get { return correoElectronicoAlternativo; }
            set { correoElectronicoAlternativo = value; }
        }

        public string TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
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
