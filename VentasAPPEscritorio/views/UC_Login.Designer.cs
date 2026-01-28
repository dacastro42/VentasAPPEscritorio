namespace VentasAPPEscritorio.views
{
    partial class UC_Login
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
            txtMail = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(104, 114);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(220, 31);
            txtMail.TabIndex = 2;
            txtMail.Text = "Mail";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(104, 180);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(220, 31);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 38);
            label1.TabIndex = 19;
            label1.Text = "Login";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Century Gothic", 12F);
            btnIngresar.Location = new Point(137, 250);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(140, 54);
            btnIngresar.TabIndex = 18;
            btnIngresar.Text = "Iniciar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnAgregar_Click;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 434);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtMail);
            Name = "UC_Login";
            Text = "UC_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private TextBox txtPass;
        private Label label1;
        private Button btnIngresar;
    }
}