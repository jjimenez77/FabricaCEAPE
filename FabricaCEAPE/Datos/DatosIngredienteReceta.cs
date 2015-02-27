using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosIngredienteReceta : Conexion
    {
        public static List<IngredienteReceta> getIngredientesRecetas()
        {
            List<IngredienteReceta> ingredientesReceta = new List<IngredienteReceta>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, idMateriaPrimaReceta, cantidad, descripcion, idMedida, idReceta from IngredientesRecetas order by id");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                ingredientesReceta.Add(new IngredienteReceta(obdr.GetInt32(0), DatosMateriaPrimaReceta.getMateriaPrimaReceta(obdr.GetInt32(1)), obdr.GetDouble(2), obdr.GetString(3), DatosMedida.getMedida(obdr.GetInt32(4)), DatosReceta.getReceta(obdr.GetInt32(5))));
            }

            cnn.Close();

            return ingredientesReceta;
        }

        public static IngredienteReceta getIngredienteReceta(int id)
        {
            IngredienteReceta ir = new IngredienteReceta();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, idMateriaPrimaReceta, cantidad, descripcion, idMedida, idReceta from IngredientesRecetas where id = @id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                ir.Id = obdr.GetInt32(0);
                ir.Nombre = DatosMateriaPrimaReceta.getMateriaPrimaReceta(obdr.GetInt32(1));
                ir.Cantidad = obdr.GetDouble(2);
                ir.Descripcion = obdr.GetString(3);
                ir.Medida = DatosMedida.getMedida(obdr.GetInt32(4));
                ir.Receta = DatosReceta.getReceta(obdr.GetInt32(5));
            }

            cnn.Close();

            return ir;
        }

        public static void Modificar(IngredienteReceta ir)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update IngredientesRecetas set idMateriaPrimaReceta = @idMateriaPrimaReceta, cantidad = @cantidad, descripcion = @descripcion, idMedida = @idMedida, idReceta = @idReceta Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", ir.Id));
            cmd.Parameters.Add(new SqlParameter("@idMateriaPrimaReceta", ir.Nombre.Id));
            cmd.Parameters.Add(new SqlParameter("@cantidad", ir.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@descripcion", ir.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@idMedida", ir.Medida.Id));
            cmd.Parameters.Add(new SqlParameter("@idReceta", ir.Receta.Id));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(IngredienteReceta ir)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into IngredientesRecetas (idMateriaPrimaReceta, cantidad, descripcion, idMedida, idReceta) values (@idMateriaPrimaReceta, @cantidad, @descripcion, @idMedida, @idReceta)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idMateriaPrimaReceta", ir.Nombre.Id));
            cmd.Parameters.Add(new SqlParameter("@cantidad", ir.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@descripcion", ir.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@idMedida", ir.Medida.Id));
            cmd.Parameters.Add(new SqlParameter("@idReceta", ir.Receta.Id));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(IngredienteReceta ir)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from IngredientesRecetas Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", ir.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<IngredienteReceta> getIngredientesRecetaPorReceta(int id)
        {
            List<IngredienteReceta> ingredientesReceta = new List<IngredienteReceta>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, idMateriaPrimaReceta, cantidad, descripcion, idMedida, idReceta from IngredientesRecetas where idReceta = @idReceta order by id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idReceta", id));


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                ingredientesReceta.Add(new IngredienteReceta(obdr.GetInt32(0), DatosMateriaPrimaReceta.getMateriaPrimaReceta(obdr.GetInt32(1)), obdr.GetDouble(2), obdr.GetString(3), DatosMedida.getMedida(obdr.GetInt32(4)), DatosReceta.getReceta(obdr.GetInt32(5))));
            }

            cnn.Close();

            return ingredientesReceta;
        }

        public static bool existe(int idReceta, int idMateriaPrimaReceta)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM IngredientesRecetas where idReceta = @idReceta and idMateriaPrimaReceta = @idMateriaPrimaReceta");

            cmd.Parameters.AddWithValue("@idReceta", idReceta);
            cmd.Parameters.AddWithValue("@idMateriaPrimaReceta", idMateriaPrimaReceta);

            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static bool existeIngrediente(int id, int idReceta, int idMateriaPrimaReceta)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM IngredientesRecetas where id = @id and idReceta = @idReceta and idMateriaPrimaReceta = @idMateriaPrimaReceta");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@idReceta", idReceta);
            cmd.Parameters.AddWithValue("@idMateriaPrimaReceta", idMateriaPrimaReceta);
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
