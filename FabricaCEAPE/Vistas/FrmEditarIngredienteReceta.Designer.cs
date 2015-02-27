namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarIngredienteReceta
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarIngredienteReceta));
            this.label1 = new System.Windows.Forms.Label();
            this.ingredienteRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbMedida1 = new System.Windows.Forms.ComboBox();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new wmgCMS.WaterMarkTextBox();
            this.textBox2 = new wmgCMS.WaterMarkTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbMateriaPrimaReceta = new System.Windows.Forms.ComboBox();
            this.materiaPrimaRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nombreLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteRecetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaRecetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 175);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 5;
            label2.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 13);
            label3.TabIndex = 6;
            label3.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 201);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 13);
            label4.TabIndex = 13;
            label4.Text = "Medida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editar ingrediente de receta";
            // 
            // ingredienteRecetaBindingSource
            // 
            this.ingredienteRecetaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.IngredienteReceta);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(222, 274);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(141, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbMedida1
            // 
            this.cbMedida1.DataSource = this.medidaBindingSource;
            this.cbMedida1.DisplayMember = "Nombre";
            this.cbMedida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida1.FormattingEnabled = true;
            this.cbMedida1.Location = new System.Drawing.Point(84, 198);
            this.cbMedida1.Name = "cbMedida1";
            this.cbMedida1.Size = new System.Drawing.Size(206, 21);
            this.cbMedida1.TabIndex = 4;
            this.cbMedida1.ValueMember = "Id";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Medida);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pedido);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteRecetaBindingSource, "Cantidad", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox3.Location = new System.Drawing.Point(84, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.WaterMarkColor = System.Drawing.Color.Gray;
            this.textBox3.WaterMarkText = "50";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteRecetaBindingSource, "Descripcion", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(84, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 100);
            this.textBox2.TabIndex = 2;
            this.textBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.textBox2.WaterMarkText = "Descripcion extra";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cbMateriaPrimaReceta
            // 
            this.cbMateriaPrimaReceta.DataSource = this.materiaPrimaRecetaBindingSource;
            this.cbMateriaPrimaReceta.DisplayMember = "Nombre";
            this.cbMateriaPrimaReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaPrimaReceta.FormattingEnabled = true;
            this.cbMateriaPrimaReceta.Location = new System.Drawing.Point(84, 40);
            this.cbMateriaPrimaReceta.Name = "cbMateriaPrimaReceta";
            this.cbMateriaPrimaReceta.Size = new System.Drawing.Size(206, 21);
            this.cbMateriaPrimaReceta.TabIndex = 1;
            this.cbMateriaPrimaReceta.ValueMember = "Id";
            this.cbMateriaPrimaReceta.DropDownClosed += new System.EventHandler(this.cbMateriaPrimaReceta_DropDownClosed);
            // 
            // materiaPrimaRecetaBindingSource
            // 
            this.materiaPrimaRecetaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.MateriaPrimaReceta);
            // 
            // FrmEditarIngredienteReceta
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(309, 309);
            this.Controls.Add(this.cbMateriaPrimaReceta);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbMedida1);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarIngredienteReceta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar ingrediente de receta";
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteRecetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaRecetaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ingredienteRecetaBindingSource;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbMedida1;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private wmgCMS.WaterMarkTextBox textBox3;
        private wmgCMS.WaterMarkTextBox textBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbMateriaPrimaReceta;
        private System.Windows.Forms.BindingSource materiaPrimaRecetaBindingSource;
    }
}