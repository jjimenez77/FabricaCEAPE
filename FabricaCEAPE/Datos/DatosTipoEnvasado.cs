using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;

namespace FabricaCEAPE.Datos
{
    class DatosTipoEnvasado
    {
        public static List<TipoEnvasado> getTipoEnvasados()
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TipoEnvasado where activo = 1 order by nombre ");
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<TipoEnvasado> tp = new List<TipoEnvasado>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                tp.Add(new TipoEnvasado(obdr.GetInt32(0), obdr.GetString(1), obdr.GetBoolean(2)));

            }
            //Cierro la conexion
            cnn.Close();
            return tp;
        }

        public static TipoEnvasado getTipoEnvasado(int idTipoEnvasado)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from TipoEnvasado where idTipoEnvasado = @idTipoEnvasado order by nombre");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idTipoEnvasado", idTipoEnvasado));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            TipoEnvasado tp = new TipoEnvasado();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                tp.IdTipoEnvasado = obdr.GetInt32(0);
                tp.Nombre = obdr.GetString(1);
                tp.Activo = obdr.GetBoolean(2);
            }
            cnn.Close();
            return tp;
        }

        public static void Modificar(TipoEnvasado tp)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update TipoEnvasado set nombre = @nombre, activo = @activo Where idTipoEnvasado = @idTipoEnvasado");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idTipoProducto", tp.IdTipoEnvasado));
            cmd.Parameters.Add(new SqlParameter("@nombre", tp.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", tp.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(TipoEnvasado tp)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into TipoEnvasado (nombre, activo) values (@nombre, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", tp.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", tp.Activo));

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

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TipoEnvasado left join ProductoTerminado on TipoEnvasado.idTipoEnvasado = ProductoTerminado.idProductoTerminado where ProductoTerminado.idProductoTerminado = @id");

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

        public static bool existe(string nombre)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TipoEnvasado where activo = 1 and nombre = @nombre");

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
