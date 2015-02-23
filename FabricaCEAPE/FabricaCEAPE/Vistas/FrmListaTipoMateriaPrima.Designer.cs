namespace FabricaCEAPE.Vistas
{
    partial class FrmListaTipoMateriaPrima
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
            this.paisDataGridView = new System.Windows.Forms.DataGridView();
            this.tipoMateriaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMateriaPrimaBindingSource)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // paisDataGridView
            // 
            this.paisDataGridView.AllowUserToAddRows = false;
            this.paisDataGridView.AllowUserToDeleteRows = false;
            this.paisDataGridView.AllowUserToResizeColumns = false;
            this.paisDataGridView.AllowUserToResizeRows = false;
            this.paisDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.paisDataGridView.AutoGenerateColumns = false;
            this.paisDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.paisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn});
            this.paisDataGridView.DataSource = this.tipoMateriaPrimaBindingSource;
            this.paisDataGridView.Location = new System.Drawing.Point(12, 28);
            this.paisDataGridView.MultiSelect = false;
            this.paisDataGridView.Name = "paisDataGridView";
            this.paisDataGridView.ReadOnly = true;
            this.paisDataGridView.RowHeadersVisible = false;
            this.paisDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paisDataGridView.Size = new System.Drawing.Size(203, 271);
            this.paisDataGridView.StandardTab = true;
            this.paisDataGridView.TabIndex = 1;
            this.paisDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paisDataGridView_CellDoubleClick);
            // 
            // tipoMateriaPrimaBindingSource
            // 
            this.tipoMateriaPrimaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.TipoMateriaPrima);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.btnSalir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(342, 25);
            this.menu.TabIndex = 0;
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
            this.btnNuevo.ToolTipText = "Nuevo tipo de materia prima";
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
            this.btnModificar.ToolTipText = "Modificar tipo de materia prima";
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
            this.btnEliminar.ToolTipText = "Eliminar tipo de materia prima";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmListaTipoMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 311);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.paisDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaTipoMateriaPrima";
            this.Text = "Tipos de materia prima";
            ((System.ComponentModel.ISupportInitialize)(this.paisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMateriaPrimaBindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tipoMateriaPrimaBindingSource;
        private System.Windows.Forms.DataGridView paisDataGridView;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}