using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosLocalidad : Conexion
    {
        public static List<Localidad> getLocalidades()
        {
            List<Localidad> localidades = new List<Localidad>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, idProvincia, activo from Localidades where activo = 1 order by nombre");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                localidades.Add(new Localidad(obdr.GetInt32(0), obdr.GetString(1), DatosProvincia.getProvincia(obdr.GetInt32(2)), obdr.GetBoolean(3)));
            }

            cnn.Close();

            return localidades;
        }

        public static Localidad getLocalidad(int id)
        {
            Localidad l = new Localidad();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, idProvincia, activo from Localidades where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                l.Id = obdr.GetInt32(0);
                l.Nombre = obdr.GetString(1);
                l.Provincia = DatosProvincia.getProvincia(obdr.GetInt32(2));
                l.Activo = obdr.GetBoolean(3);
            }

            cnn.Close();

            return l;
        }

        public static void Modificar(Localidad l)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Localidades set nombre = @nombre, idProvincia = @idProvincia, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", l.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", l.Nombre));
            cmd.Parameters.Add(new SqlParameter("@idProvincia", l.Provincia.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", l.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Localidad l)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Localidades (nombre, idProvincia, activo) values (@nombre, @idProvincia, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", l.Nombre));
            cmd.Parameters.Add(new SqlParameter("@idProvincia", l.Provincia.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", l.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(Localidad l)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Localidades Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", l.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<Localidad> getLocalidadesPorProvincia(int id)
        {
            List<Localidad> localidades = new List<Localidad>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, idProvincia, activo from Localidades where idProvincia = @id order by nombre");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                localidades.Add(new Localidad(obdr.GetInt32(0), obdr.GetString(1), DatosProvincia.getProvincia(obdr.GetInt32(2)), obdr.GetBoolean(3)));
            }

            cnn.Close();

            return localidades;
        }

        public static Localidad getLocalidadPorProvincia(int id)
        {
            Localidad l = new Localidad();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, idProvincia, activo from Localidades where idProvincia = @id order by nombre");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                l.Id = obdr.GetInt32(0);
                l.Nombre = obdr.GetString(1);
                l.Provincia = DatosProvincia.getProvincia(obdr.GetInt32(2));
                l.Activo = obdr.GetBoolean(3);
            }

            cnn.Close();

            return l;
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Proveedores
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Localidades left join Proveedores on Localidades.id = Proveedores.idLocalidad where Proveedores.idLocalidad = @id");
            //Repartidores
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Localidades left join Repartidores on Localidades.id = Repartidores.idLocalidad where Repartidores.idLocalidad = @id");
            //Repartidores
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Localidades left join Usuarios on Localidades.id = Usuarios.idLocalidad where Usuarios.idLocalidad = @id");
            //Zonas
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Localidades left join Zona on Localidades.id = Zona.idLocalidad where Zona.idLocalidad = @id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Connection = cnn;
            cmd1.ExecuteNonQuery();

            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.Connection = cnn;
            cmd2.ExecuteNonQuery();

            cmd3.Parameters.AddWithValue("@id", id);
            cmd3.Connection = cnn;
            cmd3.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            int count1 = Convert.ToInt32(cmd1.ExecuteScalar());
            int count2 = Convert.ToInt32(cmd2.ExecuteScalar());
            int count3 = Convert.ToInt32(cmd3.ExecuteScalar());

            if (count == 0 && count1 == 0 && count2 == 0 && count3 == 0)
                return false;
            else
                return true;
        }
    }
}
