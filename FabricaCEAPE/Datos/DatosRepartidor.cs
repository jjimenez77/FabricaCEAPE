using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosRepartidor
    {
        public static List<Repartidor> getRepartidores()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT id,nombre,apellido,sexo,fechaNacimiento,numeroTelefono,numeroCelular,correoElectronico,correoElectronicoAlternativo,tipoDocumento,numeroDocumento,fechaIngreso,direccion,idLocalidad,idZona,activo FROM Repartidores where activo = 1 ");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<Repartidor> cl = new List<Repartidor>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                cl.Add(new Repartidor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetString(6), obdr.GetString(7), obdr.GetString(8), obdr.GetString(9), obdr.GetString(10), obdr.GetDateTime(11), obdr.GetString(12), DatosLocalidad.getLocalidad(obdr.GetInt32(13)), DatosZona.getZona(obdr.GetInt32(14)), obdr.GetBoolean(15)));
            }
            //Cierro la conexion
            cnn.Close();
            return cl;
        }

        public static Repartidor getRepartido(int idRepartidor)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Repartidores Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", idRepartidor));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Repartidor r = new Repartidor();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                r.Id = obdr.GetInt32(0);
                r.Nombre = obdr.GetString(1);
                r.Apellido = obdr.GetString(2);
                r.Sexo = obdr.GetBoolean(3);
                r.FechaNacimiento= obdr.GetDateTime(4);
                r.NumeroTelefono = obdr.GetString(5);
                r.NumeroCelular = obdr.GetString(6);
                r.CorreoElectronico = obdr.GetString(7);
                r.CorreoElectronicoAlternativo = obdr.GetString(8);
                r.TipoDocumento = obdr.GetString(9);
                r.NumeroDocumento = obdr.GetString(10);
                r.FechaIngreso = obdr.GetDateTime(11);
                r.Direccion = obdr.GetString(12);
                r.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(13));
                r.Zona = DatosZona.getZona(obdr.GetInt32(14));
                r.Activo = obdr.GetBoolean(15);
            }
            cnn.Close();
            return r;
        }

        public static void Eliminar(Repartidor r)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Repartidores Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", r.Id));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(Repartidor r)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Repartidores set nombre = @nombre, apellido = @apellido, sexo = @sexo, fechaNacimiento = @fechaNacimiento, numeroTelefono =  @numeroTelefono, numeroCelular = @numeroCelular, correoElectronico = @correoElectronico, correoElectronicoAlternativo = @correoElectronicoAlternativo, tipoDocumento = @tipoDocumento, numeroDocumento = @numeroDocumento, fechaIngreso = @fechaIngreso, direccion = @direccion, idLocalidad = @idLocalidad, idZona = @idZona, activo = @activo where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", r.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", r.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", r.Apellido));
            cmd.Parameters.Add(new SqlParameter("@sexo", r.Sexo));
            cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", r.FechaNacimiento));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", r.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", r.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", r.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@correoElectronicoAlternativo", r.CorreoElectronicoAlternativo));
            cmd.Parameters.Add(new SqlParameter("@tipoDocumento", r.TipoDocumento));
            cmd.Parameters.Add(new SqlParameter("@numeroDocumento", r.NumeroDocumento));
            cmd.Parameters.Add(new SqlParameter("@fechaIngreso", r.FechaIngreso));
            cmd.Parameters.Add(new SqlParameter("@direccion", r.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", r.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@idZona", r.Zona.IdZona));
            cmd.Parameters.Add(new SqlParameter("@activo", r.Activo));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Repartidor r)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Repartidores (nombre,apellido,sexo,fechaNacimiento,numeroTelefono,numeroCelular,correoElectronico,correoElectronicoAlternativo,tipoDocumento,numeroDocumento,fechaIngreso,direccion,idLocalidad,idZona,activo) values (@nombre,@apellido,@sexo,@fechaNacimiento,@numeroTelefono,@numeroCelular,@correoElectronico,@correoElectronicoAlternativo,@tipoDocumento,@numeroDocumento,@fechaIngreso,@direccion,@idLocalidad,@idZona,@activo)");
            //Cargo el valor del parametro

            cmd.Parameters.Add(new SqlParameter("@nombre", r.Nombre));
            cmd.Parameters.Add(new SqlParameter("@apellido", r.Apellido));
            cmd.Parameters.Add(new SqlParameter("@sexo", r.Sexo));
            cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", r.FechaNacimiento));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", r.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", r.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", r.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@correoElectronicoAlternativo", r.CorreoElectronicoAlternativo));
            cmd.Parameters.Add(new SqlParameter("@tipoDocumento", r.TipoDocumento));
            cmd.Parameters.Add(new SqlParameter("@numeroDocumento", r.NumeroDocumento));
            cmd.Parameters.Add(new SqlParameter("@fechaIngreso", r.FechaIngreso));
            cmd.Parameters.Add(new SqlParameter("@direccion", r.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", r.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@idZona", r.Zona.IdZona));
            cmd.Parameters.Add(new SqlParameter("@activo", r.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static bool Existe(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores WHERE nombre=@nombre and activo = 1");

            cmd.Parameters.AddWithValue("nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static List<Repartidor> BuscarNombre(String nombre)
        {
            List<Repartidor> Lista = new List<Repartidor>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select nombre,apellido,sexo,fechaNacimiento,numeroTelefono,numeroCelular,correoElectronico,correoElectronicoAlternativo,tipoDocumento,numeroDocumento,fechaIngreso,direccion,idLocalidad,idZona,activo from Respartidores where activo = 1 and nombre like '%{0}%' order by nombre", nombre), conexion);

                SqlDataReader obdr = comando.ExecuteReader();

                while (obdr.Read())
                {
                    Repartidor r = new Repartidor();
                    r.Id = obdr.GetInt32(0);
                    r.Nombre = obdr.GetString(1);
                    r.Apellido = obdr.GetString(2);
                    r.Sexo = obdr.GetBoolean(3);
                    r.FechaNacimiento = obdr.GetDateTime(4);
                    r.NumeroTelefono = obdr.GetString(5);
                    r.NumeroCelular = obdr.GetString(6);
                    r.CorreoElectronico = obdr.GetString(7);
                    r.CorreoElectronicoAlternativo = obdr.GetString(8);
                    r.TipoDocumento = obdr.GetString(9);
                    r.NumeroDocumento = obdr.GetString(10);
                    r.FechaIngreso = obdr.GetDateTime(11);
                    r.Direccion = obdr.GetString(12);
                    r.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(13));
                    r.Zona = DatosZona.getZona(obdr.GetInt32(14));
                    r.Activo = obdr.GetBoolean(15);

                    Lista.Add(r);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Repartidor> BuscarNroDocumento(String nroDocumento)
        {

            List<Repartidor> Lista = new List<Repartidor>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select *d from Repartidores where numeroDocumento like '%{0}%' order by nombre", nroDocumento), conexion);

                SqlDataReader obdr = comando.ExecuteReader();

                while (obdr.Read())
                {
                    Repartidor r = new Repartidor();
                    r.Id = obdr.GetInt32(0);
                    r.Nombre = obdr.GetString(1);
                    r.Apellido = obdr.GetString(2);
                    r.Sexo = obdr.GetBoolean(3);
                    r.FechaNacimiento = obdr.GetDateTime(4);
                    r.NumeroTelefono = obdr.GetString(5);
                    r.NumeroCelular = obdr.GetString(6);
                    r.CorreoElectronico = obdr.GetString(7);
                    r.CorreoElectronicoAlternativo = obdr.GetString(8);
                    r.TipoDocumento = obdr.GetString(9);
                    r.NumeroDocumento = obdr.GetString(10);
                    r.FechaIngreso = obdr.GetDateTime(11);
                    r.Direccion = obdr.GetString(12);
                    r.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(13));
                    r.Zona = DatosZona.getZona(obdr.GetInt32(14));
                    r.Activo = obdr.GetBoolean(15);

                    Lista.Add(r);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores left join EntregaProductoTerminado on Repartidores.id = EntregaProductoTerminado.idVendedor where EntregaProductoTerminado.idVendedor = @id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeDocumento(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and numeroDocumento = @nombre");

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeTelefono(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and numeroTelefono = @nombre");

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeCelular(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and numeroCelular = @nombre");

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeCorreoE(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and correoElectronico = @nombre");

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeCorreoEA(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and correoElectronicoAlternativo = @nombre");

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeRepartidorNT(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and id = @id and numeroTelefono = @nombre");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeRepartidorNC(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and id = @id and numeroCelular = @nombre");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeRepartidorCE(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and id = @id and correoElectronico = @nombre");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeRepartidorCEA(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and id = @id and correoElectronicoAlternativo = @nombre");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeRepartidorND(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Repartidores where activo = 1 and id = @id and numeroDocumento = @nombre");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }
    }
}
