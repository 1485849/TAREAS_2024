using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace login
{
    public partial class Form1 : Form
    {

        CrearCuenta formularioCrearCuenta;
        IniciarSesion formularioIniciarSesion;


        // Define la cadena de conexión
        string connectionString = "Data Source=localhost;Initial Catalog=master;User ID=DESKTOP-JGAUG7S\\Alumno; Password=";

        // Crea un objeto de conexión
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            // Inicializa el objeto de conexión
            connection = new SqlConnection(connectionString);

            formularioCrearCuenta = new CrearCuenta();

            formularioIniciarSesion = new IniciarSesion();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            formularioCrearCuenta = new CrearCuenta(connectionString);
            formularioCrearCuenta.ShowDialog();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            formularioIniciarSesion.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Abre la conexión al cargar el formulario
            try
            {
                connection.Open();
                Console.WriteLine("Conexión establecida correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al establecer la conexión: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cierra la conexión al cerrar el formulario
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}