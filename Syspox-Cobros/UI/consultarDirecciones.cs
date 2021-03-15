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
    public partial class consultarDirecciones : UI.BASEFORM
    {
        data data = new data();
        public consultarDirecciones()
        {
            InitializeComponent();
        }

        private void consultarDirecciones_Load(object sender, EventArgs e)
        {
            this.titulo = "consultar direcciones";
            cargar();
        }

        private void cargar()
        {
            dataGridView1.DataSource = data.getTable("direcciones",string.Empty);
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            nuevaDireccion p = new nuevaDireccion(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            p.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
