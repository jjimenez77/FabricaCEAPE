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
    class DatosProductoTerminado:Conexion
    {
        public static List<ProductoTerminado> getProductosTerminados()
        {
            List<ProductoTerminado> pro = new List<ProductoTerminado>();
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoTerminado");
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;
                        
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                pro.Add(new ProductoTerminado(obdr.GetInt32(0), DatosTipoProducto.getTipoProducto(obdr.GetInt32(1)), DatosProducto.getProducto(obdr.GetInt32(2)), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetInt32(6), obdr.GetDecimal(7), obdr.GetString(8), obdr.GetInt32(9), obdr.GetInt32(10), DatosMedida.getMedida(obdr.GetInt32(11)), obdr.GetInt32(12),DatosTipoEnvasado.getTipoEnvasado(obdr.GetInt32(13)),DatosSeleccionProducto.getSeleccionProducto(obdr.GetInt32(14))));
                
            }
            //Cierro la conexion
            cnn.Close();
            return pro;
        }

        public static ProductoTerminado getProductoTerminado(int idProductoTerminado)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from ProductoTerminado Where idProductoTerminado = @idProductoTerminado");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProductoTerminado", idProductoTerminado));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            ProductoTerminado prod = new ProductoTerminado();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //zona = new Zona(obdr.GetInt32(0), obdr.GetString(1),  DatosLocalidad.getLocalidad(obdr.GetInt32(2)));
                prod.IdProductoTerminado = obdr.GetInt32(0);
                prod.Tipo = DatosTipoProducto.getTipoProducto(obdr.GetInt32(1));
                prod.Producto = DatosProducto.getProducto(obdr.GetInt32(2));
                prod.FechaElaboracion = obdr.GetDateTime(3);
                prod.FechaVencimiento = obdr.GetDateTime(4);
                prod.LoteProductoTerminado = obdr.GetString(5);
                prod.CajasPorTarima = obdr.GetInt32(6);
                prod.KgPorTarima = obdr.GetDecimal(7);
                prod.CodigoBarraProducto = obdr.GetString(8);
                prod.Stock = obdr.GetInt32(9);
                prod.Gramaje = obdr.GetInt32(10);
                prod.UnidadM = DatosMedida.getMedida(obdr.GetInt32(11));
                prod.UnidadPorCaja = obdr.GetInt32(12);
                prod.Envasado = DatosTipoEnvasado.getTipoEnvasado(obdr.GetInt32(13));
                prod.SelProducto = DatosSeleccionProducto.getSeleccionProducto(obdr.GetInt32(14));
            }
            cnn.Close();
            return prod;
        }

        public static void Eliminar(ProductoTerminado prod)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from ProductoTerminado Where idProductoTerminado = @idProductoTerminado");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProductoTerminado", prod.IdProductoTerminado));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(ProductoTerminado prod)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update ProductoTerminado set idTipoProducto=@idTipoProducto, idProducto=@idProducto, fechaElaboracion=@fechaElaboracion, fechaVencimiento=@fechaVencimiento, loteProductoTerminado=@loteProductoTerminado, cajasPorTarima=@cajasPorTarima, kgPorTarima=@kgPorTarima, codigoBarraProducto=@codigoBarraProducto, stock=@stock , gramaje=@gramaje, idUnidadDeMedida=@idUnidadDeMedida, unidadPorCaja=@unidadPorCaja, idTipoEnvasado=@idTipoEnvasado, idSeleccion=@idSeleccion Where idProductoTerminado=@idProductoTerminado");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProductoTerminado", prod.IdProductoTerminado));
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", prod.Tipo.IdTipoProducto));
            cmd.Parameters.Add(new SqlParameter("@idProducto", prod.Producto.IdProducto));
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

        public static void Crear(ProductoTerminado prod)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into ProductoTerminado (idTipoProducto,idProducto,fechaElaboracion,fechaVencimiento,loteProductoTerminado,cajasPorTarima,kgPorTarima,codigoBarraProducto,stock,gramaje,idUnidadDeMedida,unidadPorCaja,idTipoEnvasado,idSeleccion) values (@idTipoProducto,@idProducto,@fechaElaboracion,@fechaVencimiento,@loteProductoTerminado,@cajasPorTarima,@kgPorTarima,@codigoBarraProducto,@stock,@gramaje,@idUnidadDeMedida,@unidadPorCaja,@idTipoEnvasado, @idSeleccion)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", prod.Tipo.IdTipoProducto));
            cmd.Parameters.Add(new SqlParameter("@idProducto", prod.Producto.IdProducto));
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
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ProductoTerminado left join Producto on ProductoTerminado.idProducto = Producto.idProducto WHERE Producto.nombre=@nombre");
                
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


        public static List<ProductoTerminado> BuscarProducto(String nombre)
        {
            List<ProductoTerminado> productos = new List<ProductoTerminado>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("Select ProductoTerminado.idProductoTerminado, ProductoTerminado.idTipoProducto, ProductoTerminado.idProducto, ProductoTerminado.fechaElaboracion, ProductoTerminado.fechaVencimiento, ProductoTerminado.loteProductoTerminado, ProductoTerminado.cajasPorTarima, ProductoTerminado.kgPorTarima, ProductoTerminado.codigoBarraProducto, ProductoTerminado.stock, ProductoTerminado.gramaje, ProductoTerminado.idUnidadDeMedida, ProductoTerminado.unidadPorCaja, ProductoTerminado.idTipoEnvasado, ProductoTerminado.idSeleccion from ProductoTerminado left join Producto on ProductoTerminado.idProducto = Producto.idProducto WHERE Producto.nombre like '%{0}%'", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                productos.Add(new ProductoTerminado(obdr.GetInt32(0), DatosTipoProducto.getTipoProducto(obdr.GetInt32(1)), DatosProducto.getProducto(obdr.GetInt32(2)), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetInt32(6), obdr.GetDecimal(7), obdr.GetString(8), obdr.GetInt32(9), obdr.GetInt32(10), DatosMedida.getMedida(obdr.GetInt32(11)), obdr.GetInt32(12), DatosTipoEnvasado.getTipoEnvasado(obdr.GetInt32(13)), DatosSeleccionProducto.getSeleccionProducto(obdr.GetInt32(14))));
                
            }
            cnn.Close();
            return productos;
        }

        public static List<ProductoTerminado> BuscarByLote(String loteProductoTerminado)
        {

            List<ProductoTerminado> Lista = new List<ProductoTerminado>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select idProductoTerminado, idTipoProducto,  idProducto, fechaElaboracion, fechaVencimiento,loteProductoTerminado, cajasPorTarima, kgPorTarima,codigoBarraProducto,stock,gramaje,idUnidadDeMedida,unidadPorCaja,idTipoEnvasado,idSeleccion from ProductoTerminado where loteProductoTerminado like '%{0}%'", loteProductoTerminado), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ProductoTerminado p = new ProductoTerminado();
                    p.IdProductoTerminado = reader.GetInt32(0);
                    p.Tipo = DatosTipoProducto.getTipoProducto(reader.GetInt32(1));
                    p.Producto = DatosProducto.getProducto(reader.GetInt32(2));
                    p.FechaElaboracion = reader.GetDateTime(3);
                    p.FechaVencimiento = reader.GetDateTime(4);
                    p.LoteProductoTerminado = reader.GetString(5);
                    p.CajasPorTarima = reader.GetInt32(6);
                    p.KgPorTarima = reader.GetDecimal(7);
                    p.CodigoBarraProducto = reader.GetString(8);
                    p.Stock = reader.GetInt32(9);

                    p.Gramaje = reader.GetInt32(10);
                    p.UnidadM = DatosMedida.getMedida(reader.GetInt32(11));
                    p.UnidadPorCaja = reader.GetInt32(12);
                    p.Envasado = DatosTipoEnvasado.getTipoEnvasado(reader.GetInt32(13));
                    p.SelProducto = DatosSeleccionProducto.getSeleccionProducto(reader.GetInt32(14));

                    Lista.Add(p);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<ProductoTerminado> BuscarByCodigoBarra(String codigoBarraProducto)
        {
            List<ProductoTerminado> productos = new List<ProductoTerminado>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("Select idProductoTerminado, idTipoProducto,  idProducto, fechaElaboracion, fechaVencimiento,loteProductoTerminado, cajasPorTarima, kgPorTarima,codigoBarraProducto,stock,gramaje,idUnidadDeMedida,unidadPorCaja,idTipoEnvasado,idSeleccion from ProductoTerminado where codigoBarraProducto like '%{0}%'", codigoBarraProducto));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                productos.Add(new ProductoTerminado(obdr.GetInt32(0), DatosTipoProducto.getTipoProducto(obdr.GetInt32(1)), DatosProducto.getProducto(obdr.GetInt32(2)), obdr.GetDateTime(3), obdr.GetDateTime(4), obdr.GetString(5), obdr.GetInt32(6), obdr.GetDecimal(7), obdr.GetString(8), obdr.GetInt32(9), obdr.GetInt32(10), DatosMedida.getMedida(obdr.GetInt32(11)), obdr.GetInt32(12), DatosTipoEnvasado.getTipoEnvasado(obdr.GetInt32(13)), DatosSeleccionProducto.getSeleccionProducto(obdr.GetInt32(14))));

            }
            cnn.Close();
            return productos;
        }

        public static void CambiarStock(int idProductoTerminado, int stock)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update ProductoTerminado set  stock=@stock where idProductoTerminado = @idProductoTerminado");
            cmd.Parameters.Add(new SqlParameter("@idProductoTerminado", idProductoTerminado));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));

            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void InsertarStock(int idProductoTerminado, int stock)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update ProductoTerminado set  stock=@stock where idProductoTerminado = @idProductoTerminado");
            cmd.Parameters.Add(new SqlParameter("@idProductoTerminado", idProductoTerminado));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));

            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ActualizarStock(int idProductoTerminado, int stock)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();
            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update ProductoTerminado set  stock=@stock where idProductoTerminado = @idProductoTerminado");
            cmd.Parameters.Add(new SqlParameter("@idProductoTerminado", idProductoTerminado));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));

            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ProductoTerminado left join DetalleEntrega on ProductoTerminado.idProductoTerminado = DetalleEntrega.idProducto where DetalleEntrega.idProducto = @id");

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
    }
}
