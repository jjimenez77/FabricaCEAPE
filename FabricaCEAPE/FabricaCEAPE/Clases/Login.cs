using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Login
    {
        int id;
        string usuario;
        string contrasena;
        bool activo;

        public Login()
        {
        }

        public Login(int id, string usuario, string contrasena, bool activo)
        {
            this.id = id;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.activo = activo;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public override string ToString()
        {
            return usuario;
        }
    }
}
