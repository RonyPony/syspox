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
        int id = 0;
        data data = new data();
        public nuevaDireccion(int idh=0)
        {
            InitializeComponent();
            if (idh != 0)
            {
                id = idh;
                cargar(idh);
                boton3.Visible = true;
                boton1.Text = "ACTUALIZAR";
            }
        }

        private void cargar(int idh)
        {
            txtnombre.Text = data.getSingleField("nombre", "direcciones", "id='" + id + "'");
            txtcalle.Text = data.getSingleField("calle", "direcciones", "id='" + id + "'");
            txtnumero.Text = data.getSingleField("numero", "direcciones", "id='" + id + "'");
            txtmanzana.Text = data.getSingleField("manzana", "direcciones", "id='" + id + "'");
            txtsector.Text = data.getSingleField("sector", "direcciones", "id='" + id + "'");
            txtmunicipio.Text = data.getSingleField("municipio", "direcciones", "id='" + id + "'");
            txtmonto.Text = data.getSingleField("monto", "direcciones", "id='" + id + "'");
            txtcomentarios.Text = data.getSingleField("comentarios", "direcciones", "id='" + id + "'");
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
            if (id!=0)
            {
                if (data.update("direcciones", "nombre='"+txtnombre.Text+ "',calle='" + txtcalle.Text + "',numero='" + txtnumero.Text + "',manzana='" + txtmanzana.Text + "',sector='" + txtsector.Text + "',municipio='" + txtmunicipio.Text + "',monto='" + txtmonto.Text + "',comentarios='" + txtcomentarios.Text + "'", "id=" + id))
                {
                    MessageBox.Show("Direccion Actualizada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se ha podido actualizar la direccion.");
                }
            }
            else
            {
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

        private void boton4_Click(object sender, EventArgs e)
        {
            selector p = new selector("municipios");
            p.ShowDialog();
            if (p.row.Cells.Count > 0)
            {
                txtmunicipio.Text = p.row.Cells[1].Value.ToString().Replace("	", "");
            }
        }
    }
}
