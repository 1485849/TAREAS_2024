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
    public partial class CrearCuenta : Form
    {

        private string connectionString;

        // Constructor que acepta la cadena de conexión
        public CrearCuenta(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString; // Almacena la cadena de conexión
        }
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            string nombres = tbNombres.Text;
            string apellidos = tbApellidos.Text;
            string correo = tbCorreo.Text;
            string contraseña = tbContraseña.Text;

            string consulta = "INSERT INTO Usuarios (nombres, apellidos, correo, contraseña) VALUES (@nombres, @apellidos, @correo, @contraseña)";

            // Abre una nueva conexión para realizar la inserción
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombres", nombres);
                comando.Parameters.AddWithValue("@apellidos", apellidos);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cuenta creada correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la cuenta: " + ex.Message);
                }

            }
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void tbNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelapellido_Click(object sender, EventArgs e)
        {

        }

        private void tbCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelCorreo_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
