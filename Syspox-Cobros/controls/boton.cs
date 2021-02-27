using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syspox_Cobros.controls
{
    public partial class boton : Button
    {
        public boton()
        {
            InitializeComponent();
        }

        public string texto
        {
            get { return this.Text; }
            set { this.Text = value.ToUpper(); }
        }

        private void boton_Load(object sender, EventArgs e)
        {
        }

        public void po(object sender, EventArgs e)
        {
            
        }

        private void boton_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void boton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void boton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Green;
        }

        //private void boton_Load_1(object sender, EventArgs e)
        //{
        //    label1.ForeColor = Color.White;
        //}

        //public Font letras
        //{
        //    get { return label1.Font; }
        //    set { label1.Font = value; }
        //}



        private void boton_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
