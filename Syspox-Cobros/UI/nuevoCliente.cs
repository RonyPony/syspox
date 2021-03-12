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
        data data = new data();
        int id = 0;
        public nuevoCliente(int idh = 0)
        {
            InitializeComponent();
            if (idh!=0)
            {
                id = idh;
                cargar(idh);
                boton4.Visible = true;
            }
        }

        private void cargar(int id)
        {
            txtcedula.Text = data.getSingleField("cedula","clientes","id='"+id+"'");
            txtnombre.Text = data.getSingleField("nombre","clientes","id='"+id+"'");
            txttel.Text = data.getSingleField("telefono","clientes","id='"+id+"'");
            txtcelular.Text = data.getSingleField("celular","clientes","id='"+id+"'");
            txtdireccion.Text = data.getSingleField("addressid", "clientes", "id='" + id + "'");
            txtcomentario.Text = data.getSingleField("comentario","clientes","id='"+id+"'");
            lbldireccion.Text = data.getAdress(txtdireccion.Text);
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
                if (id == 0)
                {
                    data data = new data();
                    if (data.save("clientes", "cedula,nombre,addressid,telefono,celular,comentario", "'" + txtcedula.Text + "','" + txtnombre.Text + "','" + txtdireccion.Text + "','" + txttel.Text + "','" + txtcelular.Text + "','" + txtcomentario.Text + "'"))
                    {
                        MessageBox.Show("Cliente Registrado");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar el cliente.");
                    }
                }
                else
                {
                    data data = new data();
                    if (data.update("clientes", "cedula = '"+txtcedula.Text+"',nombre='"+txtnombre.Text+"',addressid='"+txtdireccion.Text+"',telefono='"+txttel.Text+"',celular='"+txtcelular.Text+"',comentario='"+txtcomentario.Text+"'","id="+id))
                    {
                        MessageBox.Show("Cliente Actualizado");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar el cliente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Cedula y nombre son obligatorios");
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            selector gg = new selector("direcciones");
            gg.ShowDialog();
            if (gg.row.Cells.Count > 0)
            {
                txtdireccion.Text = gg.row.Cells[0].Value.ToString();
            }
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            lbldireccion.Text = data.getAdress(txtdireccion.Text);
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.delete("clientes", "id=" + id))
                {
                    MessageBox.Show("CLIENTE ELIMINADO");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
