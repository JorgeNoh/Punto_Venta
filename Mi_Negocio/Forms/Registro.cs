using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Mi_Negocio.Forms
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            ObtenerDatos();
        }
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Registro_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
        private void ObtenerDatos()
        {
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand("Select * from Registros where Fecha = ('" + date1.Value.ToString("MM/dd/yyyy") + "')", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            datgrd.DataSource = tabla;
            conexion.Close();
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * from Registros where Fecha = ('"+ date1.Value.ToString("MM/dd/yyyy") + "')", conexion);
            adp.SelectCommand = cmd;
            DataTable table = new DataTable();
            adp.Fill(table);
            datgrd.DataSource = table;
            conexion.Close();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach(DataGridViewRow row in datgrd.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }
            Tbre.Text = Convert.ToString(total);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Hide();
            reportes.ShowDialog();
            Reportes existe = Application.OpenForms.OfType<Reportes>().Where(pre => pre.Name == "frmName").SingleOrDefault<Reportes>();
            if (existe != null)
            {
            }
            else
            {
                this.Show();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
