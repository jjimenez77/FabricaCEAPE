using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosMarca : Conexion
    {
        public static List<Marca> getMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select id, nombre, activo from Marcas where activo = 1 order by nombre");
            cmd.Connection = cnn;
            SqlDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                marcas.Add(new Marca(obdr.GetInt32(0), obdr.GetString(1), obdr.GetBoolean(2)));
            }
            cnn.Close();
            return marcas;
        }

        public static Marca getMarca(int id)
        {
            Marca m = new Marca();
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select id, nombre, activo from Marcas where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Connection = cnn;
            SqlDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                m.Id = obdr.GetInt32(0);
                m.Nombre = obdr.GetString(1);
                m.Activo = obdr.GetBoolean(2);
            }
            cnn.Close();
            return m;
        }

        public static void Modificar(Marca m)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("update Marcas set nombre = @nombre, activo = @activo Where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", m.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", m.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", m.Activo));
            cmd.Connection = cnn; 
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Marca m)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into Marcas (nombre, activo) values (@nombre, @activo)");
            cmd.Parameters.Add(new SqlParameter("@nombre", m.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", m.Activo));
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(Marca m)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("delete from Marcas Where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", m.Id));
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<Marca> getMarcasPorNombre(string nombre)
        {
            List<Marca> marcas = new List<Marca>();
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre, activo from Marcas where activo = 1 and nombre like '%{0}%' order by nombre", nombre));

            cmd.Connection = cnn;
            SqlDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                marcas.Add(new Marca(obdr.GetInt32(0), obdr.GetString(1), obdr.GetBoolean(2)));
            }
            cnn.Close();
            return marcas;
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Marcas left join MateriasPrimas on Marcas.id = MateriasPrimas.idMarca where MateriasPrimas.idMarca = @id");

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

        public static bool existe(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Marcas where activo = 1 and nombre = @nombre");

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

        public static bool existeMarca(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Marcas where activo = 1 and id = @id and nombre = @nombre");

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
