namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarProveedor
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new wmgCMS.WaterMarkTextBox();
            this.cuitTextBox = new wmgCMS.WaterMarkTextBox();
            this.nombreDeContactoTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroTelefonoTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroCelularTextBox = new wmgCMS.WaterMarkTextBox();
            this.correoElectronicoTextBox = new wmgCMS.WaterMarkTextBox();
            this.direccionTextBox = new wmgCMS.WaterMarkTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            cuitLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaInicioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreDeContactoLabel = new System.Windows.Forms.Label();
            numeroCelularLabel = new System.Windows.Forms.Label();
            numeroTelefonoLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(13, 174);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(96, 13);
            correoElectronicoLabel.TabIndex = 7;
            correoElectronicoLabel.Text = "Correo electronico:";
            // 
            // cuitLabel
            // 
            cuitLabel.AutoSize = true;
            cuitLabel.Location = new System.Drawing.Point(13, 96);
            cuitLabel.Name = "cuitLabel";
            cuitLabel.Size = new System.Drawing.Size(64, 13);
            cuitLabel.TabIndex = 9;
            cuitLabel.Text = "CUIL/CUIT:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(13, 226);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Location = new System.Drawing.Point(13, 203);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(82, 13);
            fechaInicioLabel.TabIndex = 13;
            fechaInicioLabel.Text = "Fecha de inicio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(13, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 17;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreDeContactoLabel
            // 
            nombreDeContactoLabel.AutoSize = true;
            nombreDeContactoLabel.Location = new System.Drawing.Point(13, 70);
            nombreDeContactoLabel.Name = "nombreDeContactoLabel";
            nombreDeContactoLabel.Size = new System.Drawing.Size(107, 13);
            nombreDeContactoLabel.TabIndex = 19;
            nombreDeContactoLabel.Text = "Nombre de contacto:";
            // 
            // numeroCelularLabel
            // 
            numeroCelularLabel.AutoSize = true;
            numeroCelularLabel.Location = new System.Drawing.Point(13, 148);
            numeroCelularLabel.Name = "numeroCelularLabel";
            numeroCelularLabel.Size = new System.Drawing.Size(96, 13);
            numeroCelularLabel.TabIndex = 21;
            numeroCelularLabel.Text = "Numero de celular:";
            // 
            // numeroTelefonoLabel
            // 
            numeroTelefonoLabel.AutoSize = true;
            numeroTelefonoLabel.Location = new System.Drawing.Point(12, 122);
            numeroTelefonoLabel.Name = "numeroTelefonoLabel";
            numeroTelefonoLabel.Size = new System.Drawing.Size(103, 13);
            numeroTelefonoLabel.TabIndex = 23;
            numeroTelefonoLabel.Text = "Numero de telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(-3, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 13);
            label6.TabIndex = 55;
            label6.Text = "Pais:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(-3, 66);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 13);
            label7.TabIndex = 54;
            label7.Text = "Localidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(-3, 39);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(54, 13);
            label8.TabIndex = 53;
            label8.Text = "Provincia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Editar proveedor";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Proveedor);
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.proveedorBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(126, 197);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioDateTimePicker.TabIndex = 7;
            this.fechaInicioDateTimePicker.DropDown += new System.EventHandler(this.fechaInicioDateTimePicker_DropDown);
            // 
            // cbPais
            // 
            this.cbPais.DataSource = this.paisBindingSource;
            this.cbPais.DisplayMember = "Nombre";
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(109, 9);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(200, 21);
            this.cbPais.TabIndex = 9;
            this.cbPais.ValueMember = "Id";
            this.cbPais.DropDownClosed += new System.EventHandler(this.cbPais_DropDownClosed);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pais);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(258, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(177, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DataSource = this.provinciaBindingSource;
            this.cbProvincia.DisplayMember = "Nombre";
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(109, 36);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(200, 21);
            this.cbProvincia.TabIndex = 10;
            this.cbProvincia.ValueMember = "Id";
            this.cbProvincia.DropDownClosed += new System.EventHandler(this.cbProvincia_DropDownClosed);
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Provincia);
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DataSource = this.localidadBindingSource;
            this.cbLocalidad.DisplayMember = "Nombre";
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(109, 63);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(200, 21);
            this.cbLocalidad.TabIndex = 11;
            this.cbLocalidad.ValueMember = "Id";
            this.cbLocalidad.Validating += new System.ComponentModel.CancelEventHandler(this.cbLocalidad_Validating);
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Localidad);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(126, 41);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreTextBox.WaterMarkText = "La Serenisima";
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // cuitTextBox
            // 
            this.cuitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Cuit", true));
            this.cuitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cuitTextBox.Location = new System.Drawing.Point(126, 93);
            this.cuitTextBox.Name = "cuitTextBox";
            this.cuitTextBox.Size = new System.Drawing.Size(200, 20);
            this.cuitTextBox.TabIndex = 3;
            this.cuitTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.cuitTextBox.WaterMarkText = "94628298";
            this.cuitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cuitTextBox_KeyPress);
            this.cuitTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cuitTextBox_Validating);
            // 
            // nombreDeContactoTextBox
            // 
            this.nombreDeContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "NombreDeContacto", true));
            this.nombreDeContactoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreDeContactoTextBox.Location = new System.Drawing.Point(126, 67);
            this.nombreDeContactoTextBox.Name = "nombreDeContactoTextBox";
            this.nombreDeContactoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreDeContactoTextBox.TabIndex = 2;
            this.nombreDeContactoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreDeContactoTextBox.WaterMarkText = "Juan Martinez";
            this.nombreDeContactoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreDeContactoTextBox_KeyPress);
            this.nombreDeContactoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreDeContactoTextBox_Validating);
            // 
            // numeroTelefonoTextBox
            // 
            this.numeroTelefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "NumeroTelefono", true));
            this.numeroTelefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroTelefonoTextBox.Location = new System.Drawing.Point(126, 119);
            this.numeroTelefonoTextBox.Name = "numeroTelefonoTextBox";
            this.numeroTelefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroTelefonoTextBox.TabIndex = 4;
            this.numeroTelefonoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroTelefonoTextBox.WaterMarkText = "3434916604";
            this.numeroTelefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTelefonoTextBox_KeyPress);
            this.numeroTelefonoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroTelefonoTextBox_Validating);
            // 
            // numeroCelularTextBox
            // 
            this.numeroCelularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "NumeroCelular", true));
            this.numeroCelularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroCelularTextBox.Location = new System.Drawing.Point(126, 145);
            this.numeroCelularTextBox.Name = "numeroCelularTextBox";
            this.numeroCelularTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroCelularTextBox.TabIndex = 5;
            this.numeroCelularTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroCelularTextBox.WaterMarkText = "3434916633";
            this.numeroCelularTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTelefonoTextBox_KeyPress);
            this.numeroCelularTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroCelularTextBox_Validating);
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(126, 171);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.correoElectronicoTextBox.TabIndex = 6;
            this.correoElectronicoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.correoElectronicoTextBox.WaterMarkText = "nombre@sitio.com";
            this.correoElectronicoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correoElectronicoTextBox_KeyPress);
            this.correoElectronicoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.correoElectronicoTextBox_Validating);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.direccionTextBox.Location = new System.Drawing.Point(126, 223);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 8;
            this.direccionTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.direccionTextBox.WaterMarkText = "25 de Mayo 493";
            this.direccionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direccionTextBox_KeyPress);
            this.direccionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.direccionTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(label6);
            this.groupBox4.Controls.Add(label7);
            this.groupBox4.Controls.Add(label8);
            this.groupBox4.Controls.Add(this.cbPais);
            this.groupBox4.Controls.Add(this.cbProvincia);
            this.groupBox4.Controls.Add(this.cbLocalidad);
            this.groupBox4.Location = new System.Drawing.Point(17, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 85);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localidad";
            // 
            // FrmEditarProveedor
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(345, 469);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.correoElectronicoTextBox);
            this.Controls.Add(this.numeroCelularTextBox);
            this.Controls.Add(this.numeroTelefonoTextBox);
            this.Controls.Add(this.nombreDeContactoTextBox);
            this.Controls.Add(this.cuitTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(cuitLabel);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(fechaInicioLabel);
            this.Controls.Add(this.fechaInicioDateTimePicker);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(nombreDeContactoLabel);
            this.Controls.Add(numeroCelularLabel);
            this.Controls.Add(numeroTelefonoLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarProveedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private wmgCMS.WaterMarkTextBox nombreTextBox;
        private wmgCMS.WaterMarkTextBox cuitTextBox;
        private wmgCMS.WaterMarkTextBox nombreDeContactoTextBox;
        private wmgCMS.WaterMarkTextBox numeroTelefonoTextBox;
        private wmgCMS.WaterMarkTextBox numeroCelularTextBox;
        private wmgCMS.WaterMarkTextBox correoElectronicoTextBox;
        private wmgCMS.WaterMarkTextBox direccionTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;

    }
}