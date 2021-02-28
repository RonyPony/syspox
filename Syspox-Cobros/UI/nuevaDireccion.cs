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
    public partial class nuevaDireccion : UI.BASEFORM
    {
        public nuevaDireccion()
        {
            InitializeComponent();
        }

        private void nuevaDireccion_Load(object sender, EventArgs e)
        {
            this.titulo = "nueva direccion";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
                data data = new data();
                if (data.save("direcciones", "nombre,calle,numero,manzana,sector,municipio,monto,comentarios", "'" + txtnombre.Text + "','" + txtcalle.Text + "','" + txtnumero.Text + "','" + txtmanzana.Text + "','" + txtsector.Text + "','" + txtmunicipio.Text + "','" + txtmonto.Text + "','" + txtcomentarios.Text + "'"))
                {
                    MessageBox.Show("Direccion Registrado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar la direccion.");
                }
           
        }
    }
}
