namespace VentasAPPEscritorio.views
{
    partial class MenuAdmin
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
            VentaBtn = new Button();
            lblBienvenida = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // VentaBtn
            // 
            VentaBtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VentaBtn.Location = new Point(487, 278);
            VentaBtn.Name = "VentaBtn";
            VentaBtn.Size = new Size(162, 66);
            VentaBtn.TabIndex = 21;
            VentaBtn.Text = "Crear Venta";
            VentaBtn.UseVisualStyleBackColor = true;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(303, 34);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(205, 41);
            lblBienvenida.TabIndex = 20;
            lblBienvenida.Text = "Bienvenido";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 147);
            button1.Name = "button1";
            button1.Size = new Size(162, 66);
            button1.TabIndex = 22;
            button1.Text = "Mayor Venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(241, 147);
            button2.Name = "button2";
            button2.Size = new Size(162, 66);
            button2.TabIndex = 23;
            button2.Text = "Vendedor Top";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(437, 147);
            button3.Name = "button3";
            button3.Size = new Size(162, 66);
            button3.TabIndex = 24;
            button3.Text = "Total Mes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(630, 147);
            button4.Name = "button4";
            button4.Size = new Size(162, 66);
            button4.TabIndex = 25;
            button4.Text = "Carro más vendido";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(172, 278);
            button5.Name = "button5";
            button5.Size = new Size(162, 66);
            button5.TabIndex = 26;
            button5.Text = "Ventas por vendedor";
            button5.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(VentaBtn);
            Controls.Add(lblBienvenida);
            Name = "MenuAdmin";
            Text = "MenuAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VentaBtn;
        private Label lblBienvenida;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}