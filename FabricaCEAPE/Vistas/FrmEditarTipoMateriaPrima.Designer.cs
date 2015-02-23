namespace FabricaCEAPE.Vistas
{
    partial class FrmEditarTipoMateriaPrima
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
            System.Windows.Forms.Button btnAceptar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarTipoMateriaPrima));
            this.label1 = new System.Windows.Forms.Label();
            this.tipoMateriaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nombreTextBox = new wmgCMS.WaterMarkTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            nombreLabel = new System.Windows.Forms.Label();
            btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMateriaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnAceptar.Location = new System.Drawing.Point(203, 76);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar tipo de materia prima";
            // 
            // tipoMateriaPrimaBindingSource
            // 
            this.tipoMateriaPrimaBindingSource.DataSource = typeof(FabricaCEAPE.Clases.TipoMateriaPrima);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(122, 76);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoMateriaPrimaBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(65, 40);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nombreTextBox.WaterMarkText = "Harina";
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmEditarTipoMateriaPrima
            // 
            this.AcceptButton = btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(290, 111);
            this.ControlBox = false;
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarTipoMateriaPrima";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar tipo de materia prima";
            ((System.ComponentModel.ISupportInitialize)(this.tipoMateriaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tipoMateriaPrimaBindingSource;
        private System.Windows.Forms.Button btnCancelar;
        private wmgCMS.WaterMarkTextBox nombreTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}