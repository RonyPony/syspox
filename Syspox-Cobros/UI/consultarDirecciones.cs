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
    }
}
