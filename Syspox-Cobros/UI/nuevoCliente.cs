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
    public partial class nuevoCliente : UI.BASEFORM
    {
        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void nuevoCliente_Load(object sender, EventArgs e)
        {
            this.titulo = "nuevo cliente";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (txtcedula.Text !="" && txtnombre.Text !="")
            {
                data data = new data();
                if (data.save("clientes", "cedula,nombre,addressid,telefono,celular,comentario", "'" + txtcedula.Text + "','" + txtnombre.Text + "','" + txtdireccion.Text + "','" + txttel.Text + "','" + txtcelular.Text + "','" + txtcomentario.Text + "'"))
                {
                    MessageBox.Show("Cliente Registrado");
                    this.Close();
                }else{
                    MessageBox.Show("No se ha podido registrar el cliente.");
                }
            }
            else
            {
                MessageBox.Show("Cedula y nombre son obligatorios");
            }
        }
    }
}
