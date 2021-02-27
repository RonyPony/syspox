using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syspox_Cobros
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UI.LOGIN login = new UI.LOGIN();
            login.Show();
            this.Hide();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value>=100)
            {
                timer1.Stop();
                this.Hide();
                UI.LOGIN lo = new UI.LOGIN();
                lo.Show();
            }
            else
            {
                progressBar1.Value ++;
            }
        }
    }
}
