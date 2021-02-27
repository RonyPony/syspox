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
    public partial class nuevopago : UI.BASEFORM
    {
        data data = new data();
        public nuevopago()
        {
            InitializeComponent();
        }

        private void nuevopago_Load(object sender, EventArgs e)
        {
            this.titulo = "nuevo pago";
            DataTable table = data.getTable("meses", string.Empty);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "name";
            comboBox1.Text = "";
        }

        private void boton1_Click(object sender, EventArgs e)
        {

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
