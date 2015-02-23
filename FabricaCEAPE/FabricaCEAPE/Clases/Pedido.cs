using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Datos;

namespace FabricaCEAPE.Clases
{
    class Pedido
    {
        int id;
        string concepto;
        string descripcion;
        DateTime fechaEmitido;
        Usuario usuario;
        Departamento departamento;
        bool activo;

        public Pedido()
        { }

        public Pedido(int id, string concepto, string descripcion, DateTime fechaEmitido, Usuario usuario, Departamento departamento, bool activo)
        {
            this.id = id;
            this.concepto = concepto;
            this.descripcion = descripcion;
            this.fechaEmitido = fechaEmitido;
            this.usuario = usuario;
            this.departamento = departamento;
            this.activo = activo;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime FechaEmitido
        {
            get { return fechaEmitido; }
            set { fechaEmitido = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public Departamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        public string Visto
        {
            get
            {
                if (activo)
                {
                    return "No leido";
                }
                else
                {
                    return "Leido";
                }
            }
        }

        public string DepartamentoDeUsuario
        {
            get { return usuario.Departamento.Nombre.ToString(); }
        }
    }
}
