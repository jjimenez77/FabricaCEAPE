using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;

namespace FabricaCEAPE.Datos
{
    class DatosTipoProducto
    {
        public static List<TipoProducto> getTipoProductos()
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TipoProducto where activo = 1 order by nombre");
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<TipoProducto> tp = new List<TipoProducto>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                tp.Add(new TipoProducto(obdr.GetInt32(0),obdr.GetString(1), obdr.GetBoolean(2)));
               
            }
            //Cierro la conexion
            cnn.Close();
            return tp;
        }

        public static TipoProducto getTipoProducto(int idTipoProducto)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select idTipoProducto, nombre, activo from TipoProducto Where idTipoProducto = @idTipoProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", idTipoProducto));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            TipoProducto tp = new TipoProducto();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //zona = new Zona(obdr.GetInt32(0), obdr.GetString(1),  DatosLocalidad.getLocalidad(obdr.GetInt32(2)));
                tp.IdTipoProducto = obdr.GetInt32(0);
                tp.Nombre = obdr.GetString(1);
                /*tp.Gramaje = obdr.GetFloat(2);
                tp.UnidadPorCaja = obdr.GetInt32(3);
                tp.Unidad = DatosUnidadDeMedida.getUnidadDeMedida(obdr.GetInt32(4));*/
            }
            cnn.Close();
            return tp;

        }

        public static void Eliminar(TipoProducto tp)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from TipoProducto Where idTipoProducto = @idTipoProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", tp.IdTipoProducto));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(TipoProducto tp)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update TipoProducto set nombre = @nombre, activo = @activo Where idTipoProducto = @idTipoProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", tp.IdTipoProducto));
            cmd.Parameters.Add(new SqlParameter("@nombre", tp.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", tp.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(TipoProducto tp)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into TipoProducto (nombre, activo) values (@nombre, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", tp.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", tp.Activo));

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
            
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TipoProducto WHERE nombre=@nombre");

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

        public static List<TipoProducto> BuscarbyNombre(String nombre)
        {

            List<TipoProducto> Lista = new List<TipoProducto>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                "select   idTipoProducto, nombre, activo from TipoProducto where activo = 1 and nombre like '%{0}%' order by nombre", nombre), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    TipoProducto tp = new TipoProducto();
                    tp.IdTipoProducto = reader.GetInt32(0);
                    tp.Nombre = reader.GetString(1);

                    Lista.Add(tp);

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
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TipoProducto left join ProductoTerminado on TipoProducto.idTipoProducto = ProductoTerminado.idTipoProducto where ProductoTerminado.idTipoProducto = @id");

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
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TipoProducto where activo = 1 and nombre = @nombre");

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

        public static bool existeProductoN(int id, string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TipoProducto where activo = 1 and idTipoProducto = @id and nombre = @nombre");

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
