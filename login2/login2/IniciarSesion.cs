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
    public partial class IniciarSesion : Form
    {

        string connectionString = "Data Source=(localdb)\\ senati;Initial Catalog=yarid_login;Integrated Security=True";
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Captura los datos del formulario
            string correo = tbIngreseUsuario.Text;
            string contraseña = tbIngreseContraseña.Text;

            // Crea la consulta SQL para verificar las credenciales en la base de datos
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo AND Contraseña = @Contraseña";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        // Verifica si se encontró una coincidencia de credenciales
                        if (count > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso");
                            // Aquí puedes redirigir al usuario a otra ventana o realizar alguna acción adicional
                            // Cerrar el formulario actual
                            this.Hide();

                            // Instanciar y mostrar el formulario de la página deseada
                            PAGINA pagina = new PAGINA();
                            pagina.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Correo electrónico o contraseña incorrectos");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                    }
                }
            }
        }
    }
}