using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectrolitosLab1UI
{
    public partial class Form1 : Form
    {
        // atributos
        public Form1()
        {
            InitializeComponent();
            this.btnMensaje.Text = "OK";
        }


        private void btnMensaje_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            try
            {
                this.btnMensaje.Text = "Cargando ...";
                resultado = 8 / resultado;
                MessageBox.Show("Hola Mundo");
                    
                this.btnMensaje.Text = "OK";
            }catch(Exception ex)
            {
                MessageBox.Show("Error = "+ex.Message);
            }
        }

      
    }
}
