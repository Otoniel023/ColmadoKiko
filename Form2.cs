using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaColmado
{
    public partial class Form2 : Form
    {

        public static List<Cliente> clientes = new List<Cliente>();
        public Form2()
        {
            InitializeComponent();
            dataGridView_nombre.DataSource = clientes;

        }


        private void btnregistrar_Click(object sender, EventArgs e)

        {
            Cliente bot = new Cliente(txtnombre.Text, txtapellido.Text, txtcedula.Text, cbsucursal.Text);
            dataGridView_nombre.DataSource = null;
            clientes.Add(bot);
            dataGridView_nombre.DataSource = clientes;


        }

        public static void inicializacion()
        {
            clientes = new List<Cliente>()
             {
                 new Cliente("Juan", "Perez", "40100000000", "Santo Domingo"),
                 new Cliente("Tania", "Imbert", "402546122355", "Santiago"),
                 new Cliente("Francisco", "Perez", "03805600000", "Santo Domingo")

             };


        }





        private void label1_Click(object sender, EventArgs e)
        {
            s registar = new s();
            this.Hide();
            registar.Show();
        }

    }



    public class Cliente
    {
        public Cliente(string nombre, string apellido, string cedula, string sucursal)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.sucursal = sucursal;

        }



        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public string sucursal { get; set; }
        public int contador { get; set; }




    }




}
