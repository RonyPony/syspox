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
    public partial class devoluciones : UI.BASEFORM
    {
        data data = new data();
        public devoluciones()
        {
            InitializeComponent();
        }

        private void devoluciones_Load(object sender, EventArgs e)
        {
            this.titulo = "Devoluciones";
            recargar();
        }

        private void recargar()
        {
            dataGridView1.DataSource = data.getTableSP("SP_getDev");
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            selector select = new selector("clientes");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                txtscedula.Text = select.row.Cells[1].Value.ToString();
            }
        }

        private void boton7_Click(object sender, EventArgs e)
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
        }

        private void boton2_Click(object sender, EventArgs e)
        {
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string idCliente, descri, monto;
                descri = textBox8.Text;
                monto = txtmonto.Text;
                if (data.save("devoluciones", "persona,cedula,descripcion,monto,fecha", "'" + txtnombre.Text + "','"+txtcedula.Text+"','" + descri + "','" + monto + "','"+DateTime.Now.ToString()+"'"))
                {
                    MessageBox.Show("DEVOLUCION REGISTRADA");
                    recargar();
                    txtcedula.Clear();
                    txtmonto.Clear();
                    txtnombre.Clear();
                    textBox8.Clear();
                    //this.Close();
                }
            }
        }

        private bool Validar()
        {
            if (txtcedula.Text.Replace("-","").Length==11)
            {
                if (textBox8.Text.Length>=1)
                {
                    if (txtmonto.Text.Length>=1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("MONTO REQUERIDO");
                    }
                }
                else
                {
                    MessageBox.Show("DESCRIPCION REQUERIDA");
                }
            }
            else
            {
                MessageBox.Show("DEBE INTRODUCIR UNA CEDULA VALIDA");
            }

            return false;

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            if (txtcedula.Text.Replace("-","").Length ==11)
            {
                getInfo();
            }
        }

        private void getInfo()
        {
            data.cerrar();
            string hid = data.getCustomerId(txtcedula.Text);
            List<string> info = data.getClienteInfo(hid);
            if (info.Count <= 0)
            {

            }
            else
            {
                txtnombre.Text = info[2];
            }

        }

        private void buscar()
        {
            string whereclause = "1=1";

            if (txtscedula.Text != string.Empty)
            {
                whereclause += " and cedula= '" + txtscedula.Text + "'";
            }
            if (txtsnombre.Text != string.Empty)
            {
                whereclause += " and persona like '%" + txtsnombre.Text + "%'";
            }
            //if (txtmes.Text != string.Empty)
            //{
            //    whereclause += " and p.mes='" + txtmes.Text + "'";
            //}
            data data2 = new data();
            dataGridView1.DataSource = data2.getTableCustomQuery("select cedula,persona,monto,descripcion,fecha from devoluciones where " + whereclause);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
