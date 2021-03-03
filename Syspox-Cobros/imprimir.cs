using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syspox_Cobros
{
    class imprimir
    {

        data data = new data();
        public string StringLimit(string str, int limit, bool AlingLeft)
        {
            string Ans = string.Empty;


            if (str.Length < limit)
            {
                if (AlingLeft)
                {
                    Ans = str + multiSpace(limit - str.Length);
                }
                else
                {
                    Ans = multiSpace(limit - str.Length) + str;
                }
            }
            else if (str.Length > limit)
            {
                Ans = str.Substring(0, limit);
            }
            else if (str.Length == limit)
            {
                Ans = str;
            }
            return Ans;
        }
        private string multiSpace(int v)
        {
            string space = string.Empty;
            for (int i = 0; i < v; i++)
            {
                space += " ";
            }
            return space;
        }

        public void printPayment(string Cedulacliente,string paid)
        {
            string businessName = "Colegio de abogados jose manuel";
            string footercustom = "este mensaje es customizable";
            string company = StringLimit(businessName, 32, true);
            string linea2 = "Factura numero " + StringLimit(Guid.NewGuid().ToString(), 5, false);
            string receiptString = "==================================\n" +
                                   "|" + company + "|\n" +
                                   "==================================\n" +
                                   "Factura No." + StringLimit(Guid.NewGuid().ToString(), 32, true) + "\n" +
                                   "                                  \n" +
                                   "----------------------------------\n" +
                                   "Concepto                    Precio\n" +
                                   "----------------------------------\n"+
                                   Cedulacliente+" RD$: "+paid+
                                   "----------------------------------\n";

            string footer = "----------------------------------\n" +
                                   "Total                   10000     \n";

            string customFooter = "----------------------------------\n " +
                                  "Le atendió: \n \n \n" + footercustom;


            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                data.cerrar();
            }

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(receiptString, new Font("OCR A Extended", 10), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };
            try
            {
                if (true)
                {
                    p.Print();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
