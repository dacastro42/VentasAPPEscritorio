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
            btnAgregar = new Button();
            dgvCarros = new DataGridView();
            dgvCarrito = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnQuitar = new Button();
            btnConfirmarVenta = new Button();
            lblSubtotal = new Label();
            lblTotal = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Century Gothic", 12F);
            btnAgregar.Location = new Point(451, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 54);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCarros
            // 
            dgvCarros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarros.Location = new Point(-7, 242);
            dgvCarros.Name = "dgvCarros";
            dgvCarros.Size = new Size(444, 211);
            dgvCarros.TabIndex = 9;
            dgvCarros.CellContentDoubleClick += dgvCarros_CellContentDoubleClick;
            dgvCarros.SelectionChanged += dgvCarros_SelectionChanged;
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
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Century Gothic", 12F);
            btnQuitar.Location = new Point(651, 46);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(140, 52);
            btnQuitar.TabIndex = 13;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Font = new Font("Century Gothic", 12F);
            btnConfirmarVenta.Location = new Point(559, 120);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(140, 55);
            btnConfirmarVenta.TabIndex = 14;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(264, 76);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(43, 22);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.Text = "000";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(264, 116);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(43, 22);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 76);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 17;
            label1.Text = "Sub total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 116);
            label4.Name = "label4";
            label4.Size = new Size(188, 22);
            label4.TabIndex = 18;
            label4.Text = "Total Valor con IVA";
            // 
            // UC_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(btnQuitar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvCarros);
            Controls.Add(btnAgregar);
            Name = "UC_Ventas";
            Text = "UC_Ventas";
            Load += LoadV;
            ((System.ComponentModel.ISupportInitialize)dgvCarros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private DataGridView dgvCarros;
        private DataGridView dgvCarrito;
        private Label label2;
        private Label label3;
        private Button btnQuitar;
        private Button btnConfirmarVenta;
        private Label lblSubtotal;
        private Label lblTotal;
        private Label label1;
        private Label label4;
    }
}