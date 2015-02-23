using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;
using System.Data.SqlClient;
using System.Collections;

namespace FabricaCEAPE.Datos
{
    class DatosEntregaProductoTerminado : Conexion
    {
        /*public static List<ItemPedidoMateriaPrima> getItemPedidoMateriaPrimaDePedido(int idPedidoMateriaPrima)
        {
            //creo la conexion
            List<ItemPedidoMateriaPrima> itemsPedidoMateriaPrima = new List<ItemPedidoMateriaPrima>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT idItemPedidoProduccionMP, idMateriaPrima, cantidad, idPedidoProduccion, idUnidadDeMedida FROM ItemPedidoProduccionMP WHERE idPedidoProduccion = @idPedidoProduccion");
            cmd.Parameters.Add(new SqlParameter("@idPedidoProduccion", idPedidoMateriaPrima));
            //asigno la conexion al comando
            cmd.Connection = cnn;


            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                itemsPedidoMateriaPrima.Add(new ItemPedidoMateriaPrima(obdr.GetInt32(0), DatosMateriaPrima.getMateriaPrima(obdr.GetInt32(1)), obdr.GetInt32(2), DatosUnidadDeMedida.getUnidadDeMedida(obdr.GetInt32(3))));
            }
            //Cierro la conexion
            cnn.Close();
            return itemsPedidoMateriaPrima;
        }*/


        public static List<EntregaProductoTerminado> getEntregaProductoTerminados()
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM EntregaProductoTerminado order by EntregaProductoTerminado.fechaEntrega desc");
            //cmd.Parameters.Add(new SqlParameter("@idEntrega", idEntrega));
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<EntregaProductoTerminado> pro = new List<EntregaProductoTerminado>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pro.Add(new EntregaProductoTerminado(obdr.GetInt32(0), DatosRepartidor.getRepartido(obdr.GetInt32(1)), DatosCliente.getCliente(obdr.GetInt32(2)), obdr.GetDateTime(3)));
                //Asigno valor a la cuenta
                // pro.Add(new EntregaProductoTerminado(obdr.GetInt32(0), DatosVendedores.getVendedor(obdr.GetInt32(1)), DatosCliente.getCliente(obdr.GetInt32(2)), obdr.GetDateTime(3)));

            }
            //Cierro la conexion
            cnn.Close();
            return pro;
        }

        public static EntregaProductoTerminado getEntregaProductoTerminado(int id)
        {
            EntregaProductoTerminado ept = new EntregaProductoTerminado();
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            // hice cambio para tomar el id en productos entregados!!!
            SqlCommand cmd = new SqlCommand("SELECT idEntrega, idVendedor, idEmpresa, fechaEntrega FROM EntregaProductoTerminado where idEntrega = @idEntrega");
            //SqlCommand cmd = new SqlCommand("select EPT.idEmpresa, v.nombre,emp.nombreEmpresa from EntregaProductoTerminado as EPT,Vendedor AS v,Empresa AS emp where EPT.idVendedor = v.idVendedor and EPT.idEmpresa = emp.idEmpresa");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idEntrega", id));
            cmd.Connection = cnn;

            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                ept.IDEntrega = obdr.GetInt32(0);
                ept.Vendedor = DatosRepartidor.getRepartido(obdr.GetInt32(1));
                ept.Client = DatosCliente.getCliente(obdr.GetInt32(2));
                ept.FechaEntrega = obdr.GetDateTime(3);
                //Asigno valor a la cuenta
                // pro.Add(new EntregaProductoTerminado(obdr.GetInt32(0), DatosVendedores.getVendedor(obdr.GetInt32(1)), DatosCliente.getCliente(obdr.GetInt32(2)), obdr.GetDateTime(3)));

            }
            //Cierro la conexion
            cnn.Close();
            return ept;
        }

        /*public static List<DetalleEntrega> getListaDetalleEntrega(int idEntrega)
        {
            List<DetalleEntrega> de = new List<DetalleEntrega>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT idEntrega,idProducto, cantidad FROM DetalleEntrega WHERE idEntrega = @idEntrega");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idEntrega", idEntrega));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            { //DatosEntregaProductoTerminado.getEntregaProductoTerminado(obdr.GetInt32(0)),
                de.Add(new DetalleEntrega(DatosProducto.getProducto(obdr.GetInt32(1)), obdr.GetInt32(2)));
            }

            cnn.Close();

            return de;
        }*/


        public static void Crear(EntregaProductoTerminado eprod)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into EntregaProductoTerminado (idVendedor,idEmpresa,fechaEntrega) values (@idVendedor,@idEmpresa,@fechaEntrega)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idVendedor", eprod.Vendedor.Id));
            cmd.Parameters.Add(new SqlParameter("@idEmpresa", eprod.Client.Id));
            cmd.Parameters.Add(new SqlParameter("@fechaEntrega", eprod.FechaEntrega));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("SELECT max(idEntrega) FROM EntregaProductoTerminado");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                eprod.IDEntrega = obdr.GetInt32(0);
            }

            foreach (DetalleEntrega de in eprod.DE)
            {
                DatosDetalleEntrega.Crear(de, eprod.IDEntrega);
            }
            cnn.Close();
        }


        public static List<EntregaProductoTerminado> BuscarByFecha(DateTime fechaEntrega, DateTime fecha_hasta)
        {

            List<EntregaProductoTerminado> Lista = new List<EntregaProductoTerminado>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                "select  idEntrega, idVendedor, idEmpresa, fechaEntrega from EntregaProductoTerminado where fechaEntrega BETWEEN '%{0}%' and '%{1}%'", fechaEntrega, fecha_hasta), conexion);


                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    EntregaProductoTerminado ept = new EntregaProductoTerminado();
                    ept.IDEntrega = reader.GetInt32(0);
                    ept.Vendedor = DatosRepartidor.getRepartido(reader.GetInt32(1));
                    ept.Client = DatosCliente.getCliente(reader.GetInt32(2));
                    ept.FechaEntrega = reader.GetDateTime(3);

                    Lista.Add(ept);

                }
                conexion.Close();
                return Lista;

            }

        }

        public static ArrayList GetBuscarByFecha(DateTime fecha_desde, DateTime fecha_hasta)
        {

            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //creo la lista para almacenar las personas
            ArrayList listaventa = new ArrayList();
            //Creo el comando sql a utlizar


            SqlCommand comando = new SqlCommand("select  idEntrega, idVendedor, idEmpresa, fechaEntrega from EntregaProductoTerminado where fechaEntrega between @fecha_desde and  @fecha_hasta order by fechaEntrega DESC");
            comando.Parameters.Add(new SqlParameter("@fecha_desde", fecha_desde));
            comando.Parameters.Add(new SqlParameter("@fecha_hasta", fecha_hasta));
            comando.Connection = cnn;

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                EntregaProductoTerminado ept = new EntregaProductoTerminado();
                ept.IDEntrega = reader.GetInt32(0);
                ept.Vendedor = DatosRepartidor.getRepartido(reader.GetInt32(1));
                ept.Client = DatosCliente.getCliente(reader.GetInt32(2));
                ept.FechaEntrega = reader.GetDateTime(3);

                listaventa.Add(ept);

            }
            cnn.Close();
            return listaventa;

        }



    }
}
