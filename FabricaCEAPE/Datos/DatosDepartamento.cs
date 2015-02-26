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

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Usuarios
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Departamentos left join Usuarios on Departamentos.id = Usuarios.idDepartamento where Usuarios.idDepartamento = @id");
            //Pedidos
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Departamentos left join Pedidos on Departamentos.id = Pedidos.idDepartamento where Pedidos.idDepartamento = @id");

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();

            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Connection = cnn;
            cmd1.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            int count1 = Convert.ToInt32(cmd1.ExecuteScalar());

            if (count == 0 && count1 == 0)
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
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Departamentos where activo = 1 and nombre = @nombre");

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
