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
    public partial class consultarPagos : UI.BASEFORM
    {
        data data = new data();
        public consultarPagos()
        {
            InitializeComponent();
        }

        private void consultarPagos_Load(object sender, EventArgs e)
        {
            this.titulo = "CONSULTAR PAGOS";
            dataGridView1.DataSource = data.getTableSP("SP_getPAgos");
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            string whereclause = "1=1";

            if (txtcedula.Text != string.Empty)
            {
                whereclause += " and c.cedula= '" + txtcedula.Text+"'";
            }
            if (txtnombre.Text != string.Empty)
            {
                whereclause += " and c.nombre like '%" + txtnombre.Text + "%'";
            }
            if (txtdireccion.Text != string.Empty)
            {
                whereclause += " and c.addressId=" + txtdireccion.Text;
            }
            if (txtmes.Text != string.Empty)
            {
                whereclause += " and p.mes='" + txtmes.Text+"'";
            }
            data data2 = new data();
            dataGridView1.DataSource = data2.getTableCustomQuery("SELECT c.nombre as CLIENTE,c.cedula as CEDULA, mes as 'MES CORRESPONDIENTE', p.monto as PAGADO, d.monto as ESPERADO,(CAST(d.monto AS int)-CAST(p.monto AS int)) as DIFERENCIA,p.fecha as 'FECHA DEL PAGO',p.id as 'FACTURA NO.'  FROM pagos as p inner join clientes as c on c.id = p.idCliente inner join direcciones d on d.id=c.addressId where " + whereclause);
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            selector select = new selector("clientes");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                txtcedula.Text = select.row.Cells[1].Value.ToString();
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            selector select = new selector("direcciones");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                txtdireccion.Text = select.row.Cells[0].Value.ToString();
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (data.delete("pagos", "id=" + dataGridView1.SelectedRows[0].Cells[7].Value.ToString()))
            {
                MessageBox.Show("Pago Eliminado Correctamente");
                dataGridView1.DataSource = data.getTableSP("SP_getPAgos");
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            srv.Visible = true;
            dataGridView1.Refresh();
            TXTmodpag.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            srv.Visible = false;
            data.update("pagos", "monto=" + TXTmodpag.Text, "id=" + dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            dataGridView1.DataSource = data.getTableSP("SP_getPAgos");
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            srv.Visible = false;
        }

        private void TXTmodpag_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TXTmodpag_KeyPress(object sender, KeyPressEventArgs e)
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
