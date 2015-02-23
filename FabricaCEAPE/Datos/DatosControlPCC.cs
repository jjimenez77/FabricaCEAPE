using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosControlPCC : Conexion
    {
        public static List<ControlPCC> getControles()
        {
            List<ControlPCC> controles = new List<ControlPCC>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select idControlPCC, idProducto, idUsuario, pesoNeto, unidadPorCaja, fechaElaboracionCaja, fechaVencimientoCaja, lotePouch, loteCaja, rneRnpa, colorFormaOlor, densidad, secadoHumedad, envasadoGranel, envasadoPouch1, envasadoPouch2, observaciones, hora from ControlPCC");
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                controles.Add(new ControlPCC(obdr.GetInt32(0), DatosProducto.getProducto(obdr.GetInt32(1)), DatosUsuario.getUsuario(obdr.GetInt32(2)), obdr.GetInt32(3), obdr.GetInt32(4), obdr.GetDateTime(5), obdr.GetDateTime(6), obdr.GetString(7), obdr.GetString(8), obdr.GetBoolean(9), obdr.GetBoolean(10), obdr.GetInt32(11), obdr.GetInt32(12), obdr.GetBoolean(13), obdr.GetBoolean(14), obdr.GetBoolean(15), obdr.GetString(16), obdr.GetDateTime(17)));
            }

            cnn.Close();

            return controles;
        }

        public static ControlPCC getControlPCC(int id)
        {
            ControlPCC c = new ControlPCC();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select idControlPCC, idProducto, idUsuario, pesoNeto, unidadPorCaja, fechaElaboracionCaja, fechaVencimientoCaja, lotePouch, loteCaja, rneRnpa, colorFormaOlor, densidad, secadoHumedad, envasadoGranel, envasadoPouch1, envasadoPouch2, observaciones, hora from ControlPCC where idControlPCC = @id");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                c.IdControlPCC = obdr.GetInt32(0);
                c.Producto = DatosProducto.getProducto(obdr.GetInt32(1));
                c.Usuario = DatosUsuario.getUsuario(obdr.GetInt32(2));
                c.PesoNeto = obdr.GetInt32(3);
                c.UnidadPorCaja = obdr.GetInt32(4);
                c.FechaElaboracionCaja = obdr.GetDateTime(5);
                c.FechaVencimientoCaja = obdr.GetDateTime(6);
                c.LotePouch = obdr.GetString(7);
                c.LoteCaja = obdr.GetString(8);
                c.RneRnpa = obdr.GetBoolean(9);
                c.ColorFormaOlor = obdr.GetBoolean(10);
                c.Densidad = obdr.GetInt32(11);
                c.SecadoHumedad = obdr.GetInt32(12);
                c.EnvasadoGranel = obdr.GetBoolean(13);
                c.EnvasadoPouch1 = obdr.GetBoolean(14);
                c.EnvasadoPouch2 = obdr.GetBoolean(15);
                c.Observaciones = obdr.GetString(16);
                c.Hora = obdr.GetDateTime(17);
            }

            cnn.Close();

            return c;
        }

        public static void Modificar(ControlPCC c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update ControlPCC set idProducto = @idProducto, idUsuario = @idUsuario, pesoNeto = @pesoNeto, unidadPorCaja = @unidadPorCaja, fechaElaboracionCaja = @fechaElaboracionCaja, fechaVencimientoCaja = @fechaVencimientoCaja, lotePouch = @lotePouch, loteCaja = @loteCaja, rneRnpa = @rneRnpa, colorFormaOlor = @colorFormaOlor, densidad = @densidad, secadoHumedad = @secadoHumedad, envasadoGranel = @envasadoGranel, envasadoPouch1 = @envasadoPouch1, envasadoPouch2 = @envasadoPouch2, observaciones = @observaciones, hora = @hora where idControlPCC = @idControlPCC");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idControlPCC", c.IdControlPCC));
            cmd.Parameters.Add(new SqlParameter("@idProducto", c.Producto.IdProducto));
            cmd.Parameters.Add(new SqlParameter("@idUsuario", c.Usuario.Id));
            cmd.Parameters.Add(new SqlParameter("@pesoNeto", c.PesoNeto));
            cmd.Parameters.Add(new SqlParameter("@unidadPorCaja", c.UnidadPorCaja));
            cmd.Parameters.Add(new SqlParameter("@fechaElaboracionCaja", c.FechaElaboracionCaja));
            cmd.Parameters.Add(new SqlParameter("@fechaVencimientoCaja", c.FechaVencimientoCaja));
            cmd.Parameters.Add(new SqlParameter("@lotePouch", c.LotePouch));
            cmd.Parameters.Add(new SqlParameter("@loteCaja", c.LoteCaja));
            cmd.Parameters.Add(new SqlParameter("@rneRnpa", c.RneRnpa));
            cmd.Parameters.Add(new SqlParameter("@colorFormaOlor", c.ColorFormaOlor));
            cmd.Parameters.Add(new SqlParameter("@densidad", c.Densidad));
            cmd.Parameters.Add(new SqlParameter("@secadoHumedad", c.SecadoHumedad));
            cmd.Parameters.Add(new SqlParameter("@envasadoGranel", c.EnvasadoGranel));
            cmd.Parameters.Add(new SqlParameter("@envasadoPouch1", c.EnvasadoPouch1));
            cmd.Parameters.Add(new SqlParameter("@envasadoPouch2", c.EnvasadoPouch2));
            cmd.Parameters.Add(new SqlParameter("@observaciones", c.Observaciones));
            cmd.Parameters.Add(new SqlParameter("@hora", c.Hora));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(ControlPCC c)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into ControlPCC (idProducto, idUsuario, pesoNeto, unidadPorCaja, fechaElaboracionCaja, fechaVencimientoCaja, lotePouch, loteCaja, rneRnpa, colorFormaOlor, densidad, secadoHumedad, envasadoGranel, envasadoPouch1, envasadoPouch2, observaciones, hora) values (@idProducto, @idUsuario, @pesoNeto, @unidadPorCaja, @fechaElaboracionCaja, @fechaVencimientoCaja, @lotePouch, @loteCaja, @rneRnpa, @colorFormaOlor, @densidad, @secadoHumedad, @envasadoGranel, @envasadoPouch1, @envasadoPouch2, @observaciones, @hora)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idProducto", c.Producto.IdProducto));
            cmd.Parameters.Add(new SqlParameter("@idUsuario", c.Usuario.Id));
            cmd.Parameters.Add(new SqlParameter("@pesoNeto", c.PesoNeto));
            cmd.Parameters.Add(new SqlParameter("@unidadPorCaja", c.UnidadPorCaja));
            cmd.Parameters.Add(new SqlParameter("@fechaElaboracionCaja", c.FechaElaboracionCaja));
            cmd.Parameters.Add(new SqlParameter("@fechaVencimientoCaja", c.FechaVencimientoCaja));
            cmd.Parameters.Add(new SqlParameter("@lotePouch", c.LotePouch));
            cmd.Parameters.Add(new SqlParameter("@loteCaja", c.LoteCaja));
            cmd.Parameters.Add(new SqlParameter("@rneRnpa", c.RneRnpa));
            cmd.Parameters.Add(new SqlParameter("@colorFormaOlor", c.ColorFormaOlor));
            cmd.Parameters.Add(new SqlParameter("@densidad", c.Densidad));
            cmd.Parameters.Add(new SqlParameter("@secadoHumedad", c.SecadoHumedad));
            cmd.Parameters.Add(new SqlParameter("@envasadoGranel", c.EnvasadoGranel));
            cmd.Parameters.Add(new SqlParameter("@envasadoPouch1", c.EnvasadoPouch1));
            cmd.Parameters.Add(new SqlParameter("@envasadoPouch2", c.EnvasadoPouch2));
            cmd.Parameters.Add(new SqlParameter("@observaciones", c.Observaciones));
            cmd.Parameters.Add(new SqlParameter("@hora", c.Hora));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Eliminar(ControlPCC c)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from ControlPCC Where idControlPCC = @idControlPCC");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idControlPCC", c.IdControlPCC));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        
        public static List<ControlPCC> getControlesPorUsuario(string nombre) //buscador
        {
            List<ControlPCC> controles = new List<ControlPCC>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select ControlPCC.idProducto, ControlPCC.idProducto, ControlPCC.idUsuario, ControlPCC.pesoNeto, ControlPCC.unidadPorCaja, ControlPCC.fechaElaboracionCaja, ControlPCC.fechaVencimientoCaja, ControlPCC.lotePouch, ControlPCC.loteCaja, ControlPCC.rneRnpa, ControlPCC.ColorFormaOlor, ControlPCC.densidad, ControlPCC.secadoHumedad, ControlPCC.envasadoGranel, ControlPCC.envasadoPouch1, ControlPCC.EnvasadoPouch2, ControlPCC.observaciones, ControlPCC.hora from ControlPCC left join Usuarios on Usuarios.id = ControlPCC.idUsuario where Usuarios.nombre like '%{0}%' order by Usuarios.nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                controles.Add(new ControlPCC(obdr.GetInt32(0), DatosProducto.getProducto(obdr.GetInt32(1)), DatosUsuario.getUsuario(obdr.GetInt32(2)), obdr.GetInt32(3), obdr.GetInt32(4), obdr.GetDateTime(5), obdr.GetDateTime(6), obdr.GetString(7), obdr.GetString(8), obdr.GetBoolean(9), obdr.GetBoolean(10), obdr.GetInt32(11), obdr.GetInt32(12), obdr.GetBoolean(13), obdr.GetBoolean(14), obdr.GetBoolean(15), obdr.GetString(16), obdr.GetDateTime(17)));
            }

            cnn.Close();

            return controles;
        }

        public static List<ControlPCC> getControlesPorProducto(string nombre) //buscador
        {
            List<ControlPCC> controles = new List<ControlPCC>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select ControlPCC.idProducto, ControlPCC.idProducto, ControlPCC.idUsuario, ControlPCC.pesoNeto, ControlPCC.unidadPorCaja, ControlPCC.fechaElaboracionCaja, ControlPCC.fechaVencimientoCaja, ControlPCC.lotePouch, ControlPCC.loteCaja, ControlPCC.rneRnpa, ControlPCC.ColorFormaOlor, ControlPCC.densidad, ControlPCC.secadoHumedad, ControlPCC.envasadoGranel, ControlPCC.envasadoPouch1, ControlPCC.EnvasadoPouch2, ControlPCC.observaciones, ControlPCC.hora from ControlPCC left join Producto on Producto.idProducto = ControlPCC.idProducto where Producto.nombre like '%{0}%' order by Producto.nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                controles.Add(new ControlPCC(obdr.GetInt32(0), DatosProducto.getProducto(obdr.GetInt32(1)), DatosUsuario.getUsuario(obdr.GetInt32(2)), obdr.GetInt32(3), obdr.GetInt32(4), obdr.GetDateTime(5), obdr.GetDateTime(6), obdr.GetString(7), obdr.GetString(8), obdr.GetBoolean(9), obdr.GetBoolean(10), obdr.GetInt32(11), obdr.GetInt32(12), obdr.GetBoolean(13), obdr.GetBoolean(14), obdr.GetBoolean(15), obdr.GetString(16), obdr.GetDateTime(17)));
            }

            cnn.Close();

            return controles;
        }
    }
}
