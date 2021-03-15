using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syspox_Cobros.UI
{
    public partial class BASEFORM : Form
    {
        bool fullscreen;

        public BASEFORM()
        {
            InitializeComponent();
        }

        public string titulo
        {
            get{ return label2.Text; }
            set { label2.Text = "SYSPOX - " + value.ToUpper(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BASEFORM_Load(object sender, EventArgs e)
        {
            fullscreen = true;
            p();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fullscreen = false;
            p();
        }

        private void p()
        {
            full.Visible = !fullscreen;
            normal.Visible = fullscreen;
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void full_Click(object sender, EventArgs e)
        {
            fullscreen = true;
            p();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
