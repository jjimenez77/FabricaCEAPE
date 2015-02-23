using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Usuario : Persona
    {
        bool tipoUsuario; //Administrador = true o moderado // o por departamento = false
        Departamento departamento;
        Login login;
        //bool activo;

        public Usuario()
        { }

        public Usuario(int id, string nombre, string apellido, bool tipoUsuario, bool sexo, DateTime fechaNacimiento, string numeroTelefono, string numeroCelular, string correoElectronico, string correoElectronicoAlternativo, string tipoDocumento, string numeroDocumento, DateTime fechaIngreso, string direccion, Localidad localidad, Departamento departamento, Login login, bool activo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.tipoUsuario = tipoUsuario;
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
            this.Departamento = departamento;
            this.Login = login;
            this.Activo = activo;
        }
        
        public bool TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public string TipoUsuarios
        {
            get
            {
                if (tipoUsuario)
                {
                    return "Administador";
                }
                else
                {
                    return "Moderado";
                }
            }
        }

        public Departamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public Login Login
        {
            get { return login; }
            set { login = value; }
        }

        //public bool Activo
        //{
        //    get { return activo; }
        //    set { activo = value; }
        //}
    }
}
