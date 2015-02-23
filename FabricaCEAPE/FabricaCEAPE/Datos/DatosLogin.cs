using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosLogin:Conexion
    {
        static int adm;
        public static List<Login> getLogins()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT id, nombreUsuario, dbo.FU_DESENCRIPTA_PASS(contrasena), activo from Logins where activo = 1 order by nombreUsuario");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<Login> logins = new List<Login>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                logins.Add(new Login(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3)));
            }
            //Cierro la conexion
            cnn.Close();
            return logins;
        }

        public static Login getLogin(int idLogin)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT id, nombreUsuario, dbo.FU_DESENCRIPTA_PASS(contrasena), activo from Logins where id = @id and activo = 1 ");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", idLogin));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Login login = new Login();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                login.Id = obdr.GetInt32(0);
                login.Usuario = obdr.GetString(1);
                login.Contrasena = obdr.GetString(2);
                login.Activo = obdr.GetBoolean(3);
            }
            cnn.Close();
            return login;
        }

        public static Login getLoginPorNombre(String usuario, String contrasena)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT id, nombreUsuario, dbo.FU_DESENCRIPTA_PASS(contrasena), activo from Logins where nombreUsuario = @nombreUsuario AND dbo.FU_DESENCRIPTA_PASS(contrasena) = @contrasena");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombreUsuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@contrasena", contrasena));

            //asigno la conexion al comando
            cmd.Connection = cnn;

            Login login = new Login();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                login.Id = obdr.GetInt32(0);
                login.Usuario = obdr.GetString(1);
                login.Contrasena = obdr.GetString(2);
                login.Activo = obdr.GetBoolean(3);
            }
            cnn.Close();
            return login;
        }

        public static Login getUltimooLogin()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT id, nombreUsuario, dbo.FU_DESENCRIPTA_PASS(contrasena), activo from Logins where id=IDENT_CURRENT('Logins')");
            //Cargo el valor del parametro
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Login login = new Login();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                login.Id = obdr.GetInt32(0);
                login.Usuario = obdr.GetString(1);
                login.Contrasena = obdr.GetString(2);
                login.Activo = obdr.GetBoolean(3);
            }
            cnn.Close();
            return login;
        }

        public static Login getUltimoLogin()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT id, nombreUsuario, dbo.FU_DESENCRIPTA_PASS(contrasena), activo from Logins where id=IDENT_CURRENT('Logins')");
            //Cargo el valor del parametro
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Login login = new Login();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                login.Id = obdr.GetInt32(0);
                login.Usuario = obdr.GetString(1);
                login.Contrasena = obdr.GetString(2);
                login.Activo = obdr.GetBoolean(3);
            }
            cnn.Close();
            return login;
        }

        public static void Crear(Login log)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Logins (nombreUsuario, contrasena, activo) values (@nombreUsuario, dbo.FU_ENCRIPTA_PASS(@contrasena), @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombreUsuario", log.Usuario));
            cmd.Parameters.Add(new SqlParameter("@contrasena", log.Contrasena));
            cmd.Parameters.Add(new SqlParameter("@activo", log.Activo));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            //SqlCommand cmd_idLogin = new SqlCommand("Select idLogin from Login where idLogin=IDENT_CURRENT('Logins')");

            //cmd_idLogin.Connection = cnn;

            //int idLogin = Int32.Parse(cmd_idLogin.ExecuteScalar().ToString());
            cnn.Close();

            //return idLogin;
        }

        public static void Modificar(Login log)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("UPDATE Logins SET nombreUsuario = @nombreUsuario, contrasena = dbo.FU_ENCRIPTA_PASS(@contrasena), activo = @activo WHERE id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", log.Id));
            cmd.Parameters.Add(new SqlParameter("@nombreUsuario", log.Usuario));
            cmd.Parameters.Add(new SqlParameter("@contrasena", log.Contrasena));
            cmd.Parameters.Add(new SqlParameter("@activo", log.Activo));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Eliminar(Login log)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("DELETE FROM Logins WHERE id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", log.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static Boolean verificarUsuario(string usuario, string contrasena)
        {
            Boolean verificar = false;
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select nombreUsuario, contrasena, id from Logins where nombreUsuario = @nombreUsuario and contrasena = @contrasena");
            cmd.Parameters.Add(new SqlParameter("@nombreUsuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@contrasena", contrasena));
            cmd.Connection = cnn;
            SqlDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                if (obdr.GetString(0) == usuario)
                {
                    if (obdr.GetString(1) == contrasena)
                    {
                        verificar = true;
                        adm = obdr.GetInt32(2);
                    }
                }
            }
            cnn.Close();
            return verificar;
        }
    }
}
