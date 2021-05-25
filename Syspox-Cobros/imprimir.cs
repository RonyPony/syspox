using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syspox_Cobros
{
    class imprimir
    {

        data data = new data();
        string reportType = "";
        string currentCedula;

        private int fontcount;
        private int fontposition = 1;
        private float ypos = 1;
        private PrintPreviewDialog previewDlg = null;
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
        private void PrintLogo(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"tempData/QR.png");
            Point loc = new Point(50, 100);
            e.Graphics.DrawImage(img, loc);
        }
        private void PrintText(object o, PrintPageEventArgs e)
        {

            string finalString = "";
            Point loc = new Point(20, 50);
            switch (reportType)
            {

                case "allpayments":

                    DataTable tabla = data.getTableSP("SP_reportAllPayments");

                    foreach (DataRow item in tabla.Rows)
                    {

                        finalString += "CEDULA: " + item[0].ToString() + "\n";
                        finalString += "NOMBRE: " + item[1].ToString() + "\n";
                        finalString += "MES: " + item[2].ToString() + "\n";
                        finalString += "FECHA: " + item[3].ToString() + "\n";
                        finalString += "MONTO PAGADO: " + item[4].ToString() + "\n";
                        finalString += "TARIFA: " + item[5].ToString() + "\n";
                        finalString += "DIFERENCIA: " + item[6].ToString() + "\n";
                        finalString += "------------------------------------------\n";


                    }
                    break;
                case "allpaymentsbycustomer":
                    DataTable tabla2 = data.getTableSPwithAttribute("SP_reportAllPaymentsByCustomer", "cedula", currentCedula);
                    string n = "", c = "";

                    foreach (DataRow item in tabla2.Rows)
                    {
                        c = item[0].ToString();
                        n = item[1].ToString();
                        finalString += "MES: " + item[2].ToString() + "\n";
                        finalString += "FECHA: " + item[3].ToString() + "\n";
                        finalString += "MONTO PAGADO: " + item[4].ToString() + "\n";
                        finalString += "TARIFA: " + item[5].ToString() + "\n";
                        finalString += "DIFERENCIA: " + item[6].ToString() + "\n";
                        finalString += "------------------------------------------\n";
                    }
                    finalString += "NOMBRE: " + n;
                    finalString += "CEDULA: " + c;
                    break;
                default:
                    break;
            }
            e.Graphics.DrawString(finalString, new Font("Arial", 12), new SolidBrush(Color.Black), loc);
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ypos = 1;
            float pageheight = ev.MarginBounds.Height;
            //Create a Graphics object  
            Graphics g = ev.Graphics;
            //Get installed fonts  
            InstalledFontCollection ifc =
            new InstalledFontCollection();
            //Get font families  
            FontFamily[] ffs = ifc.Families;
            //Draw string on the paper  
            while (ypos + 60 < pageheight &&
            fontposition < ffs.GetLength(0))
            {
                //Get the font name   
                Font f =
                new Font(ffs[fontposition].GetName(0), 25);
                //Draw string  
                g.DrawString(ffs[fontposition].GetName(0), f,
                new SolidBrush(Color.Black), 1, ypos);
                fontposition = fontposition + 1;
                ypos = ypos + 60;
            }
            if (fontposition < ffs.GetLength(0))
            {
                //Has more pages??  
                ev.HasMorePages = true;
            }
        }
        public void todosLosPagos()
        {
            try
            {
                //PrintDocument pd = new PrintDocument();
                //pd.PrintPage += PrintText;
                //pd.Print();
                PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                //Create a PrintDocument object  
                PrintDocument pd = new PrintDocument();
                //Add print-page event handler  
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                //Set Document property of PrintPreviewDialog  
                previewDlg.Document = pd;
                //Display dialog  
                previewDlg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //File.Delete("QR" + id + ".png");
            }
        }

        public void todosLosPagosPorCliente(string cedula)
        {
            try
            {
                //Bitmap qrCodeImage = qrCode.GetGraphic(5);
                //qrCodeImage.Save("tempData/QR" + gui.ToString() + ".png", ImageFormat.Png); // ImageFormat.Jpeg, etc
                //qrCodeImage.Dispose();
                PrintDocument pd = new PrintDocument();
                reportType = "allpaymentsbycustomer";
                currentCedula = cedula;
                //pd.PrintPage += PrintLogo;
                pd.PrintPage += PrintTextFile;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //File.Delete("QR" + id + ".png");
            }
        }

        private void PrintTextFile(object o, PrintPageEventArgs e)
        {
            DataTable tabla = data.getTableSP("SP_reportAllPayments");
            StreamWriter sw = new StreamWriter("report.txt");
            Point loc = new Point(20, 50);
            foreach (DataRow item in tabla.Rows)
            {

                sw.WriteLine("CEDULA: " + item[0].ToString() + "\n");
                sw.WriteLine("NOMBRE: " + item[1].ToString() + "\n");
                sw.WriteLine("MES: " + item[2].ToString() + "\n");
                sw.WriteLine("FECHA: " + item[3].ToString() + "\n");
                sw.WriteLine("MONTO PAGADO: " + item[4].ToString() + "\n");
                sw.WriteLine("TARIFA: " + item[5].ToString() + "\n");
                sw.WriteLine("DIFERENCIA: " + item[6].ToString() + "\n");
                sw.WriteLine("------------------------------------------\n");


            }
            sw.Close();
            sw.Dispose();
            e.Graphics.DrawString(File.ReadAllText("report.txt"), new Font("Arial", 12), new SolidBrush(Color.Black), loc);
        }

        public void caboom(string thetext)
        {
            try
            {

                System.Drawing.Printing.PrintDocument p = new System.Drawing.Printing.PrintDocument();

                var font = new Font("Times New Roman", 12);
                var brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

                // what still needs to be printed
                var remainingText = thetext;

                p.PrintPage += delegate (object sender1, System.Drawing.Printing.PrintPageEventArgs e1)
                {
                    int charsFitted, linesFilled;

                    // measure how many characters will fit of the remaining text

                    var realsize = e1.Graphics.MeasureString(
                            remainingText,
                            font,
                            e1.MarginBounds.Size,
                            System.Drawing.StringFormat.GenericDefault,
                            out charsFitted,  // this will return what we need
                            out linesFilled);

                    // take from the remainingText what we're going to print on this page
                    var fitsOnPage = remainingText.Substring(0, charsFitted);
                    // keep what is not printed on this page 
                    remainingText = remainingText.Substring(charsFitted).Trim();

                    // print what fits on the page
                    e1.Graphics.DrawString(
                            fitsOnPage,
                            font,
                            brush,
                            //e1.MarginBounds);
                            new RectangleF(0, 50, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

                    // if there is still text left, tell the PrintDocument it needs to call 
                    // PrintPage again.
                    e1.HasMorePages = remainingText.Length > 0;
                };
                PrinterSettings ps = new PrinterSettings();
                p.DefaultPageSettings.PaperSize = new PaperSize("kol", 800, 550);

                //PrintPreviewDialog ppvw = new PrintPreviewDialog();
                //ppvw.Document = p;
                //ppvw.ShowDialog();


                System.Windows.Forms.PrintDialog pd = new System.Windows.Forms.PrintDialog();
                pd.Document = p;
                DialogResult result = pd.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    p.Print();
                }


            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Unable to print", (MessageBoxButtons)System.Windows.MessageBoxButton.OK);
            }
        }
        public void printPayment(string Cedulacliente, string paid,string fechaa)
        {
            string businessName = "recibo de pago numero - ".ToUpper()+getID();
            string footercustom = "este mensaje es customizable";
            string mes, fecha, nombre, id,direccion;
            string a = data.moneyFormat(paid);
            id = data.getCustomerId(Cedulacliente);
            mes = data.getSingleField("mes", "pagos", "idCliente=" + id + " order by fecha desc");
            fecha = fechaa;
            nombre = data.getSingleField("nombre", "clientes", "id=" + id);
            string addressId = data.getSingleField("addressId", "clientes", "id=" + id);
            direccion = data.getAdress(addressId);
            string company = StringLimit(businessName, 32, true);
            string linea2 = "Factura numero " + StringLimit(Guid.NewGuid().ToString(), 5, false);
            string receiptString = "==================================\n" +
                                    company + "\n" +
                                   "==================================\n" +
                                   "                                  \n" +
                                   "----------------------------------\n" +
                                   "CONCEPTO                  PRECIO\n" +
                                   "----------------------------------\n" +
                                   "PAGO DE ALQUILER   " + a + "\n" +
                                   "----------------------------------\n" +
                                   "\n" +
                                   "FECHA DEL PAGO:                   \n" +
                                   "    " + fecha + "\n" +
                                   "\n" +
                                   "MES:                              \n" +
                                   "    " + mes + "\n" +
                                   "\n" +
                                   "A NOMBRE DE:                      \n" +
                                   "    " + nombre + "\n" +
                                   "\n" +
                                   "INMUEBLE:                         \n" +
                                   "                                  \n" +
                                   "" + autoalign(direccion, 25) +
                                   "\n" +
                                   "\n" +
                                   "----------------------------------- \n" +
                                   "CALLE COLON NO. 82, ESQ,=. JOSE DEL \n" +
                                   "CARMEN RAMIREZ - TEL. OFIC.:\n" +
                                   "809.557.3269 - CEL.: 809.543.8135 \n" +
                                   "SAN JUAN DE LA MAGUANA, R.D \n" +
                                   "OFICINAMATEO@HOTMAIL.COM";


            string footer = "----------------------------------\n" +
                                   "Total                   10000     \n";

            string customFooter = "----------------------------------\n " +
                                  "Le atendió: \n \n \n" + footercustom;

            

            
            try
            {
                PrintDocument p = new PrintDocument();
                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString(StringLimit(Syspox_Cobros.Properties.Settings.Default.paymentPrintTitle.ToUpper(), 19, false), new Font("Arial", 15), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

                };
                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString(receiptString, new Font("OCR A Extended", 10), new SolidBrush(Color.Black), new RectangleF(0, 50, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                    //e1.Graphics.DrawString(receiptString, new Font("Arial", 10), new SolidBrush(Color.Black), new RectangleF(0, 50, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

                };

                if (Syspox_Cobros.Properties.Settings.Default.paymentPrints)
                {
                    for (int i = 0; i < Syspox_Cobros.Properties.Settings.Default.paymentPrintsQty; i++)
                    {
                        System.Windows.Forms.PrintDialog pd = new System.Windows.Forms.PrintDialog();
                        pd.Document = p;
                        DialogResult result = pd.ShowDialog();

                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            p.Print();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }

        private string getID()
        {
            string id = data.getSingleField("id", "pagos", "1=1 order by id desc");
            return id;
        }

        private string autoalign(string direccion,int characterPerLine)
        {
            string final = "";
            int i=0;
            foreach (char item in direccion)
            {
                if (i==characterPerLine)
                {
                    final += item;
                    final += "\n";
                    i = 0;
                }
                else
                {
                    i++;
                    final += item;
                }
            }
            return final;
        }
    }
}
