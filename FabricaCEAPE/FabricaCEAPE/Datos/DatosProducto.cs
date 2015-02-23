using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
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

            SqlCommand cmd = new SqlCommand("SELECT * FROM Producto");
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<Producto> pro = new List<Producto>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                pro.Add(new Producto(obdr.GetInt32(0), DatosTipoProducto.getTipoProducto(obdr.GetInt32(1)), obdr.GetString(2), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetInt32(6), obdr.GetDecimal(7), obdr.GetString(8), obdr.GetInt32(9), float.Parse(obdr.GetDouble(10).ToString()), DatosMedida.getMedida(obdr.GetInt32(11)), obdr.GetInt32(12),DatosTipoEnvasado.getTipoEnvasado(obdr.GetInt32(13)),DatosSeleccionProducto.getSeleccionProducto(obdr.GetInt32(14))));
                
            }
            //Cierro la conexion
            cnn.Close();
            return pro;
        }

        public static Producto getProducto(int idProducto)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Producto Where idProducto = @idProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", idProducto));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Producto prod = new Producto();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //zona = new Zona(obdr.GetInt32(0), obdr.GetString(1),  DatosLocalidad.getLocalidad(obdr.GetInt32(2)));
                prod.IdProducto = obdr.GetInt32(0);
                prod.Tipo = DatosTipoProducto.getTipoProducto(obdr.GetInt32(1));
                prod.Nombre = obdr.GetString(2);
                prod.FechaElaboracion = obdr.GetDateTime(3);
                prod.FechaVencimiento = obdr.GetDateTime(4);
                prod.LoteProductoTerminado = obdr.GetString(5);
                prod.CajasPorTarima = obdr.GetInt32(6);
                prod.KgPorTarima = obdr.GetDecimal(7);
                prod.CodigoBarraProducto = obdr.GetString(8);
                prod.Stock = obdr.GetInt32(9);
                //prod.Gramaje = obdr.GetFloat(10);
                prod.UnidadM = DatosMedida.getMedida(obdr.GetInt32(11));
                prod.UnidadPorCaja = obdr.GetInt32(12);
                prod.Envasado = DatosTipoEnvasado.getTipoEnvasado(obdr.GetInt32(13));
                prod.SelProducto = DatosSeleccionProducto.getSeleccionProducto(obdr.GetInt32(14));
                
                
            }
            cnn.Close();
            return prod;

        }

        public static void Eliminar(Producto prod)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Producto Where idProducto = @idProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", prod.IdProducto));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(Producto prod)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Producto set idTipoProducto = @idTipoProducto, nombre = @nombre, fechaElaboracion = @fechaElaboracion, fechaVencimiento = @fechaVencimiento, loteProductoTerminado =  @loteProductoTerminado, cajasPorTarima = @cajasPorTarima, kgPorTarima = @kgPorTarima, codigoBarraProducto = @codigoBarraProducto, stock = @stock , gramaje= @gramaje, idUnidadDeMedida= @idUnidadDeMedida, unidadPorCaja= @unidadPorCaja,idTipoEnvasado = @idTipoEnvasado, idSeleccion = @idSeleccion Where idProducto = @idProducto");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", prod.IdProducto));
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", prod.Tipo.IdTipoProducto));
            cmd.Parameters.Add(new SqlParameter("@nombre", prod.Nombre));
            cmd.Parameters.Add(new SqlParameter("@fechaElaboracion", prod.FechaElaboracion));
            cmd.Parameters.Add(new SqlParameter("@fechaVencimiento", prod.FechaVencimiento));
            cmd.Parameters.Add(new SqlParameter("@loteProductoTerminado", prod.LoteProductoTerminado));
            cmd.Parameters.Add(new SqlParameter("@cajasPorTarima", prod.CajasPorTarima));
            cmd.Parameters.Add(new SqlParameter("@kgPorTarima", prod.KgPorTarima));
            cmd.Parameters.Add(new SqlParameter("@codigoBarraProducto", prod.CodigoBarraProducto));
            cmd.Parameters.Add(new SqlParameter("@stock", prod.Stock));
            cmd.Parameters.Add(new SqlParameter("@gramaje", prod.Gramaje));
            cmd.Parameters.Add(new SqlParameter("@idUnidadDeMedida", prod.UnidadM.Id));
            cmd.Parameters.Add(new SqlParameter("@unidadPorCaja", prod.UnidadPorCaja));
            cmd.Parameters.Add(new SqlParameter("@idTipoEnvasado",prod.Envasado.IdTipoEnvasado));
            cmd.Parameters.Add(new SqlParameter("@idSeleccion",prod.SelProducto.IdSeleccionProducto));
            
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Producto prod)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Producto (idTipoProducto,nombre,fechaElaboracion,fechaVencimiento,loteProductoTerminado,cajasPorTarima,kgPorTarima,codigoBarraProducto,stock,gramaje,idUnidadDeMedida,unidadPorCaja,idTipoEnvasado,idSeleccion) values (@idTipoProducto,@nombre,@fechaElaboracion,@fechaVencimiento,@loteProductoTerminado,@cajasPorTarima,@kgPorTarima,@codigoBarraProducto,@stock,@gramaje,@idUnidadDeMedida,@unidadPorCaja,@idTipoEnvasado, @idSeleccion)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", prod.Tipo.IdTipoProducto));
            cmd.Parameters.Add(new SqlParameter("@nombre", prod.Nombre));
            cmd.Parameters.Add(new SqlParameter("@fechaElaboracion", prod.FechaElaboracion));
            cmd.Parameters.Add(new SqlParameter("@fechaVencimiento", prod.FechaVencimiento));
            cmd.Parameters.Add(new SqlParameter("@loteProductoTerminado", prod.LoteProductoTerminado));
            cmd.Parameters.Add(new SqlParameter("@cajasPorTarima", prod.CajasPorTarima));
            cmd.Parameters.Add(new SqlParameter("@kgPorTarima",prod.KgPorTarima));
            cmd.Parameters.Add(new SqlParameter("@codigoBarraProducto", prod.CodigoBarraProducto));
            cmd.Parameters.Add(new SqlParameter("@stock", prod.Stock));
            cmd.Parameters.Add(new SqlParameter("@gramaje", prod.Gramaje));
            cmd.Parameters.Add(new SqlParameter("@idUnidadDeMedida", prod.UnidadM.Id));
            cmd.Parameters.Add(new SqlParameter("@unidadPorCaja", prod.UnidadPorCaja));
            cmd.Parameters.Add(new SqlParameter("@idTipoEnvasado", prod.Envasado.IdTipoEnvasado));
            cmd.Parameters.Add(new SqlParameter("@idSeleccion", prod.SelProducto.IdSeleccionProducto));
            
          
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
            //SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Zona WHERE idZona=@Id");
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Producto WHERE nombre=@nombre");
                
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


        public static List<Producto> BuscarProducto(String nombre)
        {

            List<Producto> Lista = new List<Producto>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select idProducto, idTipoProducto,  nombre, fechaElaboracion, fechaVencimiento,loteProductoTerminado, cajasPorTarima, kgPorTarima,codigoBarraProducto,stock,gramaje,idUnidadDeMedida,unidadPorCaja,idTipoEnvasado,idSeleccion from Producto where nombre like '%{0}%'", nombre), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.IdProducto = reader.GetInt32(0);
                    p.Tipo = DatosTipoProducto.getTipoProducto(reader.GetInt32(1));
                    p.Nombre = reader.GetString(2);
                    p.FechaElaboracion = reader.GetDateTime(3);
                    p.FechaVencimiento = reader.GetDateTime(4);
                    p.LoteProductoTerminado = reader.GetString(5);
                    p.CajasPorTarima = reader.GetInt32(6);
                    p.KgPorTarima = reader.GetDecimal(7);
                    p.CodigoBarraProducto = reader.GetString(8);
                    p.Stock = reader.GetInt32(9);
                    
                    p.Gramaje = float.Parse(reader.GetDouble(10).ToString());
                    p.UnidadM = DatosMedida.getMedida(reader.GetInt32(11));
                    p.UnidadPorCaja = reader.GetInt32(12);
                    p.Envasado = DatosTipoEnvasado.getTipoEnvasado(reader.GetInt32(13));
                    p.SelProducto = DatosSeleccionProducto.getSeleccionProducto(reader.GetInt32(14));


                    //pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                    Lista.Add(p);

                }
                conexion.Close();
                return Lista;

            }

        }

        public static List<Producto> BuscarByLote(String loteProductoTerminado)
        {

            List<Producto> Lista = new List<Producto>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select idProducto, idTipoProducto,  nombre, fechaElaboracion, fechaVencimiento,loteProductoTerminado, cajasPorTarima, kgPorTarima,codigoBarraProducto,stock,gramaje,idUnidadDeMedida,unidadPorCaja,idTipoEnvasado,idSeleccion from Producto where loteProductoTerminado like '%{0}%'", loteProductoTerminado), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.IdProducto = reader.GetInt32(0);
                    p.Tipo = DatosTipoProducto.getTipoProducto(reader.GetInt32(1));
                    p.Nombre = reader.GetString(2);
                    p.FechaElaboracion = reader.GetDateTime(3);
                    p.FechaVencimiento = reader.GetDateTime(4);
                    p.LoteProductoTerminado = reader.GetString(5);
                    p.CajasPorTarima = reader.GetInt32(6);
                    p.KgPorTarima = reader.GetDecimal(7);
                    p.CodigoBarraProducto = reader.GetString(8);
                    p.Stock = reader.GetInt32(9);

                    p.Gramaje = float.Parse(reader.GetDouble(10).ToString());
                    p.UnidadM = DatosMedida.getMedida(reader.GetInt32(11));
                    p.UnidadPorCaja = reader.GetInt32(12);
                    p.Envasado = DatosTipoEnvasado.getTipoEnvasado(reader.GetInt32(13));
                    p.SelProducto = DatosSeleccionProducto.getSeleccionProducto(reader.GetInt32(14));


                    //pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                    Lista.Add(p);

                }
                conexion.Close();
                return Lista;

            }

        }

        public static List<Producto> BuscarByCodigoBarra(String codigoBarraProducto)
        {

            List<Producto> Lista = new List<Producto>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select idProducto, idTipoProducto,  nombre, fechaElaboracion, fechaVencimiento,loteProductoTerminado, cajasPorTarima, kgPorTarima,codigoBarraProducto,stock,gramaje,idUnidadDeMedida,unidadPorCaja,idTipoEnvasado,idSeleccion from Producto where codigoBarraProducto like '%{0}%'", codigoBarraProducto), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto p = new Producto();
                    p.IdProducto = reader.GetInt32(0);
                    p.Tipo = DatosTipoProducto.getTipoProducto(reader.GetInt32(1));
                    p.Nombre = reader.GetString(2);
                    p.FechaElaboracion = reader.GetDateTime(3);
                    p.FechaVencimiento = reader.GetDateTime(4);
                    p.LoteProductoTerminado = reader.GetString(5);
                    p.CajasPorTarima = reader.GetInt32(6);
                    p.KgPorTarima = reader.GetDecimal(7);
                    p.CodigoBarraProducto = reader.GetString(8);
                    p.Stock = reader.GetInt32(9);

                    p.Gramaje = float.Parse(reader.GetDouble(10).ToString());
                    p.UnidadM = DatosMedida.getMedida(reader.GetInt32(11));
                    p.UnidadPorCaja = reader.GetInt32(12);
                    p.Envasado = DatosTipoEnvasado.getTipoEnvasado(reader.GetInt32(13));
                    p.SelProducto = DatosSeleccionProducto.getSeleccionProducto(reader.GetInt32(14));


                    //pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                    Lista.Add(p);

                }
                conexion.Close();
                return Lista;

            }

        }

        public static void CambiarStock(int idProducto, int stock)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Producto set  stock=@stock where idProducto = @idProducto");
            cmd.Parameters.Add(new SqlParameter("@idProducto", idProducto));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static void InsertarStock(int idProducto, int stock)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Producto set  stock=@stock where idProducto = @idProducto");
            cmd.Parameters.Add(new SqlParameter("@idProducto", idProducto));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();

            cnn.Close();

        }

        public static void ActualizarStock(int idProducto, int stock)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Producto set  stock=@stock where idProducto = @idProducto");
            cmd.Parameters.Add(new SqlParameter("@idProducto", idProducto));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));

            cmd.Connection = cnn;

            cmd.ExecuteNonQuery();

            cnn.Close();

        }


      
    }
}
