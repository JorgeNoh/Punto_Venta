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
    public partial class RegistrarProductos : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader read;
        public RegistrarProductos()
        {
            InitializeComponent();
            ObtenerDatos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void ObtenerDatos()
        {
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand("Select * from Productos", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgpro.DataSource = tabla;
            conexion.Close();
        }
        private void Clear()
        {
            txtprod.Text = "";
            txtprec.Text = "";
            txtstock.Text = "";
            txtfolio.Text = "";            
        }
        private void CampoRequerido()
        {
            if(txtprec.Text == "")
            {
                Error.SetError(txtprec, "Campo requerido");
            }
            else
            {
                Error.SetError(txtprec, "");
            }
            if (txtprod.Text == "")
            {
                Error.SetError(txtprod, "Campo requerido");
            }
            else
            {
                Error.SetError(txtprod, "");
            }
            if (txtstock.Text == "")
            {
                Error.SetError(txtstock, "Campo requerido");
            }
            else
            {
                Error.SetError(txtstock, "");
            }
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (txtfolio.Text == "")
            {
                CampoRequerido();
                if (!Validar(txtprod.Text) || !Validar(txtprec.Text) || !Validar(txtstock.Text))
                {
                    MessageBox.Show("Rellene los campos faltantes");
                }
                /*si no entonces el codigo ingresara los datos*/
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Productos (Producto, Precio, Stock) VALUES ('" + txtprod.Text + "','" + txtprec.Text + "','" + txtstock.Text + "')", con);
                    read = cmd.ExecuteReader();
                    MessageBox.Show("Se registró el producto satisfactoriamente");
                    ObtenerDatos();
                    Clear();
                    con.Close();
                }
            }else
            {
                MessageBox.Show("No se puede agregar un producto ya existente");
                Clear();
            }        
        }

        private void BtCan_Click(object sender, EventArgs e)
        {
            txtfolio.Text = "";
            txtprec.Text = "";
            txtprod.Text = "";
            txtstock.Text = "";
            txtfolio.Enabled = true;
        }
        private bool Validar(string dato)
        {
            if (dato != "")
                return true;

            else
                return false;
        }

        private void RegistrarProductos_Load(object sender, EventArgs e)
        {
        }

        private void BtUp_Click(object sender, EventArgs e)
        {
            CampoRequerido();
            if (!Validar(txtfolio.Text) || !Validar(txtprod.Text) && !Validar(txtprec.Text) && !Validar(txtstock.Text))
            {
                MessageBox.Show("Rellene los campos faltantes");
            }
            /*si no entonces el codigo ingresara los datos*/
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("UPDATE Productos SET Producto = '" + txtprod.Text + "', Precio = '" + txtprec.Text + "' , Stock = '" + txtstock.Text + "' WHERE Folio = '" + txtfolio.Text + "'", con);
                read = cmd.ExecuteReader();
                MessageBox.Show("Se modifico el producto satisfactoriamente");
                ObtenerDatos();
                Clear();
                con.Close();
                txtfolio.Enabled = true;
            }
        }

        private void BtDel_Click(object sender, EventArgs e)
        {
            if (txtfolio.Text == "")
            {
                MessageBox.Show("Rellene el campo Folio");
            }
            /*si no entonces el codigo ingresara los datos*/
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                con.Open();
                cmd = new SqlCommand("DELETE FROM Productos  WHERE Folio = '" + txtfolio.Text + "'", con);
                read = cmd.ExecuteReader();
                MessageBox.Show("Se ha eliminado el producto satisfactoriamente");
                ObtenerDatos();
                Clear();
                con.Close();
                txtfolio.Enabled = true;
            }
        }

        private void dtgpro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgpro.Rows[e.RowIndex];
                txtfolio.Text = row.Cells["Folio"].Value.ToString();
                txtprod.Text = row.Cells["Producto"].Value.ToString();
                txtprec.Text = row.Cells["Precio"].Value.ToString();
                txtstock.Text = row.Cells["Stock"].Value.ToString();
                txtfolio.Enabled = false;
            }
        }

        private void dtgpro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtprec_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtfolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void RegistrarProductos_MouseDown(object sender, MouseEventArgs e)
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
