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
    public partial class consultarClientes : UI.BASEFORM
    {
        data data = new data();
        public consultarClientes()
        {
            InitializeComponent();
        }

        private void consultarClientes_Load(object sender, EventArgs e)
        {
            this.titulo = "consultar clientes";
            cargar();
        }

        private void cargar()
        {
            dataGridView1.DataSource = data.getTable("clientes",string.Empty);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            nuevoCliente p = new nuevoCliente(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            p.Show();
        }
    }
}
