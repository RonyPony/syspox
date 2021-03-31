using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syspox_Cobros.UI
{
    public partial class nuevopago : UI.BASEFORM
    {
        data data = new data();
        int pagoEsperado;
        int id = 0;
        imprimir imprimir = new imprimir();
        public nuevopago()
        {
            InitializeComponent();
        }
        private void cargar(int id)
        {
            txtcedula.Text = data.getSingleField("cedula", "clientes", "id='" + id + "'");
            txtnombre.Text = "modificado";
            //txttel.Text = data.getSingleField("telefono", "clientes", "id='" + id + "'");
            //txtcelular.Text = data.getSingleField("celular", "clientes", "id='" + id + "'");
            //txtdireccion.Text = data.getSingleField("addressid", "clientes", "id='" + id + "'");
            //txtcomentario.Text = data.getSingleField("comentario", "clientes", "id='" + id + "'");
            //lbldireccion.Text = data.getAdress(txtdireccion.Text);
        }

        private void nuevopago_Load(object sender, EventArgs e)
        {
            
            this.titulo = "nuevo pago";
            DataTable table = data.getTable("meses", string.Empty);
            txtmes.DataSource = table;
            txtmes.DisplayMember = "name";
            txtmes.Text = "";
        }


        private void boton1_Click(object sender, EventArgs e)
        {

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            selector select = new selector("direcciones");

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            lbldireccion.Text = data.getAdress(txtdireccion.Text);
        }

        private void boton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id, mes, monto, fecha, valores;
                id = "'" + data.getCustomerId(txtcedula.Text) + "'";
                mes = "'" + txtmes.Text + "'";
                monto = "'" + txtmonto.Text + "'";
                fecha = "'" + txtfecha.Value.ToString() + "'";
                valores = id + "," + mes + "," + monto + "," + fecha;
                if (validateMonth(mes,id))
                {
                    if (data.save("pagos", "idCliente,mes,monto,fecha", valores))
                    {
                        MessageBox.Show("Pago hecho con exito");
                        imprimir.printPayment(txtcedula.Text, txtmonto.Text,txtfecha.Value.ToString());
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validateMonth(string mes,string user)
        {
            try
            {
                data data = new data();
                DataTable tableAll= data.getTable("pagos","idCliente="+user);
                List<String> meses = new List<string>();
                List<String> rawdates = new List<string>();
                foreach (DataRow ddfrs in tableAll.Rows)
                {
                    DateTime ggo = Convert.ToDateTime(ddfrs[4].ToString().ToUpper());
                    meses.Add(ddfrs[2].ToString().Replace(" ","").ToLower()+"-"+ggo.Year.ToString());
                }
                string pal = mes.Replace(" ", "").Replace("'","").ToLower() +"-"+ (txtfecha.Value.Year.ToString());
                if (meses.Contains(pal))
                {
                    MessageBox.Show("ESTE CLIENTE YA HA PAGADO EL MES DE " + pal.Replace("-"," del año ").ToUpper());
                    return false;
                }
                else
                {
                    return true;
                }
                
                //m = mes.Replace(" ","").ToLower();
                //l = last.Replace(" ", "").ToLower();
                //if (m == l && fec.Year == DateTime.Now.Year)
                //{
                //    MessageBox.Show("ESTE CLIENTE YA HA PAGADO EL MES DE "+m.ToLowerInvariant());
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            getInfo();
        }

        private void getInfo()
        {
            List<string> info = data.getClienteInfo(data.getCustomerId(txtcedula.Text));
            if (info.Count <= 0)
            {

            }
            else
            {
                txtnombre.Text = info[2];
                txtdireccion.Text = info[3];
                getLastPayment();
                lblmonto.Text = "Restante RD$:"+data.getAdressMonto(txtdireccion.Text);
                pagoEsperado = Convert.ToInt32(data.getAdressMonto(txtdireccion.Text));
                lbldireccion.Text = data.getAdress(txtdireccion.Text);
                txtfechadepago.Text ="A este cliente le corresponde pagar el "+ data.getSingleField("diaDePago", "clientes", "cedula='" + txtcedula.Text + "'") +" de "+ data.getSingleField("mesDePago", "clientes", "cedula='" + txtcedula.Text + "'");
            }
            
        }

        private void getLastPayment()
        {
            string mes, monto,id;
            id = data.getCustomerId(txtcedula.Text);
            mes = data.getSingleField("mes","pagos","idCliente="+id+ " order by fecha desc");
            monto = data.getSingleField("monto","pagos","idCliente="+id+ " order by fecha desc");
            if (mes!=null)
            {
                txtultimomonto.Text = "Ultimo pago recibido fue del mes de " + mes + " por un monto de " + monto;
                txtmes.Text = mes;
                txtmes.DroppedDown = true;
            }
            else
            {
                txtultimomonto.Text = "Este cliente no ha hecho pagos todavia.";
            }
            
        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtmonto.Text != string.Empty)
                {
                    lblmonto.Text = "Restante RD$:" + (pagoEsperado - Convert.ToInt32(txtmonto.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void boton10_Click(object sender, EventArgs e)
        {
            selector select = new selector("clientes");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                txtcedula.Text = select.row.Cells[1].Value.ToString();
            }
            
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



