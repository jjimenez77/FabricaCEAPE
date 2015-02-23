namespace FabricaCEAPE.Vistas
{
    partial class FrmListaZona
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
            this.zonaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.zonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.zonaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingNavigator)).BeginInit();
            this.zonaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zonaBindingNavigator
            // 
            this.zonaBindingNavigator.AddNewItem = null;
            this.zonaBindingNavigator.BindingSource = this.zonaBindingSource;
            this.zonaBindingNavigator.CountItem = null;
            this.zonaBindingNavigator.DeleteItem = null;
            this.zonaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.btnSalir});
            this.zonaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zonaBindingNavigator.MoveFirstItem = null;
            this.zonaBindingNavigator.MoveLastItem = null;
            this.zonaBindingNavigator.MoveNextItem = null;
            this.zonaBindingNavigator.MovePreviousItem = null;
            this.zonaBindingNavigator.Name = "zonaBindingNavigator";
            this.zonaBindingNavigator.PositionItem = null;
            this.zonaBindingNavigator.Size = new System.Drawing.Size(531, 25);
            this.zonaBindingNavigator.TabIndex = 0;
            this.zonaBindingNavigator.TabStop = true;
            this.zonaBindingNavigator.Text = "bindingNavigator1";
            // 
            // zonaBindingSource
            // 
            this.zonaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Zona);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nueva zona";
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
            this.btnModificar.ToolTipText = "Modificar zona";
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
            this.btnEliminar.ToolTipText = "Eliminar zona";
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // zonaDataGridView
            // 
            this.zonaDataGridView.AllowUserToAddRows = false;
            this.zonaDataGridView.AllowUserToDeleteRows = false;
            this.zonaDataGridView.AllowUserToResizeColumns = false;
            this.zonaDataGridView.AllowUserToResizeRows = false;
            this.zonaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.zonaDataGridView.AutoGenerateColumns = false;
            this.zonaDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.zonaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.zonaDataGridView.DataSource = this.zonaBindingSource;
            this.zonaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.zonaDataGridView.MultiSelect = false;
            this.zonaDataGridView.Name = "zonaDataGridView";
            this.zonaDataGridView.ReadOnly = true;
            this.zonaDataGridView.RowHeadersVisible = false;
            this.zonaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zonaDataGridView.Size = new System.Drawing.Size(333, 265);
            this.zonaDataGridView.StandardTab = true;
            this.zonaDataGridView.TabIndex = 1;
            this.zonaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zonaDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Localidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Localidad";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FrmListaZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 305);
            this.Controls.Add(this.zonaDataGridView);
            this.Controls.Add(this.zonaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaZona";
            this.Text = "Zonas";
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingNavigator)).EndInit();
            this.zonaBindingNavigator.ResumeLayout(false);
            this.zonaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource zonaBindingSource;
        private System.Windows.Forms.BindingNavigator zonaBindingNavigator;
        private System.Windows.Forms.DataGridView zonaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}