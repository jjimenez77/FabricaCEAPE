using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Clases;

namespace FabricaCEAPE.Datos
{
    class DatosProveedor : Conexion
    {
        public static List<Proveedor> getProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, nombreDeContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idLocalidad, activo from Proveedores where activo = 1 order by nombre");
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosLocalidad.getLocalidad(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }

            cnn.Close();

            return proveedores;
        }

        public static Proveedor getProveedor(int id)
        {
            Proveedor p = new Proveedor();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select id, nombre, nombreDeContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idLocalidad, activo from Proveedores where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                p.NombreDeContacto = obdr.GetString(2);
                p.Cuit = obdr.GetString(3);
                p.NumeroTelefono = obdr.GetString(4);
                p.NumeroCelular = obdr.GetString(5);
                p.CorreoElectronico = obdr.GetString(6);
                p.FechaInicio = obdr.GetDateTime(7);
                p.Direccion = obdr.GetString(8);
                p.Localidad = DatosLocalidad.getLocalidad(obdr.GetInt32(9));
                p.Activo = obdr.GetBoolean(10);
            }

            cnn.Close();

            return p;
        }

        public static void Modificar(Proveedor p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("update Proveedores set nombre = @nombre, nombreDeContacto = @nombreDeContacto, cuit = @cuit, numeroTelefono = @numeroTelefono, numeroCelular = @numeroCelular, correoElectronico = @correoElectronico, fechaInicio = @fechaInicio, direccion = @direccion, idLocalidad = @idLocalidad, activo = @activo Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", p.Id));
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@nombreDeContacto", p.NombreDeContacto));
            cmd.Parameters.Add(new SqlParameter("@cuit", p.Cuit));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", p.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", p.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", p.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@fechaInicio", p.FechaInicio));
            cmd.Parameters.Add(new SqlParameter("@direccion", p.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", p.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Crear(Proveedor p)
        {
            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("insert into Proveedores (nombre, nombreDeContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idLocalidad, activo) values (@nombre, @nombreDeContacto, @cuit, @numeroTelefono, @numeroCelular, @correoElectronico, @fechaInicio, @direccion, @idLocalidad, @activo)");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SqlParameter("@nombreDeContacto", p.NombreDeContacto));
            cmd.Parameters.Add(new SqlParameter("@cuit", p.Cuit));
            cmd.Parameters.Add(new SqlParameter("@numeroTelefono", p.NumeroTelefono));
            cmd.Parameters.Add(new SqlParameter("@numeroCelular", p.NumeroCelular));
            cmd.Parameters.Add(new SqlParameter("@correoElectronico", p.CorreoElectronico));
            cmd.Parameters.Add(new SqlParameter("@fechaInicio", p.FechaInicio));
            cmd.Parameters.Add(new SqlParameter("@direccion", p.Direccion));
            cmd.Parameters.Add(new SqlParameter("@idLocalidad", p.Localidad.Id));
            cmd.Parameters.Add(new SqlParameter("@activo", p.Activo));
            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void Eliminar(Proveedor p)
        {

            //creo la conexion
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("delete from Proveedores Where id = @id");
            //Cargo el valor del parametro
            cmd.Parameters.Add(new SqlParameter("@id", p.Id));

            //asigno la conexion al comando
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static List<Proveedor> getProveedoresPorPais(int id)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("select Proveedores.id, Proveedores.nombre, Proveedores.nombreDeContacto, Proveedores.cuit, Proveedores.numeroTelefono, Proveedores.numeroCelular, Proveedores.correoElectronico, Proveedores.fechaInicio, Proveedores.direccion, Proveedores.idLocalidad, Proveedores.activo from Proveedores INNER JOIN Localidades on Proveedores.idLocalidad=Localidades.id INNER JOIN Provincias on Localidades.idProvincia=Provincias.id INNER JOIN Paises on Provincias.idPais=Paises.id where idPais = @id order by nombre");
            //asigno la conexion al comando
            cmd.Parameters.Add(new SqlParameter("@id", id));


            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosLocalidad.getLocalidad(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }

            cnn.Close();

            return proveedores;
        }

        public static List<Proveedor> getProveedoresPorNombre(string nombre)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre, nombreDeContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idLocalidad, activo from Proveedores where activo = 1 and nombre like '%{0}%' order by nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosLocalidad.getLocalidad(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }

            cnn.Close();

            return proveedores;
        }

        public static List<Proveedor> getProveedoresPorContacto(string nombre)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre, nombreDeContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idLocalidad, activo from Proveedores where activo = 1 and nombreDeContacto like '%{0}%' order by nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosLocalidad.getLocalidad(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }

            cnn.Close();

            return proveedores;
        }

        public static List<Proveedor> getProveedoresPorCuit(string nombre)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select id, nombre, nombreDeContacto, cuit, numeroTelefono, numeroCelular, correoElectronico, fechaInicio, direccion, idLocalidad, activo from Proveedores where activo = 1 and cuit like '%{0}%' order by nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosLocalidad.getLocalidad(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }

            cnn.Close();

            return proveedores;
        }

        public static List<Proveedor> getProveedoresPorProvincia(string nombre)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select Proveedores.id, Proveedores.nombre, Proveedores.nombreDeContacto, Proveedores.cuit, Proveedores.numeroTelefono, Proveedores.numeroCelular, Proveedores.correoElectronico, Proveedores.fechaInicio, Proveedores.direccion, Proveedores.idLocalidad, Proveedores.activo from Proveedores left join Localidades on Proveedores.idLocalidad = Localidades.id left join Provincias on Localidades.idProvincia = Provincias.id where Proveedores.activo = 1 and Provincias.nombre like '%{0}%' order by Proveedores.nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosLocalidad.getLocalidad(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }

            cnn.Close();

            return proveedores;
        }

        public static List<Proveedor> getProveedoresPorPais(string nombre)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            SqlConnection cnn = new SqlConnection(conexion);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand(string.Format("select Proveedores.id, Proveedores.nombre, Proveedores.nombreDeContacto, Proveedores.cuit, Proveedores.numeroTelefono, Proveedores.numeroCelular, Proveedores.correoElectronico, Proveedores.fechaInicio, Proveedores.direccion, Proveedores.idLocalidad, Proveedores.activo from Proveedores left join Localidades on Proveedores.idLocalidad = Localidades.id left join Provincias on Localidades.idProvincia = Provincias.id left join Paises on Provincias.idPais = Paises.id where Proveedores.activo = 1 and Paises.nombre like '%{0}%' order by Proveedores.nombre", nombre));
            //asigno la conexion al comando

            cmd.Connection = cnn;
            //creo el datareader
            SqlDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader
            while (obdr.Read())
            {
                proveedores.Add(new Proveedor(obdr.GetInt32(0), obdr.GetString(1), obdr.GetString(2), obdr.GetString(3), obdr.GetString(4), obdr.GetString(5), obdr.GetString(6), obdr.GetDateTime(7), obdr.GetString(8), DatosLocalidad.getLocalidad(obdr.GetInt32(9)), obdr.GetBoolean(10)));
            }

            cnn.Close();

            return proveedores;
        }

        public static bool enUso(int id)
        {
            SqlConnection cnn = new SqlConnection(Conexion.Connection);
            //abro la conexion
            cnn.Open();

            //Creo el comando sql a utlizar
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Proveedores left join MateriasPrimas on Proveedores.id = MateriasPrimas.idProveedor where MateriasPrimas.idProveedor = @id");

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
