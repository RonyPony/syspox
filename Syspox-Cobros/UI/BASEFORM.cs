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
    public partial class BASEFORM : Form
    {
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
            this.Close();
        }

        private void BASEFORM_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
