namespace ConsultaColmado
{
    public partial class s : Form
    {
        
        public s()
        {
            InitializeComponent();
            Form2.inicializacion();
            




        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = false;



            foreach (Cliente iterador in Form2.clientes)
            {
                MessageBox.Show(iterador.nombre);
                if (iterador.cedula == txtcedula.Text)
                {
                    resultado = true;
                    lblnombre.Text = iterador.nombre;
                    lblapellido.Text = iterador.apellido;
                    lblcedula.Text = iterador.cedula;
                    lblsucursal.Text = iterador.sucursal;

                    lblapellido.Visible = true;
                    lblnombre.Visible = true;
                    lblcedula.Visible = true;
                    lblsucursal.Visible = true;
                    
                    foreach (factura iterador2 in facturas)
                    {
                        if (long.Parse(lblcedula.Text) == iterador2.id_cliente)
                        {
                            dgvfactura.Rows.Add(iterador2.id_factura, iterador2.cliente, iterador2.items_cant, iterador2.fecha);
                        }
                    }
                    
                }

            }

            if (resultado == false)
            {
                MessageBox.Show("El cliente no existe");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form2 consulta = new Form2();
            this.Hide();
            consulta.Show();
        }

        //Clase Factura
        public class factura
        {
            public factura(int id, string clientes, int items_cant, string fecha, long id_cliente)
            {
                this.id_factura = id;   
                this.cliente = clientes;
                this.items_cant = items_cant;
                this.fecha = fecha;
                this.id_cliente = id_cliente;
            }

            public string fecha { get; set; }
            public string cliente { get; set; }
            public int items_cant { get; set; }
            public int id_factura { get; set; }
            public long id_cliente { get; set; }

        }

        List<factura> facturas = new List<factura>() 
        {
            new factura(1, "Juan Perez", 2, "12/12/2023", 00100000000),
            new factura(4, "Juan Perez", 4, "12/12/2023", 00100000000),
            new factura(2, "Tania Imbert",2, "12/12/2023", 402546122355),
            new factura(5, "Tania Imbert",3, "12/11/2023", 402546122355),
            new factura(5, "Tania Imbert", 1, "12/12/2012", 402546122355),
            new factura(3, "Francisco Imbert",2, "12/12/2023", 00100000000)
            
        
        };

        /*List<producto> products = new List<producto>() 
        {
           new producto(facturas[0]., "Huevo", 100, 2),
           new producto(factura.id_cliente, "Salami", 100, 2), 
           new producto(factura.id_cliente, "Papa", 100, 2),
           new producto(factura.id_cliente, "Creveza", 100, 2),
        };*/



        

        //Clase Detalle
        public class producto
        {
            public producto(int id, string nombre, int precio, int cantidad)
            {
                this.nombre = nombre;
                this.precio = precio;
                this.cantidad = cantidad;
                this.id = id;
            }

            public string nombre { get; set; }
            public int precio { get; set; }
            public int cantidad { get; set; }
            public int id { get; set; }
            
        }

            

            

        

    }

}

