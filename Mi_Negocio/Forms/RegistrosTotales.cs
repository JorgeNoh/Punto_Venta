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
    public partial class RegistrosTotales : Form
    {
        public RegistrosTotales()
        {
            InitializeComponent();
            ObtenerDatos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void RegistrosTotales_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
        private void ObtenerDatos()
        {
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand("Select * from Registros where Fecha = ('" + date1.Value.ToString("MM/dd/yyyy") + "')", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            datagr.DataSource = tabla;
            conexion.Close();
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * from Registros where Fecha = ('" + date1.Value.ToString("MM/dd/yyyy") + "')", conexion);
            adp.SelectCommand = cmd;
            DataTable table = new DataTable();
            adp.Fill(table);
            datagr.DataSource = table;
            conexion.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void RegistrosTotales_MouseDown(object sender, MouseEventArgs e)
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
