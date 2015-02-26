using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosProvincia : Conexion
    {
        public static List<Provincia> getProvincias()
        {
            List<Provincia> provincias = new List<Provincia>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, idPais, activo from Provincias where activo = 1 order by nombre");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                provincias.Add(new Provincia(obdr.GetInt32(0), obdr.GetString(1), DatosPais.getPais(obdr.GetInt32(2)), obdr.GetBoolean(3)));
            }

            cnn.Close();

            return provincias;
        }
        
        public static Provincia getProvincia(int id)
        {
            Provincia p = new Provincia();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, idPais, activo from Provincias where id = @id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                p.Pais = DatosPais.getPais(obdr.GetInt32(2));
                p.Activo = obdr.GetBoolean(3);
            }

            cnn.Close();

            return p;
        }

        public static void Modificar(Provincia p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Provincias set nombre = @nombre, idPais = @idPais, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", p.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@idPais", p.Pais.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Provincia p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Provincias (nombre, idPais, activo) values (@nombre, @idPais, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@idPais", p.Pais.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(Provincia p)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Provincias Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", p.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<Provincia> getProvinciasPorPais(int id)
        {
            List<Provincia> provincias = new List<Provincia>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, idPais, activo from Provincias where idPais = @id order by nombre");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                provincias.Add(new Provincia(obdr.GetInt32(0), obdr.GetString(1), DatosPais.getPais(obdr.GetInt32(2)), obdr.GetBoolean(3)));
            }

            cnn.Close();

            return provincias;
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Provincias left join Localidades on Provincias.id = Localidades.idProvincia where Localidades.idProvincia = @id");

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
    }
}
