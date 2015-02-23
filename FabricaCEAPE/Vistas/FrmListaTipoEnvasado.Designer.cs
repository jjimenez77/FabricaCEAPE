namespace FabricaCEAPE.Vistas
{
    partial class FrmListaTipoEnvasado
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
            this.tipoEnvasadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tipoEnvasadoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEnvasadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoBindingNavigator)).BeginInit();
            this.tipoEnvasadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoEnvasadoBindingNavigator
            // 
            this.tipoEnvasadoBindingNavigator.AddNewItem = null;
            this.tipoEnvasadoBindingNavigator.BindingSource = this.tipoEnvasadoBindingSource;
            this.tipoEnvasadoBindingNavigator.CountItem = null;
            this.tipoEnvasadoBindingNavigator.DeleteItem = null;
            this.tipoEnvasadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.btnSalir});
            this.tipoEnvasadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoEnvasadoBindingNavigator.MoveFirstItem = null;
            this.tipoEnvasadoBindingNavigator.MoveLastItem = null;
            this.tipoEnvasadoBindingNavigator.MoveNextItem = null;
            this.tipoEnvasadoBindingNavigator.MovePreviousItem = null;
            this.tipoEnvasadoBindingNavigator.Name = "tipoEnvasadoBindingNavigator";
            this.tipoEnvasadoBindingNavigator.PositionItem = null;
            this.tipoEnvasadoBindingNavigator.Size = new System.Drawing.Size(437, 25);
            this.tipoEnvasadoBindingNavigator.TabIndex = 0;
            this.tipoEnvasadoBindingNavigator.Text = "bindingNavigator1";
            // 
            // tipoEnvasadoDataGridView
            // 
            this.tipoEnvasadoDataGridView.AllowUserToAddRows = false;
            this.tipoEnvasadoDataGridView.AllowUserToDeleteRows = false;
            this.tipoEnvasadoDataGridView.AllowUserToResizeColumns = false;
            this.tipoEnvasadoDataGridView.AllowUserToResizeRows = false;
            this.tipoEnvasadoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tipoEnvasadoDataGridView.AutoGenerateColumns = false;
            this.tipoEnvasadoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tipoEnvasadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoEnvasadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.tipoEnvasadoDataGridView.DataSource = this.tipoEnvasadoBindingSource;
            this.tipoEnvasadoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.tipoEnvasadoDataGridView.MultiSelect = false;
            this.tipoEnvasadoDataGridView.Name = "tipoEnvasadoDataGridView";
            this.tipoEnvasadoDataGridView.ReadOnly = true;
            this.tipoEnvasadoDataGridView.RowHeadersVisible = false;
            this.tipoEnvasadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tipoEnvasadoDataGridView.Size = new System.Drawing.Size(203, 239);
            this.tipoEnvasadoDataGridView.StandardTab = true;
            this.tipoEnvasadoDataGridView.TabIndex = 1;
            this.tipoEnvasadoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tipoEnvasadoDataGridView_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo tipo de envasado";
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
            this.btnModificar.ToolTipText = "Modificar tipo de envasado";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnEliminar.ToolTipText = "Eliminar tipo de envasado";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tipoEnvasadoBindingSource
            // 
            this.tipoEnvasadoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.TipoEnvasado);
            // 
            // FrmListaTipoEnvasado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 279);
            this.Controls.Add(this.tipoEnvasadoDataGridView);
            this.Controls.Add(this.tipoEnvasadoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaTipoEnvasado";
            this.Text = "Tipos de envasado";
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoBindingNavigator)).EndInit();
            this.tipoEnvasadoBindingNavigator.ResumeLayout(false);
            this.tipoEnvasadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEnvasadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tipoEnvasadoBindingSource;
        private System.Windows.Forms.BindingNavigator tipoEnvasadoBindingNavigator;
        private System.Windows.Forms.DataGridView tipoEnvasadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}