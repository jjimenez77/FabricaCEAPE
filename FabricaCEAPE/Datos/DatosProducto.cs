using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosProducto:Conexion
    {
        public static List<Producto> getProductos()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("select * from Producto");
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<Producto> p = new List<Producto>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                p.Add(new Producto(obdr.GetInt32(0), obdr.GetString(1), obdr.GetBoolean(2)));

            }
            //Cierro la conexion
            cnn.Close();
            return p;
        }

        public static Producto getProducto(int idProducto)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Producto where idProducto = @idProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", idProducto));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Producto p = new Producto();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                p.IdProducto = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                p.Activo = obdr.GetBoolean(2);
            }
            cnn.Close();
            return p;

        }

        public static void Eliminar(Producto p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Producto Where idProducto = @idProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", p.IdProducto));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(Producto p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Producto set nombre = @nombre, activo = @activo where idProducto = @idProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", p.IdProducto));
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Producto p)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Producto (nombre, activo) values (@nombre, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
