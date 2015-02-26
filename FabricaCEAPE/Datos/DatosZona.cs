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
    class DatosZona
    {
        public static List<Zona> getZonas()
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("select idZona, nombre, idLocalidad,activo from Zona where activo = 1 order by nombre");
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<Zona> zonas = new List<Zona>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                zonas.Add(new Zona(obdr.GetInt32(0), obdr.GetString(1), DatosLocalidad.getLocalidad(obdr.GetInt32(2)), obdr.GetBoolean(3)));
            }
            //Cierro la conexion
            cnn.Close();
            return zonas;
        }

        public static Zona getZona(int idZona)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select idZona, nombre, idLocalidad, activo from Zona Where idZona = @idZona");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idZona", idZona));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Zona zona = new Zona();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                zona.IdZona = obdr.GetInt32(0);
                zona.Nombre = obdr.GetString(1);
                zona.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(2));
                zona.Activo = obdr.GetBoolean(3);
            }
            cnn.Close();
            return zona;
        }

        public static void Eliminar(Zona z)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Zona Where idZona = @idZona");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idZona", z.IdZona));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(Zona z)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Zona set nombre = @nombre, idLocalidad = @idLocalidad, activo = @activo Where idZona = @idZona");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idZona", z.IdZona));
            cmd.Parameters.Add(new SqlParameter("@nombre", z.Nombre));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", z.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", z.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Zona z)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Zona (nombre, idLocalidad, activo) values (@nombre, @idLocalidad, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", z.Nombre));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", z.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", z.Activo));
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
            //SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Zona WHERE idZona=@Id");
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Zona WHERE activo = 1 and nombre=@nombre");

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


        public static List<Zona> BuscarByNombre(String nombre)
        {

            List<Zona> Lista = new List<Zona>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format("select   idZona, nombre, idLocalidad, activo from Zona where activo = 1 and nombre like '%{0}%' order by nombre", nombre), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Zona z = new Zona();
                    z.IdZona = reader.GetInt32(0);
                    z.Nombre = reader.GetString(1);
                    z.Localidad = DatosLocalidad.getLocalidad(reader.GetInt32(2));
                    z.Activo = reader.GetBoolean(3);

                    Lista.Add(z);

                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Zona> getZonasPorLocalidad(int id)
        {
            List<Zona> zonas = new List<Zona>();
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Zona where activo = 1 and idLocalidad = @id order by nombre");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                zonas.Add(new Zona(obdr.GetInt32(0), obdr.GetString(1), DatosLocalidad.getLocalidad(obdr.GetInt32(2)), obdr.GetBoolean(3)));
            }

            cnn.Close();

            return zonas;
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Clientes
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Zonas left join Cliente on Zonas.idZona = Cliente.idCliente where Cliente.idCliente = @id");
            //Repartidores
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Zonas left join Repartidores on Zonas.idZona = Repartidores.idZona where Repartidores.idZona = @id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Connection = cnn;
            cmd1.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            int count1 = Convert.ToInt32(cmd1.ExecuteScalar());

            if (count == 0 && count1 == 0)
                return false;
            else
                return true;
        }
    }
}
