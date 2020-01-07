using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Negocio.Forms
{
    public partial class Addsessions : Form
    {
        public Addsessions()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Clear()
        {
            txtpossi.Text = "";
            txtname.Text = "";
            txtlastname.Text = "";
            txtpwd.Text = "";
            txtuser.Text = "";
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" | txtpwd.Text == "" | txtpossi.Text == "" | txtname.Text == "" | txtlastname.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                    con.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO Users (LoginName, Pass, Nombre, Apellido, Puesto) VALUES ('" + txtuser.Text + "','" + txtpwd.Text + "','" + txtname.Text + "', '" + txtlastname.Text + "', '" + txtpossi.Text + "')", con);
                    SqlDataReader reader = com.ExecuteReader();
                    MessageBox.Show("Se registró al usuario satisfactoriamente");
                    txtpwd.UseSystemPasswordChar = true;
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    Clear();
                }
            }      
        }

        private void Addsessions_Load(object sender, EventArgs e)
        {
            txtpwd.UseSystemPasswordChar = true;
        }

        private void Addsessions_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
