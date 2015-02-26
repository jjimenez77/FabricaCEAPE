namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarReceta
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label tiempoLabel;
            System.Windows.Forms.Label temperaturaLabel;
            System.Windows.Forms.Label otrosLabel;
            System.Windows.Forms.Button btnAceptar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarReceta));
            this.ingredienteRecetaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredienteRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observacionesTextBox = new wmgCMS.WaterMarkTextBox();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiempoTextBox = new wmgCMS.WaterMarkTextBox();
            this.temperaturaTextBox = new wmgCMS.WaterMarkTextBox();
            this.otrosTextBox = new wmgCMS.WaterMarkTextBox();
            nombreLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            tiempoLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            otrosLabel = new System.Windows.Forms.Label();
            btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteRecetaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteRecetaBindingSource)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Cursor = System.Windows.Forms.Cursors.Default;
            nombreLabel.Location = new System.Drawing.Point(503, 28);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 26;
            nombreLabel.Text = "Nombre:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Cursor = System.Windows.Forms.Cursors.Default;
            observacionesLabel.Location = new System.Drawing.Point(503, 54);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 27;
            observacionesLabel.Text = "Observaciones:";
            // 
            // tiempoLabel
            // 
            tiempoLabel.AutoSize = true;
            tiempoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            tiempoLabel.Location = new System.Drawing.Point(503, 110);
            tiempoLabel.Name = "tiempoLabel";
            tiempoLabel.Size = new System.Drawing.Size(45, 13);
            tiempoLabel.TabIndex = 28;
            tiempoLabel.Text = "Tiempo:";
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Cursor = System.Windows.Forms.Cursors.Default;
            temperaturaLabel.Location = new System.Drawing.Point(503, 136);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(70, 13);
            temperaturaLabel.TabIndex = 29;
            temperaturaLabel.Text = "Temperatura:";
            // 
            // otrosLabel
            // 
            otrosLabel.AutoSize = true;
            otrosLabel.Cursor = System.Windows.Forms.Cursors.Default;
            otrosLabel.Location = new System.Drawing.Point(503, 162);
            otrosLabel.Name = "otrosLabel";
            otrosLabel.Size = new System.Drawing.Size(35, 13);
            otrosLabel.TabIndex = 30;
            otrosLabel.Text = "Otros:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnAceptar.Location = new System.Drawing.Point(729, 324);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ingredienteRecetaDataGridView
            // 
            this.ingredienteRecetaDataGridView.AllowUserToAddRows = false;
            this.ingredienteRecetaDataGridView.AllowUserToDeleteRows = false;
            this.ingredienteRecetaDataGridView.AllowUserToResizeColumns = false;
            this.ingredienteRecetaDataGridView.AllowUserToResizeRows = false;
            this.ingredienteRecetaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ingredienteRecetaDataGridView.AutoGenerateColumns = false;
            this.ingredienteRecetaDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ingredienteRecetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredienteRecetaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.Medida});
            this.ingredienteRecetaDataGridView.DataSource = this.ingredienteRecetaBindingSource;
            this.ingredienteRecetaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.ingredienteRecetaDataGridView.MultiSelect = false;
            this.ingredienteRecetaDataGridView.Name = "ingredienteRecetaDataGridView";
            this.ingredienteRecetaDataGridView.ReadOnly = true;
            this.ingredienteRecetaDataGridView.RowHeadersVisible = false;
            this.ingredienteRecetaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredienteRecetaDataGridView.Size = new System.Drawing.Size(485, 318);
            this.ingredienteRecetaDataGridView.StandardTab = true;
            this.ingredienteRecetaDataGridView.TabIndex = 1;
            this.ingredienteRecetaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingredienteRecetaDataGridView_CellDoubleClick);
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
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // Medida
            // 
            this.Medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medida.DataPropertyName = "Medida";
            this.Medida.HeaderText = "Medida";
            this.Medida.MinimumWidth = 50;
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // ingredienteRecetaBindingSource
            // 
            this.ingredienteRecetaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.IngredienteReceta);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Location = new System.Drawing.Point(648, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn1.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripSeparator2,
            this.btnEliminar});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(816, 25);
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
            this.btnNuevo.ToolTipText = "Nuevo ingrediente de receta";
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
            this.btnModificar.ToolTipText = "Modificar ingrediente de receta";
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
            this.btnEliminar.ToolTipText = "Eliminar ingrediente de receta";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cbProducto
            // 
            this.cbProducto.DataSource = this.productoBindingSource;
            this.cbProducto.DisplayMember = "Nombre";
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(590, 24);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(206, 21);
            this.cbProducto.TabIndex = 31;
            this.cbProducto.ValueMember = "IdProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Producto);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "Observaciones", true));
            this.observacionesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.observacionesTextBox.Location = new System.Drawing.Point(590, 51);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(206, 50);
            this.observacionesTextBox.TabIndex = 3;
            this.observacionesTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.observacionesTextBox.WaterMarkText = "Observaciones extras";
            this.observacionesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otrosTextBox_KeyPress);
            this.observacionesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.observacionesTextBox_Validating);
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Receta);
            // 
            // tiempoTextBox
            // 
            this.tiempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "Tiempo", true));
            this.tiempoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tiempoTextBox.Location = new System.Drawing.Point(590, 107);
            this.tiempoTextBox.Name = "tiempoTextBox";
            this.tiempoTextBox.Size = new System.Drawing.Size(206, 20);
            this.tiempoTextBox.TabIndex = 4;
            this.tiempoTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.tiempoTextBox.WaterMarkText = "2 hrs";
            this.tiempoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otrosTextBox_KeyPress);
            this.tiempoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.tiempoTextBox_Validating);
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "Temperatura", true));
            this.temperaturaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.temperaturaTextBox.Location = new System.Drawing.Point(590, 133);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(206, 20);
            this.temperaturaTextBox.TabIndex = 5;
            this.temperaturaTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.temperaturaTextBox.WaterMarkText = "40 grados";
            this.temperaturaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otrosTextBox_KeyPress);
            this.temperaturaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.temperaturaTextBox_Validating);
            // 
            // otrosTextBox
            // 
            this.otrosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "Otros", true));
            this.otrosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.otrosTextBox.Location = new System.Drawing.Point(590, 159);
            this.otrosTextBox.Multiline = true;
            this.otrosTextBox.Name = "otrosTextBox";
            this.otrosTextBox.Size = new System.Drawing.Size(206, 100);
            this.otrosTextBox.TabIndex = 6;
            this.otrosTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.otrosTextBox.WaterMarkText = "Otros";
            this.otrosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otrosTextBox_KeyPress);
            this.otrosTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.otrosTextBox_Validating);
            // 
            // FrmEditarReceta
            // 
            this.AcceptButton = btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 359);
            this.ControlBox = false;
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(this.tiempoTextBox);
            this.Controls.Add(this.temperaturaTextBox);
            this.Controls.Add(this.otrosTextBox);
            this.Controls.Add(this.menu);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(otrosLabel);
            this.Controls.Add(temperaturaLabel);
            this.Controls.Add(tiempoLabel);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.ingredienteRecetaDataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarReceta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar receta";
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteRecetaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteRecetaBindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ingredienteRecetaBindingSource;
        private System.Windows.Forms.DataGridView ingredienteRecetaDataGridView;
        private System.Windows.Forms.BindingSource recetaBindingSource;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private wmgCMS.WaterMarkTextBox otrosTextBox;
        private wmgCMS.WaterMarkTextBox temperaturaTextBox;
        private wmgCMS.WaterMarkTextBox tiempoTextBox;
        private wmgCMS.WaterMarkTextBox observacionesTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}