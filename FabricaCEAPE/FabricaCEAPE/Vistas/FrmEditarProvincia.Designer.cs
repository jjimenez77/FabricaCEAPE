namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarProvincia
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
            System.Windows.Forms.Label Pais;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProvincia));
            this.label1 = new System.Windows.Forms.Label();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nombreTextBox = new wmgCMS.WaterMarkTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            nombreLabel = new System.Windows.Forms.Label();
            Pais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(13, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // Pais
            // 
            Pais.AutoSize = true;
            Pais.Location = new System.Drawing.Point(13, 70);
            Pais.Name = "Pais";
            Pais.Size = new System.Drawing.Size(27, 13);
            Pais.TabIndex = 4;
            Pais.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar provincia";
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Provincia);
            // 
            // cbPais
            // 
            this.cbPais.DataSource = this.paisBindingSource;
            this.cbPais.DisplayMember = "Nombre";
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(65, 67);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(206, 21);
            this.cbPais.TabIndex = 2;
            this.cbPais.ValueMember = "Id";
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(FabricaCEAPE.Clases.Pais);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(122, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(203, 226);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provinciaBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(66, 40);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreTextBox.WaterMarkText = "Entre Rios";
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmEditarProvincia
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.ControlBox = false;
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(Pais);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarProvincia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar provincia";
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private wmgCMS.WaterMarkTextBox nombreTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}