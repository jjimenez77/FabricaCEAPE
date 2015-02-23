namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarRepartidor
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label correoElectronicoAlternativoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numeroCelularLabel;
            System.Windows.Forms.Label numeroDocumentoLabel;
            System.Windows.Forms.Label numeroTelefonoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarRepartidor));
            this.label1 = new System.Windows.Forms.Label();
            this.repartidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.correoElectronicoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.correoElectronicoAlternativoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.direccionWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroCelularWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroDocumentoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.numeroTelefonoWaterMarkTextBox = new wmgCMS.WaterMarkTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.tipoDocumentoDropbox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPais2 = new System.Windows.Forms.ComboBox();
            this.paisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbZona2 = new System.Windows.Forms.ComboBox();
            this.zonaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbLocalidad2 = new System.Windows.Forms.ComboBox();
            this.localidadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbProvincia2 = new System.Windows.Forms.ComboBox();
            this.provinciaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            apellidoLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            correoElectronicoAlternativoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numeroCelularLabel = new System.Windows.Forms.Label();
            numeroDocumentoLabel = new System.Windows.Forms.Label();
            numeroTelefonoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repartidorBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(13, 69);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 10;
            apellidoLabel.Text = "Apellido:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(13, 193);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(96, 13);
            correoElectronicoLabel.TabIndex = 12;
            correoElectronicoLabel.Text = "Correo electronico:";
            // 
            // correoElectronicoAlternativoLabel
            // 
            correoElectronicoAlternativoLabel.AutoSize = true;
            correoElectronicoAlternativoLabel.Location = new System.Drawing.Point(13, 219);
            correoElectronicoAlternativoLabel.Name = "correoElectronicoAlternativoLabel";
            correoElectronicoAlternativoLabel.Size = new System.Drawing.Size(148, 13);
            correoElectronicoAlternativoLabel.TabIndex = 14;
            correoElectronicoAlternativoLabel.Text = "Correo electronico alternativo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(13, 324);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 16;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Location = new System.Drawing.Point(13, 301);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(92, 13);
            fechaIngresoLabel.TabIndex = 18;
            fechaIngresoLabel.Text = "Fecha de ingreso:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(13, 118);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(109, 13);
            fechaNacimientoLabel.TabIndex = 20;
            fechaNacimientoLabel.Text = "Fecha de nacimiento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(13, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 24;
            nombreLabel.Text = "Nombre:";
            // 
            // numeroCelularLabel
            // 
            numeroCelularLabel.AutoSize = true;
            numeroCelularLabel.Location = new System.Drawing.Point(13, 167);
            numeroCelularLabel.Name = "numeroCelularLabel";
            numeroCelularLabel.Size = new System.Drawing.Size(96, 13);
            numeroCelularLabel.TabIndex = 26;
            numeroCelularLabel.Text = "Numero de celular:";
            // 
            // numeroDocumentoLabel
            // 
            numeroDocumentoLabel.AutoSize = true;
            numeroDocumentoLabel.Location = new System.Drawing.Point(13, 272);
            numeroDocumentoLabel.Name = "numeroDocumentoLabel";
            numeroDocumentoLabel.Size = new System.Drawing.Size(118, 13);
            numeroDocumentoLabel.TabIndex = 28;
            numeroDocumentoLabel.Text = "Numero de documento:";
            // 
            // numeroTelefonoLabel
            // 
            numeroTelefonoLabel.AutoSize = true;
            numeroTelefonoLabel.Location = new System.Drawing.Point(13, 141);
            numeroTelefonoLabel.Name = "numeroTelefonoLabel";
            numeroTelefonoLabel.Size = new System.Drawing.Size(103, 13);
            numeroTelefonoLabel.TabIndex = 30;
            numeroTelefonoLabel.Text = "Numero de telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 245);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 13);
            label2.TabIndex = 40;
            label2.Text = "Tipo de documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 41;
            label3.Text = "Sexo:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(-3, 12);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(30, 13);
            label4.TabIndex = 55;
            label4.Text = "Pais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(-3, 66);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 13);
            label5.TabIndex = 54;
            label5.Text = "Localidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(-3, 39);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 13);
            label9.TabIndex = 53;
            label9.Text = "Provincia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(-3, 93);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(35, 13);
            label10.TabIndex = 24;
            label10.Text = "Zona:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Editar repartidor";
            // 
            // repartidorBindingSource
            // 
            this.repartidorBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Repartidor);
            // 
            // apellidoWaterMarkTextBox
            // 
            this.apellidoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "Apellido", true));
            this.apellidoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.apellidoWaterMarkTextBox.Location = new System.Drawing.Point(167, 66);
            this.apellidoWaterMarkTextBox.Name = "apellidoWaterMarkTextBox";
            this.apellidoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.apellidoWaterMarkTextBox.TabIndex = 1;
            this.apellidoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.apellidoWaterMarkTextBox.WaterMarkText = "Perez";
            this.apellidoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreWaterMarkTextBox_KeyPress);
            this.apellidoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.apellidoWaterMarkTextBox_Validating);
            // 
            // correoElectronicoWaterMarkTextBox
            // 
            this.correoElectronicoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "CorreoElectronico", true));
            this.correoElectronicoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.correoElectronicoWaterMarkTextBox.Location = new System.Drawing.Point(167, 190);
            this.correoElectronicoWaterMarkTextBox.Name = "correoElectronicoWaterMarkTextBox";
            this.correoElectronicoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.correoElectronicoWaterMarkTextBox.TabIndex = 7;
            this.correoElectronicoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.correoElectronicoWaterMarkTextBox.WaterMarkText = "nombre@sitio.com";
            this.correoElectronicoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correoElectronicoWaterMarkTextBox_KeyPress);
            this.correoElectronicoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.correoElectronicoWaterMarkTextBox_Validating);
            // 
            // correoElectronicoAlternativoWaterMarkTextBox
            // 
            this.correoElectronicoAlternativoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "CorreoElectronicoAlternativo", true));
            this.correoElectronicoAlternativoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.correoElectronicoAlternativoWaterMarkTextBox.Location = new System.Drawing.Point(167, 216);
            this.correoElectronicoAlternativoWaterMarkTextBox.Name = "correoElectronicoAlternativoWaterMarkTextBox";
            this.correoElectronicoAlternativoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.correoElectronicoAlternativoWaterMarkTextBox.TabIndex = 8;
            this.correoElectronicoAlternativoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.correoElectronicoAlternativoWaterMarkTextBox.WaterMarkText = "alternativo@sitio.com";
            this.correoElectronicoAlternativoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correoElectronicoWaterMarkTextBox_KeyPress);
            this.correoElectronicoAlternativoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.correoElectronicoAlternativoWaterMarkTextBox_Validating);
            // 
            // direccionWaterMarkTextBox
            // 
            this.direccionWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "Direccion", true));
            this.direccionWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.direccionWaterMarkTextBox.Location = new System.Drawing.Point(167, 321);
            this.direccionWaterMarkTextBox.Name = "direccionWaterMarkTextBox";
            this.direccionWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.direccionWaterMarkTextBox.TabIndex = 12;
            this.direccionWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.direccionWaterMarkTextBox.WaterMarkText = "9 de Julio 99";
            this.direccionWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direccionWaterMarkTextBox_KeyPress);
            this.direccionWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.direccionWaterMarkTextBox_Validating);
            // 
            // fechaIngresoDateTimePicker
            // 
            this.fechaIngresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.repartidorBindingSource, "FechaIngreso", true));
            this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(167, 295);
            this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.fechaIngresoDateTimePicker.TabIndex = 11;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.repartidorBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(167, 112);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 4;
            this.fechaNacimientoDateTimePicker.DropDown += new System.EventHandler(this.fechaNacimientoDateTimePicker_DropDown);
            // 
            // nombreWaterMarkTextBox
            // 
            this.nombreWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "Nombre", true));
            this.nombreWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreWaterMarkTextBox.Location = new System.Drawing.Point(167, 40);
            this.nombreWaterMarkTextBox.Name = "nombreWaterMarkTextBox";
            this.nombreWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreWaterMarkTextBox.TabIndex = 0;
            this.nombreWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreWaterMarkTextBox.WaterMarkText = "Juan";
            this.nombreWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreWaterMarkTextBox_KeyPress);
            this.nombreWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreWaterMarkTextBox_Validating);
            // 
            // numeroCelularWaterMarkTextBox
            // 
            this.numeroCelularWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "NumeroCelular", true));
            this.numeroCelularWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroCelularWaterMarkTextBox.Location = new System.Drawing.Point(167, 164);
            this.numeroCelularWaterMarkTextBox.Name = "numeroCelularWaterMarkTextBox";
            this.numeroCelularWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroCelularWaterMarkTextBox.TabIndex = 6;
            this.numeroCelularWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroCelularWaterMarkTextBox.WaterMarkText = "3434560090";
            this.numeroCelularWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTelefonoWaterMarkTextBox_KeyPress);
            this.numeroCelularWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroCelularWaterMarkTextBox_Validating);
            // 
            // numeroDocumentoWaterMarkTextBox
            // 
            this.numeroDocumentoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "NumeroDocumento", true));
            this.numeroDocumentoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroDocumentoWaterMarkTextBox.Location = new System.Drawing.Point(167, 269);
            this.numeroDocumentoWaterMarkTextBox.Name = "numeroDocumentoWaterMarkTextBox";
            this.numeroDocumentoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroDocumentoWaterMarkTextBox.TabIndex = 10;
            this.numeroDocumentoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroDocumentoWaterMarkTextBox.WaterMarkText = "94432267";
            this.numeroDocumentoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroDocumentoWaterMarkTextBox_KeyPress);
            this.numeroDocumentoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroDocumentoWaterMarkTextBox_Validating);
            // 
            // numeroTelefonoWaterMarkTextBox
            // 
            this.numeroTelefonoWaterMarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartidorBindingSource, "NumeroTelefono", true));
            this.numeroTelefonoWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numeroTelefonoWaterMarkTextBox.Location = new System.Drawing.Point(167, 138);
            this.numeroTelefonoWaterMarkTextBox.Name = "numeroTelefonoWaterMarkTextBox";
            this.numeroTelefonoWaterMarkTextBox.Size = new System.Drawing.Size(206, 20);
            this.numeroTelefonoWaterMarkTextBox.TabIndex = 5;
            this.numeroTelefonoWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.numeroTelefonoWaterMarkTextBox.WaterMarkText = "3434532292";
            this.numeroTelefonoWaterMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTelefonoWaterMarkTextBox_KeyPress);
            this.numeroTelefonoWaterMarkTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroTelefonoWaterMarkTextBox_Validating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnF);
            this.panel2.Controls.Add(this.rbtnM);
            this.panel2.Location = new System.Drawing.Point(167, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 21);
            this.panel2.TabIndex = 38;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Location = new System.Drawing.Point(97, 3);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(71, 17);
            this.rbtnF.TabIndex = 3;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "Femenino";
            this.rbtnF.UseVisualStyleBackColor = true;
            this.rbtnF.CheckedChanged += new System.EventHandler(this.rbtnF_CheckedChanged);
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(3, 3);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(73, 17);
            this.rbtnM.TabIndex = 2;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "Masculino";
            this.rbtnM.UseVisualStyleBackColor = true;
            this.rbtnM.CheckedChanged += new System.EventHandler(this.rbtnM_CheckedChanged);
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
            this.tipoDocumentoDropbox.Location = new System.Drawing.Point(167, 242);
            this.tipoDocumentoDropbox.Name = "tipoDocumentoDropbox";
            this.tipoDocumentoDropbox.Size = new System.Drawing.Size(206, 21);
            this.tipoDocumentoDropbox.TabIndex = 9;
            this.tipoDocumentoDropbox.ValueMember = "Id";
            this.tipoDocumentoDropbox.DropDownClosed += new System.EventHandler(this.tipoDocumentoDropbox_DropDownClosed);
            this.tipoDocumentoDropbox.Validating += new System.ComponentModel.CancelEventHandler(this.tipoDocumentoDropbox_Validating);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPais);
            this.groupBox4.Controls.Add(this.cbProvincia);
            this.groupBox4.Controls.Add(label6);
            this.groupBox4.Controls.Add(this.cbLocalidad);
            this.groupBox4.Controls.Add(label7);
            this.groupBox4.Controls.Add(label8);
            this.groupBox4.Location = new System.Drawing.Point(16, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 85);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localidad";
            // 
            // cbPais
            // 
            this.cbPais.DataSource = this.paisBindingSource;
            this.cbPais.DisplayMember = "Nombre";
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(151, 9);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(206, 21);
            this.cbPais.TabIndex = 13;
            this.cbPais.ValueMember = "Id";
            this.cbPais.DropDownClosed += new System.EventHandler(this.cbPais_DropDownClosed);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pais);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DataSource = this.provinciaBindingSource;
            this.cbProvincia.DisplayMember = "Nombre";
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(151, 36);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(206, 21);
            this.cbProvincia.TabIndex = 14;
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
            this.cbLocalidad.Location = new System.Drawing.Point(151, 61);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(206, 21);
            this.cbLocalidad.TabIndex = 15;
            this.cbLocalidad.ValueMember = "Id";
            this.cbLocalidad.Validating += new System.ComponentModel.CancelEventHandler(this.cbLocalidad_Validating);
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Localidad);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPais2);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.cbZona2);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.cbLocalidad2);
            this.groupBox1.Controls.Add(this.cbProvincia2);
            this.groupBox1.Controls.Add(label10);
            this.groupBox1.Location = new System.Drawing.Point(16, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 114);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zona de trabajo";
            // 
            // cbPais2
            // 
            this.cbPais2.DataSource = this.paisBindingSource2;
            this.cbPais2.DisplayMember = "Nombre";
            this.cbPais2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais2.FormattingEnabled = true;
            this.cbPais2.Location = new System.Drawing.Point(151, 9);
            this.cbPais2.Name = "cbPais2";
            this.cbPais2.Size = new System.Drawing.Size(206, 21);
            this.cbPais2.TabIndex = 16;
            this.cbPais2.ValueMember = "Id";
            this.cbPais2.DropDownClosed += new System.EventHandler(this.cbPais2_DropDownClosed);
            // 
            // paisBindingSource2
            // 
            this.paisBindingSource2.DataSource = typeof(FabricaCEAPE.Clases.Pais);
            // 
            // cbZona2
            // 
            this.cbZona2.DataSource = this.zonaBindingSource2;
            this.cbZona2.DisplayMember = "Nombre";
            this.cbZona2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZona2.FormattingEnabled = true;
            this.cbZona2.Location = new System.Drawing.Point(151, 90);
            this.cbZona2.Name = "cbZona2";
            this.cbZona2.Size = new System.Drawing.Size(206, 21);
            this.cbZona2.TabIndex = 19;
            this.cbZona2.ValueMember = "IdZona";
            this.cbZona2.Validating += new System.ComponentModel.CancelEventHandler(this.cbZona2_Validating);
            // 
            // zonaBindingSource2
            // 
            this.zonaBindingSource2.DataSource = typeof(FabricaCEAPE.Clases.Zona);
            // 
            // cbLocalidad2
            // 
            this.cbLocalidad2.DataSource = this.localidadBindingSource2;
            this.cbLocalidad2.DisplayMember = "Nombre";
            this.cbLocalidad2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad2.FormattingEnabled = true;
            this.cbLocalidad2.Location = new System.Drawing.Point(151, 63);
            this.cbLocalidad2.Name = "cbLocalidad2";
            this.cbLocalidad2.Size = new System.Drawing.Size(206, 21);
            this.cbLocalidad2.TabIndex = 18;
            this.cbLocalidad2.ValueMember = "Id";
            this.cbLocalidad2.DropDownClosed += new System.EventHandler(this.cbLocalidad2_DropDownClosed);
            // 
            // localidadBindingSource2
            // 
            this.localidadBindingSource2.DataSource = typeof(FabricaCEAPE.Clases.Localidad);
            // 
            // cbProvincia2
            // 
            this.cbProvincia2.DataSource = this.provinciaBindingSource2;
            this.cbProvincia2.DisplayMember = "Nombre";
            this.cbProvincia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia2.FormattingEnabled = true;
            this.cbProvincia2.Location = new System.Drawing.Point(151, 36);
            this.cbProvincia2.Name = "cbProvincia2";
            this.cbProvincia2.Size = new System.Drawing.Size(206, 21);
            this.cbProvincia2.TabIndex = 17;
            this.cbProvincia2.ValueMember = "Id";
            this.cbProvincia2.DropDownClosed += new System.EventHandler(this.cbProvincia2_DropDownClosed);
            // 
            // provinciaBindingSource2
            // 
            this.provinciaBindingSource2.DataSource = typeof(FabricaCEAPE.Clases.Provincia);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(225, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(306, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEditarRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 626);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(label3);
            this.Controls.Add(this.tipoDocumentoDropbox);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoWaterMarkTextBox);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoWaterMarkTextBox);
            this.Controls.Add(correoElectronicoAlternativoLabel);
            this.Controls.Add(this.correoElectronicoAlternativoWaterMarkTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionWaterMarkTextBox);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.fechaIngresoDateTimePicker);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreWaterMarkTextBox);
            this.Controls.Add(numeroCelularLabel);
            this.Controls.Add(this.numeroCelularWaterMarkTextBox);
            this.Controls.Add(numeroDocumentoLabel);
            this.Controls.Add(this.numeroDocumentoWaterMarkTextBox);
            this.Controls.Add(numeroTelefonoLabel);
            this.Controls.Add(this.numeroTelefonoWaterMarkTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarRepartidor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar repartidor";
            ((System.ComponentModel.ISupportInitialize)(this.repartidorBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource repartidorBindingSource;
        private wmgCMS.WaterMarkTextBox apellidoWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox correoElectronicoWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox correoElectronicoAlternativoWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox direccionWaterMarkTextBox;
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private wmgCMS.WaterMarkTextBox nombreWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox numeroCelularWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox numeroDocumentoWaterMarkTextBox;
        private wmgCMS.WaterMarkTextBox numeroTelefonoWaterMarkTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.ComboBox tipoDocumentoDropbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPais2;
        private System.Windows.Forms.ComboBox cbZona2;
        private System.Windows.Forms.ComboBox cbLocalidad2;
        private System.Windows.Forms.ComboBox cbProvincia2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private System.Windows.Forms.BindingSource zonaBindingSource2;
        private System.Windows.Forms.BindingSource paisBindingSource2;
        private System.Windows.Forms.BindingSource provinciaBindingSource2;
        private System.Windows.Forms.BindingSource localidadBindingSource2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}