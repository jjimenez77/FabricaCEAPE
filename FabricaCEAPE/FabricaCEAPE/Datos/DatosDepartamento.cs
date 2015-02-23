using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosDepartamento : Conexion
    {
        public static List<Departamento> getDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select id, nombre, activo from Departamentos where activo = 1 order by nombre");
            cmd.Connection = cnn;
            SqlDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                departamentos.Add(new Departamento(obdr.GetInt32(0), obdr.GetString(1), obdr.GetBoolean(2)));
            }
            cnn.Close();
            return departamentos;
        }

        public static Departamento getDepartamento(int id)
        {
            Departamento d = new Departamento();
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select id, nombre, activo from Departamentos where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Connection = cnn;
            SqlDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                d.Id = obdr.GetInt32(0);
                d.Nombre = obdr.GetString(1);
                d.Activo = obdr.GetBoolean(2);
            }
            cnn.Close();
            return d;
        }

        public static void Modificar(Departamento d)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("update Departamentos set nombre = @nombre, activo = @activo Where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", d.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", d.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", d.Activo));
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Departamento d)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into Departamentos (nombre, activo) values (@nombre, @activo)");
            cmd.Parameters.Add(new SqlParameter("@nombre", d.Nombre));
            cmd.Parameters.Add(new SqlParameter("@activo", d.Activo));
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void Eliminar(Departamento d)
        {
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("delete from Departamentos Where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", d.Id));
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
