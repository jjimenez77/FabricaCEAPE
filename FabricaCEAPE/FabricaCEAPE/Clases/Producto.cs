using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class Producto
    {
        private int idProducto;
        private TipoProducto tipo;
        private string nombre;
        private DateTime fechaElaboracion;
        private DateTime fechaVencimiento;
        private string loteProductoTerminado;
        private int cajasPorTarima;
        private decimal kgPorTarima;
        private string codigoBarraProducto;
        private int stock;
        private float gramaje;
        private Medida unidadM;
        private int unidadPorCaja;
        private TipoEnvasado envasado;  //pouch o granel
        private SeleccionProducto selproducto; // 1era, 2da y productos con observaciones



        public Producto()
        {

        }
        public Producto(int idProducto, int stock)
        {
            this.idProducto = idProducto;
            this.stock = stock;
        }

        public Producto(int idProducto, TipoProducto tipo, string nombre, DateTime fechaElaboracion, DateTime fechaVencimiento, string loteProductoTerminado, int cajasPorTarima, decimal kgPorTarima, string codigoBarraProducto, int stock, float gramaje, Medida unidadM, int unidadPorCaja, TipoEnvasado envasado, SeleccionProducto selproducto)
        {
            this.idProducto = idProducto;
            this.tipo = tipo;
            this.nombre = nombre;
            this.fechaElaboracion = fechaElaboracion;
            this.fechaVencimiento = fechaVencimiento;
            this.loteProductoTerminado = loteProductoTerminado;
            this.cajasPorTarima = cajasPorTarima;
            this.kgPorTarima = kgPorTarima;
            this.codigoBarraProducto = codigoBarraProducto;
            this.stock = stock;
            this.gramaje = gramaje;
            this.unidadM = unidadM;
            this.unidadPorCaja = unidadPorCaja;
            this.envasado = envasado;
            this.selproducto = selproducto;

        }



        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public TipoProducto Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string NombreTipoProducto
        {
            get { return tipo.Nombre; }
            set { tipo.Nombre = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaElaboracion
        {
            get { return fechaElaboracion; }
            set { fechaElaboracion = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return FechaElaboracion; }
            set { FechaElaboracion = value; }
        }

        public string LoteProductoTerminado
        {
            get { return loteProductoTerminado; }
            set { loteProductoTerminado = value; }
        }

        public int CajasPorTarima
        {
            get { return cajasPorTarima; }
            set { cajasPorTarima = value; }
        }

        public decimal KgPorTarima
        {
            get { return kgPorTarima; }
            set { kgPorTarima = value; }
        }

        public string CodigoBarraProducto
        {
            get { return codigoBarraProducto; }
            set { codigoBarraProducto = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public float Gramaje
        {
            get { return gramaje; }
            set { gramaje = value; }
        }
        public int UnidadPorCaja
        {
            get { return unidadPorCaja; }
            set { unidadPorCaja = value; }
        }
        public Medida UnidadM
        {
            get { return unidadM; }
            set { unidadM = value; }
        }

        public string GramajeMedida
        {
            get { return gramaje + "[" + unidadM.Abreviacion + "]"; }
        }
        public string Medida
        {
            get { return unidadM.Abreviacion; }
            //set { unidad.Abreviatura = value; }
        }

        public TipoEnvasado Envasado
        {
            get { return envasado; }
            set { envasado = value; }
        }

        public string NombreTipoEnvasado
        {
            get { return envasado.Nombre; }
            set { envasado.Nombre = value; }
        }


        public SeleccionProducto SelProducto
        {
            get { return selproducto; }
            set { selproducto = value; }
        }

        public string NombreSeleccionProducto
        {
            get { return selproducto.Nombre; }
            set { selproducto.Nombre = value; }
        }
    }
}
