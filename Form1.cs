using System.Security.Cryptography.X509Certificates;

namespace ConsultaColmado
{

    //Clase Formulario Consulta
    public partial class s : Form
    {
        //Constructor
        public s()
        {
            InitializeComponent();
            Form2.inicializacion();
            // dgvfactura.RowHeadersVisible = Visible;
        }


        //Funcion de la clase--------------------------------------------------------------------------------

        //Boton Consultar
        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            //Recorre la lista de clientes y compara el valor de la cedula con el valor del textbox
            foreach (Cliente iterador in Form2.clientes)
            {

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
                    //Recorre la lista de facturas y compara el valor de la cedula con el valor del textbox
                    foreach (factura iterador2 in facturas)
                    {
                        if (long.Parse(lblcedula.Text) == iterador2.id_cliente)
                        {
                            //Agrega los valores a la GridView
                            dgvfactura.Rows.Add(iterador2.id_factura, iterador2.cliente, iterador2.items_cant, iterador2.fecha);
                        }
                    }
                }

            }
            if (resultado == false)
            {
                MessageBox.Show("El cliente no existe");
            }


        }//--------------------------------------------------------------------------------------------

        //Boton ir al formulario de registro
        private void label10_Click(object sender, EventArgs e)
        {
            Form2 consulta = new Form2();
            this.Hide();
            consulta.Show();
        }


        //Boton para mostrar el detalle de la factura
        private void dgvfactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

           
        {

            this.dgvdetalle.Rows.Clear();
            try
            {
                int id = Convert.ToInt32(this.dgvfactura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                foreach (producto x in products)
                {
                    if (x.id == id)
                    {
                        dgvdetalle.Rows.Add(products[id].nombre, products[id].cantidad, products[id].precio);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Total();

        }

        public void Total()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {
                // MessageBox.Show(row.Cells[0].Value.ToString());
                total += Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[1].Value);

            }
            lblvalor.Text = total.ToString();
            lblvalor.Visible = true;
        }

        //Campos de clase--------------------------------------------------------------------------------

        //Lista de Facturas
        List<factura> facturas = new List<factura>() {

            new factura(1, "Juan Perez", 2, "12/12/2023", 40100000000),
            new factura(2, "Tania Imbert",2, "12/12/2023", 402546122355),
            new factura(3, "Francisco Imbert",2, "12/12/2023", 03805600000),
            new factura(4, "Juan Perez", 4, "12/12/2023", 40100000000),
            new factura(5, "Tania Imbert",3, "12/11/2023", 402546122355),
            new factura(6, "Tania Imbert", 1, "12/12/2012", 402546122355),

        };

        //Lista de productos
        List<producto> products = new List<producto>() {

           new producto(1, "Coca Cola", 35, 1),//Factura 1 Juan Perez
           new producto(1, "platano", 15, 5),//Factura 1 Juan Perez

           new producto(2, "Cerveza", 175, 3),//Factura 2 Tania Imbert
           new producto(2, "Vasos", 15, 3),//Factura 2 Tania Imbert

           new producto(3, "Papa", 4, 20),//Factura 3 Francisco Imbert
           new producto(3, "Cebolla", 12, 4),//Factura 3 Francisco Imbert

           new producto(4, "Dorito", 35, 1),//Factura 4 Juan Perez
           new producto(4, "Pepsi", 35, 1),//Factura 4 Juan Perez

           new producto(5, "Cerveza", 175, 3),//Factura 5 Tania Imbert
           new producto(5, "Vasos", 15, 3),//Factura 5 Tania Imbert

           new producto(6, "Coca Cola", 35, 1),//Factura 6 Tania Imbert
           new producto(6, "platano", 15, 5),//Factura 6 Tania Imbert

        };


    }


    //Clases externas----------------------------------------------------------------------------

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
    //-------------------------------------------------------------------------------------------

    //Clase Factura
    public class factura
    {
        //Constructor
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


}

