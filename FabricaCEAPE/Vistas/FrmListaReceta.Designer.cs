namespace FabricaCEAPE.Vistas
{
    partial class FrmListaReceta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.cbSelector = new System.Windows.Forms.ToolStripComboBox();
            this.dgRecetas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalir,
            this.txtBuscar,
            this.cbSelector});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(827, 25);
            this.menu.TabIndex = 0;
            this.menu.TabStop = true;
            this.menu.Text = "menu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nueva receta";
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
            this.btnModificar.ToolTipText = "Modificar receta";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
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
            this.btnEliminar.ToolTipText = "Eliminar receta";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 25);
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.ToolTipText = "Buscar recetas por nombre";
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
            // dgRecetas
            // 
            this.dgRecetas.AllowUserToAddRows = false;
            this.dgRecetas.AllowUserToDeleteRows = false;
            this.dgRecetas.AllowUserToResizeColumns = false;
            this.dgRecetas.AllowUserToResizeRows = false;
            this.dgRecetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgRecetas.AutoGenerateColumns = false;
            this.dgRecetas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoDataGridViewTextBoxColumn1,
            this.observacionesDataGridViewTextBoxColumn1,
            this.tiempoDataGridViewTextBoxColumn1,
            this.temperaturaDataGridViewTextBoxColumn1,
            this.otrosDataGridViewTextBoxColumn1,
            this.fechaCreacionDataGridViewTextBoxColumn1,
            this.usuarioDataGridViewTextBoxColumn1});
            this.dgRecetas.DataSource = this.recetaBindingSource;
            this.dgRecetas.Location = new System.Drawing.Point(12, 28);
            this.dgRecetas.MultiSelect = false;
            this.dgRecetas.Name = "dgRecetas";
            this.dgRecetas.ReadOnly = true;
            this.dgRecetas.RowHeadersVisible = false;
            this.dgRecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecetas.Size = new System.Drawing.Size(803, 221);
            this.dgRecetas.StandardTab = true;
            this.dgRecetas.TabIndex = 1;
            this.dgRecetas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRecetas_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // tiempoDataGridViewTextBoxColumn
            // 
            this.tiempoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn.Name = "tiempoDataGridViewTextBoxColumn";
            // 
            // temperaturaDataGridViewTextBoxColumn
            // 
            this.temperaturaDataGridViewTextBoxColumn.DataPropertyName = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn.HeaderText = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn.Name = "temperaturaDataGridViewTextBoxColumn";
            // 
            // otrosDataGridViewTextBoxColumn
            // 
            this.otrosDataGridViewTextBoxColumn.DataPropertyName = "Otros";
            this.otrosDataGridViewTextBoxColumn.HeaderText = "Otros";
            this.otrosDataGridViewTextBoxColumn.Name = "otrosDataGridViewTextBoxColumn";
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Receta);
            // 
            // productoDataGridViewTextBoxColumn1
            // 
            this.productoDataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.productoDataGridViewTextBoxColumn1.Name = "productoDataGridViewTextBoxColumn1";
            this.productoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // observacionesDataGridViewTextBoxColumn1
            // 
            this.observacionesDataGridViewTextBoxColumn1.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.Name = "observacionesDataGridViewTextBoxColumn1";
            this.observacionesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.observacionesDataGridViewTextBoxColumn1.Width = 150;
            // 
            // tiempoDataGridViewTextBoxColumn1
            // 
            this.tiempoDataGridViewTextBoxColumn1.DataPropertyName = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn1.HeaderText = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn1.Name = "tiempoDataGridViewTextBoxColumn1";
            this.tiempoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // temperaturaDataGridViewTextBoxColumn1
            // 
            this.temperaturaDataGridViewTextBoxColumn1.DataPropertyName = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn1.HeaderText = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn1.Name = "temperaturaDataGridViewTextBoxColumn1";
            this.temperaturaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // otrosDataGridViewTextBoxColumn1
            // 
            this.otrosDataGridViewTextBoxColumn1.DataPropertyName = "Otros";
            this.otrosDataGridViewTextBoxColumn1.HeaderText = "Otros";
            this.otrosDataGridViewTextBoxColumn1.Name = "otrosDataGridViewTextBoxColumn1";
            this.otrosDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn1
            // 
            this.fechaCreacionDataGridViewTextBoxColumn1.DataPropertyName = "FechaCreacion";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaCreacionDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaCreacionDataGridViewTextBoxColumn1.HeaderText = "Fecha de creacion";
            this.fechaCreacionDataGridViewTextBoxColumn1.Name = "fechaCreacionDataGridViewTextBoxColumn1";
            this.fechaCreacionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn1
            // 
            this.usuarioDataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.Name = "usuarioDataGridViewTextBoxColumn1";
            this.usuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FrmListaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 261);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dgRecetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaReceta";
            this.Text = "Recetas";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource recetaBindingSource;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgRecetas;
        private System.Windows.Forms.ToolStripComboBox cbSelector;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
    }
}