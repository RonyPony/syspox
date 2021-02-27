using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syspox_Cobros.UI
{
    public partial class LOGIN : BASEFORM
    {
        data data = new data();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            this.titulo = "Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void boton1_Load(object sender, EventArgs e)
        {
            
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (data.login(textBox1.Text,textBox2.Text))
            {
                mainMenu MM = new mainMenu();
                MM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Informacion incorrecta");
            }
        }

        private void boton2_Load(object sender, EventArgs e)
        {

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boton2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void boton1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
