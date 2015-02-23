using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class MateriaPrima
    {
        int id;
        string nombre;
        double cantidad;
        string lote;
        TipoMateriaPrima tipoMateriaPrima;
        Medida medida;
        Marca marca;
        Proveedor proveedor;
        DateTime fechaIngreso;
        DateTime fechaElaboracion;
        DateTime fechaCaducidad;
        bool activo;

        public MateriaPrima()
        { }

        public MateriaPrima(int id, string nombre, double cantidad, string lote, TipoMateriaPrima tipoMateriaPrima, Medida medida, Marca marca, Proveedor proveedor, DateTime fechaIngreso, DateTime fechaElaboracion, DateTime fechaCaducidad, bool activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.lote = lote;
            this.tipoMateriaPrima = tipoMateriaPrima;
            this.medida = medida;
            this.marca = marca;
            this.proveedor = proveedor;
            this.fechaIngreso = fechaIngreso;
            this.fechaElaboracion = fechaElaboracion;
            this.fechaCaducidad = fechaCaducidad;
            this.activo = activo;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }

        public TipoMateriaPrima TipoMateriaPrima
        {
            get { return tipoMateriaPrima; }
            set { tipoMateriaPrima = value; }
        }
        
        public Medida Medida
        {
            get { return medida; }
            set { medida = value; }
        }

        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }


        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }


        public DateTime FechaElaboracion
        {
            get { return fechaElaboracion; }
            set { fechaElaboracion = value; }
        }


        public DateTime FechaCaducidad
        {
            get { return fechaCaducidad; }
            set { fechaCaducidad = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
