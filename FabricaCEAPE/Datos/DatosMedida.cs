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

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Materias primas
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Medidas left join MateriasPrimas on Medidas.id = MateriasPrimas.idMedida where MateriasPrimas.idMedida = @id");
            //Producto terminado
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Medidas left join ProductoTerminado on Medidas.id = ProductoTerminado.idUnidadDeMedida where ProductoTerminado.idUnidadDeMedida = @id");
            //Articulos pedidos
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Medidas left join ArticulosPedidos on Medidas.id = ArticulosPedidos.idMedida where ArticulosPedidos.idMedida = @id");
            //Ingredientes recetas
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Medidas left join IngredientesRecetas on Medidas.id = IngredientesRecetas.idMedida where IngredientesRecetas.idMedida = @id");

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

        public static bool existeN(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Medidas where activo = 1 and nombre = @nombre");

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

        public static bool existeA(string abreviacion)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Medidas where activo = 1 and abreviacion = @abreviacion");

            cmd.Parameters.AddWithValue("@abreviacion", abreviacion);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeMedidaN(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Medidas where activo = 1 and id = @id and nombre = @nombre");

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

        public static bool existeMedidaA(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Medidas where activo = 1 and id = @id and abreviacion = @nombre");

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
