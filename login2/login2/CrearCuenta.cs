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

namespace login2
{
    public partial class CrearCuenta : Form
    {
        // Cadena de conexión a la base de datos
        string connectionString = "Data Source=(localdb)\\ senati;Initial Catalog=yarid_login;Integrated Security=True";
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {// Captura los datos del formulario
            string nombres = tbNombres.Text;
            string apellidos = tbApellidos.Text;
            string correo = tbCorreo.Text;
            string contraseña = tbContraseña.Text;

            // Verificar si el correo contiene el símbolo '@'
            if (!correo.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener el símbolo '@'.");
                return; // Salir del método sin guardar la cuenta
            }

            // Crea la consulta SQL para insertar los datos en la base de datos
            string query = "INSERT INTO Usuarios (Nombres, Apellidos, Correo, Contraseña) VALUES (@Nombres, @Apellidos, @Correo, @Contraseña)";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Registro exitoso");

                        // Cerrar el formulario actual
                        this.Close();

                        // Abrir el formulario de inicio de sesión
                        IniciarSesion formIniciarSesion = new IniciarSesion();
                        formIniciarSesion.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar: " + ex.Message);
                    }
                }
            }
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}