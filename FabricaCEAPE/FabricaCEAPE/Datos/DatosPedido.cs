using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosPedido : Conexion
    {
        public static List<Pedido> getPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, concepto, descripcion, fechaCreado, idUsuario, idDepartamento, activo from Pedidos order by fechaEmitido");
            //asigno la conexion al comando


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static Pedido getPedido(int id)
        {
            Pedido p = new Pedido();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where id = @id");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                p.Id =obdr.GetInt32(0);
                p.Concepto = obdr.GetString(1);
                p.Descripcion = obdr.GetString(2);
                p.FechaEmitido = obdr.GetDateTime(3);
                p.Usuario = DatosUsuario.getUsuario(obdr.GetInt32(4));
                p.Departamento = DatosDepartamento.getDepartamento(obdr.GetInt32(5));
                p.Activo = obdr.GetBoolean(6);
            }

            cnn.Close();

            return p;
        }

        public static void Modificar(Pedido p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Pedidos set concepto = @concepto, descripcion = @descripcion, idUsuario = @idUsuario, idDepartamento = @idDepartamento, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", p.Id));
            cmd.Parameters.Add(new SqlParameter("@concepto", p.Concepto));
            cmd.Parameters.Add(new SqlParameter("@descripcion", p.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@idUsuario", p.Usuario.Id));
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", p.Departamento.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Pedido p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Pedidos (concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo) values (@concepto, @descripcion, @fechaEmitido, @idUsuario, @idDepartamento, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@concepto", p.Concepto));
            cmd.Parameters.Add(new SqlParameter("@descripcion", p.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@fechaEmitido", p.FechaEmitido));
            cmd.Parameters.Add(new SqlParameter("@idUsuario", p.Usuario.Id)); 
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", p.Departamento.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(Pedido p)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Pedidos Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", p.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static int getUltimoPedido()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("Select id from Pedidos where id=IDENT_CURRENT('Pedidos')");
            //Cargo el valor del parametro
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Pedido p = new Pedido();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                p.Id = obdr.GetInt32(0);
                //p.Estado = obdr.GetString(1);
                //p.Concepto = obdr.GetString(2);
                //p.FechaEmitido = obdr.GetDateTime(3);
                //p.FechaAtendido = obdr.GetDateTime(4);
                //p.Usuario = DatosUsuario.getUsuario(obdr.GetInt32(5));
                //p.Departamento = DatosDepartamento.getDepartamento(obdr.GetInt32(6));
            }
            cnn.Close();
            return p.Id;
        }

        public static List<Pedido> getPedidosPorEstadoDepartamentoOrigen(string estado, int idDepartamento)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where idDepartamento = @idDepartamento order by fechaEmitido");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", idDepartamento));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static List<Pedido> getPedidosPorEstadoEnviadosUsuarioId(int idUsuario)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where idUsuario = @idUsuario order by fechaEmitido DESC;");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static List<Pedido> getPedidosPorEstadoRecibidosUsuarioId(int idDepartamento)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where idDepartamento = @idDepartamento order by activo desc, fechaEmitido desc;");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", idDepartamento));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        //public static List<Pedido> getPedidosPorDepartamento(int id)
        //{
        //    List<Provincia> provincias = new List<Provincia>();
        //    SqlConnection cnn = new SqlConnection(conexion);
        //    //abro la conexion
        //    cnn.Open();

        //    //Creo el comando sql a utlizar
        //    SqlCommand cmd = new SqlCommand("select id, nombre, idPais from Provincia where idPais = @id order by id, nombre");
        //    //asigno la conexion al comando
        //    cmd.Parameters.Add(new SqlParameter("@id", id));


        //    cmd.Connection = cnn;
        //    //creo el datareader
        //    SqlDataReader obdr = cmd.ExecuteReader();
        //    //recorro el datareader
        //    while (obdr.Read())
        //    {
        //        provincias.Add(new Provincia(obdr.GetInt32(0), obdr.GetString(1), DatosPais.getPais(obdr.GetInt32(2))));
        //    }

        //    cnn.Close();

        //    return provincias;
        //}

        public static List<Pedido> getPedidosPorEstadoRecibidosUsuarioIdConcepto(int idDepartamento, string nombre)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where idDepartamento = @idDepartamento and concepto like '%{0}%' order by activo desc, fechaEmitido desc", nombre));

            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", idDepartamento));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static List<Pedido> getPedidosPorEstadoRecibidosUsuarioIdDescripcion(int idDepartamento, string nombre)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where idDepartamento = @idDepartamento and descripcion like '%{0}%' order by activo desc, fechaEmitido desc", nombre));

            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", idDepartamento));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static List<Pedido> getPedidosPorEstadoRecibidosUsuarioIdDepartamentoOrigen(int idDepartamento, string nombre)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select Pedidos.id, Pedidos.concepto, Pedidos.descripcion, Pedidos.fechaEmitido, Pedidos.idUsuario, Pedidos.idDepartamento, Pedidos.activo from Pedidos left join Usuarios on Pedidos.idUsuario = Usuarios.id left join Departamentos on Usuarios.idDepartamento = Departamentos.id where Pedidos.idDepartamento = @idDepartamento and Departamentos.nombre like '%{0}%' order by Pedidos.activo desc, Pedidos.fechaEmitido desc", nombre));

            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idDepartamento", idDepartamento));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static List<Pedido> getPedidosPorEstadoEnviadosUsuarioIdConcepto(int idUsuario, string nombre)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where idUsuario = @idUsuario and concepto like '%{0}%' order by activo desc, fechaEmitido desc", nombre));

            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static List<Pedido> getPedidosPorEstadoEnviadosUsuarioIdDescripcion(int idUsuario, string nombre)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, concepto, descripcion, fechaEmitido, idUsuario, idDepartamento, activo from Pedidos where idUsuario = @idUsuario and descripcion like '%{0}%' order by activo desc, fechaEmitido desc", nombre));

            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }

        public static List<Pedido> getPedidosPorEstadoEnviadosUsuarioIdDepartamentoDestino(int idUsuario, string nombre)
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select Pedidos.id, Pedidos.concepto, Pedidos.descripcion, Pedidos.fechaEmitido, Pedidos.idUsuario, Pedidos.idDepartamento, Pedidos.activo from Pedidos left join Usuarios on Pedidos.idUsuario = Usuarios.id left join Departamentos on Pedidos.idDepartamento = Departamentos.id where Pedidos.idUsuario = @idUsuario and Departamentos.nombre like '%{0}%' order by Pedidos.activo desc, Pedidos.fechaEmitido desc", nombre));

            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                pedidos.Add(new Pedido(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetDateTime(3), DatosUsuario.getUsuario(obdr.GetInt32(4)), DatosDepartamento.getDepartamento(obdr.GetInt32(5)), obdr.GetBoolean(6)));
            }

            cnn.Close();

            return pedidos;
        }
    }
}
