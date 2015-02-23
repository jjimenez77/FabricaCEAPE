using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class IngredienteReceta
    {
        int id; 
        MateriaPrimaReceta nombre;      
        double cantidad;
        string descripcion;
        Medida medida;
        Receta receta;

        public IngredienteReceta()
        { }

        public IngredienteReceta(int id, MateriaPrimaReceta nombre, double cantidad, string descripcion, Medida medida, Receta receta)
        {
            this.id = id; 
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.medida = medida;
            this.receta = receta;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public MateriaPrimaReceta Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Medida Medida
        {
            get { return medida; }
            set { medida = value; }
        }
        public Receta Receta
        {
            get { return receta; }
            set { receta = value; }
        }
    }
}
