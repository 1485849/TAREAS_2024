using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativ
{
    public partial class Form1 : Form
    {

        // Define la lista de opciones
        private List<string> opciones = new List<string>
        {
            "selecciona...",
            "lavar la ropa",
            "cocinar",
            "lavar los servicios",
            "barrer",
            "lavar el carro",
            "trapear el cuarto",
            "ordenar la cocina",
            "ordenar la biblioteca",
            "limpiar la cochera"
        };
        public Form1()
        {
            InitializeComponent();



            // Asigna la lista de opciones a cada ComboBox

            comboBox1.Items.AddRange(opciones.ToArray());
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(opciones.ToArray());
            comboBox2.SelectedIndex = 0;

            comboBox3.Items.AddRange(opciones.ToArray());
            comboBox3.SelectedIndex = 0;

            comboBox4.Items.AddRange(opciones.ToArray());
            comboBox4.SelectedIndex = 0;

            comboBox5.Items.AddRange(opciones.ToArray());
            comboBox5.SelectedIndex = 0;

            comboBox6.Items.AddRange(opciones.ToArray());
            comboBox6.SelectedIndex = 0;

            comboBox7.Items.AddRange(opciones.ToArray());
            comboBox7.SelectedIndex = 0;

            comboBox8.Items.AddRange(opciones.ToArray());
            comboBox8.SelectedIndex = 0;

            comboBox9.Items.AddRange(opciones.ToArray());
            comboBox9.SelectedIndex = 0;

            comboBox10.Items.AddRange(opciones.ToArray());
            comboBox10.SelectedIndex = 0;

            comboBox11.Items.AddRange(opciones.ToArray());
            comboBox11.SelectedIndex = 0;

            comboBox12.Items.AddRange(opciones.ToArray());
            comboBox12.SelectedIndex = 0;

            comboBox13.Items.AddRange(opciones.ToArray());
            comboBox13.SelectedIndex = 0;

            comboBox14.Items.AddRange(opciones.ToArray());
            comboBox14.SelectedIndex = 0; 
            
            comboBox15.Items.AddRange(opciones.ToArray());
            comboBox15.SelectedIndex = 0;

            comboBox16.Items.AddRange(opciones.ToArray());
            comboBox16.SelectedIndex = 0;



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox1);
        }
        private void MostrarSeleccion(ComboBox comboBox)
        {
            string seleccion = comboBox.SelectedItem.ToString();
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox2);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox4);
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox3);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox6);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox10);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox9);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox8);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeleccion(comboBox16);
        }
    }
}
