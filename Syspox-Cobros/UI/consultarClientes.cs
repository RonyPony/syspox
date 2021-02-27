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
        public consultarClientes()
        {
            InitializeComponent();
        }

        private void consultarClientes_Load(object sender, EventArgs e)
        {
            this.titulo = "consultar clientes";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
