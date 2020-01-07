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
using Common.Cache;

namespace Mi_Negocio.Forms
{
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
            ObtenerDatos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
        private void ObtenerDatos()
        {
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand("Select * from Registros", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            datagr.DataSource = tabla;
            conexion.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {       
        }

        private void btnadd_Click(object sender, EventArgs e)            
        {
            int cant, txtcant;

            cant = int.Parse(cantidad.Text);
            txtcant = int.Parse(txcant.Text);


            if (cant == txtcant)
            {
                string contra;

                contra = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña", "Devolución", "", 100, 0);

                if (contra == UserLoginCache.Nombre)
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Productos SET Stock = Stock + '" + cantidad.Text + "' where Producto = '" + txtno.Text + "'", con);
                    SqlDataReader read;
                    SqlDataReader reader;
                    SqlCommand cmnd = new SqlCommand("DELETE FROM Registros WHERE Id = '" + txId.Text + "'", con);
                    read = cmd.ExecuteReader();
                    read.Close();
                    reader = cmnd.ExecuteReader();
                    MessageBox.Show("Se devolvio el producto");
                    con.Close();
                    txtno.Text = "";
                    txId.Text = "";
                    txcant.Text = "";
                    cantidad.Text = "";
                    ObtenerDatos();
                }
                else
                {
                    MessageBox.Show("La contraseña que ingresó es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (cant < txtcant)
            {
                string contra;

                contra = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña", "Devolución", "", 100, 0);

                if (contra == UserLoginCache.Nombre)
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Productos SET Stock = Stock + '" + cantidad.Text + "' where Producto = '" + txtno.Text + "'", con);
                    SqlDataReader read;
                    SqlDataReader reader;
                    SqlCommand cmnd = new SqlCommand("UPDATE Registros SET Cantidad = Cantidad - '" + cantidad.Text + "' where Producto = '" + txtno.Text + "'", con);

                    double totalfinal = Convert.ToDouble(cantidad.Text) * Convert.ToDouble(price.Text);

                    SqlCommand sqlcom = new SqlCommand("UPDATE Registros SET Total = Total - '"+ totalfinal +"' where Producto = '" + txtno.Text + "'", con);
                    SqlDataReader leer;
                    read = cmd.ExecuteReader();
                    read.Close();
                    reader = cmnd.ExecuteReader();
                    reader.Close();
                    leer = sqlcom.ExecuteReader();
                    MessageBox.Show("Se devolvio el producto");
                    con.Close();
                    txtno.Text = "";
                    txId.Text = "";
                    txcant.Text = "";
                    cantidad.Text = "";
                    ObtenerDatos();
                }
                else
                {
                    MessageBox.Show("La contraseña que ingresó es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }

        private void datagr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conexion.Open();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagr.Rows[e.RowIndex];
                txId.Text = row.Cells["Id"].Value.ToString();
                txtno.Text = row.Cells["Producto"].Value.ToString();
                txcant.Text = row.Cells["Cantidad"].Value.ToString();                
            }
            
            SqlCommand comando = new SqlCommand("SELECT Precio from Productos where Producto = '" + txtno.Text + "'", conexion);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            while (leer.Read() == true)
            {
                price.Text = leer[0].ToString();

            }
            conexion.Close();
        }

        private void Devolucion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
