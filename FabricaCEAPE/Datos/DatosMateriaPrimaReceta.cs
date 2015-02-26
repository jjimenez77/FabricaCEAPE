using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;
using System.Data.SqlClient;

namespace FabricaCEAPE.Datos
{
    class DatosMateriaPrimaReceta : Conexion
    {
        public static List<MateriaPrimaReceta> getMateriaPrimaRecetas()
        {
            List<MateriaPrimaReceta> materiaPrimaRecetas = new List<MateriaPrimaReceta>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre from MateriaPrimaRecetas order by nombre");
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                materiaPrimaRecetas.Add(new MateriaPrimaReceta(obdr.GetInt32(0), obdr.GetString(1)));
            }

            cnn.Close();

            return materiaPrimaRecetas;
        }

        public static MateriaPrimaReceta getMateriaPrimaReceta(int id)
        {
            MateriaPrimaReceta mpr = new MateriaPrimaReceta();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre from MateriaPrimaRecetas where id = @id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                mpr.Id = obdr.GetInt32(0);
                mpr.Nombre = obdr.GetString(1);
            }

            cnn.Close();

            return mpr;
        }

        public static void Modificar(MateriaPrimaReceta mpr)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update MateriaPrimaRecetas set nombre = @nombre Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", mpr.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", mpr.Nombre));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(MateriaPrimaReceta mpr)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into MateriaPrimaRecetas (nombre) values (@nombre)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", mpr.Nombre));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Eliminar(MateriaPrimaReceta mpr)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from MateriaPrimaRecetas Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", mpr.Id));

            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<MateriaPrimaReceta> getMateriaPrimaPorNombre(string nombre) //buscador
        {
            List<MateriaPrimaReceta> materiaPrimaRecetas = new List<MateriaPrimaReceta>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre from MateriaPrimaRecetas where nombre like '%{0}%' order by nombre", nombre));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                materiaPrimaRecetas.Add(new MateriaPrimaReceta(obdr.GetInt32(0), obdr.GetString(1)));
            }

            cnn.Close();

            return materiaPrimaRecetas;
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MateriaPrimaRecetas left join IngredientesRecetas on MateriaPrimaRecetas.id = IngredientesRecetas.idMateriaPrimaReceta where IngredientesRecetas.idMateriaPrimaReceta = @id");

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
