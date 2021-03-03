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
            //cargar();
            dataGridView1.DataSource = data.getTableSP("SP_getClientes");
        }

        private void cargar()
        {
            dataGridView1.DataSource = data.getTable("clientes",string.Empty);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void boton4_Click(object sender, EventArgs e)
        {
            data data2 = new data();
            string cedula = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string id = data2.getCustomerId(cedula);
            int idn = Convert.ToInt32(id);
            nuevoCliente p = new nuevoCliente(idn);
            p.Show();
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            selector select = new selector("direcciones");
            select.ShowDialog();
            txtdireccion.Text = select.row.Cells[0].Value.ToString();
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            lbldireccion.Text = data.getAdress(txtdireccion.Text);
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            buscar();
            
        }
        private void buscar()
        {
            string condicional;

            if (txtcedula.Text != string.Empty)
            {
                condicional = "cedula";
            }
            if (txtcedula.Text != string.Empty)
            {

            }
            if (txtcedula.Text != string.Empty)
            {

            }
            string direccion;
            if (txtdireccion.Text==string.Empty)
            {
                direccion = string.Empty;
            }
            else
            {
                direccion = "and addressid = "+txtdireccion.Text;
            }
            data data2 = new data();
            dataGridView1.DataSource = data2.getTable("clientes","cedula like '%" + txtcedula.Text + "%' and nombre like '%"+txtnombre.Text+"%' "+direccion);
        }
    }
}
