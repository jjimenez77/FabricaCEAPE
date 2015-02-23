using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosMedida : Conexion
    {
        public static List<Medida> getMedidas()
        {
            List<Medida> medidas = new List<Medida>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, abreviacion, activo from Medidas where activo = 1 order by nombre");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                medidas.Add(new Medida(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetBoolean(3)));
            }

            cnn.Close();

            return medidas;
        }

        public static Medida getMedida(int id)
        {
            Medida m = new Medida();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, abreviacion, activo from Medidas where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                m.Id = obdr.GetInt32(0);
                m.Nombre = obdr.GetString(1);
                m.Abreviacion = obdr.GetString(2);
                m.Activo = obdr.GetBoolean(3);
            }

            cnn.Close();

            return m;
        }

        public static void Modificar(Medida m)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Medidas set nombre = @nombre, abreviacion = @abreviacion, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", m.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", m.Nombre));
            cmd.Parameters.Add(new SqlParameter("@abreviacion", m.Abreviacion));
            cmd.Parameters.Add(new SqlParameter("@activo", m.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Medida m)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Medidas (nombre, abreviacion, activo) values (@nombre, @abreviacion, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", m.Nombre));
            cmd.Parameters.Add(new SqlParameter("@abreviacion", m.Abreviacion));
            cmd.Parameters.Add(new SqlParameter("@activo", m.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(Medida m)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Medidas Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", m.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
