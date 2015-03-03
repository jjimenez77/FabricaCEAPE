namespace FabricaCEAPE.Vistas
{
    partial class Entregas
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
            this.entregaProductoTerminadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregaProductoTerminadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.entregaProductoTerminadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaProductoTerminadoBindingSource)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // entregaProductoTerminadoDataGridView
            // 
            this.entregaProductoTerminadoDataGridView.AllowUserToAddRows = false;
            this.entregaProductoTerminadoDataGridView.AllowUserToDeleteRows = false;
            this.entregaProductoTerminadoDataGridView.AllowUserToResizeColumns = false;
            this.entregaProductoTerminadoDataGridView.AllowUserToResizeRows = false;
            this.entregaProductoTerminadoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.entregaProductoTerminadoDataGridView.AutoGenerateColumns = false;
            this.entregaProductoTerminadoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.entregaProductoTerminadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entregaProductoTerminadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.entregaProductoTerminadoDataGridView.DataSource = this.entregaProductoTerminadoBindingSource;
            this.entregaProductoTerminadoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.entregaProductoTerminadoDataGridView.MultiSelect = false;
            this.entregaProductoTerminadoDataGridView.Name = "entregaProductoTerminadoDataGridView";
            this.entregaProductoTerminadoDataGridView.ReadOnly = true;
            this.entregaProductoTerminadoDataGridView.RowHeadersVisible = false;
            this.entregaProductoTerminadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entregaProductoTerminadoDataGridView.Size = new System.Drawing.Size(603, 318);
            this.entregaProductoTerminadoDataGridView.StandardTab = true;
            this.entregaProductoTerminadoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaEntrega";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha de entrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreCliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre de cliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombreVendedor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre de vendedor";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 180;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // entregaProductoTerminadoBindingSource
            // 
            this.entregaProductoTerminadoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.EntregaProductoTerminado);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(887, 25);
            this.menu.TabIndex = 1;
            this.menu.TabStop = true;
            this.menu.Text = "menu";
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Image = global::FabricaCEAPE.Properties.Resources.next21;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Entregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 358);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.entregaProductoTerminadoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Entregas";
            this.Text = "Entregas";
            ((System.ComponentModel.ISupportInitialize)(this.entregaProductoTerminadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaProductoTerminadoBindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource entregaProductoTerminadoBindingSource;
        private System.Windows.Forms.DataGridView entregaProductoTerminadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}