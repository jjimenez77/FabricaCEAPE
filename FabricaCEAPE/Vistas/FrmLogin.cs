using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;
using FabricaCEAPE.Vistas;

namespace FabricaCEAPE.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUsuario.Text; //jimenez//
            log.Contrasena = txtContrasena.Text; //hola


            bool exito = false;

            foreach (Login l in Program.logins)
            {
                Usuario u = DatosUsuario.getUsuarioPorLogin(l.Id);
                if (u.Activo)
                {
                    while ((log.Usuario == l.Usuario) && (log.Contrasena == l.Contrasena))
                    {
                        exito = true;
                        break;
                    }
                }
            }

            if (exito)
            {
                Login l = DatosLogin.getLoginPorNombre(log.Usuario, log.Contrasena);

                Hide();
                
                GlobalClass.GlobalVar = l.Id; //variable global de el id del usuario que se logueo

                FrmPrincipal p = new FrmPrincipal();
                p.ShowDialog();     

                Close();
            }
            else
            {
                error.Text = "Usuario o contraseña no valido";
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
