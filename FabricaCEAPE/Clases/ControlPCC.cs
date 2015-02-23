    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class ControlPCC
    {
        int idControlPCC;
        Producto producto;
        Usuario usuario;
        int pesoNeto;
        int unidadPorCaja;
        DateTime fechaElaboracionCaja;
        DateTime fechaVencimientoCaja;
        string lotePouch;
        string loteCaja;
        bool rneRnpa;
        bool colorFormaOlor;
        int densidad;
        int secadoHumedad;
        bool envasadoGranel;
        bool envasadoPouch1;
        bool envasadoPouch2;
        string observaciones;
        DateTime hora;

        public ControlPCC()
        { }

        public ControlPCC(int idControlPCC, Producto Producto, Usuario Usuario, int pesoNeto, int unidadPorCaja, DateTime fechaElaboracionCaja, DateTime fechaVencimientoCaja, string lotePouch, string loteCaja, bool rneRnpa, bool colorFormaOlor, int densidad, int secadoHumedad, bool envasadoGranel, bool envasadoPouch1, bool envasadoPouch2, string observaciones, DateTime hora)
        {
            this.idControlPCC = idControlPCC;
            this.producto = Producto;
            this.usuario = Usuario;
            this.pesoNeto = pesoNeto;
            this.unidadPorCaja = unidadPorCaja;
            this.fechaElaboracionCaja = fechaElaboracionCaja;
            this.fechaVencimientoCaja = fechaVencimientoCaja;
            this.lotePouch = lotePouch;
            this.loteCaja = loteCaja;
            this.rneRnpa = rneRnpa;
            this.colorFormaOlor = colorFormaOlor;
            this.densidad = densidad;
            this.secadoHumedad = secadoHumedad;
            this.envasadoGranel = envasadoGranel;
            this.envasadoPouch1 = envasadoPouch1;
            this.envasadoPouch2 = envasadoPouch2;
            this.observaciones = observaciones;
            this.hora = hora;
        }

        public int IdControlPCC
        {
            get { return idControlPCC; }
            set { idControlPCC = value; }
        }

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int PesoNeto
        {
            get { return pesoNeto; }
            set { pesoNeto = value; }
        }

        public int UnidadPorCaja
        {
            get { return unidadPorCaja; }
            set { unidadPorCaja = value; }
        }

        public DateTime FechaElaboracionCaja
        {
            get { return fechaElaboracionCaja; }
            set { fechaElaboracionCaja = value; }
        }

        public DateTime FechaVencimientoCaja
        {
            get { return fechaVencimientoCaja; }
            set { fechaVencimientoCaja = value; }
        }

        public string LotePouch
        {
            get { return lotePouch; }
            set { lotePouch = value; }
        }
        
        public string LoteCaja
        {
            get { return loteCaja; }
            set { loteCaja = value; }
        }

        public bool RneRnpa
        {
            get { return rneRnpa; }
            set { rneRnpa = value; }
        }

        public bool ColorFormaOlor
        {
            get { return colorFormaOlor; }
            set { colorFormaOlor = value; }
        }

        public int Densidad
        {
            get { return densidad; }
            set { densidad = value; }
        }

        public int SecadoHumedad
        {
            get { return secadoHumedad; }
            set { secadoHumedad = value; }
        }

        public bool EnvasadoGranel
        {
            get { return envasadoGranel; }
            set { envasadoGranel = value; }
        }

        public bool EnvasadoPouch1
        {
            get { return envasadoPouch1; }
            set { envasadoPouch1 = value; }
        }

        public bool EnvasadoPouch2
        {
            get { return envasadoPouch2; }
            set { envasadoPouch2 = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }
    }
}
