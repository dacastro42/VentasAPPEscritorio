namespace VentasAPPEscritorio.views
{
    partial class FrmCarroMultimedia
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
            pbPrincipal = new PictureBox();
            lblCarro = new Label();
            dgvMedia = new DataGridView();
            btnAbrirRecurso = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedia).BeginInit();
            SuspendLayout();
            // 
            // pbPrincipal
            // 
            pbPrincipal.Location = new Point(499, 62);
            pbPrincipal.Name = "pbPrincipal";
            pbPrincipal.Size = new Size(155, 197);
            pbPrincipal.TabIndex = 0;
            pbPrincipal.TabStop = false;
            // 
            // lblCarro
            // 
            lblCarro.AutoSize = true;
            lblCarro.Location = new Point(71, 86);
            lblCarro.Name = "lblCarro";
            lblCarro.Size = new Size(38, 15);
            lblCarro.TabIndex = 1;
            lblCarro.Text = "label1";
            // 
            // dgvMedia
            // 
            dgvMedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedia.Location = new Point(-1, 225);
            dgvMedia.Name = "dgvMedia";
            dgvMedia.Size = new Size(430, 223);
            dgvMedia.TabIndex = 2;
            // 
            // btnAbrirRecurso
            // 
            btnAbrirRecurso.Location = new Point(534, 325);
            btnAbrirRecurso.Name = "btnAbrirRecurso";
            btnAbrirRecurso.Size = new Size(133, 58);
            btnAbrirRecurso.TabIndex = 3;
            btnAbrirRecurso.Text = "button1";
            btnAbrirRecurso.UseVisualStyleBackColor = true;
            btnAbrirRecurso.Click += btnAbrirRecurso_Click;
            // 
            // FrmCarroMultimedia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbrirRecurso);
            Controls.Add(dgvMedia);
            Controls.Add(lblCarro);
            Controls.Add(pbPrincipal);
            Name = "FrmCarroMultimedia";
            Text = "FrmCarroMultimedia";
            ((System.ComponentModel.ISupportInitialize)pbPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPrincipal;
        private Label lblCarro;
        private DataGridView dgvMedia;
        private Button btnAbrirRecurso;
    }
}