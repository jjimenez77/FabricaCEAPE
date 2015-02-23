namespace FabricaCEAPE.Vistas
{
    partial class FrmEntregaProducto
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
            System.Windows.Forms.Label numeroTelefonoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntregaProducto));
            this.detalleEntregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtGDetalle = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.repartidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.productoTerminadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStock = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTotalCajas = new System.Windows.Forms.TextBox();
            this.txtTotalCantidad = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.entregaProductoTerminadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            numeroTelefonoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEntregaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repartidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoTerminadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaProductoTerminadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroTelefonoLabel
            // 
            numeroTelefonoLabel.AutoSize = true;
            numeroTelefonoLabel.Location = new System.Drawing.Point(12, 42);
            numeroTelefonoLabel.Name = "numeroTelefonoLabel";
            numeroTelefonoLabel.Size = new System.Drawing.Size(42, 13);
            numeroTelefonoLabel.TabIndex = 22;
            numeroTelefonoLabel.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 23;
            label1.Text = "Repartidor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 24;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(321, 70);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 26;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(471, 70);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 13);
            label4.TabIndex = 28;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 97);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 13);
            label5.TabIndex = 30;
            label5.Text = "Tipo de producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(371, 180);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(118, 13);
            label6.TabIndex = 35;
            label6.Text = "Total de cajas a enviar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(371, 154);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 38;
            label9.Text = "Total";
            label9.Visible = false;
            // 
            // detalleEntregaBindingSource
            // 
            this.detalleEntregaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.DetalleEntrega);
            // 
            // dtGDetalle
            // 
            this.dtGDetalle.AllowUserToAddRows = false;
            this.dtGDetalle.AllowUserToDeleteRows = false;
            this.dtGDetalle.AllowUserToResizeColumns = false;
            this.dtGDetalle.AllowUserToResizeRows = false;
            this.dtGDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGDetalle.AutoGenerateColumns = false;
            this.dtGDetalle.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtGDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtGDetalle.DataSource = this.detalleEntregaBindingSource;
            this.dtGDetalle.Location = new System.Drawing.Point(15, 151);
            this.dtGDetalle.MultiSelect = false;
            this.dtGDetalle.Name = "dtGDetalle";
            this.dtGDetalle.ReadOnly = true;
            this.dtGDetalle.RowHeadersVisible = false;
            this.dtGDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGDetalle.Size = new System.Drawing.Size(353, 168);
            this.dtGDetalle.StandardTab = true;
            this.dtGDetalle.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad de cajas";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.repartidorBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id";
            // 
            // repartidorBindingSource
            // 
            this.repartidorBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Repartidor);
            // 
            // cbCliente
            // 
            this.cbCliente.DataSource = this.clienteBindingSource;
            this.cbCliente.DisplayMember = "Nombre";
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(109, 39);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(206, 21);
            this.cbCliente.TabIndex = 10;
            this.cbCliente.ValueMember = "Id";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Cliente);
            // 
            // cbProducto
            // 
            this.cbProducto.DataSource = this.productoTerminadoBindingSource;
            this.cbProducto.DisplayMember = "Producto";
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(109, 67);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(206, 21);
            this.cbProducto.TabIndex = 11;
            this.cbProducto.ValueMember = "IdProductoTerminado";
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            this.cbProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProducto_KeyPress);
            // 
            // productoTerminadoBindingSource
            // 
            this.productoTerminadoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.ProductoTerminado);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(365, 67);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 25;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(529, 68);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(66, 20);
            this.numCantidad.TabIndex = 27;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            this.numCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numCantidad_KeyUp);
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(109, 94);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.ReadOnly = true;
            this.txtTipoProducto.Size = new System.Drawing.Size(206, 20);
            this.txtTipoProducto.TabIndex = 29;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(582, 296);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(501, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTotalCajas
            // 
            this.txtTotalCajas.Location = new System.Drawing.Point(495, 177);
            this.txtTotalCajas.Name = "txtTotalCajas";
            this.txtTotalCajas.ReadOnly = true;
            this.txtTotalCajas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCajas.TabIndex = 33;
            // 
            // txtTotalCantidad
            // 
            this.txtTotalCantidad.Location = new System.Drawing.Point(495, 151);
            this.txtTotalCantidad.Name = "txtTotalCantidad";
            this.txtTotalCantidad.ReadOnly = true;
            this.txtTotalCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCantidad.TabIndex = 34;
            this.txtTotalCantidad.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(601, 66);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(23, 23);
            this.btnagregar.TabIndex = 36;
            this.btnagregar.Text = "+";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            this.btnagregar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnagregar_MouseClick);
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(630, 66);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(23, 23);
            this.btnquitar.TabIndex = 37;
            this.btnquitar.Text = "-";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // entregaProductoTerminadoBindingSource
            // 
            this.entregaProductoTerminadoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.EntregaProductoTerminado);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmEntregaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 331);
            this.Controls.Add(label9);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtTotalCantidad);
            this.Controls.Add(this.txtTotalCajas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(label4);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(numeroTelefonoLabel);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtGDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEntregaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega producto terminado";
            this.Load += new System.EventHandler(this.FrmEntregaProducto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.detalleEntregaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repartidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoTerminadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaProductoTerminadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource detalleEntregaBindingSource;
        private System.Windows.Forms.DataGridView dtGDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTotalCajas;
        private System.Windows.Forms.TextBox txtTotalCantidad;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.BindingSource repartidorBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource entregaProductoTerminadoBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource productoTerminadoBindingSource;
    }
}