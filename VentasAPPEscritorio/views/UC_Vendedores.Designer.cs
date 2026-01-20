namespace VentasAPPEscritorio.views
{
    partial class UC_Vendedores
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
            button1 = new Button();
            txtNombre1 = new TextBox();
            txtNombre2 = new TextBox();
            txtApellido1 = new TextBox();
            txtApellido2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(417, 353);
            button1.Name = "button1";
            button1.Size = new Size(128, 36);
            button1.TabIndex = 0;
            button1.Text = "Create Vendedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNombre1
            // 
            txtNombre1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre1.Location = new Point(120, 67);
            txtNombre1.Name = "txtNombre1";
            txtNombre1.Size = new Size(220, 31);
            txtNombre1.TabIndex = 1;
            txtNombre1.Text = "Nombre 1";
            // 
            // txtNombre2
            // 
            txtNombre2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre2.Location = new Point(120, 118);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(220, 31);
            txtNombre2.TabIndex = 2;
            txtNombre2.Text = "Nombre 2";
            // 
            // txtApellido1
            // 
            txtApellido1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido1.Location = new Point(120, 166);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(220, 31);
            txtApellido1.TabIndex = 3;
            txtApellido1.Text = "Apellido 1";
            // 
            // txtApellido2
            // 
            txtApellido2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido2.Location = new Point(120, 212);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(220, 31);
            txtApellido2.TabIndex = 4;
            txtApellido2.Text = "Apellido 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 68);
            label1.Name = "label1";
            label1.Size = new Size(23, 30);
            label1.TabIndex = 5;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(346, 167);
            label2.Name = "label2";
            label2.Size = new Size(23, 30);
            label2.TabIndex = 6;
            label2.Text = "*";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(417, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 31);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(643, 68);
            label3.Name = "label3";
            label3.Size = new Size(23, 30);
            label3.TabIndex = 8;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(643, 119);
            label4.Name = "label4";
            label4.Size = new Size(23, 30);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(417, 118);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(220, 31);
            txtTelefono.TabIndex = 9;
            txtTelefono.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(643, 167);
            label5.Name = "label5";
            label5.Size = new Size(23, 30);
            label5.TabIndex = 12;
            label5.Text = "*";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(417, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 31);
            txtPassword.TabIndex = 11;
            txtPassword.Text = "Password";
            // 
            // UC_Vendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido2);
            Controls.Add(txtApellido1);
            Controls.Add(txtNombre2);
            Controls.Add(txtNombre1);
            Controls.Add(button1);
            Name = "UC_Vendedores";
            Text = "UC_Vendedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNombre1;
        private TextBox txtNombre2;
        private TextBox txtApellido1;
        private TextBox txtApellido2;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtPassword;
    }
}