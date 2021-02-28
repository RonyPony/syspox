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
    public partial class selector : UI.BASEFORM
    {
        string table;
        data data = new data();

        public DataGridViewRow row { get; set; }


        public selector(string tablex)
        {
            InitializeComponent();
            table = tablex;
        }

        private void selector_Load(object sender, EventArgs e)
        {
            this.titulo = "seleccionar un elemento";
            dataGridView1.DataSource = data.getTable(table,string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            row = dataGridView1.SelectedRows[0];
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
