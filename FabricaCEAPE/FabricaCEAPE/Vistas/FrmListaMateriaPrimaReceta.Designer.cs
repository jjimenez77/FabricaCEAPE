namespace FabricaCEAPE.Vistas
{
    partial class FrmListaMateriaPrimaReceta
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
            this.materiaPrimaRecetaDataGridView = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaPrimaRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaRecetaDataGridView)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaRecetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materiaPrimaRecetaDataGridView
            // 
            this.materiaPrimaRecetaDataGridView.AllowUserToAddRows = false;
            this.materiaPrimaRecetaDataGridView.AllowUserToDeleteRows = false;
            this.materiaPrimaRecetaDataGridView.AllowUserToResizeColumns = false;
            this.materiaPrimaRecetaDataGridView.AllowUserToResizeRows = false;
            this.materiaPrimaRecetaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materiaPrimaRecetaDataGridView.AutoGenerateColumns = false;
            this.materiaPrimaRecetaDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.materiaPrimaRecetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiaPrimaRecetaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.materiaPrimaRecetaDataGridView.DataSource = this.materiaPrimaRecetaBindingSource;
            this.materiaPrimaRecetaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.materiaPrimaRecetaDataGridView.MultiSelect = false;
            this.materiaPrimaRecetaDataGridView.Name = "materiaPrimaRecetaDataGridView";
            this.materiaPrimaRecetaDataGridView.ReadOnly = true;
            this.materiaPrimaRecetaDataGridView.RowHeadersVisible = false;
            this.materiaPrimaRecetaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materiaPrimaRecetaDataGridView.Size = new System.Drawing.Size(203, 286);
            this.materiaPrimaRecetaDataGridView.StandardTab = true;
            this.materiaPrimaRecetaDataGridView.TabIndex = 1;
            this.materiaPrimaRecetaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materiaPrimaRecetaDataGridView_CellDoubleClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnSalir,
            this.txtBuscar});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(636, 25);
            this.menu.TabIndex = 2;
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
            this.btnNuevo.ToolTipText = "Nueva materia prima de recetas";
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
            this.btnModificar.ToolTipText = "Modificar materia prima de recetas";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 25);
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.ToolTipText = "Buscar materia prima de recetas por nombre";
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
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
            // materiaPrimaRecetaBindingSource
            // 
            this.materiaPrimaRecetaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.MateriaPrimaReceta);
            // 
            // FrmListaMateriaPrimaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 326);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.materiaPrimaRecetaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaMateriaPrimaReceta";
            this.Text = "Materia prima de recetas";
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaRecetaDataGridView)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaRecetaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materiaPrimaRecetaBindingSource;
        private System.Windows.Forms.DataGridView materiaPrimaRecetaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
    }
}