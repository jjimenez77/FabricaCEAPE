using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Receta
    {
        int id;
        Producto producto;
        string observaciones;
        string tiempo;
        string temperatura;
        string otros;
        DateTime fechaCreacion;
        Usuario usuario;
        bool activo;

        public Receta()
        { }

        public Receta(int id, Producto producto, string observaciones, string tiempo, string temperatura, string otros, DateTime fechaCreacion, Usuario usuario, bool activo)
        {
            this.id = id;
            this.producto = producto;
            this.observaciones = observaciones;
            this.tiempo = tiempo;
            this.temperatura = temperatura;
            this.otros = otros;
            this.fechaCreacion = fechaCreacion;
            this.usuario = usuario;
            this.activo = activo;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public string Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        public string Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public string Otros
        {
            get { return otros; }
            set { otros = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public override string ToString()
        {
            return producto.Nombre;
        }
    }
}
