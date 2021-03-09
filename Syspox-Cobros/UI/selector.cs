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
            row = new DataGridViewRow();
            this.titulo = "seleccionar un elemento";
            dataGridView1.DataSource = data.getTable(table,string.Empty);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                comboBox1.Items.Add(col.Name);
            }
            comboBox1.Text = comboBox1.Items[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            row = dataGridView1.SelectedRows[0];
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            dataGridView1.DataSource = data.getTable(table,comboBox1.Text+" like '%"+textBox1.Text+"%'");
        }
    }
}
