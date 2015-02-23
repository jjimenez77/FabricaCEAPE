using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;
using System.Data.SqlClient;

namespace FabricaCEAPE.Datos
{
    class DatosDetalleEntrega : Conexion
    {

        public static List<DetalleEntrega> getDetalleEntregas()
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT idEntrega,idProducto,cantidad  FROM DetalleEntrega order by DetalleEntrega.cantidad ASC ");

            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<DetalleEntrega> de = new List<DetalleEntrega>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {

                de.Add(new DetalleEntrega(DatosProductoTerminado.getProductoTerminado(obdr.GetInt32(0)), obdr.GetInt32(1)));
            }
            //Cierro la conexion
            cnn.Close();
            return de;
        }

        public static List<DetalleEntrega> getListaDetalleEntrega(int idEntrega)
        {
            List<DetalleEntrega> de = new List<DetalleEntrega>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT idEntrega,idProducto, cantidad FROM DetalleEntrega WHERE idEntrega = @idEntrega order by DetalleEntrega.cantidad ASC");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idEntrega", idEntrega));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                de.Add(new DetalleEntrega(DatosProductoTerminado.getProductoTerminado(obdr.GetInt32(1)), obdr.GetInt32(2)));
            }

            cnn.Close();

            return de;
        }

        public static void Crear(DetalleEntrega de, int idEntrega)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("INSERT INTO DetalleEntrega(idEntrega, idProducto, cantidad) VALUES (@idEntrega, @idProducto, @cantidad)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idEntrega", idEntrega));
            cmd.Parameters.Add(new SqlParameter("@idProducto", de.Product.Producto.IdProducto));
            cmd.Parameters.Add(new SqlParameter("@cantidad", de.Cantidad));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();


            cnn.Close();
        }

        public static void Eliminar(DetalleEntrega de)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from DetalleEntrega Where idDetalle = @idDetalle");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idDetalle", de.IdEntrega));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
