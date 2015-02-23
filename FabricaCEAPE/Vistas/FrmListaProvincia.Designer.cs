namespace FabricaCEAPE.Vistas
{
    partial class FrmListaProvincia
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
            this.provinciaDataGridView = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbPais = new System.Windows.Forms.ToolStripComboBox();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaDataGridView)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // provinciaDataGridView
            // 
            this.provinciaDataGridView.AllowUserToAddRows = false;
            this.provinciaDataGridView.AllowUserToDeleteRows = false;
            this.provinciaDataGridView.AllowUserToResizeColumns = false;
            this.provinciaDataGridView.AllowUserToResizeRows = false;
            this.provinciaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.provinciaDataGridView.AutoGenerateColumns = false;
            this.provinciaDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.provinciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provinciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.provinciaDataGridView.DataSource = this.provinciaBindingSource;
            this.provinciaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.provinciaDataGridView.MultiSelect = false;
            this.provinciaDataGridView.Name = "provinciaDataGridView";
            this.provinciaDataGridView.ReadOnly = true;
            this.provinciaDataGridView.RowHeadersVisible = false;
            this.provinciaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.provinciaDataGridView.Size = new System.Drawing.Size(303, 271);
            this.provinciaDataGridView.StandardTab = true;
            this.provinciaDataGridView.TabIndex = 0;
            this.provinciaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provinciaDataGridView_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::FabricaCEAPE.Properties.Resources.add139;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nueva provincia";
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
            this.btnModificar.ToolTipText = "Modificar provincia";
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
            this.btnEliminar.ToolTipText = "Eliminar provincia";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(206, 25);
            this.cbPais.ToolTipText = "Paises";
            this.cbPais.DropDownClosed += new System.EventHandler(this.cbPais_DropDownClosed_1);
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
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.cbPais,
            this.btnSalir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(543, 25);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Provincia);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FrmListaProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 311);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.provinciaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmListaProvincia";
            this.Text = "Provincias";
            ((System.ComponentModel.ISupportInitialize)(this.provinciaDataGridView)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private System.Windows.Forms.DataGridView provinciaDataGridView;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox cbPais;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}