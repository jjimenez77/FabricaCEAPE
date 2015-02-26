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

            SqlCommand cmd = new SqlCommand("select * from Producto where activo = 1 order by nombre");
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

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Recetas
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Producto left join Recetas on Producto.idProducto = Recetas.idProducto where Producto.idProducto = @id");
            //Producto terminado
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Producto left join ProductoTerminado on Producto.idProducto = ProductoTerminado.idProducto where ProductoTerminado.idProducto = @id");
            //ControlPCC
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Producto left join ControlPCC on Producto.idProducto = ControlPCC.idProducto where ControlPCC.idProducto = @id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Connection = cnn;
            cmd1.ExecuteNonQuery();

            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.Connection = cnn;
            cmd2.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            int count1 = Convert.ToInt32(cmd1.ExecuteScalar());
            int count2 = Convert.ToInt32(cmd2.ExecuteScalar());

            if (count == 0 && count1 == 0 && count2 == 0)
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
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Producto where activo = 1 and nombre = @nombre");

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
