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
            selector select = new selector("direcciones");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                txtsdireccion.Text = select.row.Cells[0].Value.ToString();
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            selector select = new selector("direcciones");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                txtdireccion.Text = select.row.Cells[0].Value.ToString();
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string idCliente, descri, monto;
                idCliente = data.getCustomerId(txtcedula.Text);
                descri = textBox8.Text;
                monto = txtmonto.Text;
                if (data.save("devoluciones", "idCliente,descripcion,monto,fecha", "'" + idCliente + "','" + descri + "','" + monto + "','"+DateTime.Now.ToString()+"'"))
                {
                    MessageBox.Show("DEVOLUCION REGISTRADA");
                    recargar();
                    txtcedula.Clear();
                    txtdireccion.Clear();
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
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE");
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
                txtdireccion.Text = info[3];
                label11.Text = data.getAdress(txtdireccion.Text);
            }

        }
    }
}
