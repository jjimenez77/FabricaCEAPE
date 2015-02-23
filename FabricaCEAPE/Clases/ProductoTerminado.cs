using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCEAPE.Clases
{
    class ProductoTerminado
    {
        private int idProductoTerminado;
        private TipoProducto tipo;
        private Producto producto;
        private DateTime fechaElaboracion;
        private DateTime fechaVencimiento;
        private string loteProductoTerminado;
        private int cajasPorTarima;
        private decimal kgPorTarima;
        private string codigoBarraProducto;
        private int stock;
        private int gramaje;
        private Medida unidadM;
        private int unidadPorCaja;
        private TipoEnvasado envasado;  //pouch o granel
        private SeleccionProducto selproducto; // 1era, 2da y productos con observaciones

        public ProductoTerminado()
        {
        }

        public ProductoTerminado(int idProductoTerminado, int stock)
        {
            this.idProductoTerminado = idProductoTerminado;
            this.stock = stock;
        }

        public ProductoTerminado(int idProductoTerminado, TipoProducto tipo, Producto producto, DateTime fechaElaboracion, DateTime fechaVencimiento, string loteProductoTerminado, int cajasPorTarima, decimal kgPorTarima, string codigoBarraProducto, int stock, int gramaje, Medida unidadM, int unidadPorCaja, TipoEnvasado envasado, SeleccionProducto selproducto)
        {
            this.idProductoTerminado = idProductoTerminado;
            this.tipo = tipo;
            this.producto = producto;
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

        public int IdProductoTerminado
        {
            get { return idProductoTerminado; }
            set { idProductoTerminado = value; }
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

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public DateTime FechaElaboracion
        {
            get { return fechaElaboracion; }
            set { fechaElaboracion = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
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

        public int Gramaje
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
            get { return gramaje + " " + unidadM.Abreviacion + "."; }
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

        public override string ToString()
        {
            return producto.Nombre;
        }
    }
}