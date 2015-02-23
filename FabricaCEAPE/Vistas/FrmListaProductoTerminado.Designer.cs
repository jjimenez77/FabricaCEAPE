namespace FabricaCEAPE.Vistas
{
    partial class FrmListaProductoTerminado
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
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.cbSelector = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.nombreTipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaElaboracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteProductoTerminadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasPorTarimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgPorTarimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarraProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gramajeMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadPorCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoEnvasadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSeleccionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoTerminadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoTerminadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = null;
            this.productoBindingNavigator.CountItem = null;
            this.productoBindingNavigator.DeleteItem = null;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton2,
            this.txtBuscar,
            this.cbSelector});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = null;
            this.productoBindingNavigator.MoveLastItem = null;
            this.productoBindingNavigator.MoveNextItem = null;
            this.productoBindingNavigator.MovePreviousItem = null;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = null;
            this.productoBindingNavigator.Size = new System.Drawing.Size(1346, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nueva producto";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::FabricaCEAPE.Properties.Resources.pencil43;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton1.Text = "Modificar";
            this.toolStripButton1.ToolTipText = "Modificar producto";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 25);
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.ToolTipText = "Buscar producto por nombre";
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
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = global::FabricaCEAPE.Properties.Resources.next21;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton3.Text = "Salir";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AllowUserToResizeColumns = false;
            this.productoDataGridView.AllowUserToResizeRows = false;
            this.productoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreTipoProductoDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.fechaElaboracionDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.loteProductoTerminadoDataGridViewTextBoxColumn,
            this.cajasPorTarimaDataGridViewTextBoxColumn,
            this.kgPorTarimaDataGridViewTextBoxColumn,
            this.codigoBarraProductoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.gramajeMedidaDataGridViewTextBoxColumn,
            this.unidadPorCajaDataGridViewTextBoxColumn,
            this.nombreTipoEnvasadoDataGridViewTextBoxColumn,
            this.nombreSeleccionProductoDataGridViewTextBoxColumn});
            this.productoDataGridView.DataSource = this.productoTerminadoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.productoDataGridView.MultiSelect = false;
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.RowHeadersVisible = false;
            this.productoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productoDataGridView.Size = new System.Drawing.Size(1306, 294);
            this.productoDataGridView.StandardTab = true;
            this.productoDataGridView.TabIndex = 1;
            this.productoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoDataGridView_CellDoubleClick);
            // 
            // nombreTipoProductoDataGridViewTextBoxColumn
            // 
            this.nombreTipoProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreTipoProducto";
            this.nombreTipoProductoDataGridViewTextBoxColumn.HeaderText = "NombreTipoProducto";
            this.nombreTipoProductoDataGridViewTextBoxColumn.Name = "nombreTipoProductoDataGridViewTextBoxColumn";
            this.nombreTipoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaElaboracionDataGridViewTextBoxColumn
            // 
            this.fechaElaboracionDataGridViewTextBoxColumn.DataPropertyName = "FechaElaboracion";
            this.fechaElaboracionDataGridViewTextBoxColumn.HeaderText = "FechaElaboracion";
            this.fechaElaboracionDataGridViewTextBoxColumn.Name = "fechaElaboracionDataGridViewTextBoxColumn";
            this.fechaElaboracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loteProductoTerminadoDataGridViewTextBoxColumn
            // 
            this.loteProductoTerminadoDataGridViewTextBoxColumn.DataPropertyName = "LoteProductoTerminado";
            this.loteProductoTerminadoDataGridViewTextBoxColumn.HeaderText = "LoteProductoTerminado";
            this.loteProductoTerminadoDataGridViewTextBoxColumn.Name = "loteProductoTerminadoDataGridViewTextBoxColumn";
            this.loteProductoTerminadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajasPorTarimaDataGridViewTextBoxColumn
            // 
            this.cajasPorTarimaDataGridViewTextBoxColumn.DataPropertyName = "CajasPorTarima";
            this.cajasPorTarimaDataGridViewTextBoxColumn.HeaderText = "CajasPorTarima";
            this.cajasPorTarimaDataGridViewTextBoxColumn.Name = "cajasPorTarimaDataGridViewTextBoxColumn";
            this.cajasPorTarimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kgPorTarimaDataGridViewTextBoxColumn
            // 
            this.kgPorTarimaDataGridViewTextBoxColumn.DataPropertyName = "KgPorTarima";
            this.kgPorTarimaDataGridViewTextBoxColumn.HeaderText = "KgPorTarima";
            this.kgPorTarimaDataGridViewTextBoxColumn.Name = "kgPorTarimaDataGridViewTextBoxColumn";
            this.kgPorTarimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoBarraProductoDataGridViewTextBoxColumn
            // 
            this.codigoBarraProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarraProducto";
            this.codigoBarraProductoDataGridViewTextBoxColumn.HeaderText = "CodigoBarraProducto";
            this.codigoBarraProductoDataGridViewTextBoxColumn.Name = "codigoBarraProductoDataGridViewTextBoxColumn";
            this.codigoBarraProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gramajeMedidaDataGridViewTextBoxColumn
            // 
            this.gramajeMedidaDataGridViewTextBoxColumn.DataPropertyName = "GramajeMedida";
            this.gramajeMedidaDataGridViewTextBoxColumn.HeaderText = "GramajeMedida";
            this.gramajeMedidaDataGridViewTextBoxColumn.Name = "gramajeMedidaDataGridViewTextBoxColumn";
            this.gramajeMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadPorCajaDataGridViewTextBoxColumn
            // 
            this.unidadPorCajaDataGridViewTextBoxColumn.DataPropertyName = "UnidadPorCaja";
            this.unidadPorCajaDataGridViewTextBoxColumn.HeaderText = "UnidadPorCaja";
            this.unidadPorCajaDataGridViewTextBoxColumn.Name = "unidadPorCajaDataGridViewTextBoxColumn";
            this.unidadPorCajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreTipoEnvasadoDataGridViewTextBoxColumn
            // 
            this.nombreTipoEnvasadoDataGridViewTextBoxColumn.DataPropertyName = "NombreTipoEnvasado";
            this.nombreTipoEnvasadoDataGridViewTextBoxColumn.HeaderText = "NombreTipoEnvasado";
            this.nombreTipoEnvasadoDataGridViewTextBoxColumn.Name = "nombreTipoEnvasadoDataGridViewTextBoxColumn";
            this.nombreTipoEnvasadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreSeleccionProductoDataGridViewTextBoxColumn
            // 
            this.nombreSeleccionProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreSeleccionProducto";
            this.nombreSeleccionProductoDataGridViewTextBoxColumn.HeaderText = "NombreSeleccionProducto";
            this.nombreSeleccionProductoDataGridViewTextBoxColumn.Name = "nombreSeleccionProductoDataGridViewTextBoxColumn";
            this.nombreSeleccionProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoTerminadoBindingSource
            // 
            this.productoTerminadoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.ProductoTerminado);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::FabricaCEAPE.Properties.Resources.delete96;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton2.Text = "Eliminar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FrmListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 334);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.productoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaProducto";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoTerminadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.DataGridView productoDataGridView;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;*/
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripComboBox cbSelector;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource productoTerminadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaElaboracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteProductoTerminadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasPorTarimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgPorTarimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarraProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramajeMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadPorCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoEnvasadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSeleccionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}