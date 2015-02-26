using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosUsuario : Conexion
    {
        public static List<Usuario> getUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, apellido, tipoUsuario, sexo, fechaNacimiento, numeroTelefono, numeroCelular, correoElectronico, correoElectronicoAlternativo, tipoDocumento, numeroDocumento, fechaIngreso, direccion, idLocalidad, idDepartamento, idLogin, activo from Usuarios where activo = 1 order by nombre");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                usuarios.Add(new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3), obdr.GetBoolean(4), obdr.GetDateTime(5), obdr.GetString(6), obdr.GetString(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetDateTime(12), obdr.GetString(13), DatosLocalidad.getLocalidad(obdr.GetInt32(14)), DatosDepartamento.getDepartamento(obdr.GetInt32(15)), DatosLogin.getLogin(obdr.GetInt32(16)), obdr.GetBoolean(17)));
            }

            cnn.Close();

            return usuarios;
        }

        public static Usuario getUsuario(int id)
        {
            Usuario u = new Usuario();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Usuarios where id = @id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                u.Id = obdr.GetInt32(0); 
                u.Nombre = obdr.GetString(1);
                u.Apellido =obdr.GetString(2);
                u.TipoUsuario = obdr.GetBoolean(3);
                u.Sexo = obdr.GetBoolean(4);
                u.FechaNacimiento= obdr.GetDateTime(5);
                u.NumeroTelefono= obdr.GetString(6);
                u.NumeroCelular = obdr.GetString(7);
                u.CorreoElectronico = obdr.GetString(8);
                u.CorreoElectronicoAlternativo = obdr.GetString(9); 
                u.TipoDocumento = obdr.GetString(10);
                u.NumeroDocumento = obdr.GetString(11);
                u.FechaIngreso = obdr.GetDateTime(12);
                u.Direccion = obdr.GetString(13);
                u.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(14));
                u.Departamento = DatosDepartamento.getDepartamento(obdr.GetInt32(15));
                u.Login = DatosLogin.getLogin(obdr.GetInt32(16));
                u.Activo = obdr.GetBoolean(17);
            }

            cnn.Close();

            return u;
        }

        public static void Modificar(Usuario u)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Usuarios set nombre = @nombre, apellido = @apellido, tipoUsuario = @tipoUsuario, sexo = @sexo, fechaNacimiento = @fechaNacimiento, numeroTelefono = @numeroTelefono, numeroCelular = @numeroCelular, correoElectronico = @correoElectronico, correoElectronicoAlternativo = @correoElectronicoAlternativo, tipoDocumento = @tipoDocumento, numeroDocumento = @numeroDocumento, fechaIngreso = @fechaIngreso, direccion = @direccion, idLocalidad = @idLocalidad, idDepartamento = @idDepartamento, idLogin = @idLogin, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", u.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", u.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", u.Apellido));
            cmd.Parameters.Add(new SqlParameter("@tipoUsuario", u.TipoUsuario));
            cmd.Parameters.Add(new SqlParameter("@sexo", u.Sexo));
            cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", u.FechaNacimiento));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", u.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", u.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", u.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@correoElectronicoAlternativo", u.CorreoElectronicoAlternativo));
            cmd.Parameters.Add(new SqlParameter("@tipoDocumento", u.TipoDocumento));
            cmd.Parameters.Add(new SqlParameter("@numeroDocumento", u.NumeroDocumento));
            cmd.Parameters.Add(new SqlParameter("@fechaIngreso", u.FechaIngreso));
            cmd.Parameters.Add(new SqlParameter("@direccion", u.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", u.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", u.Departamento.Id));
            cmd.Parameters.Add(new SqlParameter("@idLogin", u.Login.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", u.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Usuario u)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Usuarios (nombre, apellido, tipoUsuario, sexo, fechaNacimiento, numeroTelefono, numeroCelular, correoElectronico, correoElectronicoAlternativo, tipoDocumento, numeroDocumento, fechaIngreso, direccion, idLocalidad, idDepartamento, idLogin, activo) values (@nombre, @apellido, @tipoUsuario, @sexo, @fechaNacimiento, @numeroTelefono, @numeroCelular, @correoElectronico, @correoElectronicoAlternativo, @tipoDocumento, @numeroDocumento, @fechaIngreso, @direccion, @idLocalidad, @idDepartamento, @idLogin, @activo)");
            cmd.Parameters.Add(new SqlParameter("@nombre", u.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", u.Apellido));
            cmd.Parameters.Add(new SqlParameter("@tipoUsuario", u.TipoUsuario));
            cmd.Parameters.Add(new SqlParameter("@sexo", u.Sexo));
            cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", u.FechaNacimiento));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", u.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", u.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", u.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@correoElectronicoAlternativo", u.CorreoElectronicoAlternativo));
            cmd.Parameters.Add(new SqlParameter("@tipoDocumento", u.TipoDocumento));
            cmd.Parameters.Add(new SqlParameter("@numeroDocumento", u.NumeroDocumento));
            cmd.Parameters.Add(new SqlParameter("@fechaIngreso", u.FechaIngreso));
            cmd.Parameters.Add(new SqlParameter("@direccion", u.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", u.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", u.Departamento.Id));
            cmd.Parameters.Add(new SqlParameter("@idLogin", u.Login.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", u.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        public static void Eliminar(Usuario u)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Usuarios Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", u.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Usuario getUsuarioPorLogin(int idLogin)
        {
            Usuario u = new Usuario();
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE idLogin = @idLogin");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idLogin", idLogin));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                u.Id = obdr.GetInt32(0);
                u.Nombre = obdr.GetString(1);
                u.Apellido = obdr.GetString(2);
                u.TipoUsuario = obdr.GetBoolean(3);
                u.Sexo = obdr.GetBoolean(4);
                u.FechaNacimiento = obdr.GetDateTime(5);
                u.NumeroTelefono = obdr.GetString(6);
                u.NumeroCelular = obdr.GetString(7);
                u.CorreoElectronico = obdr.GetString(8);
                u.CorreoElectronicoAlternativo = obdr.GetString(9);
                u.TipoDocumento = obdr.GetString(10);
                u.NumeroDocumento = obdr.GetString(11);
                u.FechaIngreso = obdr.GetDateTime(12);
                u.Direccion = obdr.GetString(13);
                u.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(14));
                u.Departamento = DatosDepartamento.getDepartamento(obdr.GetInt32(15));
                u.Login = DatosLogin.getLogin(obdr.GetInt32(16));
                u.Activo = obdr.GetBoolean(17);
            }
            cnn.Close();
            return u;
        }

        public static Usuario getUsuarioPorLoginn(int idLogin)
        {
            Usuario u = new Usuario();
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select Usuarios.* from Usuarios left join Logins on Usuarios.idLogin = Logins.id where Usuarios.activo = 1 and Logins.id=@id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", idLogin));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                u.Id = obdr.GetInt32(0);
                u.Nombre = obdr.GetString(1);
                u.Apellido = obdr.GetString(2);
                u.TipoUsuario = obdr.GetBoolean(3);
                u.Sexo = obdr.GetBoolean(4);
                u.FechaNacimiento = obdr.GetDateTime(5);
                u.NumeroTelefono = obdr.GetString(6);
                u.NumeroCelular = obdr.GetString(7);
                u.CorreoElectronico = obdr.GetString(8);
                u.CorreoElectronicoAlternativo = obdr.GetString(9);
                u.TipoDocumento = obdr.GetString(10);
                u.NumeroDocumento = obdr.GetString(11);
                u.FechaIngreso = obdr.GetDateTime(12);
                u.Direccion = obdr.GetString(13);
                u.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(14));
                u.Departamento = DatosDepartamento.getDepartamento(obdr.GetInt32(15));
                u.Login = DatosLogin.getLogin(obdr.GetInt32(16));
                u.Activo = obdr.GetBoolean(17);
            }
            cnn.Close();
            return u;
        }

        public static List<Usuario> getUsuariosPorNombre(string nombre) //buscador
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre, apellido, tipoUsuario, sexo, fechaNacimiento, numeroTelefono, numeroCelular, correoElectronico, correoElectronicoAlternativo, tipoDocumento, numeroDocumento, fechaIngreso, direccion, idLocalidad, idDepartamento, idLogin, activo from Usuarios where activo = 1 and nombre like '%{0}%' order by nombre", nombre));
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                usuarios.Add(new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3), obdr.GetBoolean(4), obdr.GetDateTime(5), obdr.GetString(6), obdr.GetString(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetDateTime(12), obdr.GetString(13), DatosLocalidad.getLocalidad(obdr.GetInt32(14)), DatosDepartamento.getDepartamento(obdr.GetInt32(15)), DatosLogin.getLogin(obdr.GetInt32(16)), obdr.GetBoolean(17)));
            }

            cnn.Close();

            return usuarios;
        }

        public static List<Usuario> getUsuariosPorApellido(string nombre) //buscador
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre, apellido, tipoUsuario, sexo, fechaNacimiento, numeroTelefono, numeroCelular, correoElectronico, correoElectronicoAlternativo, tipoDocumento, numeroDocumento, fechaIngreso, direccion, idLocalidad, idDepartamento, idLogin, activo from Usuarios where activo = 1 and apellido like '%{0}%' order by nombre", nombre));
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                usuarios.Add(new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3), obdr.GetBoolean(4), obdr.GetDateTime(5), obdr.GetString(6), obdr.GetString(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetDateTime(12), obdr.GetString(13), DatosLocalidad.getLocalidad(obdr.GetInt32(14)), DatosDepartamento.getDepartamento(obdr.GetInt32(15)), DatosLogin.getLogin(obdr.GetInt32(16)), obdr.GetBoolean(17)));
            }

            cnn.Close();

            return usuarios;
        }

        public static List<Usuario> getUsuariosPorDepartamento(string nombre) //buscador
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select Usuarios.id, Usuarios.nombre, Usuarios.apellido, Usuarios.tipoUsuario, Usuarios.sexo, Usuarios.fechaNacimiento, Usuarios.numeroTelefono, Usuarios.numeroCelular, Usuarios.correoElectronico, Usuarios.correoElectronicoAlternativo, Usuarios.tipoDocumento, Usuarios.numeroDocumento, Usuarios.fechaIngreso, Usuarios.direccion, Usuarios.idLocalidad, Usuarios.idDepartamento, Usuarios.idLogin, Usuarios.activo from Usuarios left join Departamentos on Usuarios.idDepartamento = Departamentos.id where Usuarios.activo = 1 and Departamentos.nombre like '%{0}%' order by Usuarios.nombre", nombre));
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                usuarios.Add(new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3), obdr.GetBoolean(4), obdr.GetDateTime(5), obdr.GetString(6), obdr.GetString(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetDateTime(12), obdr.GetString(13), DatosLocalidad.getLocalidad(obdr.GetInt32(14)), DatosDepartamento.getDepartamento(obdr.GetInt32(15)), DatosLogin.getLogin(obdr.GetInt32(16)), obdr.GetBoolean(17)));
            }

            cnn.Close();

            return usuarios;
        }

        public static List<Usuario> getUsuariosPorNumeroDeDocumento(string nombre) //buscador
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre, apellido, tipoUsuario, sexo, fechaNacimiento, numeroTelefono, numeroCelular, correoElectronico, correoElectronicoAlternativo, tipoDocumento, numeroDocumento, fechaIngreso, direccion, idLocalidad, idDepartamento, idLogin, activo from Usuarios where activo = 1 and numeroDocumento like '%{0}%' order by nombre", nombre));
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                usuarios.Add(new Usuario(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3), obdr.GetBoolean(4), obdr.GetDateTime(5), obdr.GetString(6), obdr.GetString(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetString(11), obdr.GetDateTime(12), obdr.GetString(13), DatosLocalidad.getLocalidad(obdr.GetInt32(14)), DatosDepartamento.getDepartamento(obdr.GetInt32(15)), DatosLogin.getLogin(obdr.GetInt32(16)), obdr.GetBoolean(17)));
            }

            cnn.Close();

            return usuarios;
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Recetas
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios left join Recetas on Usuarios.id = Recetas.idUsuario where Recetas.idUsuario = @id");
            //Pedidos
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Usuarios left join Pedidos on Usuarios.id = Pedidos.idUsuario where Pedidos.idUsuario = @id");
            //ControlPCC
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Usuarios left join ControlPCC on Usuarios.id = ControlPCC.idUsuario where ControlPCC.idUsuario = @id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Connection = cnn;
            cmd1.ExecuteNonQuery();

            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.Connection = cnn;
            cmd2.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            int count1 = Convert.ToInt32(cmd1.ExecuteScalar());
            int count2 = Convert.ToInt32(cmd2.ExecuteScalar());

            if (count == 0 && count1 == 0 && count2 == 0)
                return false;
            else
                return true;
        }
    }
}
