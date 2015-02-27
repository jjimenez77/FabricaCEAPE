using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosMateriaPrima : Conexion
    {
        public static List<MateriaPrima> getMateriasPrimas()
        {
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, cantidad, lote, idTipoMateriaPrima, idMedida, idMarca, idProveedor, fechaIngreso, fechaElaboracion, fechaCaducidad, activo from MateriasPrimas where activo = 1 order by fechaIngreso");
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                materiaPrimas.Add(new MateriaPrima(obdr.GetInt32(0), obdr.GetString(1), obdr.GetDouble(2), obdr.GetString(3), DatosTipoMateriaPrima.getTipoMateriaPrima(obdr.GetInt32(4)), DatosMedida.getMedida(obdr.GetInt32(5)), DatosMarca.getMarca(obdr.GetInt32(6)), DatosProveedor.getProveedor(obdr.GetInt32(7)), obdr.GetDateTime(8), obdr.GetDateTime(9), obdr.GetDateTime(10), obdr.GetBoolean(11)));
            }

            cnn.Close();

            return materiaPrimas;
        }

        public static MateriaPrima getMateriaPrima(int id)
        {
            MateriaPrima mp = new MateriaPrima();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, cantidad, lote, idTipoMateriaPrima, idMedida, idMarca, idProveedor, fechaIngreso, fechaElaboracion, fechaCaducidad, activo from MateriasPrimas where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                mp.Id = obdr.GetInt32(0);
                mp.Nombre = obdr.GetString(1);
                mp.Cantidad =obdr.GetDouble(2);
                mp.Lote = obdr.GetString(3);
                mp.TipoMateriaPrima = DatosTipoMateriaPrima.getTipoMateriaPrima(obdr.GetInt32(4));
                mp.Medida = DatosMedida.getMedida(obdr.GetInt32(5));
                mp.Marca = DatosMarca.getMarca(obdr.GetInt32(6));
                mp.Proveedor = DatosProveedor.getProveedor(obdr.GetInt32(7));
                mp.FechaIngreso = obdr.GetDateTime(8);
                mp.FechaElaboracion = obdr.GetDateTime(9);
                mp.FechaCaducidad = obdr.GetDateTime(10);
                mp.Activo = obdr.GetBoolean(11);
            }

            cnn.Close();

            return mp;
        }

        public static void Modificar(MateriaPrima mp)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update MateriasPrimas set nombre = @nombre, cantidad = @cantidad, lote = @lote, idTipoMateriaPrima = @idTipoMateriaPrima, idMedida = @idMedida, idMarca = @idMarca, idProveedor = @idProveedor, fechaIngreso = @fechaIngreso, fechaElaboracion = @fechaElaboracion, fechaCaducidad = @fechaCaducidad, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", mp.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", mp.Nombre));
            cmd.Parameters.Add(new SqlParameter("@cantidad", mp.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@lote", mp.Lote));
            cmd.Parameters.Add(new SqlParameter("@idTipoMateriaPrima", mp.TipoMateriaPrima.Id));
            cmd.Parameters.Add(new SqlParameter("@idMedida", mp.Medida.Id));
            cmd.Parameters.Add(new SqlParameter("@idMarca", mp.Marca.Id));
            cmd.Parameters.Add(new SqlParameter("@idProveedor", mp.Proveedor.Id));
            cmd.Parameters.Add(new SqlParameter("@fechaIngreso", mp.FechaIngreso));
            cmd.Parameters.Add(new SqlParameter("@fechaElaboracion", mp.FechaElaboracion));
            cmd.Parameters.Add(new SqlParameter("@fechaCaducidad", mp.FechaCaducidad));
            cmd.Parameters.Add(new SqlParameter("@activo", mp.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(MateriaPrima mp)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into MateriasPrimas (nombre, cantidad, lote, idTipoMateriaPrima, idMedida, idMarca, idProveedor, fechaIngreso, fechaElaboracion, fechaCaducidad, activo) values (@nombre, @cantidad, @lote, @idTipoMateriaPrima, @idMedida, @idMarca, @idProveedor, @fechaIngreso, @fechaElaboracion, @fechaCaducidad, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", mp.Nombre));
            cmd.Parameters.Add(new SqlParameter("@cantidad", mp.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@lote", mp.Lote));
            cmd.Parameters.Add(new SqlParameter("@idTipoMateriaPrima", mp.TipoMateriaPrima.Id));
            cmd.Parameters.Add(new SqlParameter("@idMedida", mp.Medida.Id));
            cmd.Parameters.Add(new SqlParameter("@idMarca", mp.Marca.Id));
            cmd.Parameters.Add(new SqlParameter("@idProveedor", mp.Proveedor.Id));
            cmd.Parameters.Add(new SqlParameter("@fechaIngreso", mp.FechaIngreso));
            cmd.Parameters.Add(new SqlParameter("@fechaElaboracion", mp.FechaElaboracion));
            cmd.Parameters.Add(new SqlParameter("@fechaCaducidad", mp.FechaCaducidad));
            cmd.Parameters.Add(new SqlParameter("@activo", mp.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Eliminar(MateriaPrima mp)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from MateriasPrimas Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", mp.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<MateriaPrima> getMateriaPrimaPorTipo(int idTipoMateriaPrima)
        {
            List<MateriaPrima> materiasPrima = new List<MateriaPrima>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, cantidad, lote, idTipoMateriaPrima, idMedida, idMarca, idProveedor, fechaIngreso, fechaElaboracion, fechaCaducidad, activo from MateriasPrimas where activo = 1 and idTipoMateriaPrima = @idTipoMateriaPrima order by nombre");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@idTipoMateriaPrima", idTipoMateriaPrima));

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                materiasPrima.Add(new MateriaPrima(obdr.GetInt32(0), obdr.GetString(1), obdr.GetDouble(2), obdr.GetString(3), DatosTipoMateriaPrima.getTipoMateriaPrima(obdr.GetInt32(4)), DatosMedida.getMedida(obdr.GetInt32(5)), DatosMarca.getMarca(obdr.GetInt32(6)), DatosProveedor.getProveedor(obdr.GetInt32(7)), obdr.GetDateTime(8), obdr.GetDateTime(9), obdr.GetDateTime(10), obdr.GetBoolean(11)));
            }

            cnn.Close();

            return materiasPrima;
        }

        public static List<MateriaPrima> getMateriasPrimasPorNombre(string nombre) //buscador
        {
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select MateriasPrimas.id, MateriasPrimas.nombre, MateriasPrimas.cantidad, MateriasPrimas.lote, MateriasPrimas.idTipoMateriaPrima, MateriasPrimas.idMedida, MateriasPrimas.idMarca, MateriasPrimas.idProveedor, MateriasPrimas.fechaIngreso, MateriasPrimas.fechaElaboracion, MateriasPrimas.fechaCaducidad, MateriasPrimas.activo from MateriasPrimas where MateriasPrimas.activo = 1 and MateriasPrimas.nombre like '%{0}%' order by MateriasPrimas.nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                materiaPrimas.Add(new MateriaPrima(obdr.GetInt32(0), obdr.GetString(1), obdr.GetDouble(2), obdr.GetString(3), DatosTipoMateriaPrima.getTipoMateriaPrima(obdr.GetInt32(4)), DatosMedida.getMedida(obdr.GetInt32(5)), DatosMarca.getMarca(obdr.GetInt32(6)), DatosProveedor.getProveedor(obdr.GetInt32(7)), obdr.GetDateTime(8), obdr.GetDateTime(9), obdr.GetDateTime(10), obdr.GetBoolean(11)));
            }

            cnn.Close();

            return materiaPrimas;
        }

        public static List<MateriaPrima> getMateriasPrimasPorTipo(string nombre) //buscador
        {
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select MateriasPrimas.id, MateriasPrimas.nombre, MateriasPrimas.cantidad, MateriasPrimas.lote, MateriasPrimas.idTipoMateriaPrima, MateriasPrimas.idMedida, MateriasPrimas.idMarca, MateriasPrimas.idProveedor, MateriasPrimas.fechaIngreso, MateriasPrimas.fechaElaboracion, MateriasPrimas.fechaCaducidad, MateriasPrimas.activo from MateriasPrimas left join TiposMateriaPrima on TiposMateriaPrima.id = MateriasPrimas.idTipoMateriaPrima where MateriasPrimas.activo = 1 and TiposMateriaPrima.nombre like '%{0}%' or TiposMateriaPrima.nombre like '%{0}%' order by MateriasPrimas.nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                materiaPrimas.Add(new MateriaPrima(obdr.GetInt32(0), obdr.GetString(1), obdr.GetDouble(2), obdr.GetString(3), DatosTipoMateriaPrima.getTipoMateriaPrima(obdr.GetInt32(4)), DatosMedida.getMedida(obdr.GetInt32(5)), DatosMarca.getMarca(obdr.GetInt32(6)), DatosProveedor.getProveedor(obdr.GetInt32(7)), obdr.GetDateTime(8), obdr.GetDateTime(9), obdr.GetDateTime(10), obdr.GetBoolean(11)));
            }

            cnn.Close();

            return materiaPrimas;
        }

        public static List<MateriaPrima> getMateriasPrimasPorProveedor(string nombre) //buscador
        {
            List<MateriaPrima> materiaPrimas = new List<MateriaPrima>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select MateriasPrimas.id, MateriasPrimas.nombre, MateriasPrimas.cantidad, MateriasPrimas.lote, MateriasPrimas.idTipoMateriaPrima, MateriasPrimas.idMedida, MateriasPrimas.idMarca, MateriasPrimas.idProveedor, MateriasPrimas.fechaIngreso, MateriasPrimas.fechaElaboracion, MateriasPrimas.fechaCaducidad, MateriasPrimas.activo from MateriasPrimas left join Proveedores on Proveedores.id = MateriasPrimas.idProveedor where MateriasPrimas.activo = 1 and Proveedores.nombre like '%{0}%' order by MateriasPrimas.nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                materiaPrimas.Add(new MateriaPrima(obdr.GetInt32(0), obdr.GetString(1), obdr.GetDouble(2), obdr.GetString(3), DatosTipoMateriaPrima.getTipoMateriaPrima(obdr.GetInt32(4)), DatosMedida.getMedida(obdr.GetInt32(5)), DatosMarca.getMarca(obdr.GetInt32(6)), DatosProveedor.getProveedor(obdr.GetInt32(7)), obdr.GetDateTime(8), obdr.GetDateTime(9), obdr.GetDateTime(10), obdr.GetBoolean(11)));
            }

            cnn.Close();

            return materiaPrimas;
        }
    }
}
