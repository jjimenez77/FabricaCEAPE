using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;
using System.Text.RegularExpressions;

namespace FabricaCEAPE.Vistas
{
    public partial class FrmEntregaProducto : Form
    {
        internal int codigoProductoSeleccionado = -1;
        private decimal StockActual = 0;

        public FrmEntregaProducto(int idEntrega)
        {
            InitializeComponent();
            entregaProductoTerminadoBindingSource.Add(new EntregaProductoTerminado());
            cargarVendedores();
            cargarProductos();
            cargarClientes();
        }

        private void FrmEntregaProducto_Load(object sender, EventArgs e)
        {

            this.numCantidad.Value = 1;
            //this.crearTabla();*/

        }

        private void limpiarControles()
        {
            this.txtTotalCantidad.Text = string.Empty;
            this.codigoProductoSeleccionado = -1;
            this.txtTotalCajas.Text = "0.00";
            this.txtStock.Text = string.Empty;
            this.txtTipoProducto.Text = string.Empty;
            this.numCantidad.Value = 1;
            this.crearTabla();

        }

        private void crearTabla()
        {


        }   

        public void cargarVendedores()
        {
            repartidorBindingSource.DataSource = DatosRepartidor.getRepartidores();
        }

        public void cargarProductos()
        {
            productoBindingSource.DataSource = DatosProducto.getProductos();
        }

        public void cargarClientes()
        {
            clienteBindingSource.DataSource = DatosCliente.getClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //if (numCantidad.Value != 0)
            if (!Validaciones())
                return;
            //if (numCantidad.Value != 0)
            //{

            try
            {
                if (cbProducto != null) // hay que verificar que el producto no este seleccionado siempre
                {

                    Producto p = (Producto)productoBindingSource.Current;
                    int c = int.Parse(numCantidad.Value.ToString());
                    //c -= Convert.ToInt32(this.txtStock.Text);
                    DetalleEntrega ept = new DetalleEntrega(p, c);

                    ((EntregaProductoTerminado)entregaProductoTerminadoBindingSource.Current).DE.Add(ept);
                    detalleEntregaBindingSource.Add(ept);


                    //this.txtTotalCantidad += subTotal;
                    //this.StockActual = subTotal;
                    //this.txtTotalCantidad.Text += numCantidad.Value;
                    //this.txtTotalCantidad.Text = "" + StockActual.ToString("#0.00#");

                }

            }
            catch
            {
                MessageBox.Show("No seleciono ningun Producto", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            //}
            /*else
            {
                DialogResult result = MessageBox.Show("El campo de cantidad no puede ser vacio", "Informacion", MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }

                else if (result == DialogResult.Retry)
                {
                    //MessageBox.Show("Vuelva a Intentarlo");
                    return;

                }
            }*/
          
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTipoProducto.Text = ((Producto)cbProducto.SelectedItem).NombreTipoProducto.ToString();
            txtStock.Text = ((Producto)cbProducto.SelectedItem).Stock.ToString();
            this.numCantidad.Value = 1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGDetalle.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Antes de enviar el pedido debe seleccionar algun Producto", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {

                    EntregaProductoTerminado ept = (EntregaProductoTerminado)entregaProductoTerminadoBindingSource.Current;
                    ept.Vendedor = (Repartidor)repartidorBindingSource.Current;
                    ept.Client = (Cliente)clienteBindingSource.Current;
                    DateTime fecha = DateTime.Now;
                    //ept.FechaEntrega =  dtFechaEntrega.Value;
                    ept.FechaEntrega = fecha;




                    //if (dtGDetalle != null)
                    if (ept.IDEntrega == 0)
                    {

                        //Producto p = (Producto)productoBindingSource.Current;
                        if (MessageBox.Show("Esta seguro de querer enviar estos productos?", "Enviar Productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            DatosEntregaProductoTerminado.Crear(ept);
                            DatosProducto.CambiarStock(((Producto)productoBindingSource.Current).IdProducto, ((Producto)productoBindingSource.Current).Stock - ((DetalleEntrega)detalleEntregaBindingSource.Current).Cantidad);


                            MessageBox.Show("Los productos se enviaron con exito!!");
                            Actualizar();
                        }

                    }
                    else
                    {

                        //es para cambiar a modificar
                        //DatosEntregaProductoTerminado.Crear(ept);

                        if (MessageBox.Show("La grilla esta Vacia, No tiene ningun producto añadido", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                    Close();
                }


            }
            catch
            {
                MessageBox.Show("La grilla esta Vacia", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtGDetalle != null)
                {


                    int fil = dtGDetalle.CurrentRow.Index;

                    dtGDetalle.Rows.RemoveAt(fil);

                    Producto p = (Producto)productoBindingSource.Current;
                    int c = int.Parse(numCantidad.Value.ToString());
                    //c -= Convert.ToInt32(this.txtStock.Text);
                    DetalleEntrega ept = new DetalleEntrega(p, c);

                    ((EntregaProductoTerminado)entregaProductoTerminadoBindingSource.Current).DE.Remove(ept);
                    detalleEntregaBindingSource.Remove(ept);

                    //esto es para sumar el total de cajas a enviar
                    double sum = 0;
                    int i = this.dtGDetalle.RowCount;
                    for (int x = 0; x < i; x++)
                    {
                        sum = sum + double.Parse(dtGDetalle[1, x].Value.ToString());

                    }

                    this.txtTotalCajas.Text = sum.ToString();


                }
            }
            catch
            {
                MessageBox.Show("La grilla esta Vacia", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void cbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            codigoProductoSeleccionado = Convert.ToInt32(this.cbProducto.SelectedItem);

            this.Hide();
        }

        private void mError(string mensaje)
        {
            MessageBox.Show(this, mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnagregar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //consulta();
                if (!Validaciones())
                    return;

                //subTotal = Convert.ToDecimal(this.txtStock.Text) - numCantidad.Value;
                decimal subTotal = Convert.ToDecimal(this.txtStock.Text) - numCantidad.Value;
                //subTotal = Decimal.Parse(txtTotalCantidad.Text);


                //this.txtTotalCantidad += subTotal;
                this.StockActual = subTotal;

                //this.txtTotalCantidad.Text += numCantidad.Value;    
                this.txtTotalCantidad.Text = "" + StockActual.ToString("#0.00#");

                //esto es para sumar el total de cajas a enviar
                double sum = 0;
                int i = this.dtGDetalle.RowCount;
                for (int x = 0; x < i; x++)
                {
                    sum = sum + double.Parse(dtGDetalle[1, x].Value.ToString());
                }

                this.txtTotalCajas.Text = sum.ToString();
                this.numCantidad.Value = 1;
            }
            catch
            {

            }
        }

        public void Actualizar()
        {
            cargarVendedores();
            cargarProductos();
            cargarClientes();
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            //consulta();
            if (!Validaciones())
                return;
        }

        private void consulta()
        {

            bool result = true;
            int may = int.Parse(this.numCantidad.Value.ToString());
            int men = Convert.ToInt32(this.txtStock.Text);
            //c -= Convert.ToInt32(this.txtStock.Text);

            //se compra ambas cantidades 
            if (may >= men)
            {
                errorProvider1.SetError(numCantidad, "La cantidad a agregar debe ser menor al Stock actuals");
                result = false;


                //this.numCantidad.Value = 1;
                //MessageBox.Show("fecha fin debe ser superior");
            }
            else
            {
                errorProvider1.SetError(numCantidad, String.Empty);
                numCantidad.BackColor = Color.Honeydew;
            }

        }

        private bool Validaciones()
        {
            bool result = true;
            try
            {

                if (numCantidad.Value != 0)
                {
                    int may = int.Parse(this.numCantidad.Value.ToString());
                    int men = Convert.ToInt32(this.txtStock.Text);


                    //se compra ambas cantidades 
                    if (may > men)
                    {
                        errorProvider1.SetError(numCantidad, "No cuenta con Stock disponible, el monto ingresado debe ser menor al Stock");

                        numCantidad.BackColor = Color.MistyRose;
                        result = false;

                        //MessageBox.Show("No cuenta con Stock disponible, el monto ingresado debe ser menor al Stock");
                    }
                    else
                    {
                        errorProvider1.SetError(numCantidad, String.Empty);
                        numCantidad.BackColor = Color.Honeydew;
                    }
                }
                else
                {
                    DialogResult resulta = MessageBox.Show("El campo de cantidad no puede ser vacio", "Informacion", MessageBoxButtons.RetryCancel);

                    if (resulta == DialogResult.Cancel)
                    {
                        this.Close();
                    }

                    else if (resulta == DialogResult.Retry)
                    {
                        //MessageBox.Show("Vuelva a Intentarlo");
                        return result;

                    }
                }


            }
            catch
            { }
            return result;
        }

        private void numCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (es_numero(numCantidad))
            {
                errorProvider1.SetError(numCantidad, String.Empty);
                numCantidad.BackColor = Color.Honeydew;
            }
            else
            {
                errorProvider1.SetError(numCantidad, "Solo numeros");
                numCantidad.BackColor = Color.MistyRose;
            }
        }

        private static bool es_numero(Control mitextbox)
        {

            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(mitextbox.Text);

        }

        private void FrmEntregaProducto_Load_1(object sender, EventArgs e)
        {
            txtTipoProducto.Text = ((Producto)cbProducto.SelectedItem).NombreTipoProducto.ToString();
            txtStock.Text = ((Producto)cbProducto.SelectedItem).Stock.ToString();
            this.numCantidad.Value = 1;
        }
    }
}
