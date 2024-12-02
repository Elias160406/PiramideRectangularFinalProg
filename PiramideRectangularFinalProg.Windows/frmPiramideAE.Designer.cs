namespace PiramideRectangularFinalProg.Windows
{
    partial class frmPiramideAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtLadoBase = new TextBox();
            cmbMaterial = new GroupBox();
            rbtnMadera = new RadioButton();
            rbtnVidrio = new RadioButton();
            rbtnPlastico = new RadioButton();
            btnCancelar = new Button();
            btnOK = new Button();
            errorProvider1 = new ErrorProvider(components);
            label4 = new Label();
            txtAltura = new TextBox();
            cmbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 56);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Lado";
            // 
            // txtLadoBase
            // 
            txtLadoBase.Location = new Point(191, 56);
            txtLadoBase.Margin = new Padding(3, 4, 3, 4);
            txtLadoBase.Name = "txtLadoBase";
            txtLadoBase.Size = new Size(114, 27);
            txtLadoBase.TabIndex = 1;
            // 
            // cmbMaterial
            // 
            cmbMaterial.Controls.Add(rbtnMadera);
            cmbMaterial.Controls.Add(rbtnVidrio);
            cmbMaterial.Controls.Add(rbtnPlastico);
            cmbMaterial.Location = new Point(66, 151);
            cmbMaterial.Margin = new Padding(3, 4, 3, 4);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Padding = new Padding(3, 4, 3, 4);
            cmbMaterial.Size = new Size(239, 133);
            cmbMaterial.TabIndex = 4;
            cmbMaterial.TabStop = false;
            cmbMaterial.Text = " Material ";
            // 
            // rbtnMadera
            // 
            rbtnMadera.AutoSize = true;
            rbtnMadera.Location = new Point(17, 96);
            rbtnMadera.Margin = new Padding(3, 4, 3, 4);
            rbtnMadera.Name = "rbtnMadera";
            rbtnMadera.Size = new Size(81, 24);
            rbtnMadera.TabIndex = 0;
            rbtnMadera.Text = "Madera";
            rbtnMadera.UseVisualStyleBackColor = true;
            // 
            // rbtnVidrio
            // 
            rbtnVidrio.AutoSize = true;
            rbtnVidrio.Location = new Point(17, 63);
            rbtnVidrio.Margin = new Padding(3, 4, 3, 4);
            rbtnVidrio.Name = "rbtnVidrio";
            rbtnVidrio.Size = new Size(70, 24);
            rbtnVidrio.TabIndex = 0;
            rbtnVidrio.Text = "Vidrio";
            rbtnVidrio.UseVisualStyleBackColor = true;
            // 
            // rbtnPlastico
            // 
            rbtnPlastico.AutoSize = true;
            rbtnPlastico.Checked = true;
            rbtnPlastico.Location = new Point(17, 29);
            rbtnPlastico.Margin = new Padding(3, 4, 3, 4);
            rbtnPlastico.Name = "rbtnPlastico";
            rbtnPlastico.Size = new Size(81, 24);
            rbtnPlastico.TabIndex = 0;
            rbtnPlastico.TabStop = true;
            rbtnPlastico.Text = "Plástico";
            rbtnPlastico.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(219, 333);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 72);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.Location = new Point(66, 333);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 72);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 95);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Altura";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(191, 95);
            txtAltura.Margin = new Padding(3, 4, 3, 4);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(114, 27);
            txtAltura.TabIndex = 1;
            // 
            // frmPiramideAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 468);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cmbMaterial);
            Controls.Add(txtAltura);
            Controls.Add(txtLadoBase);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(389, 515);
            MinimumSize = new Size(389, 515);
            Name = "frmPiramideAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPiramideAE";
            Load += frmPiramideAE_Load;
            cmbMaterial.ResumeLayout(false);
            cmbMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLadoBase;
        private GroupBox cmbMaterial;
        private RadioButton rbtnPlastico;
        private RadioButton rbtnMadera;
        private RadioButton rbtnVidrio;
        private Button btnCancelar;
        private Button btnOK;
        private ErrorProvider errorProvider1;
        private TextBox txtAltura;
        private Label label4;
    }
}