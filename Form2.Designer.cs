namespace ConsultaColmado
{
    partial class Form2
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
            btnregistrar = new Button();
            txtapellido = new TextBox();
            label2 = new Label();
            label6 = new Label();
            lblapellido = new Label();
            lblnombre = new Label();
            txtnombre = new TextBox();
            lblcedula = new Label();
            txtcedula = new TextBox();
            label1 = new Label();
            lblsucursal = new Label();
            cbsucursal = new ComboBox();
            dataGridView_nombre = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_nombre).BeginInit();
            SuspendLayout();
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = SystemColors.ButtonFace;
            btnregistrar.Location = new Point(525, 211);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(75, 23);
            btnregistrar.TabIndex = 1;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(457, 89);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(173, 23);
            txtapellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(300, 22);
            label2.Name = "label2";
            label2.Size = new Size(151, 24);
            label2.TabIndex = 3;
            label2.Text = "Colmado Kiko";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 211);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 12;
            label6.Text = "Clientes Registrados ";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(397, 92);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(54, 15);
            lblapellido.TabIndex = 13;
            lblapellido.Text = "Apellido:";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(38, 100);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 15);
            lblnombre.TabIndex = 14;
            lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(98, 97);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(179, 23);
            txtnombre.TabIndex = 15;
            // 
            // lblcedula
            // 
            lblcedula.AutoSize = true;
            lblcedula.Location = new Point(38, 177);
            lblcedula.Name = "lblcedula";
            lblcedula.Size = new Size(47, 15);
            lblcedula.TabIndex = 16;
            lblcedula.Text = "Cedula:";
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(98, 173);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(179, 23);
            txtcedula.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(574, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 16);
            label1.TabIndex = 21;
            label1.Text = "Consultar Clientes ";
            label1.Click += label1_Click;
            // 
            // lblsucursal
            // 
            lblsucursal.AutoSize = true;
            lblsucursal.Location = new Point(397, 173);
            lblsucursal.Name = "lblsucursal";
            lblsucursal.Size = new Size(54, 15);
            lblsucursal.TabIndex = 22;
            lblsucursal.Text = "Sucursal:";
            // 
            // cbsucursal
            // 
            cbsucursal.FormattingEnabled = true;
            cbsucursal.Items.AddRange(new object[] { "Puerto Plata ", "Santiago ", "Santo Domingo ", "San Pedro de Macoris " });
            cbsucursal.Location = new Point(457, 170);
            cbsucursal.Name = "cbsucursal";
            cbsucursal.Size = new Size(173, 23);
            cbsucursal.TabIndex = 23;
            // 
            // dataGridView_nombre
            // 
            dataGridView_nombre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_nombre.Location = new Point(173, 243);
            dataGridView_nombre.Name = "dataGridView_nombre";
            dataGridView_nombre.RowTemplate.Height = 25;
            dataGridView_nombre.Size = new Size(427, 150);
            dataGridView_nombre.TabIndex = 24;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(727, 405);
            Controls.Add(dataGridView_nombre);
            Controls.Add(cbsucursal);
            Controls.Add(lblsucursal);
            Controls.Add(label1);
            Controls.Add(txtcedula);
            Controls.Add(lblcedula);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(lblapellido);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtapellido);
            Controls.Add(btnregistrar);
            Name = "Form2";
            Text = "Registro clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView_nombre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnregistrar;
        private TextBox txtapellido;
        private Label label2;
        private Label label6;
        private Label lblapellido;
        private Label lblnombre;
        private TextBox txtnombre;
        private Label lblcedula;
        private TextBox txtcedula;
        private DataGridView dgvclientes;
        private Label label1;
        private Label lblsucursal;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cbsucursal;
        private DataGridView dataGridView_nombre;
    }
}