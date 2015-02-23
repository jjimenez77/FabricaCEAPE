namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarMateriaPrima
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label fechaCaducidadLabel;
            System.Windows.Forms.Label fechaElaboracionLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label loteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarMateriaPrima));
            this.label1 = new System.Windows.Forms.Label();
            this.materiaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaCaducidadDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaElaboracionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbTipoMateriaPrima = new System.Windows.Forms.ComboBox();
            this.tipoMateriaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nombreTextBox = new wmgCMS.WaterMarkTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cantidadTextBox = new wmgCMS.WaterMarkTextBox();
            this.loteTextBox = new wmgCMS.WaterMarkTextBox();
            cantidadLabel = new System.Windows.Forms.Label();
            fechaCaducidadLabel = new System.Windows.Forms.Label();
            fechaElaboracionLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            loteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMateriaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(12, 69);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 8;
            cantidadLabel.Text = "Cantidad:";
            // 
            // fechaCaducidadLabel
            // 
            fechaCaducidadLabel.AutoSize = true;
            fechaCaducidadLabel.Location = new System.Drawing.Point(12, 284);
            fechaCaducidadLabel.Name = "fechaCaducidadLabel";
            fechaCaducidadLabel.Size = new System.Drawing.Size(108, 13);
            fechaCaducidadLabel.TabIndex = 10;
            fechaCaducidadLabel.Text = "Fecha de caducidad:";
            // 
            // fechaElaboracionLabel
            // 
            fechaElaboracionLabel.AutoSize = true;
            fechaElaboracionLabel.Location = new System.Drawing.Point(12, 258);
            fechaElaboracionLabel.Name = "fechaElaboracionLabel";
            fechaElaboracionLabel.Size = new System.Drawing.Size(113, 13);
            fechaElaboracionLabel.TabIndex = 12;
            fechaElaboracionLabel.Text = "Fecha de elaboracion:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Location = new System.Drawing.Point(12, 232);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(92, 13);
            fechaIngresoLabel.TabIndex = 14;
            fechaIngresoLabel.Text = "Fecha de ingreso:";
            // 
            // loteLabel
            // 
            loteLabel.AutoSize = true;
            loteLabel.Location = new System.Drawing.Point(12, 122);
            loteLabel.Name = "loteLabel";
            loteLabel.Size = new System.Drawing.Size(31, 13);
            loteLabel.TabIndex = 18;
            loteLabel.Text = "Lote:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 20;
            nombreLabel.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 13);
            label2.TabIndex = 22;
            label2.Text = "Tipo de materia prima:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 27;
            label3.Text = "Medida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 175);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 28;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 202);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 13);
            label5.TabIndex = 29;
            label5.Text = "Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Editar materia prima";
            // 
            // materiaPrimaBindingSource
            // 
            this.materiaPrimaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.MateriaPrima);
            // 
            // fechaCaducidadDateTimePicker
            // 
            this.fechaCaducidadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.materiaPrimaBindingSource, "FechaCaducidad", true));
            this.fechaCaducidadDateTimePicker.Location = new System.Drawing.Point(129, 278);
            this.fechaCaducidadDateTimePicker.Name = "fechaCaducidadDateTimePicker";
            this.fechaCaducidadDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCaducidadDateTimePicker.TabIndex = 10;
            this.fechaCaducidadDateTimePicker.DropDown += new System.EventHandler(this.fechaCaducidadDateTimePicker_DropDown);
            // 
            // fechaElaboracionDateTimePicker
            // 
            this.fechaElaboracionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.materiaPrimaBindingSource, "FechaElaboracion", true));
            this.fechaElaboracionDateTimePicker.Location = new System.Drawing.Point(129, 252);
            this.fechaElaboracionDateTimePicker.Name = "fechaElaboracionDateTimePicker";
            this.fechaElaboracionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaElaboracionDateTimePicker.TabIndex = 9;
            this.fechaElaboracionDateTimePicker.DropDown += new System.EventHandler(this.fechaElaboracionDateTimePicker_DropDown);
            // 
            // fechaIngresoDateTimePicker
            // 
            this.fechaIngresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.materiaPrimaBindingSource, "FechaIngreso", true));
            this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(129, 226);
            this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaIngresoDateTimePicker.TabIndex = 8;
            // 
            // cbTipoMateriaPrima
            // 
            this.cbTipoMateriaPrima.DataSource = this.tipoMateriaPrimaBindingSource;
            this.cbTipoMateriaPrima.DisplayMember = "Nombre";
            this.cbTipoMateriaPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMateriaPrima.FormattingEnabled = true;
            this.cbTipoMateriaPrima.Location = new System.Drawing.Point(129, 145);
            this.cbTipoMateriaPrima.Name = "cbTipoMateriaPrima";
            this.cbTipoMateriaPrima.Size = new System.Drawing.Size(200, 21);
            this.cbTipoMateriaPrima.TabIndex = 5;
            this.cbTipoMateriaPrima.ValueMember = "Id";
            // 
            // tipoMateriaPrimaBindingSource
            // 
            this.tipoMateriaPrimaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.TipoMateriaPrima);
            // 
            // cbMedida
            // 
            this.cbMedida.DataSource = this.medidaBindingSource;
            this.cbMedida.DisplayMember = "Nombre";
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(129, 92);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(200, 21);
            this.cbMedida.TabIndex = 3;
            this.cbMedida.ValueMember = "Id";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Medida);
            // 
            // cbMarca
            // 
            this.cbMarca.DataSource = this.marcaBindingSource;
            this.cbMarca.DisplayMember = "Nombre";
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(129, 172);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(200, 21);
            this.cbMarca.TabIndex = 6;
            this.cbMarca.ValueMember = "Id";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Marca);
            // 
            // cbProveedor
            // 
            this.cbProveedor.DataSource = this.proveedorBindingSource;
            this.cbProveedor.DisplayMember = "Nombre";
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(129, 199);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(200, 21);
            this.cbProveedor.TabIndex = 7;
            this.cbProveedor.ValueMember = "Id";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Proveedor);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(261, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(180, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaPrimaBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(129, 40);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreTextBox.WaterMarkText = "Harina de trigo";
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaPrimaBindingSource, "Cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cantidadTextBox.Location = new System.Drawing.Point(129, 66);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(200, 20);
            this.cantidadTextBox.TabIndex = 2;
            this.cantidadTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.cantidadTextBox.WaterMarkText = "22";
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadTextBox_KeyPress);
            this.cantidadTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cantidadTextBox_Validating);
            // 
            // loteTextBox
            // 
            this.loteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaPrimaBindingSource, "Lote", true));
            this.loteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loteTextBox.Location = new System.Drawing.Point(129, 119);
            this.loteTextBox.Name = "loteTextBox";
            this.loteTextBox.Size = new System.Drawing.Size(200, 20);
            this.loteTextBox.TabIndex = 4;
            this.loteTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.loteTextBox.WaterMarkText = "0100492";
            this.loteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loteTextBox_KeyPress);
            this.loteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loteTextBox_Validating);
            // 
            // FrmEditarMateriaPrima
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(348, 469);
            this.Controls.Add(this.loteTextBox);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbMedida);
            this.Controls.Add(this.cbTipoMateriaPrima);
            this.Controls.Add(label2);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(fechaCaducidadLabel);
            this.Controls.Add(this.fechaCaducidadDateTimePicker);
            this.Controls.Add(fechaElaboracionLabel);
            this.Controls.Add(this.fechaElaboracionDateTimePicker);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.fechaIngresoDateTimePicker);
            this.Controls.Add(loteLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarMateriaPrima";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar materia prima";
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMateriaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource materiaPrimaBindingSource;
        private System.Windows.Forms.DateTimePicker fechaCaducidadDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaElaboracionDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.ComboBox cbTipoMateriaPrima;
        private System.Windows.Forms.BindingSource tipoMateriaPrimaBindingSource;
        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private wmgCMS.WaterMarkTextBox nombreTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private wmgCMS.WaterMarkTextBox loteTextBox;
        private wmgCMS.WaterMarkTextBox cantidadTextBox;
    }
}