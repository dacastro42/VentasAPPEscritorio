namespace VentasAPPEscritorio.views
{
    partial class UC_Ventas
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
            label1 = new Label();
            txtNombre1 = new TextBox();
            button1 = new Button();
            dgvCarros = new DataGridView();
            dgvCarrito = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            lblSubtotal = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 65);
            label1.Name = "label1";
            label1.Size = new Size(23, 30);
            label1.TabIndex = 8;
            label1.Text = "*";
            // 
            // txtNombre1
            // 
            txtNombre1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre1.Location = new Point(188, 64);
            txtNombre1.Name = "txtNombre1";
            txtNombre1.Size = new Size(220, 31);
            txtNombre1.TabIndex = 7;
            txtNombre1.Text = "Nombre 1";
            // 
            // button1
            // 
            button1.Location = new Point(574, 35);
            button1.Name = "button1";
            button1.Size = new Size(128, 36);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvCarros
            // 
            dgvCarros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarros.Location = new Point(-7, 242);
            dgvCarros.Name = "dgvCarros";
            dgvCarros.Size = new Size(444, 211);
            dgvCarros.TabIndex = 9;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(435, 242);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(434, 211);
            dgvCarrito.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 190);
            label2.Name = "label2";
            label2.Size = new Size(162, 22);
            label2.TabIndex = 11;
            label2.Text = "Carros en Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(559, 190);
            label3.Name = "label3";
            label3.Size = new Size(176, 22);
            label3.TabIndex = 12;
            label3.Text = "Carros agregados";
            // 
            // button2
            // 
            button2.Location = new Point(574, 86);
            button2.Name = "button2";
            button2.Size = new Size(128, 36);
            button2.TabIndex = 13;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(574, 128);
            button3.Name = "button3";
            button3.Size = new Size(128, 36);
            button3.TabIndex = 14;
            button3.Text = "Confirmar Venta";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(188, 113);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(91, 22);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.Text = "Sub total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(188, 153);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 22);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total";
            // 
            // UC_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvCarros);
            Controls.Add(label1);
            Controls.Add(txtNombre1);
            Controls.Add(button1);
            Name = "UC_Ventas";
            Text = "UC_Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvCarros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre1;
        private Button button1;
        private DataGridView dgvCarros;
        private DataGridView dgvCarrito;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label lblSubtotal;
        private Label lblTotal;
    }
}