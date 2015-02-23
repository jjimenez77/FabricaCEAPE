namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarArticuloPedido
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreMedidaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarArticuloPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.articuloPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nombreTextBox = new wmgCMS.WaterMarkTextBox();
            this.descripcionTextBox = new wmgCMS.WaterMarkTextBox();
            this.cantidadTextBox = new wmgCMS.WaterMarkTextBox();
            cantidadLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreMedidaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articuloPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(12, 175);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 3;
            cantidadLabel.Text = "Cantidad:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 69);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreMedidaLabel
            // 
            nombreMedidaLabel.AutoSize = true;
            nombreMedidaLabel.Location = new System.Drawing.Point(12, 201);
            nombreMedidaLabel.Name = "nombreMedidaLabel";
            nombreMedidaLabel.Size = new System.Drawing.Size(45, 13);
            nombreMedidaLabel.TabIndex = 11;
            nombreMedidaLabel.Text = "Medida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar articulo de pedido";
            // 
            // articuloPedidoBindingSource
            // 
            this.articuloPedidoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.ArticuloPedido);
            // 
            // cbMedida
            // 
            this.cbMedida.DataSource = this.medidaBindingSource;
            this.cbMedida.DisplayMember = "Nombre";
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(84, 198);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(206, 21);
            this.cbMedida.TabIndex = 3;
            this.cbMedida.ValueMember = "Id";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Medida);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(222, 274);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(141, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pedido);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloPedidoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(84, 40);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreTextBox.TabIndex = 12;
            this.nombreTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreTextBox.WaterMarkText = "Harina";
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloPedidoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.descripcionTextBox.Location = new System.Drawing.Point(84, 66);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(206, 100);
            this.descripcionTextBox.TabIndex = 13;
            this.descripcionTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.descripcionTextBox.WaterMarkText = "Descripcion extra";
            this.descripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcionTextBox_KeyPress);
            this.descripcionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descripcionTextBox_Validating);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloPedidoBindingSource, "Cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cantidadTextBox.Location = new System.Drawing.Point(84, 172);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(206, 20);
            this.cantidadTextBox.TabIndex = 14;
            this.cantidadTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.cantidadTextBox.WaterMarkText = "50";
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadTextBox_KeyPress);
            this.cantidadTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cantidadTextBox_Validating);
            // 
            // FrmEditarArticuloPedido
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(309, 309);
            this.ControlBox = false;
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbMedida);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(nombreMedidaLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarArticuloPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar articulo de pedido";
            ((System.ComponentModel.ISupportInitialize)(this.articuloPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource articuloPedidoBindingSource;
        private System.Windows.Forms.ComboBox cbMedida;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private wmgCMS.WaterMarkTextBox cantidadTextBox;
        private wmgCMS.WaterMarkTextBox descripcionTextBox;
        private wmgCMS.WaterMarkTextBox nombreTextBox;
    }
}