namespace FabricaCEAPE.Vistas
{
    partial class FrmListaPedido
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnRecibidos = new System.Windows.Forms.ToolStripButton();
            this.btnEnviados = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.cbSelector = new System.Windows.Forms.ToolStripComboBox();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.DepartamentoDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Departamento de destino";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo pedido";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnVer
            // 
            this.btnVer.Image = global::FabricaCEAPE.Properties.Resources.eye106;
            this.btnVer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(44, 22);
            this.btnVer.Text = "Ver";
            this.btnVer.ToolTipText = "Ver pedido";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Image = global::FabricaCEAPE.Properties.Resources.next21;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnRecibidos
            // 
            this.btnRecibidos.Image = global::FabricaCEAPE.Properties.Resources.download151;
            this.btnRecibidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecibidos.Name = "btnRecibidos";
            this.btnRecibidos.Size = new System.Drawing.Size(78, 22);
            this.btnRecibidos.Text = "Recibidos";
            this.btnRecibidos.Click += new System.EventHandler(this.btnRecibidos_Click);
            // 
            // btnEnviados
            // 
            this.btnEnviados.Image = global::FabricaCEAPE.Properties.Resources.upload102;
            this.btnEnviados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnviados.Name = "btnEnviados";
            this.btnEnviados.Size = new System.Drawing.Size(74, 22);
            this.btnEnviados.Text = "Enviados";
            this.btnEnviados.Click += new System.EventHandler(this.btnEnviados_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 25);
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.ToolTipText = "Buscar pedido recibido por concepto";
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // cbSelector
            // 
            this.cbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelector.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbSelector.Name = "cbSelector";
            this.cbSelector.Size = new System.Drawing.Size(206, 25);
            this.cbSelector.ToolTipText = "Seleccione el tipo de busqueda";
            this.cbSelector.DropDownClosed += new System.EventHandler(this.cbSelector_DropDownClosed);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnVer,
            this.toolStripSeparator3,
            this.btnSalir,
            this.btnRecibidos,
            this.btnEnviados,
            this.toolStripSeparator2,
            this.txtBuscar,
            this.cbSelector});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1354, 25);
            this.menu.TabIndex = 0;
            this.menu.TabStop = true;
            this.menu.Text = "menu";
            // 
            // DepartamentoDeUsuario
            // 
            this.DepartamentoDeUsuario.DataPropertyName = "DepartamentoDeUsuario";
            this.DepartamentoDeUsuario.HeaderText = "Departamento emisor";
            this.DepartamentoDeUsuario.Name = "DepartamentoDeUsuario";
            this.DepartamentoDeUsuario.ReadOnly = true;
            this.DepartamentoDeUsuario.Width = 150;
            // 
            // Visto
            // 
            this.Visto.DataPropertyName = "Visto";
            this.Visto.HeaderText = "Visto";
            this.Visto.Name = "Visto";
            this.Visto.ReadOnly = true;
            this.Visto.Width = 50;
            // 
            // pedidoDataGridView
            // 
            this.pedidoDataGridView.AllowUserToAddRows = false;
            this.pedidoDataGridView.AllowUserToDeleteRows = false;
            this.pedidoDataGridView.AllowUserToResizeColumns = false;
            this.pedidoDataGridView.AllowUserToResizeRows = false;
            this.pedidoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pedidoDataGridView.AutoGenerateColumns = false;
            this.pedidoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.pedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Visto,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.DepartamentoDeUsuario,
            this.Departamento});
            this.pedidoDataGridView.DataSource = this.pedidoBindingSource;
            this.pedidoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.pedidoDataGridView.MultiSelect = false;
            this.pedidoDataGridView.Name = "pedidoDataGridView";
            this.pedidoDataGridView.ReadOnly = true;
            this.pedidoDataGridView.RowHeadersVisible = false;
            this.pedidoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedidoDataGridView.Size = new System.Drawing.Size(1003, 221);
            this.pedidoDataGridView.StandardTab = true;
            this.pedidoDataGridView.TabIndex = 1;
            this.pedidoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedidoDataGridView_CellDoubleClick);
            this.pedidoDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pedidoDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Concepto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaEmitido";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha emitido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Usuario emisor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento de destino";
            this.Departamento.MinimumWidth = 130;
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pedido);
            // 
            // FrmListaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 261);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pedidoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaPedido";
            this.Text = "Pedidos";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnVer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnRecibidos;
        private System.Windows.Forms.ToolStripButton btnEnviados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripComboBox cbSelector;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartamentoDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visto;
        private System.Windows.Forms.DataGridView pedidoDataGridView;
    }
}