using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosArticuloPedido : Conexion
    {
        public static List<ArticuloPedido> getArticulosPedidos()
        {
            List<ArticuloPedido> articulosPedidos = new List<ArticuloPedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, cantidad, descripcion, idMedida, idPedido from ArticulosPedidos order by nombre");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                articulosPedidos.Add(new ArticuloPedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetDouble(2), obdr.GetString(3), DatosMedida.getMedida(obdr.GetInt32(4)), DatosPedido.getPedido(obdr.GetInt32(5))));
            }

            cnn.Close();

            return articulosPedidos;
        }

        public static ArticuloPedido getArticuloPedido(int id)
        {
            ArticuloPedido ap = new ArticuloPedido();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, cantidad, descripcion, idMedida, idPedido from ArticulosPedidos where id = @id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                ap.Id = obdr.GetInt32(0); 
                ap.Nombre = obdr.GetString(1); 
                ap.Cantidad = obdr.GetDouble(2); 
                ap.Descripcion = obdr.GetString(3); 
                ap.Medida = DatosMedida.getMedida(obdr.GetInt32(4));
                ap.Pedido = DatosPedido.getPedido(obdr.GetInt32(5));
            }

            cnn.Close();

            return ap;
        }

        public static void Modificar(ArticuloPedido ap)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update ArticulosPedidos set nombre = @nombre, cantidad = @cantidad, descripcion = @descripcion, idMedida = @idMedida, idPedido = @idPedido Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", ap.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", ap.Nombre));
            cmd.Parameters.Add(new SqlParameter("@cantidad", ap.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@descripcion", ap.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@idMedida", ap.Medida.Id));
            cmd.Parameters.Add(new SqlParameter("@idPedido", ap.Pedido.Id));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(ArticuloPedido ap)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into ArticulosPedidos (nombre, cantidad, descripcion, idMedida, idPedido) values (@nombre, @cantidad, @descripcion, @idMedida, @idPedido)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", ap.Nombre));
            cmd.Parameters.Add(new SqlParameter("@cantidad", ap.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@descripcion", ap.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@idMedida", ap.Medida.Id));
            cmd.Parameters.Add(new SqlParameter("@idPedido", ap.Pedido.Id));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(ArticuloPedido ap)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from ArticulosPedidos Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", ap.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<ArticuloPedido> getArticulosPedidosPorPedido(int id)
        {
            List<ArticuloPedido> articulosPedidos = new List<ArticuloPedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, cantidad, descripcion, idMedida, idPedido from ArticulosPedidos where idPedido = @idPedido order by nombre");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idPedido", id));


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                articulosPedidos.Add(new ArticuloPedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetDouble(2), obdr.GetString(3), DatosMedida.getMedida(obdr.GetInt32(4)), DatosPedido.getPedido(obdr.GetInt32(5))));
            }

            cnn.Close();

            return articulosPedidos;
        }
    }
}
