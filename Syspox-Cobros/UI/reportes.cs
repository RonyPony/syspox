using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Syspox_Cobros.UI
{
    public partial class reportes : UI.BASEFORM
    {
        imprimir print = new imprimir();
        data data = new data();
        public reportes()
        {
            InitializeComponent();
        }

        private void reportes_Load(object sender, EventArgs e)
        {
            this.titulo = "REPORTES";
            DataTable table = data.getTable("meses", string.Empty);
            txtmes.DataSource = table;
            txtmes.DisplayMember = "name";
            txtmes.Text = "";

            txtmes2.DataSource = table;
            txtmes2.DisplayMember = "name";
            txtmes2.Text = "";

            txtmesnotpaid.DataSource = table;
            txtmesnotpaid.DisplayMember = "name";
            txtmesnotpaid.Text = "";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //print.todosLosPagos();
            //[SP_getPagos]
            DataTable pagos = data.getTableSP("SP_getPagos");
            string res;
            String cols = "REPORTE DE TODOS LOS PAGOS \n ----------------------------------------" + "|NOMBRE|MES|PAGADO|TARIFA|DIFERENCIA|FECHA|".Replace("|", "\n") + "============================= \n";
            res = cols+string.Join(Environment.NewLine+"-----------------------------------------"+Environment.NewLine, pagos.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            print.caboom(res);
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            //print.todosLosPagosPorCliente(txtpagoscedula.Text);
            DataTable bycus = data.getTableCustomQuery("exec SP_reportAllPaymentsByCustomer '"+txtpagoscedula.Text+"'");
            string res;
            string cols = "REPORTE DE PAGOS DEL CLIENTE "+data.getClienteNombre(data.getCustomerId(txtpagoscedula.Text))+" ("+txtpagoscedula.Text+")\n ----------------------------------------- \n" + "|CEDULA|NOMBRE|MES|FECHA|PAGADO|TARIFA|DIFERENCIA|".Replace("|","\n")+"============================= \n";
            res = cols+string.Join(Environment.NewLine + "--------------------------------" + Environment.NewLine, bycus.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            if (bycus.Rows.Count<=0)
            {
                res += "NO HAY DATOS";
            }
            print.caboom(res);
        }

        private void boton3_Click(object sender, EventArgs e)
        {            
            DataTable clientes = data.getTableSP("SP_getClientes");
            string res = string.Join(Environment.NewLine + "--------------------------------" + Environment.NewLine, clientes.Rows.OfType<DataRow>().Select(x => string.Join(" \n ", x.ItemArray)));
            print.caboom(res);
        }

        private void txtpagoscedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton10_Click(object sender, EventArgs e)
        {
            selector select = new selector("clientes");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                txtpagoscedula.Text = select.row.Cells[1].Value.ToString();
            }

        }

        private void boton4_Click(object sender, EventArgs e)
        {
            DataTable bycus = data.getTableCustomQuery("exec SP_reportAllPaymentsByMonth'" + txtmes.Text + "'");
            string res;
            string cols = "REPORTE DE PAGOS DEL MES DE "+txtmes.Text+" \n ----------------------------------------- \n" + "|NOMBRE|CEDULA|FECHA|PAGADO|TARIFA|DIFERENCIA|TELEFONO|CELULAR|".Replace("|", "\n") + "============================= \n";
            res = cols + string.Join(Environment.NewLine + "--------------------------------" + Environment.NewLine, bycus.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            if (bycus.Rows.Count <= 0)
            {
                res += "NO HAY DATOS";
            }
            print.caboom(res);
        }

        private void boton11_Click(object sender, EventArgs e)
        {
            selector select = new selector("clientes");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                cedulaespecificpayment.Text = select.row.Cells[1].Value.ToString();
            }
        }

        private void boton12_Click(object sender, EventArgs e)
        {
            selector select = new selector("clientes");
            select.ShowDialog();
            if (select.row.Cells.Count > 0)
            {
                ceduladev.Text = select.row.Cells[1].Value.ToString();
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            DataTable bycus = data.getTableCustomQuery("exec SP_reportSpecificPayment '" + cedulaespecificpayment.Text + "','"+txtmes2.Text.Replace(" ","")+"'");
            string res;
            string cols = "REPORTE DE PAGO DEL MES DE " + txtmes2.Text.ToUpper() + " \n ----------------------------------------- \n" + "|NOMBRE|CEDULA|FECHA|PAGADO|TARIFA|DIFERENCIA|TELEFONO|CELULAR|".Replace("|", "\n") + "============================= \n";
            res = cols + string.Join(Environment.NewLine + "--------------------------------" + Environment.NewLine, bycus.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            if (bycus.Rows.Count <= 0)
            {
                res += "NO HAY DATOS";
            }
            print.caboom(res);
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            DataTable pagos = data.getTableSP("SP_getAllAdresses");
            string res;
            String cols = "REPORTE DE TODAS LAS DIRECCIONES \n ----------------------------------------" + "|NOMBRE|UBICACION|TARIFA|INQUILINO|CEDULA DEL INQUILINO|CONTACTO|COMENTARIOS|".Replace("|", "\n") + "============================= \n";
            res = cols + string.Join(Environment.NewLine + "-----------------------------------------" + Environment.NewLine, pagos.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            print.caboom(res);
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            DataTable pagos = data.getTableSP("SP_reportAllDev");
            string res;
            String cols = "REPORTE DE TODAS LAS DEVOLUCIONES \n ----------------------------------------" + "|PERSONA|CEDULA|DESCRIPCION|MONTO|FECHA|".Replace("|", "\n") + "============================= \n";
            res = cols + string.Join(Environment.NewLine + "-----------------------------------------" + Environment.NewLine, pagos.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            print.caboom(res);
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            DataTable bycus = data.getTableCustomQuery("exec SP_reportDevByCed'" + ceduladev.Text + "'");
            string res;
            string cols = "REPORTE DE DEVOLUCION " + txtmes.Text + " \n ----------------------------------------- \n" + "|PERSONA|CEDULA|DESCRIPCION|MONTO|FECHA|".Replace("|", "\n") + "============================= \n";
            res = cols + string.Join(Environment.NewLine + "--------------------------------" + Environment.NewLine, bycus.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            if (bycus.Rows.Count <= 0)
            {
                res += "NO HAY DATOS";
            }
            print.caboom(res);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void boton13_Click(object sender, EventArgs e)
        {
            DataTable bycus = data.getTableCustomQuery("exec SP_reportMissingPaymentsByMonth'" + txtmesnotpaid.Text.Replace(" ","")+" - "+txtYear.Text + "'");
            string res;
            string cols = "REPORTE DE CLIENTES QUE NO HAN \n PAGADO EL MES DE "+ txtmesnotpaid.Text.Replace(" ", "").ToUpper()+ " \n ----------------------------------------- \n" + "|PERSONA|CEDULA|TELEFONO|CELULAR|DIA DE PAGO|".Replace("|", "\n") + "============================= \n";
            res = cols + string.Join(Environment.NewLine + "--------------------------------" + Environment.NewLine, bycus.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            if (bycus.Rows.Count <= 0)
            {
                res += "NO HAY DATOS";
            }
            print.caboom(res);
        }
    }
}
