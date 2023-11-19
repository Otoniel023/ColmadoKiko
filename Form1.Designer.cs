namespace ConsultaColmado
{
    partial class s
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnbuscar = new Button();
            label1 = new Label();
            txtcedula = new TextBox();
            lblcedula = new Label();
            label5 = new Label();
            label7 = new Label();
            dgvfactura = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dgvdetalle = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Colunma6 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            lblnombre = new Label();
            lblapellido = new Label();
            lblsucursal = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvfactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetalle).BeginInit();
            SuspendLayout();
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(72, 175);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 0;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 38);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 1;
            label1.Text = "Colmado Kiko";
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(125, 112);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(153, 23);
            txtcedula.TabIndex = 2;
            // 
            // lblcedula
            // 
            lblcedula.AutoSize = true;
            lblcedula.Location = new Point(700, 136);
            lblcedula.Name = "lblcedula";
            lblcedula.Size = new Size(47, 15);
            lblcedula.TabIndex = 6;
            lblcedula.Text = "Cedula:";
            lblcedula.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 262);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Factura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(610, 262);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 10;
            label7.Text = "Detalle";
            // 
            // dgvfactura
            // 
            dgvfactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfactura.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvfactura.Location = new Point(12, 298);
            dgvfactura.Name = "dgvfactura";
            dgvfactura.RowTemplate.Height = 25;
            dgvfactura.Size = new Size(399, 150);
            dgvfactura.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Cliente";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cant Items";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha ";
            Column4.Name = "Column4";
            // 
            // dgvdetalle
            // 
            dgvdetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdetalle.Columns.AddRange(new DataGridViewColumn[] { Column5, Colunma6, Column6 });
            dgvdetalle.Location = new Point(463, 298);
            dgvdetalle.Name = "dgvdetalle";
            dgvdetalle.RowTemplate.Height = 25;
            dgvdetalle.Size = new Size(344, 150);
            dgvdetalle.TabIndex = 13;
            // 
            // Column5
            // 
            Column5.HeaderText = "Producto ";
            Column5.Name = "Column5";
            // 
            // Colunma6
            // 
            Colunma6.HeaderText = "Cantidad ";
            Colunma6.Name = "Colunma6";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.Name = "Column6";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(453, 112);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 11;
            lblnombre.Text = "Nombre:";
            lblnombre.Visible = false;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(453, 161);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(54, 15);
            lblapellido.TabIndex = 16;
            lblapellido.Text = "Apellido:";
            lblapellido.Visible = false;
            // 
            // lblsucursal
            // 
            lblsucursal.AutoSize = true;
            lblsucursal.Location = new Point(610, 136);
            lblsucursal.Name = "lblsucursal";
            lblsucursal.Size = new Size(54, 15);
            lblsucursal.TabIndex = 18;
            lblsucursal.Text = "Sucursal:";
            lblsucursal.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(667, 18);
            label10.Name = "label10";
            label10.Size = new Size(129, 16);
            label10.TabIndex = 19;
            label10.Text = "Registro Clientes";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(700, 464);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 21;
            label12.Text = "Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(741, 464);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 22;
            label11.Text = "Valor";
            label11.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 112);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 23;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 161);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 24;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 112);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 25;
            label4.Text = "Sucursal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(700, 112);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 26;
            label6.Text = "Cedula:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 115);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 27;
            label9.Text = "Cedula:";
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 499);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(lblsucursal);
            Controls.Add(lblapellido);
            Controls.Add(dgvdetalle);
            Controls.Add(dgvfactura);
            Controls.Add(lblnombre);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lblcedula);
            Controls.Add(txtcedula);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Name = "s";
            ((System.ComponentModel.ISupportInitialize)dgvfactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbuscar;
        private Label label1;
        private TextBox txtcedula;
        private Label lblcedula;
        private Label label5;
        private Label label7;
        private DataGridView dgvfactura;
        private DataGridView dgvdetalle;
        private Label lblnombre;
        private Label lblapellido;
        private Label lblsucursal;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Colunma6;
        private DataGridViewTextBoxColumn Column6;
        private Label label12;
        private Label label11;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label9;
    }
}