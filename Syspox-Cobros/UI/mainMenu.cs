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
    public partial class mainMenu : UI.BASEFORM
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            this.titulo = "menu principal";
        }

        private void boton1_Load(object sender, EventArgs e)
        {

        }

        private void boton3_Load(object sender, EventArgs e)
        {
            //boton3.ForeColor = Color.White;
        }

        private void homeShorcut1_Load(object sender, EventArgs e)
        {

        }

        private void homeShorcut1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            np();
        }

        private void np()
        {
            nuevopago NP = new nuevopago();
            NP.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            np();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            np();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cp()
        {
            consultarPagos CP = new consultarPagos();
            CP.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            cp();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cp();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            nc();
        }

        private void nc()
        {
            nuevoCliente nc = new nuevoCliente();
            nc.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            nc();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            np();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            cp();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            nc();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            cc();
        }

        private void cc()
        {
            consultarClientes cc = new consultarClientes();
            cc.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cc();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            cc();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            nd();
        }

        private void nd()
        {
            nuevaDireccion nd = new nuevaDireccion();
            nd.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            nd();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            nd();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cd();
        }

        private void cd()
        {
            consultarDirecciones cd = new consultarDirecciones();
            cd.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            cd();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            cd();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            r();
        }

        private void r()
        {
            reportes r = new reportes();
            r.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            r();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            r();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            d();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            d();
        }

        private void d()
        {
            devoluciones d = new devoluciones();
            d.Show();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            d();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
