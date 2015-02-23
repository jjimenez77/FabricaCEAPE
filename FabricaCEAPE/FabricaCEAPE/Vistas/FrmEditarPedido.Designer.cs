namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarPedido
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
            System.Windows.Forms.Button btnAceptar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarPedido));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbDepartamento = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.conceptoTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.articuloPedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.descripcionTextBox = new wmgCMS.WaterMarkTextBox();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            btnAceptar = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloPedidoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloPedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnAceptar.Location = new System.Drawing.Point(838, 324);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Enviar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Location = new System.Drawing.Point(757, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo articulo de pedido";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::FabricaCEAPE.Properties.Resources.pencil43;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.ToolTipText = "Modificar articulo de pedido";
            this.btnModificar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::FabricaCEAPE.Properties.Resources.delete96;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar articulo de pedido";
            this.btnEliminar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(206, 25);
            this.cbDepartamento.ToolTipText = "Seleccione el departamento de destino";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.conceptoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(206, 25);
            this.conceptoTextBox.Text = "Concepto";
            this.conceptoTextBox.ToolTipText = "Concepto de pedido";
            this.conceptoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcionTextBox_KeyPress);
            this.conceptoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.conceptoTextBox_Validating);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.cbDepartamento,
            this.toolStripSeparator4,
            this.conceptoTextBox});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(925, 25);
            this.menu.TabIndex = 0;
            this.menu.TabStop = true;
            this.menu.Text = "menu";
            // 
            // articuloPedidoDataGridView
            // 
            this.articuloPedidoDataGridView.AllowUserToAddRows = false;
            this.articuloPedidoDataGridView.AllowUserToDeleteRows = false;
            this.articuloPedidoDataGridView.AllowUserToResizeColumns = false;
            this.articuloPedidoDataGridView.AllowUserToResizeRows = false;
            this.articuloPedidoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.articuloPedidoDataGridView.AutoGenerateColumns = false;
            this.articuloPedidoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.articuloPedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articuloPedidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.articuloPedidoDataGridView.DataSource = this.articuloPedidoBindingSource;
            this.articuloPedidoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.articuloPedidoDataGridView.Name = "articuloPedidoDataGridView";
            this.articuloPedidoDataGridView.ReadOnly = true;
            this.articuloPedidoDataGridView.RowHeadersVisible = false;
            this.articuloPedidoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articuloPedidoDataGridView.Size = new System.Drawing.Size(683, 318);
            this.articuloPedidoDataGridView.StandardTab = true;
            this.articuloPedidoDataGridView.TabIndex = 1;
            this.articuloPedidoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articuloPedidoDataGridView_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.descripcionTextBox.Location = new System.Drawing.Point(701, 28);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(206, 160);
            this.descripcionTextBox.TabIndex = 2;
            this.descripcionTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.descripcionTextBox.WaterMarkText = "Descripcion del pedido";
            this.descripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcionTextBox_KeyPress);
            this.descripcionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descripcionTextBox_Validating);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pedido);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // articuloPedidoBindingSource
            // 
            this.articuloPedidoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.ArticuloPedido);
            // 
            // FrmEditarPedido
            // 
            this.AcceptButton = btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 359);
            this.ControlBox = false;
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.articuloPedidoDataGridView);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar pedido";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloPedidoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloPedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.BindingSource articuloPedidoBindingSource;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox cbDepartamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox conceptoTextBox;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.DataGridView articuloPedidoDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private wmgCMS.WaterMarkTextBox descripcionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

    }
}