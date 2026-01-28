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
            button5 = new Button();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            monthCalendar2 = new MonthCalendar();
            monthCalendar3 = new MonthCalendar();
            groupBox1 = new GroupBox();
            dgvVendedores = new DataGridView();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // VentaBtn
            // 
            VentaBtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VentaBtn.Location = new Point(1128, 424);
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
            lblBienvenida.Location = new Point(549, 26);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(205, 41);
            lblBienvenida.TabIndex = 20;
            lblBienvenida.Text = "Bienvenido";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(75, 127);
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
            button2.Location = new Point(276, 127);
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
            button3.Location = new Point(59, 240);
            button3.Name = "button3";
            button3.Size = new Size(162, 66);
            button3.TabIndex = 24;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(135, 217);
            button5.Name = "button5";
            button5.Size = new Size(162, 66);
            button5.TabIndex = 26;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(25, 69);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 38);
            label1.Name = "label1";
            label1.Size = new Size(171, 22);
            label1.TabIndex = 28;
            label1.Text = "Selecciona el mes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(22, 41);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 29;
            // 
            // monthCalendar3
            // 
            monthCalendar3.Location = new Point(287, 41);
            monthCalendar3.Name = "monthCalendar3";
            monthCalendar3.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(monthCalendar2);
            groupBox1.Controls.Add(monthCalendar3);
            groupBox1.Location = new Point(841, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 295);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona Rango Fechas";
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(28, 50);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.Size = new Size(403, 161);
            dgvVendedores.TabIndex = 32;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dgvVendedores);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(23, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 289);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ventas por vendedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(118, 19);
            label2.Name = "label2";
            label2.Size = new Size(228, 22);
            label2.TabIndex = 34;
            label2.Text = "Selecciona el vendedor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(monthCalendar1);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(533, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(292, 316);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Total por mes";
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(195, 215);
            button4.Name = "button4";
            button4.Size = new Size(162, 66);
            button4.TabIndex = 29;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 593);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(VentaBtn);
            Controls.Add(lblBienvenida);
            Name = "MenuAdmin";
            Text = "MenuAdmin";
            Load += MenuAdmin_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VentaBtn;
        private Label lblBienvenida;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private MonthCalendar monthCalendar2;
        private MonthCalendar monthCalendar3;
        private GroupBox groupBox1;
        private DataGridView dgvVendedores;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox3;
        private Button button4;
    }
}