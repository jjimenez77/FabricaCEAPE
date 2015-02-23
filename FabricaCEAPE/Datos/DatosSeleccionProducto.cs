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
    class DatosSeleccionProducto
    {
        public static List<SeleccionProducto> getSeleccionProductos()
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM SeleccionProducto ");
            //SqlCommand cmd = new SqlCommand("SELECT Zona.nombre, Localidad.nombre as NombreLocalidad FROM Zona, Localidad where Zona.idLocalidad=Localidad.idLocalidad");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<SeleccionProducto> tp = new List<SeleccionProducto>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                tp.Add(new SeleccionProducto(obdr.GetInt32(0), obdr.GetString(1),obdr.GetString(2)));

            }
            //Cierro la conexion
            cnn.Close();
            return tp;
        }

        public static SeleccionProducto getSeleccionProducto(int idSeleccion)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select idSeleccion, nombre, observacion from SeleccionProducto Where idSeleccion = @idSeleccion");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@idSeleccion", idSeleccion));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            SeleccionProducto tp = new SeleccionProducto();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                
                tp.IdSeleccionProducto = obdr.GetInt32(0);
                tp.Nombre = obdr.GetString(1);
                tp.Observacion = obdr.GetString(2);
                
            }
            cnn.Close();
            return tp;

        }
    }
}
