using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Mi_Negocio
{
    public partial class Cobrar : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
        public Cobrar()
        {
            InitializeComponent();
        }
        public Cobrar(string text)
        {
            InitializeComponent();
            txtTotal.Text = String.Format("{0:c}", text);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Cobrar_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(txtEfectivo.Text)) < (Convert.ToDouble(txtTotal.Text)))
            {
                MessageBox.Show("El monto que ingreso es menor que el total");
            }
            else
            {
                MessageBox.Show("Venta exitosa");
                this.Close();               
            }
        }

        private void txtEfectivo_Leave(object sender, EventArgs e)
        {                
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if ((Convert.ToDouble(txtEfectivo.Text)) < (Convert.ToDouble(txtTotal.Text)))
                {
                    MessageBox.Show("El monto que ingreso es menor que el total");
                }
                else
                {
                    MessageBox.Show("Venta exitosa");
                    this.Close();
                }
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if(txtEfectivo.Text == "")
            {
                MessageBox.Show("Ingrese el monto recibido");
            }else
            {
                double tot, resl;
                double efect = 0;
                efect = Convert.ToDouble(txtEfectivo.Text);
                tot = Convert.ToDouble(txtTotal.Text);
                resl = efect - tot;
                txtCambio.Text = String.Format("{0:c}", resl);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se borraran los articulos ya añadidos", "¿Desea cerrar esta ventana?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Cobrar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
