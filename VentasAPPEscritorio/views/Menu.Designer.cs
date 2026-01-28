namespace VentasAPPEscritorio.views
{
    partial class Menu
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
            lblBienvenida = new Label();
            VentaBtn = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(287, 33);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(205, 41);
            lblBienvenida.TabIndex = 18;
            lblBienvenida.Text = "Bienvenido";
            // 
            // VentaBtn
            // 
            VentaBtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VentaBtn.Location = new Point(12, 78);
            VentaBtn.Name = "VentaBtn";
            VentaBtn.Size = new Size(162, 66);
            VentaBtn.TabIndex = 19;
            VentaBtn.Text = "Crear Venta";
            VentaBtn.UseVisualStyleBackColor = true;
            VentaBtn.Click += VentaBtn_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VentaBtn);
            Controls.Add(lblBienvenida);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button VentaBtn;
    }
}