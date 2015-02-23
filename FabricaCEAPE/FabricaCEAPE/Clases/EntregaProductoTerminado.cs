using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Datos;

namespace FabricaCEAPE.Clases
{
    class EntregaProductoTerminado : Conexion
    {
        int idEntrega;
        Repartidor vendedor;
        Cliente cliente;
        DateTime fechaEntrega;
        List<DetalleEntrega> de;


        public EntregaProductoTerminado()
        {
            de = new List<DetalleEntrega>();
        }
        public EntregaProductoTerminado(int idEntrega, Repartidor vendedor, Cliente cliente, DateTime fechaEntrega)
        {
            this.IDEntrega = idEntrega;
            this.Vendedor = vendedor;
            this.Client = cliente;
            this.fechaEntrega = fechaEntrega;

        }

        public EntregaProductoTerminado(int idEntrega, Repartidor vendedor, Cliente cliente, DateTime fechaEntrega, List<DetalleEntrega> de)
        {
            this.IDEntrega = idEntrega;
            this.Vendedor = vendedor;
            this.Client = cliente;
            this.fechaEntrega = fechaEntrega;
            this.DE = de;
        }

        public int IDEntrega
        {
            get { return idEntrega; }
            set { idEntrega = value; }
        }

        public Repartidor Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        public Cliente Client
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public DateTime FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }

        public string NombreCliente
        {
            get { return cliente.Nombre; }
        }

        public string NombreVendedor
        {
            get { return vendedor.Nombre; }
        }



        public List<DetalleEntrega> DE
        {
            get { return de; }
            set { de = value; }
        }

        //Metodo utilizado para insertar un Venta
        /*
        public string Insertar(EntregaProductoTerminado varEPT, List<DetalleEntrega> detalles)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            //try
            //{
            //1. Establecer la cadena de conexion
            sqlCon.ConnectionString = Conexion.conexion;
            //2. Abrir la conexion de la BD
            sqlCon.Open();
            //3. Establecer la transaccion
            SqlTransaction sqlTra = sqlCon.BeginTransaction();
            //4. Establecer el comando
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon;
            sqlCmd.Transaction = sqlTra;
            sqlCmd.CommandText = "spI_Entrega";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //5. Agregar los parametros al comando
            //Establecemos los valores para el parametro @codigoVenta del Procedimiento Almacenado
            SqlParameter sqlParidEntrega = new SqlParameter();
            sqlParidEntrega.ParameterName = "@idEntrega";
            sqlParidEntrega.SqlDbType = SqlDbType.Int;
            sqlParidEntrega.Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add(sqlParidEntrega); //Agregamos el parametro al comando

            //Establecemos los valores para el parametro @cliente del Procedimiento Almacenado
            SqlParameter sqlParidVendedor = new SqlParameter();
            sqlParidVendedor.ParameterName = "@idVendedor";
            sqlParidVendedor.SqlDbType = SqlDbType.Int;
            sqlParidVendedor.Size = 100;
            sqlParidVendedor.Value = varEPT.idVendedor;
            sqlCmd.Parameters.Add(sqlParidVendedor); //Agregamos el parametro al comando

            //Establecemos los valores para el parametro @cliente del Procedimiento Almacenado
            SqlParameter sqlParidCliente = new SqlParameter();
            sqlParidCliente.ParameterName = "@idCliente";
            sqlParidCliente.SqlDbType = SqlDbType.Int;
            sqlParidCliente.Size = 100;
            sqlParidCliente.Value = varEPT.idCliente;
            sqlCmd.Parameters.Add(sqlParidCliente); //Agregamos el parametro al comando

            //6. Ejecutamos el commando
            rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el detalle de entrega de forma correcta";
            if (rpta.Equals("OK"))
            {
                //Obtenemos el codigo de la venta que se genero por la base de datos
                this.idEntrega = Convert.ToInt32(sqlCmd.Parameters["@idEntrega"].Value);
                foreach (DetalleEntrega det in detalles)
                {
                    //Establecemos el codigo de la venta que se autogenero
                    det.IDEntrega = this.idEntrega;
                    //Llamamos al metodo insertar de la clase DetalleVenta
                    //y le pasamos la conexion y la transaccion que debe de usar
                    rpta = det.Insertar(det, ref sqlCon, ref sqlTra);
                    if (!rpta.Equals("OK"))
                    {
                        //Si ocurre un error al insertar un detalle de venta salimos del for
                        break;
                    }
                }
            }
            if (rpta.Equals("OK"))
            {
                //Se inserto todo los detalles y confirmamos la transaccion
                sqlTra.Commit();
            }
            else
            {
                //Algun detalle no se inserto y negamos la transaccion
                sqlTra.Rollback();
            }

             return rpta;
        }

        //Obtenemos la venta por el codigo generado
        public DataTable ObtenerEntrega(int idEntrega)
        {
            DataTable dtEntrega = new DataTable("EntregaProductoTerminado");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                sqlCon.ConnectionString = Conexion.conexion;

                //2. Establecer el comando
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
                sqlCmd.CommandText = "spF_Entrega_One";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL

                //3. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoVenta del Procedimiento Almacenado
                SqlParameter sqlParidEntrega = new SqlParameter();
                sqlParidEntrega.ParameterName = "@idEntrega";
                sqlParidEntrega.SqlDbType = SqlDbType.Int;
                sqlParidEntrega.Value = idEntrega;
                sqlCmd.Parameters.Add(sqlParidEntrega); //Agregamos el parametro al comando

                //4. El DataAdapter que va a ejecutar el comando y es el encargado de llena el DataTable
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtEntrega);//Llenamos el DataTable
            }
            catch
            {
                dtEntrega = null;
            }
            return dtEntrega;
        }

        //Obtener todas las ventas
        public DataTable ObtenerEntrega()
        {
            DataTable dtEntrega = new DataTable("EntregaProductoTerminado");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                sqlCon.ConnectionString = Conexion.conexion;

                //2. Establecer el comando
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
                sqlCmd.CommandText = "spF_Entrega_All";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL

                //3. No hay parametros

                //4. El DataAdapter que va a ejecutar el comando y es el encargado de llena el DataTable
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtEntrega);//Llenamos el DataTable
            }
            catch
            {
                dtEntrega = null;
            }
            return dtEntrega;
        }*/
    }
}
