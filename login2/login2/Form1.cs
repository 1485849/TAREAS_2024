using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login2
{
   
    public partial class Form1 : Form
    { 
        
        CrearCuenta formularioCrearCuenta;
        IniciarSesion formularioIniciarSesion;
        public Form1()
        {
            InitializeComponent();

            formularioCrearCuenta = new CrearCuenta();

            formularioIniciarSesion = new IniciarSesion();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            formularioCrearCuenta.ShowDialog();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            formularioIniciarSesion.ShowDialog();
        }
    }
}
