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
            string cols = "REPORTE DE PAGOS DE UN CLIENTE \n ----------------------------------------- \n" + "|CEDULA|NOMBRE|MES|FECHA|PAGADO|TARIFA|DIFERENCIA|".Replace("|","\n")+"============================= \n";
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
            string cols = "REPORTE DE PAGOS DE UN MES \n ----------------------------------------- \n" + "|NOMBRE|CEDULA|FECHA|PAGADO|TARIFA|DIFERENCIA|TELEFONO|CELULAR|".Replace("|", "\n") + "============================= \n";
            res = cols + string.Join(Environment.NewLine + "--------------------------------" + Environment.NewLine, bycus.Rows.OfType<DataRow>().Select(x => string.Join("\n", x.ItemArray)));
            if (bycus.Rows.Count <= 0)
            {
                res += "NO HAY DATOS";
            }
            print.caboom(res);
        }
    }
}
