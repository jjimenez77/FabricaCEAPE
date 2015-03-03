namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarProductoTerminado
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
            System.Windows.Forms.Label cajasPorTarimaLabel;
            System.Windows.Forms.Label codigoBarraProductoLabel;
            System.Windows.Forms.Label fechaElaboracionLabel;
            System.Windows.Forms.Label fechaVencimientoLabel;
            System.Windows.Forms.Label gramajeLabel;
            System.Windows.Forms.Label kgPorTarimaLabel;
            System.Windows.Forms.Label loteProductoTerminadoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label unidadPorCajaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProductoTerminado));
            this.codigoBarraProductoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.productoTerminadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaElaboracionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loteProductoTerminadoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbEnvasado = new System.Windows.Forms.ComboBox();
            this.tipoEnvasadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCalidad = new System.Windows.Forms.ComboBox();
            this.seleccionProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.waterMarkTextBox1 = new wmgCMS.WaterMarkTextBox();
            this.waterMarkTextBox2 = new wmgCMS.WaterMarkTextBox();
            this.waterMarkTextBox3 = new wmgCMS.WaterMarkTextBox();
            this.waterMarkTextBox4 = new wmgCMS.WaterMarkTextBox();
            this.waterMarkTextBox5 = new wmgCMS.WaterMarkTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNombreProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cajasPorTarimaLabel = new System.Windows.Forms.Label();
            codigoBarraProductoLabel = new System.Windows.Forms.Label();
            fechaElaboracionLabel = new System.Windows.Forms.Label();
            fechaVencimientoLabel = new System.Windows.Forms.Label();
            gramajeLabel = new System.Windows.Forms.Label();
            kgPorTarimaLabel = new System.Windows.Forms.Label();
            loteProductoTerminadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            unidadPorCajaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoTerminadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seleccionProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cajasPorTarimaLabel
            // 
            cajasPorTarimaLabel.AutoSize = true;
            cajasPorTarimaLabel.Location = new System.Drawing.Point(14, 68);
            cajasPorTarimaLabel.Name = "cajasPorTarimaLabel";
            cajasPorTarimaLabel.Size = new System.Drawing.Size(85, 13);
            cajasPorTarimaLabel.TabIndex = 1;
            cajasPorTarimaLabel.Text = "Cajas por tarima:";
            // 
            // codigoBarraProductoLabel
            // 
            codigoBarraProductoLabel.AutoSize = true;
            codigoBarraProductoLabel.Location = new System.Drawing.Point(12, 386);
            codigoBarraProductoLabel.Name = "codigoBarraProductoLabel";
            codigoBarraProductoLabel.Size = new System.Drawing.Size(71, 13);
            codigoBarraProductoLabel.TabIndex = 3;
            codigoBarraProductoLabel.Text = "Codigo Barra:";
            // 
            // fechaElaboracionLabel
            // 
            fechaElaboracionLabel.AutoSize = true;
            fechaElaboracionLabel.Location = new System.Drawing.Point(12, 176);
            fechaElaboracionLabel.Name = "fechaElaboracionLabel";
            fechaElaboracionLabel.Size = new System.Drawing.Size(113, 13);
            fechaElaboracionLabel.TabIndex = 5;
            fechaElaboracionLabel.Text = "Fecha de elaboracion:";
            // 
            // fechaVencimientoLabel
            // 
            fechaVencimientoLabel.AutoSize = true;
            fechaVencimientoLabel.Location = new System.Drawing.Point(12, 203);
            fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            fechaVencimientoLabel.Size = new System.Drawing.Size(108, 13);
            fechaVencimientoLabel.TabIndex = 7;
            fechaVencimientoLabel.Text = "Fecha de caducidad:";
            // 
            // gramajeLabel
            // 
            gramajeLabel.AutoSize = true;
            gramajeLabel.Location = new System.Drawing.Point(12, 307);
            gramajeLabel.Name = "gramajeLabel";
            gramajeLabel.Size = new System.Drawing.Size(49, 13);
            gramajeLabel.TabIndex = 9;
            gramajeLabel.Text = "Gramaje:";
            // 
            // kgPorTarimaLabel
            // 
            kgPorTarimaLabel.AutoSize = true;
            kgPorTarimaLabel.Location = new System.Drawing.Point(12, 360);
            kgPorTarimaLabel.Name = "kgPorTarimaLabel";
            kgPorTarimaLabel.Size = new System.Drawing.Size(79, 13);
            kgPorTarimaLabel.TabIndex = 15;
            kgPorTarimaLabel.Text = "Kg. por Tarima:";
            // 
            // loteProductoTerminadoLabel
            // 
            loteProductoTerminadoLabel.AutoSize = true;
            loteProductoTerminadoLabel.Location = new System.Drawing.Point(12, 118);
            loteProductoTerminadoLabel.Name = "loteProductoTerminadoLabel";
            loteProductoTerminadoLabel.Size = new System.Drawing.Size(31, 13);
            loteProductoTerminadoLabel.TabIndex = 17;
            loteProductoTerminadoLabel.Text = "Lote:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(14, 41);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Nombre:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(12, 148);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(38, 13);
            stockLabel.TabIndex = 29;
            stockLabel.Text = "Stock:";
            // 
            // unidadPorCajaLabel
            // 
            unidadPorCajaLabel.AutoSize = true;
            unidadPorCajaLabel.Location = new System.Drawing.Point(12, 95);
            unidadPorCajaLabel.Name = "unidadPorCajaLabel";
            unidadPorCajaLabel.Size = new System.Drawing.Size(96, 13);
            unidadPorCajaLabel.TabIndex = 31;
            unidadPorCajaLabel.Text = "Unidades por caja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 226);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 13);
            label2.TabIndex = 35;
            label2.Text = "Tipo de producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 253);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 13);
            label3.TabIndex = 36;
            label3.Text = "Tipo de envasado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 13);
            label4.TabIndex = 39;
            label4.Text = "Tipo de calidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 333);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 13);
            label5.TabIndex = 41;
            label5.Text = "Medida:";
            // 
            // codigoBarraProductoWaterMarkTextBox
            // 
            this.codigoBarraProductoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoTerminadoBindingSource, "CodigoBarraProducto", true));
            this.codigoBarraProductoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.codigoBarraProductoWaterMarkTextBox.Location = new System.Drawing.Point(131, 383);
            this.codigoBarraProductoWaterMarkTextBox.Name = "codigoBarraProductoWaterMarkTextBox";
            this.codigoBarraProductoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.codigoBarraProductoWaterMarkTextBox.TabIndex = 14;
            this.codigoBarraProductoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.codigoBarraProductoWaterMarkTextBox.WaterMarkText = "4342222344";
            this.codigoBarraProductoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoBarraProductoWaterMarkTextBox_KeyPress);
            this.codigoBarraProductoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.codigoBarraProductoWaterMarkTextBox_Validating);
            // 
            // productoTerminadoBindingSource
            // 
            this.productoTerminadoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.ProductoTerminado);
            // 
            // fechaElaboracionDateTimePicker
            // 
            this.fechaElaboracionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoTerminadoBindingSource, "FechaElaboracion", true));
            this.fechaElaboracionDateTimePicker.Location = new System.Drawing.Point(131, 170);
            this.fechaElaboracionDateTimePicker.Name = "fechaElaboracionDateTimePicker";
            this.fechaElaboracionDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.fechaElaboracionDateTimePicker.TabIndex = 6;
            this.fechaElaboracionDateTimePicker.DropDown += new System.EventHandler(this.fechaElaboracionDateTimePicker_DropDown);
            // 
            // fechaVencimientoDateTimePicker
            // 
            this.fechaVencimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoTerminadoBindingSource, "FechaVencimiento", true));
            this.fechaVencimientoDateTimePicker.Location = new System.Drawing.Point(131, 196);
            this.fechaVencimientoDateTimePicker.Name = "fechaVencimientoDateTimePicker";
            this.fechaVencimientoDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.fechaVencimientoDateTimePicker.TabIndex = 7;
            this.fechaVencimientoDateTimePicker.DropDown += new System.EventHandler(this.fechaVencimientoDateTimePicker_DropDown);
            // 
            // loteProductoTerminadoWaterMarkTextBox
            // 
            this.loteProductoTerminadoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoTerminadoBindingSource, "LoteProductoTerminado", true));
            this.loteProductoTerminadoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loteProductoTerminadoWaterMarkTextBox.Location = new System.Drawing.Point(131, 117);
            this.loteProductoTerminadoWaterMarkTextBox.Name = "loteProductoTerminadoWaterMarkTextBox";
            this.loteProductoTerminadoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.loteProductoTerminadoWaterMarkTextBox.TabIndex = 4;
            this.loteProductoTerminadoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.loteProductoTerminadoWaterMarkTextBox.WaterMarkText = "3433";
            this.loteProductoTerminadoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loteProductoTerminadoWaterMarkTextBox_KeyPress);
            this.loteProductoTerminadoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loteProductoTerminadoWaterMarkTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Editar producto";
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.DataSource = this.tipoProductoBindingSource;
            this.cbTipoProducto.DisplayMember = "Nombre";
            this.cbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Location = new System.Drawing.Point(131, 222);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(206, 21);
            this.cbTipoProducto.TabIndex = 8;
            this.cbTipoProducto.ValueMember = "IdTipoProducto";
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.TipoProducto);
            // 
            // cbEnvasado
            // 
            this.cbEnvasado.DataSource = this.tipoEnvasadoBindingSource;
            this.cbEnvasado.DisplayMember = "Nombre";
            this.cbEnvasado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnvasado.FormattingEnabled = true;
            this.cbEnvasado.Location = new System.Drawing.Point(131, 249);
            this.cbEnvasado.Name = "cbEnvasado";
            this.cbEnvasado.Size = new System.Drawing.Size(206, 21);
            this.cbEnvasado.TabIndex = 9;
            this.cbEnvasado.ValueMember = "IdTipoEnvasado";
            // 
            // tipoEnvasadoBindingSource
            // 
            this.tipoEnvasadoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.TipoEnvasado);
            // 
            // cbCalidad
            // 
            this.cbCalidad.DataSource = this.seleccionProductoBindingSource;
            this.cbCalidad.DisplayMember = "Nombre";
            this.cbCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalidad.FormattingEnabled = true;
            this.cbCalidad.Location = new System.Drawing.Point(131, 276);
            this.cbCalidad.Name = "cbCalidad";
            this.cbCalidad.Size = new System.Drawing.Size(206, 21);
            this.cbCalidad.TabIndex = 10;
            this.cbCalidad.ValueMember = "IdSeleccionProducto";
            // 
            // seleccionProductoBindingSource
            // 
            this.seleccionProductoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.SeleccionProducto);
            // 
            // cbMedida
            // 
            this.cbMedida.DataSource = this.medidaBindingSource;
            this.cbMedida.DisplayMember = "Nombre";
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(131, 330);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(206, 21);
            this.cbMedida.TabIndex = 12;
            this.cbMedida.ValueMember = "Id";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Medida);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(268, 426);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(187, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // waterMarkTextBox1
            // 
            this.waterMarkTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoTerminadoBindingSource, "KgPorTarima", true));
            this.waterMarkTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox1.Location = new System.Drawing.Point(131, 357);
            this.waterMarkTextBox1.Name = "waterMarkTextBox1";
            this.waterMarkTextBox1.ReadOnly = true;
            this.waterMarkTextBox1.Size = new System.Drawing.Size(206, 20);
            this.waterMarkTextBox1.TabIndex = 13;
            this.waterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox1.WaterMarkText = "10.5";
            this.waterMarkTextBox1.DoubleClick += new System.EventHandler(this.waterMarkTextBox1_DoubleClick);
            // 
            // waterMarkTextBox2
            // 
            this.waterMarkTextBox2.CausesValidation = false;
            this.waterMarkTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoTerminadoBindingSource, "Gramaje", true));
            this.waterMarkTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox2.Location = new System.Drawing.Point(131, 304);
            this.waterMarkTextBox2.Name = "waterMarkTextBox2";
            this.waterMarkTextBox2.Size = new System.Drawing.Size(206, 20);
            this.waterMarkTextBox2.TabIndex = 11;
            this.waterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox2.WaterMarkText = "10.5";
            this.waterMarkTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waterMarkTextBox2_KeyPress);
            this.waterMarkTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.waterMarkTextBox2_Validating);
            // 
            // waterMarkTextBox3
            // 
            this.waterMarkTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoTerminadoBindingSource, "Stock", true));
            this.waterMarkTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox3.Location = new System.Drawing.Point(131, 145);
            this.waterMarkTextBox3.Name = "waterMarkTextBox3";
            this.waterMarkTextBox3.Size = new System.Drawing.Size(206, 20);
            this.waterMarkTextBox3.TabIndex = 5;
            this.waterMarkTextBox3.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox3.WaterMarkText = "100";
            this.waterMarkTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waterMarkTextBox3_KeyPress);
            this.waterMarkTextBox3.Validating += new System.ComponentModel.CancelEventHandler(this.waterMarkTextBox3_Validating);
            // 
            // waterMarkTextBox4
            // 
            this.waterMarkTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoTerminadoBindingSource, "UnidadPorCaja", true));
            this.waterMarkTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox4.Location = new System.Drawing.Point(131, 91);
            this.waterMarkTextBox4.Name = "waterMarkTextBox4";
            this.waterMarkTextBox4.Size = new System.Drawing.Size(206, 20);
            this.waterMarkTextBox4.TabIndex = 3;
            this.waterMarkTextBox4.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox4.WaterMarkText = "10";
            this.waterMarkTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waterMarkTextBox4_KeyPress);
            this.waterMarkTextBox4.Validating += new System.ComponentModel.CancelEventHandler(this.waterMarkTextBox4_Validating);
            // 
            // waterMarkTextBox5
            // 
            this.waterMarkTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoTerminadoBindingSource, "CajasPorTarima", true));
            this.waterMarkTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waterMarkTextBox5.Location = new System.Drawing.Point(131, 65);
            this.waterMarkTextBox5.Name = "waterMarkTextBox5";
            this.waterMarkTextBox5.Size = new System.Drawing.Size(206, 20);
            this.waterMarkTextBox5.TabIndex = 2;
            this.waterMarkTextBox5.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox5.WaterMarkText = "8";
            this.waterMarkTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waterMarkTextBox5_KeyPress);
            this.waterMarkTextBox5.Validating += new System.ComponentModel.CancelEventHandler(this.waterMarkTextBox5_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cbNombreProducto
            // 
            this.cbNombreProducto.DataSource = this.productoBindingSource;
            this.cbNombreProducto.DisplayMember = "Nombre";
            this.cbNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreProducto.FormattingEnabled = true;
            this.cbNombreProducto.Location = new System.Drawing.Point(131, 38);
            this.cbNombreProducto.Name = "cbNombreProducto";
            this.cbNombreProducto.Size = new System.Drawing.Size(206, 21);
            this.cbNombreProducto.TabIndex = 1;
            this.cbNombreProducto.ValueMember = "IdProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Producto);
            // 
            // FrmEditarProductoTerminado
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(355, 461);
            this.ControlBox = false;
            this.Controls.Add(this.cbNombreProducto);
            this.Controls.Add(this.waterMarkTextBox5);
            this.Controls.Add(this.waterMarkTextBox4);
            this.Controls.Add(this.waterMarkTextBox3);
            this.Controls.Add(this.waterMarkTextBox2);
            this.Controls.Add(this.waterMarkTextBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(label5);
            this.Controls.Add(this.cbMedida);
            this.Controls.Add(label4);
            this.Controls.Add(this.cbCalidad);
            this.Controls.Add(this.cbEnvasado);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.cbTipoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(cajasPorTarimaLabel);
            this.Controls.Add(codigoBarraProductoLabel);
            this.Controls.Add(this.codigoBarraProductoWaterMarkTextBox);
            this.Controls.Add(fechaElaboracionLabel);
            this.Controls.Add(this.fechaElaboracionDateTimePicker);
            this.Controls.Add(fechaVencimientoLabel);
            this.Controls.Add(this.fechaVencimientoDateTimePicker);
            this.Controls.Add(gramajeLabel);
            this.Controls.Add(kgPorTarimaLabel);
            this.Controls.Add(loteProductoTerminadoLabel);
            this.Controls.Add(this.loteProductoTerminadoWaterMarkTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(stockLabel);
            this.Controls.Add(unidadPorCajaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarProductoTerminado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar producto";
            ((System.ComponentModel.ISupportInitialize)(this.productoTerminadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seleccionProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wmgCMS.WaterMarkTextBox codigoBarraProductoWaterMarkTextBox;
        private System.Windows.Forms.DateTimePicker fechaElaboracionDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaVencimientoDateTimePicker;
        private wmgCMS.WaterMarkTextBox loteProductoTerminadoWaterMarkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoProducto;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private System.Windows.Forms.ComboBox cbEnvasado;
        private System.Windows.Forms.BindingSource tipoEnvasadoBindingSource;
        private System.Windows.Forms.ComboBox cbCalidad;
        private System.Windows.Forms.BindingSource seleccionProductoBindingSource;
        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private wmgCMS.WaterMarkTextBox waterMarkTextBox1;
        private wmgCMS.WaterMarkTextBox waterMarkTextBox2;
        private wmgCMS.WaterMarkTextBox waterMarkTextBox3;
        private wmgCMS.WaterMarkTextBox waterMarkTextBox4;
        private wmgCMS.WaterMarkTextBox waterMarkTextBox5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbNombreProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingSource productoTerminadoBindingSource;
    }
}