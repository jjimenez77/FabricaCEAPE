namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarUsuarioLimitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuarioLimitado));
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label correoElectronicoAlternativoLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label numeroTelefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label numeroCelularLabel;
            System.Windows.Forms.Label numeroDocumentoLabel;
            System.Windows.Forms.Label tipoDocumentoLabel;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoDropbox = new System.Windows.Forms.ComboBox();
            this.direccionTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroDocumentoTextBox = new wmgCMS.WaterMarkTextBox();
            this.correoElectronicoTextBox = new wmgCMS.WaterMarkTextBox();
            this.correoElectronicoAlternativoTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroCelularTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroTelefonoTextBox = new wmgCMS.WaterMarkTextBox();
            this.apellidoTextBox = new wmgCMS.WaterMarkTextBox();
            this.nombreTextBox = new wmgCMS.WaterMarkTextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label10 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            correoElectronicoAlternativoLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            numeroTelefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            numeroCelularLabel = new System.Windows.Forms.Label();
            numeroDocumentoLabel = new System.Windows.Forms.Label();
            tipoDocumentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pais);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Usuario);
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Provincia);
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Localidad);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(312, 522);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(231, 522);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Editar usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.tipoDocumentoDropbox);
            this.groupBox2.Controls.Add(this.direccionTextBox);
            this.groupBox2.Controls.Add(this.numeroDocumentoTextBox);
            this.groupBox2.Controls.Add(this.correoElectronicoTextBox);
            this.groupBox2.Controls.Add(this.correoElectronicoAlternativoTextBox);
            this.groupBox2.Controls.Add(this.numeroCelularTextBox);
            this.groupBox2.Controls.Add(this.numeroTelefonoTextBox);
            this.groupBox2.Controls.Add(this.apellidoTextBox);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(correoElectronicoAlternativoLabel);
            this.groupBox2.Controls.Add(apellidoLabel);
            this.groupBox2.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.groupBox2.Controls.Add(fechaNacimientoLabel);
            this.groupBox2.Controls.Add(numeroTelefonoLabel);
            this.groupBox2.Controls.Add(direccionLabel);
            this.groupBox2.Controls.Add(correoElectronicoLabel);
            this.groupBox2.Controls.Add(numeroCelularLabel);
            this.groupBox2.Controls.Add(numeroDocumentoLabel);
            this.groupBox2.Controls.Add(tipoDocumentoLabel);
            this.groupBox2.Location = new System.Drawing.Point(7, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 373);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPais);
            this.groupBox4.Controls.Add(this.cbProvincia);
            this.groupBox4.Controls.Add(label10);
            this.groupBox4.Controls.Add(this.cbLocalidad);
            this.groupBox4.Controls.Add(label14);
            this.groupBox4.Controls.Add(label27);
            this.groupBox4.Location = new System.Drawing.Point(9, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 85);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localidad";
            // 
            // cbPais
            // 
            this.cbPais.DisplayMember = "Nombre";
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(151, 9);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(206, 21);
            this.cbPais.TabIndex = 17;
            this.cbPais.ValueMember = "Id";
            // 
            // cbProvincia
            // 
            this.cbProvincia.DisplayMember = "Nombre";
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(151, 36);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(206, 21);
            this.cbProvincia.TabIndex = 18;
            this.cbProvincia.ValueMember = "Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(-3, 12);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(30, 13);
            label10.TabIndex = 55;
            label10.Text = "Pais:";
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DisplayMember = "Nombre";
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(151, 61);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(206, 21);
            this.cbLocalidad.TabIndex = 19;
            this.cbLocalidad.ValueMember = "Id";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(-3, 66);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(56, 13);
            label14.TabIndex = 54;
            label14.Text = "Localidad:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(-3, 39);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(54, 13);
            label27.TabIndex = 53;
            label27.Text = "Provincia:";
            // 
            // tipoDocumentoDropbox
            // 
            this.tipoDocumentoDropbox.DisplayMember = "Id";
            this.tipoDocumentoDropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDocumentoDropbox.FormattingEnabled = true;
            this.tipoDocumentoDropbox.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE",
            "OTRO"});
            this.tipoDocumentoDropbox.Location = new System.Drawing.Point(160, 201);
            this.tipoDocumentoDropbox.Name = "tipoDocumentoDropbox";
            this.tipoDocumentoDropbox.Size = new System.Drawing.Size(206, 21);
            this.tipoDocumentoDropbox.TabIndex = 12;
            this.tipoDocumentoDropbox.ValueMember = "Id";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.direccionTextBox.Location = new System.Drawing.Point(160, 253);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(206, 20);
            this.direccionTextBox.TabIndex = 16;
            this.direccionTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.direccionTextBox.WaterMarkText = "Uruguay 148 depto. 6";
            // 
            // numeroDocumentoTextBox
            // 
            this.numeroDocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NumeroDocumento", true));
            this.numeroDocumentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroDocumentoTextBox.Location = new System.Drawing.Point(160, 227);
            this.numeroDocumentoTextBox.Name = "numeroDocumentoTextBox";
            this.numeroDocumentoTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroDocumentoTextBox.TabIndex = 13;
            this.numeroDocumentoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroDocumentoTextBox.WaterMarkText = "94693298";
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(160, 149);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(206, 20);
            this.correoElectronicoTextBox.TabIndex = 10;
            this.correoElectronicoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.correoElectronicoTextBox.WaterMarkText = "nombre@sitio.com";
            // 
            // correoElectronicoAlternativoTextBox
            // 
            this.correoElectronicoAlternativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CorreoElectronicoAlternativo", true));
            this.correoElectronicoAlternativoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.correoElectronicoAlternativoTextBox.Location = new System.Drawing.Point(160, 175);
            this.correoElectronicoAlternativoTextBox.Name = "correoElectronicoAlternativoTextBox";
            this.correoElectronicoAlternativoTextBox.Size = new System.Drawing.Size(206, 20);
            this.correoElectronicoAlternativoTextBox.TabIndex = 11;
            this.correoElectronicoAlternativoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.correoElectronicoAlternativoTextBox.WaterMarkText = "nombre@sitio.com";
            // 
            // numeroCelularTextBox
            // 
            this.numeroCelularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NumeroCelular", true));
            this.numeroCelularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroCelularTextBox.Location = new System.Drawing.Point(160, 123);
            this.numeroCelularTextBox.Name = "numeroCelularTextBox";
            this.numeroCelularTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroCelularTextBox.TabIndex = 9;
            this.numeroCelularTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroCelularTextBox.WaterMarkText = "3434527700";
            // 
            // numeroTelefonoTextBox
            // 
            this.numeroTelefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NumeroTelefono", true));
            this.numeroTelefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroTelefonoTextBox.Location = new System.Drawing.Point(160, 97);
            this.numeroTelefonoTextBox.Name = "numeroTelefonoTextBox";
            this.numeroTelefonoTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroTelefonoTextBox.TabIndex = 8;
            this.numeroTelefonoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroTelefonoTextBox.WaterMarkText = "3434527708";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.apellidoTextBox.Location = new System.Drawing.Point(160, 45);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(206, 20);
            this.apellidoTextBox.TabIndex = 2;
            this.apellidoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.apellidoTextBox.WaterMarkText = "Jimenez";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(160, 19);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreTextBox.WaterMarkText = "Jonas";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(6, 25);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 18;
            nombreLabel.Text = "Nombre:";
            // 
            // correoElectronicoAlternativoLabel
            // 
            correoElectronicoAlternativoLabel.AutoSize = true;
            correoElectronicoAlternativoLabel.Location = new System.Drawing.Point(6, 178);
            correoElectronicoAlternativoLabel.Name = "correoElectronicoAlternativoLabel";
            correoElectronicoAlternativoLabel.Size = new System.Drawing.Size(148, 13);
            correoElectronicoAlternativoLabel.TabIndex = 6;
            correoElectronicoAlternativoLabel.Text = "Correo electronico alternativo:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(6, 48);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 2;
            apellidoLabel.Text = "Apellido:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(160, 71);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 7;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(6, 77);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(109, 13);
            fechaNacimientoLabel.TabIndex = 14;
            fechaNacimientoLabel.Text = "Fecha de nacimiento:";
            // 
            // numeroTelefonoLabel
            // 
            numeroTelefonoLabel.AutoSize = true;
            numeroTelefonoLabel.Location = new System.Drawing.Point(6, 100);
            numeroTelefonoLabel.Name = "numeroTelefonoLabel";
            numeroTelefonoLabel.Size = new System.Drawing.Size(103, 13);
            numeroTelefonoLabel.TabIndex = 24;
            numeroTelefonoLabel.Text = "Numero de telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(6, 256);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Direccion:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(6, 152);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(96, 13);
            correoElectronicoLabel.TabIndex = 4;
            correoElectronicoLabel.Text = "Correo electronico:";
            // 
            // numeroCelularLabel
            // 
            numeroCelularLabel.AutoSize = true;
            numeroCelularLabel.Location = new System.Drawing.Point(6, 126);
            numeroCelularLabel.Name = "numeroCelularLabel";
            numeroCelularLabel.Size = new System.Drawing.Size(96, 13);
            numeroCelularLabel.TabIndex = 20;
            numeroCelularLabel.Text = "Numero de celular:";
            // 
            // numeroDocumentoLabel
            // 
            numeroDocumentoLabel.AutoSize = true;
            numeroDocumentoLabel.Location = new System.Drawing.Point(6, 230);
            numeroDocumentoLabel.Name = "numeroDocumentoLabel";
            numeroDocumentoLabel.Size = new System.Drawing.Size(118, 13);
            numeroDocumentoLabel.TabIndex = 22;
            numeroDocumentoLabel.Text = "Numero de documento:";
            // 
            // tipoDocumentoLabel
            // 
            tipoDocumentoLabel.AutoSize = true;
            tipoDocumentoLabel.Location = new System.Drawing.Point(6, 204);
            tipoDocumentoLabel.Name = "tipoDocumentoLabel";
            tipoDocumentoLabel.Size = new System.Drawing.Size(102, 13);
            tipoDocumentoLabel.TabIndex = 28;
            tipoDocumentoLabel.Text = "Tipo de documento:";
            // 
            // FrmEditarUsuarioLimitado
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(399, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarUsuarioLimitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar usuario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox tipoDocumentoDropbox;
        private wmgCMS.WaterMarkTextBox direccionTextBox;
        private wmgCMS.WaterMarkTextBox numeroDocumentoTextBox;
        private wmgCMS.WaterMarkTextBox correoElectronicoTextBox;
        private wmgCMS.WaterMarkTextBox correoElectronicoAlternativoTextBox;
        private wmgCMS.WaterMarkTextBox numeroCelularTextBox;
        private wmgCMS.WaterMarkTextBox numeroTelefonoTextBox;
        private wmgCMS.WaterMarkTextBox apellidoTextBox;
        private wmgCMS.WaterMarkTextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
    }
}