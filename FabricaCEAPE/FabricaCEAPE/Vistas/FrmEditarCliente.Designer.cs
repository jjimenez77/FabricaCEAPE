namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarCliente
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
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label cuitLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaInicioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreDeContactoLabel;
            System.Windows.Forms.Label numeroCelularLabel;
            System.Windows.Forms.Label numeroTelefonoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCliente));
            this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.direccionWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroTelefonoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroCelularWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.cuitWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.nombreDeContactoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.nombreWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.correoElectronicoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.zonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            cuitLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaInicioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreDeContactoLabel = new System.Windows.Forms.Label();
            numeroCelularLabel = new System.Windows.Forms.Label();
            numeroTelefonoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(13, 173);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(96, 13);
            correoElectronicoLabel.TabIndex = 3;
            correoElectronicoLabel.Text = "Correo electronico:";
            // 
            // cuitLabel
            // 
            cuitLabel.AutoSize = true;
            cuitLabel.Location = new System.Drawing.Point(13, 95);
            cuitLabel.Name = "cuitLabel";
            cuitLabel.Size = new System.Drawing.Size(28, 13);
            cuitLabel.TabIndex = 5;
            cuitLabel.Text = "Cuit:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(13, 225);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 7;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Location = new System.Drawing.Point(13, 202);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(82, 13);
            fechaInicioLabel.TabIndex = 9;
            fechaInicioLabel.Text = "Fecha de inicio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(13, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreDeContactoLabel
            // 
            nombreDeContactoLabel.AutoSize = true;
            nombreDeContactoLabel.Location = new System.Drawing.Point(13, 69);
            nombreDeContactoLabel.Name = "nombreDeContactoLabel";
            nombreDeContactoLabel.Size = new System.Drawing.Size(107, 13);
            nombreDeContactoLabel.TabIndex = 15;
            nombreDeContactoLabel.Text = "Nombre de contacto:";
            // 
            // numeroCelularLabel
            // 
            numeroCelularLabel.AutoSize = true;
            numeroCelularLabel.Location = new System.Drawing.Point(13, 147);
            numeroCelularLabel.Name = "numeroCelularLabel";
            numeroCelularLabel.Size = new System.Drawing.Size(96, 13);
            numeroCelularLabel.TabIndex = 19;
            numeroCelularLabel.Text = "Numero de celular:";
            // 
            // numeroTelefonoLabel
            // 
            numeroTelefonoLabel.AutoSize = true;
            numeroTelefonoLabel.Location = new System.Drawing.Point(13, 121);
            numeroTelefonoLabel.Name = "numeroTelefonoLabel";
            numeroTelefonoLabel.Size = new System.Drawing.Size(103, 13);
            numeroTelefonoLabel.TabIndex = 21;
            numeroTelefonoLabel.Text = "Numero de telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(-3, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 24;
            label2.Text = "Zona:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(-3, 39);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 13);
            label5.TabIndex = 53;
            label5.Text = "Provincia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(-3, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 54;
            label3.Text = "Localidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(-3, 12);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(30, 13);
            label4.TabIndex = 55;
            label4.Text = "Pais:";
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(129, 196);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.fechaInicioDateTimePicker.TabIndex = 6;
            this.fechaInicioDateTimePicker.DropDown += new System.EventHandler(this.fechaInicioDateTimePicker_DropDown_1);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Cliente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Editar cliente";
            // 
            // direccionWaterMarkTextBox
            // 
            this.direccionWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Direccion", true));
            this.direccionWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.direccionWaterMarkTextBox.Location = new System.Drawing.Point(129, 222);
            this.direccionWaterMarkTextBox.Name = "direccionWaterMarkTextBox";
            this.direccionWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.direccionWaterMarkTextBox.TabIndex = 7;
            this.direccionWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.direccionWaterMarkTextBox.WaterMarkText = "9 de Julio 22";
            this.direccionWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direccionWaterMarkTextBox_KeyPress);
            this.direccionWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.direccionWaterMarkTextBox_Validating);
            // 
            // numeroTelefonoWaterMarkTextBox
            // 
            this.numeroTelefonoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NumeroTelefono", true));
            this.numeroTelefonoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroTelefonoWaterMarkTextBox.Location = new System.Drawing.Point(129, 118);
            this.numeroTelefonoWaterMarkTextBox.Name = "numeroTelefonoWaterMarkTextBox";
            this.numeroTelefonoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroTelefonoWaterMarkTextBox.TabIndex = 3;
            this.numeroTelefonoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroTelefonoWaterMarkTextBox.WaterMarkText = "3434539902";
            this.numeroTelefonoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTelefonoWaterMarkTextBox_KeyPress);
            this.numeroTelefonoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroTelefonoWaterMarkTextBox_Validating);
            // 
            // numeroCelularWaterMarkTextBox
            // 
            this.numeroCelularWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NumeroCelular", true));
            this.numeroCelularWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroCelularWaterMarkTextBox.Location = new System.Drawing.Point(129, 144);
            this.numeroCelularWaterMarkTextBox.Name = "numeroCelularWaterMarkTextBox";
            this.numeroCelularWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroCelularWaterMarkTextBox.TabIndex = 4;
            this.numeroCelularWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroCelularWaterMarkTextBox.WaterMarkText = "3434521101";
            this.numeroCelularWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTelefonoWaterMarkTextBox_KeyPress);
            this.numeroCelularWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroCelularWaterMarkTextBox_Validating);
            // 
            // cuitWaterMarkTextBox
            // 
            this.cuitWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cuit", true));
            this.cuitWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cuitWaterMarkTextBox.Location = new System.Drawing.Point(129, 92);
            this.cuitWaterMarkTextBox.Name = "cuitWaterMarkTextBox";
            this.cuitWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.cuitWaterMarkTextBox.TabIndex = 2;
            this.cuitWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.cuitWaterMarkTextBox.WaterMarkText = "29347393";
            this.cuitWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cuitWaterMarkTextBox_KeyPress);
            this.cuitWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cuitWaterMarkTextBox_Validating);
            // 
            // nombreDeContactoWaterMarkTextBox
            // 
            this.nombreDeContactoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NombreDeContacto", true));
            this.nombreDeContactoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreDeContactoWaterMarkTextBox.Location = new System.Drawing.Point(129, 66);
            this.nombreDeContactoWaterMarkTextBox.Name = "nombreDeContactoWaterMarkTextBox";
            this.nombreDeContactoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreDeContactoWaterMarkTextBox.TabIndex = 1;
            this.nombreDeContactoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreDeContactoWaterMarkTextBox.WaterMarkText = "Antonio Perez";
            this.nombreDeContactoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreDeContactoWaterMarkTextBox_KeyPress);
            this.nombreDeContactoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreDeContactoWaterMarkTextBox_Validating);
            // 
            // nombreWaterMarkTextBox
            // 
            this.nombreWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nombre", true));
            this.nombreWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreWaterMarkTextBox.Location = new System.Drawing.Point(129, 40);
            this.nombreWaterMarkTextBox.Name = "nombreWaterMarkTextBox";
            this.nombreWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreWaterMarkTextBox.TabIndex = 0;
            this.nombreWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreWaterMarkTextBox.WaterMarkText = "Kiosco Chaly";
            this.nombreWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreWaterMarkTextBox_KeyPress);
            this.nombreWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreWaterMarkTextBox_Validating);
            // 
            // correoElectronicoWaterMarkTextBox
            // 
            this.correoElectronicoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CorreoElectronico", true));
            this.correoElectronicoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.correoElectronicoWaterMarkTextBox.Location = new System.Drawing.Point(129, 170);
            this.correoElectronicoWaterMarkTextBox.Name = "correoElectronicoWaterMarkTextBox";
            this.correoElectronicoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.correoElectronicoWaterMarkTextBox.TabIndex = 5;
            this.correoElectronicoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.correoElectronicoWaterMarkTextBox.WaterMarkText = "nombre@sitio.com";
            this.correoElectronicoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correoElectronicoWaterMarkTextBox_KeyPress);
            this.correoElectronicoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.correoElectronicoWaterMarkTextBox_Validating);
            // 
            // zonaBindingSource
            // 
            this.zonaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Zona);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(266, 444);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(185, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Localidad);
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Provincia);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pais);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPais);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.cbZona);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.cbLocalidad);
            this.groupBox1.Controls.Add(this.cbProvincia);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 114);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zona";
            // 
            // cbPais
            // 
            this.cbPais.DataSource = this.paisBindingSource;
            this.cbPais.DisplayMember = "Nombre";
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(113, 9);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(206, 21);
            this.cbPais.TabIndex = 8;
            this.cbPais.ValueMember = "Id";
            this.cbPais.DropDownClosed += new System.EventHandler(this.cbPais_DropDownClosed);
            // 
            // cbZona
            // 
            this.cbZona.DataSource = this.zonaBindingSource;
            this.cbZona.DisplayMember = "Nombre";
            this.cbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(113, 90);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(206, 21);
            this.cbZona.TabIndex = 11;
            this.cbZona.ValueMember = "IdZona";
            this.cbZona.Validating += new System.ComponentModel.CancelEventHandler(this.cbZona_Validating);
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DataSource = this.localidadBindingSource;
            this.cbLocalidad.DisplayMember = "Nombre";
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(113, 63);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(206, 21);
            this.cbLocalidad.TabIndex = 10;
            this.cbLocalidad.ValueMember = "Id";
            this.cbLocalidad.DropDownClosed += new System.EventHandler(this.cbLocalidad_DropDownClosed);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DataSource = this.provinciaBindingSource;
            this.cbProvincia.DisplayMember = "Nombre";
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(113, 36);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(206, 21);
            this.cbProvincia.TabIndex = 9;
            this.cbProvincia.ValueMember = "Id";
            this.cbProvincia.DropDownClosed += new System.EventHandler(this.cbProvincia_DropDownClosed);
            // 
            // FrmEditarCliente
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(353, 479);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.direccionWaterMarkTextBox);
            this.Controls.Add(this.numeroTelefonoWaterMarkTextBox);
            this.Controls.Add(this.numeroCelularWaterMarkTextBox);
            this.Controls.Add(this.cuitWaterMarkTextBox);
            this.Controls.Add(this.nombreDeContactoWaterMarkTextBox);
            this.Controls.Add(this.nombreWaterMarkTextBox);
            this.Controls.Add(this.correoElectronicoWaterMarkTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(cuitLabel);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(fechaInicioLabel);
            this.Controls.Add(this.fechaInicioDateTimePicker);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(nombreDeContactoLabel);
            this.Controls.Add(numeroCelularLabel);
            this.Controls.Add(numeroTelefonoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.Label label1;
        private wmgCMS.WaterMarkTextBox correoElectronicoWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox nombreWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox nombreDeContactoWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox cuitWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox numeroCelularWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox numeroTelefonoWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox direccionWaterMarkTextBox;
        private System.Windows.Forms.BindingSource zonaBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbProvincia;
    }
}