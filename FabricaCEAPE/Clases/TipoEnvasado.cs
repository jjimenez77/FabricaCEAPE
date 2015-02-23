using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class TipoEnvasado
    {
        int idTipoEnvasado;
        string nombre;
        bool activo;

        public TipoEnvasado()
        {
        }

        public TipoEnvasado(int idTipoEnvasado, string nombre, bool activo)
        {
            this.idTipoEnvasado = idTipoEnvasado;
            this.nombre = nombre;
            this.activo = activo;
        }

        public int IdTipoEnvasado
        {
            get { return idTipoEnvasado; }
            set { idTipoEnvasado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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