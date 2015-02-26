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
    class DatosCliente
    {
        public static List<Cliente> getClientes()
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT idCliente, nombre, nombreContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idZona, activo FROM Cliente WHERE activo = 1 order by nombre");
            //SqlCommand cmd = new SqlCommand("SELECT idEmpresa, nombreEmpresa, contacto, cuit, telefono, celular, email1, email2, direccion, idLocalidad, fechaInicioCompra, cop, idZona FROM Empresa ");
            //asigno la conexion al comando
            cmd.Connection = cnn;

            List<Cliente> cl = new List<Cliente>();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                //Asigno valor a la cuenta
                cl.Add(new Cliente(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosZona.getZona(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }
            //Cierro la conexion
            cnn.Close();
            return cl;
        }

        public static Cliente getCliente(int id)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Cliente WHERE idCliente = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Cliente cl = new Cliente();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                cl.Id = obdr.GetInt32(0);
                cl.Nombre = obdr.GetString(1);
                cl.NombreDeContacto = obdr.GetString(2);
                cl.Cuit = obdr.GetString(3);
                cl.NumeroTelefono = obdr.GetString(4);
                cl.NumeroCelular = obdr.GetString(5);
                cl.CorreoElectronico = obdr.GetString(6);
                cl.FechaInicio = obdr.GetDateTime(7);
                cl.Direccion = obdr.GetString(8);
                cl.Zona = DatosZona.getZona(obdr.GetInt32(9));
                cl.Activo = obdr.GetBoolean(10);
            }
            cnn.Close();
            return cl;
        }

        public static Cliente getClienteByCuit(string cuit)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select * from Cliente WHERE activo = 1 AND cuit like 'cuit' order by nombre");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@cuit", cuit));
            //asigno la conexion al comando
            cmd.Connection = cnn;

            Cliente cl = new Cliente();
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                cl.Id = obdr.GetInt32(0);
                cl.Nombre = obdr.GetString(1);
                cl.NombreDeContacto = obdr.GetString(2);
                cl.Cuit = obdr.GetString(3);
                cl.NumeroTelefono = obdr.GetString(4);
                cl.NumeroCelular = obdr.GetString(5);
                cl.CorreoElectronico = obdr.GetString(6);
                cl.FechaInicio = obdr.GetDateTime(7);
                cl.Direccion = obdr.GetString(8);
                cl.Zona = DatosZona.getZona(obdr.GetInt32(9));
                cl.Activo = obdr.GetBoolean(10);
            }
            cnn.Close();
            return cl;
        }

        public static void Eliminar(Cliente cl)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Cliente Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", cl.Id));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Modificar(Cliente cl)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Cliente set nombre = @nombre, nombreContacto = @nombreContacto, cuit = @cuit, numeroTelefono = @numeroTelefono, numeroCelular = @numeroCelular, correoElectronico = @correoElectronico, fechaInicio = @fechaInicio, direccion = @direccion, idZona = @idZona, activo = @activo Where idCliente = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", cl.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", cl.Nombre));
            cmd.Parameters.Add(new SqlParameter("@nombreContacto", cl.NombreDeContacto));
            cmd.Parameters.Add(new SqlParameter("@cuit", cl.Cuit));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", cl.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", cl.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", cl.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@fechaInicio", cl.FechaInicio));
            cmd.Parameters.Add(new SqlParameter("@direccion", cl.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idZona", cl.Zona.IdZona));
            cmd.Parameters.Add(new SqlParameter("@activo", cl.Activo));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Cliente cl)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Cliente (nombre, nombreContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idZona, activo) values (@nombre, @nombreContacto, @cuit, @numeroTelefono, @numeroCelular, @correoElectronico, @fechaInicio, @direccion, @idZona, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", cl.Nombre));
            cmd.Parameters.Add(new SqlParameter("@nombreContacto", cl.NombreDeContacto));
            cmd.Parameters.Add(new SqlParameter("@cuit", cl.Cuit));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", cl.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", cl.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", cl.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@fechaInicio", cl.FechaInicio));
            cmd.Parameters.Add(new SqlParameter("@direccion", cl.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idZona", cl.Zona.IdZona));
            cmd.Parameters.Add(new SqlParameter("@activo", cl.Activo));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static bool Existe(string nombreEmpresa)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            //SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Zona WHERE idZona=@Id");
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cliente WHERE nombre=@nombre and activo = 1");

            cmd.Parameters.AddWithValue("nombre", nombreEmpresa);
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            //cnn.Close();

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }

        public static List<Cliente> BuscarNombreCliente(String nombreEmpresa)
        {
            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                "select * from Cliente where nombre like '%{0}%' and activo = 1 order by nombre", nombreEmpresa), conexion);
                SqlDataReader obdr = comando.ExecuteReader();

                while (obdr.Read())
                {
                    Cliente cl = new Cliente();
                    cl.Id = obdr.GetInt32(0);
                    cl.Nombre = obdr.GetString(1);
                    cl.NombreDeContacto = obdr.GetString(2);
                    cl.Cuit = obdr.GetString(3);
                    cl.NumeroTelefono = obdr.GetString(4);
                    cl.NumeroCelular = obdr.GetString(5);
                    cl.CorreoElectronico = obdr.GetString(6);
                    cl.FechaInicio = obdr.GetDateTime(7);
                    cl.Direccion = obdr.GetString(8);
                    cl.Zona = DatosZona.getZona(obdr.GetInt32(9));
                    cl.Activo = obdr.GetBoolean(10);

                    Lista.Add(cl);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Cliente> BuscarCuit(String cuit)
        {
            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                "select * from Cliente where cuit like '%{0}%' and activo = 1 order by nombre", cuit), conexion);
                SqlDataReader obdr = comando.ExecuteReader();

                while (obdr.Read())
                {
                    Cliente cl = new Cliente();
                    cl.Id = obdr.GetInt32(0);
                    cl.Nombre = obdr.GetString(1);
                    cl.NombreDeContacto = obdr.GetString(2);
                    cl.Cuit = obdr.GetString(3);
                    cl.NumeroTelefono = obdr.GetString(4);
                    cl.NumeroCelular = obdr.GetString(5);
                    cl.CorreoElectronico = obdr.GetString(6);
                    cl.FechaInicio = obdr.GetDateTime(7);
                    cl.Direccion = obdr.GetString(8);
                    cl.Zona = DatosZona.getZona(obdr.GetInt32(9));
                    cl.Activo = obdr.GetBoolean(10);

                    Lista.Add(cl);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Cliente> BuscarZona(String NombreZona)
        {
            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                "select Cliente.idCliente, Cliente.nombre, Cliente.nombreContacto, Cliente.cuit, Cliente.numeroTelefono, Cliente.numeroCelular, Cliente.correoElectronico, Cliente.fechaInicio, Cliente.direccion, Cliente.idZona, Cliente.activo from Cliente join Zona on Cliente.idZona = Zona.idZona and Cliente.activo = 1 and Zona.nombre like '%{0}%' order by nombre", NombreZona), conexion);
                SqlDataReader obdr = comando.ExecuteReader();

                while (obdr.Read())
                {
                    Cliente cl = new Cliente();
                    cl.Id = obdr.GetInt32(0);
                    cl.Nombre = obdr.GetString(1);
                    cl.NombreDeContacto = obdr.GetString(2);
                    cl.Cuit = obdr.GetString(3);
                    cl.NumeroTelefono = obdr.GetString(4);
                    cl.NumeroCelular = obdr.GetString(5);
                    cl.CorreoElectronico = obdr.GetString(6);
                    cl.FechaInicio = obdr.GetDateTime(7);
                    cl.Direccion = obdr.GetString(8);
                    cl.Zona = DatosZona.getZona(obdr.GetInt32(9));
                    cl.Activo = obdr.GetBoolean(10);

                    Lista.Add(cl);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<Cliente> BuscarContacto(String contacto)
        {
            List<Cliente> Lista = new List<Cliente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Connection))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format(
                "select * from Cliente where nombreContacto like '%{0}%' and activo = 1 order by nombre", contacto), conexion);
                SqlDataReader obdr = comando.ExecuteReader();

                while (obdr.Read())
                {
                    Cliente cl = new Cliente();
                    cl.Id = obdr.GetInt32(0);
                    cl.Nombre = obdr.GetString(1);
                    cl.NombreDeContacto = obdr.GetString(2);
                    cl.Cuit = obdr.GetString(3);
                    cl.NumeroTelefono = obdr.GetString(4);
                    cl.NumeroCelular = obdr.GetString(5);
                    cl.CorreoElectronico = obdr.GetString(6);
                    cl.FechaInicio = obdr.GetDateTime(7);
                    cl.Direccion = obdr.GetString(8);
                    cl.Zona = DatosZona.getZona(obdr.GetInt32(9));
                    cl.Activo = obdr.GetBoolean(10);

                    Lista.Add(cl);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes left join EntregaProductoTerminado on Clientes.id = EntregaProductoTerminado.idEmpresa where EntregaProductoTerminado.idEmpresa = @id");

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
