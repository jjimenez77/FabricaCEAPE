using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosReceta : Conexion
    {
        public static List<Receta> getRecetas()
        {
            List<Receta> recetas = new List<Receta>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Recetas where activo = 1 order by idProducto");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                recetas.Add(new Receta(obdr.GetInt32(0), DatosProducto.getProducto(obdr.GetInt32(1)), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetDateTime(6), DatosUsuario.getUsuario(obdr.GetInt32(7)), obdr.GetBoolean(8)));
            }

            cnn.Close();

            return recetas;
        }

        public static Receta getReceta(int id)
        {
            Receta r = new Receta();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Recetas where id = @id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                r.Id =obdr.GetInt32(0);
                r.Producto = DatosProducto.getProducto(obdr.GetInt32(1)); 
                r.Observaciones = obdr.GetString(2);
                r.Tiempo = obdr.GetString(3);
                r.Temperatura = obdr.GetString(4);
                r.Otros = obdr.GetString(5);
                r.FechaCreacion = obdr.GetDateTime(6);
                r.Usuario = DatosUsuario.getUsuario(obdr.GetInt32(7));
                r.Activo = obdr.GetBoolean(8);
            }

            cnn.Close();

            return r;
        }

        public static void Modificar(Receta r)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Recetas set idProducto = @idProducto, observaciones = @observaciones, tiempo = @tiempo, temperatura = @temperatura, otros = @otros, fechaCreacion = @fechaCreacion, idUsuario = @idUsuario, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", r.Id));
            cmd.Parameters.Add(new SqlParameter("@idProducto", r.Producto.IdProducto));
            cmd.Parameters.Add(new SqlParameter("@observaciones", r.Observaciones));
            cmd.Parameters.Add(new SqlParameter("@tiempo", r.Tiempo));
            cmd.Parameters.Add(new SqlParameter("@temperatura", r.Temperatura));
            cmd.Parameters.Add(new SqlParameter("@otros", r.Otros));
            cmd.Parameters.Add(new SqlParameter("@fechaCreacion", r.FechaCreacion));
            cmd.Parameters.Add(new SqlParameter("@idUsuario", r.Usuario.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", r.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Receta r)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Recetas (idProducto, observaciones, tiempo, temperatura, otros, fechaCreacion, idUsuario, activo) values (@idProducto, @observaciones, @tiempo, @temperatura, @otros, @fechaCreacion, @idUsuario, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", r.Producto.IdProducto));
            cmd.Parameters.Add(new SqlParameter("@observaciones", r.Observaciones));
            cmd.Parameters.Add(new SqlParameter("@tiempo", r.Tiempo));
            cmd.Parameters.Add(new SqlParameter("@temperatura", r.Temperatura));
            cmd.Parameters.Add(new SqlParameter("@otros", r.Otros));
            cmd.Parameters.Add(new SqlParameter("@fechaCreacion", r.FechaCreacion));
            cmd.Parameters.Add(new SqlParameter("@idUsuario", r.Usuario.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", r.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(Receta r)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Recetas Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", r.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static int getUltimaReceta()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("Select id from Recetas where id=IDENT_CURRENT('Recetas')");
            //Cargo el valor del parametro
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Receta r = new Receta();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                r.Id = obdr.GetInt32(0);
            }
            cnn.Close();
            return r.Id;
        }

        public static List<Receta> getRecetaPorNombre(String nombre)
        {
            List<Receta> recetas = new List<Receta>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select Recetas.id, Recetas.idProducto, Recetas.observaciones, Recetas.tiempo, Recetas.temperatura, Recetas.otros, Recetas.fechaCreacion, Recetas.idUsuario, Recetas.activo from Recetas left join Producto on Recetas.idProducto = Producto.idProducto where Recetas.activo = 1 and Producto.nombre like '%{0}%' order by Recetas.idProducto", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                recetas.Add(new Receta(obdr.GetInt32(0), DatosProducto.getProducto(obdr.GetInt32(1)), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetDateTime(6), DatosUsuario.getUsuario(obdr.GetInt32(7)), obdr.GetBoolean(8)));
            }

            cnn.Close();

            return recetas;
        }

        public static List<Receta> getRecetaPorUsuario(String nombre)
        {
            List<Receta> recetas = new List<Receta>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select Recetas.id, Recetas.idProducto, Recetas.observaciones, Recetas.tiempo, Recetas.temperatura, Recetas.otros, Recetas.fechaCreacion, Recetas.idUsuario, Recetas.activo from Recetas left join Usuarios on Recetas.idUsuario = Usuarios.id where Recetas.activo = 1 and Usuarios.nombre like '%{0}%' order by Recetas.idProducto", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                recetas.Add(new Receta(obdr.GetInt32(0), DatosProducto.getProducto(obdr.GetInt32(1)), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetDateTime(6), DatosUsuario.getUsuario(obdr.GetInt32(7)), obdr.GetBoolean(8)));
            }

            cnn.Close();

            return recetas;
        }
    }
}
