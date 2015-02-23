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

namespace FabricaCEAPE.Vistas
{
    public partial class FrmEditarMateriaPrima : Form
    {
        bool fechaElaboracion = false;
        bool fechaCaducidad = false;

        public FrmEditarMateriaPrima(int id)
        {
            InitializeComponent();
            tipoMateriaPrimaBindingSource.DataSource = DatosTipoMateriaPrima.getTiposMateriaPrima();
            medidaBindingSource.DataSource = DatosMedida.getMedidas();
            marcaBindingSource.DataSource = DatosMarca.getMarcas();
            proveedorBindingSource.DataSource = DatosProveedor.getProveedores();

            this.fechaIngresoDateTimePicker.MaxDate = DateTime.Today;
            this.fechaIngresoDateTimePicker.MinDate = DateTime.Today.AddDays(-3);
            this.fechaElaboracionDateTimePicker.MaxDate = DateTime.Today.AddDays(-4);
            this.fechaCaducidadDateTimePicker.MinDate = DateTime.Today.AddDays(2);

            if (id == 0)
            {
                materiaPrimaBindingSource.Add(new MateriaPrima());
            }
            else
            {
                fechaElaboracion = true;
                fechaCaducidad = true;

                materiaPrimaBindingSource.Add(DatosMateriaPrima.getMateriaPrima(id));

                cbTipoMateriaPrima.SelectedItem = ((MateriaPrima)materiaPrimaBindingSource.Current).TipoMateriaPrima;
                cbTipoMateriaPrima.SelectedValue = ((MateriaPrima)materiaPrimaBindingSource.Current).TipoMateriaPrima.Id;

                cbMedida.SelectedItem = ((MateriaPrima)materiaPrimaBindingSource.Current).Medida;
                cbMedida.SelectedValue = ((MateriaPrima)materiaPrimaBindingSource.Current).Medida.Id;

                cbMarca.SelectedItem = ((MateriaPrima)materiaPrimaBindingSource.Current).Marca;
                cbMarca.SelectedValue = ((MateriaPrima)materiaPrimaBindingSource.Current).Marca.Id;

                cbProveedor.SelectedItem = ((MateriaPrima)materiaPrimaBindingSource.Current).Proveedor;
                cbProveedor.SelectedValue = ((MateriaPrima)materiaPrimaBindingSource.Current).Proveedor.Id;

                MateriaPrima mp = (MateriaPrima)materiaPrimaBindingSource.Current;

                if (mp.Nombre != "")
                {
                    this.Text = "Editar " + mp.Nombre;
                }    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaciones())
                    return;
                MateriaPrima mp = (MateriaPrima)materiaPrimaBindingSource.Current;
                mp.TipoMateriaPrima = (TipoMateriaPrima)cbTipoMateriaPrima.SelectedItem;
                mp.Medida = (Medida)cbMedida.SelectedItem;
                mp.Marca = (Marca)cbMarca.SelectedItem;
                mp.Proveedor = (Proveedor)cbProveedor.SelectedItem;
                mp.FechaIngreso = fechaIngresoDateTimePicker.Value;
                mp.FechaElaboracion = fechaElaboracionDateTimePicker.Value;
                mp.FechaCaducidad = fechaCaducidadDateTimePicker.Value;

                mp.Activo = true;

                if (mp.Id == 0)
                {
                    DatosMateriaPrima.Crear(mp);
                }
                else
                {
                    DatosMateriaPrima.Modificar(mp);
                }
                Close();
            }
            catch
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        Color colorOk = (Color)((new ColorConverter()).ConvertFromString("#bbda68"));
    
        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumeroPunto(nombreTextBox) || nombreTextBox.Text.Trim() == String.Empty)
            {
                error = "Ingrese el nombre de la materia prima";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                nombreTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cantidadTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esNumero(cantidadTextBox) || cantidadTextBox.Text == "0")
            {
                error = "Ingrese la cantidad";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                cantidadTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void loteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void loteTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (!Validacion.esCadenaNumero(loteTextBox))
            {
                error = "Ingrese el numero de lote";
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, error);
            }
            else
            {
                loteTextBox.BackColor = colorOk;
                errorProvider1.SetError((Control)sender, String.Empty);
            }
        }

        private bool validaciones()
        {
            bool resultados = true;
            string error = null;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                error = "Ingrese el nombre de la materia prima";

                errorProvider1.SetError(nombreTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(cantidadTextBox.Text) || cantidadTextBox.Text == "0")
            {
                error = "Ingrese la cantidad";

                errorProvider1.SetError(cantidadTextBox, error);
                resultados = false;
            }

            if (string.IsNullOrEmpty(loteTextBox.Text))
            {
                error = "Ingrese el numero de lote";

                errorProvider1.SetError(loteTextBox, error);
                resultados = false;
            }

            if (fechaElaboracion == false)
            {
                error = "Seleccione la fecha de elaboracion de la materia prima";
                errorProvider1.SetError(fechaElaboracionDateTimePicker, error);
                resultados = false;
            }
            else
            {
                fechaElaboracionDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaElaboracionDateTimePicker, String.Empty);
            }

            if (fechaCaducidad == false)
            {
                error = "Seleccione la fecha de elaboracion de la materia prima";
                errorProvider1.SetError(fechaCaducidadDateTimePicker, error);
                resultados = false;
            }
            else
            {
                fechaCaducidadDateTimePicker.BackColor = colorOk;
                errorProvider1.SetError(fechaCaducidadDateTimePicker, String.Empty);
            }

            return resultados;
        }

        private void fechaElaboracionDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaElaboracion = true;
            fechaElaboracionDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaElaboracionDateTimePicker, String.Empty);
        }

        private void fechaCaducidadDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fechaCaducidad = true;
            fechaCaducidadDateTimePicker.BackColor = colorOk;
            errorProvider1.SetError(fechaCaducidadDateTimePicker, String.Empty);
        }
    }
}
