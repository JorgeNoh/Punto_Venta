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
using Mi_Negocio.Forms;
using System.Configuration;
using Common.Cache;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace Mi_Negocio
{
    public partial class Venta : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
        public Venta()
        {
            InitializeComponent();
            LlenarCombo();
            Encabezados();
        }
        // Metodos//   


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AddDataBD()
        {
            foreach (ListViewItem item in lvproducts.Items)
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Registros (Producto, Cantidad, Total, Fecha) values ('" + item.SubItems[0].Text + "', '" + item.SubItems[1].Text + "', '" + item.SubItems[3].Text + "', '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);

                cmd.ExecuteNonQuery();

                SqlCommand commad = new SqlCommand("insert into RegistrosTotales (Producto, Cantidad, Total, Fecha) values ('" + item.SubItems[0].Text + "', '" + item.SubItems[1].Text + "', '" + item.SubItems[3].Text + "', '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')", con);

                commad.ExecuteNonQuery();

                SqlCommand com = new SqlCommand("UPDATE Productos SET Stock = Stock - '" + item.SubItems[1].Text + "' where Producto = '" + item.SubItems[0].Text + "'", con);

                com.ExecuteNonQuery();

                con.Close();
            }
        }
        public void Cobrar()
        {
            Cobrar frmCobrar = new Cobrar(txtTotal.Text);
            frmCobrar.ShowDialog();
        }
        public void sumar()
        {
            Double dblSuma = 0;
            foreach (ListViewItem item in lvproducts.Items)
            {
                item.SubItems.Add(lbre.Text);
                dblSuma += Convert.ToDouble(item.SubItems[3].Text);
            }
            txtTotal.Text = dblSuma.ToString();
        }
        public void clear()
        {
            txtcant.Text = "";
            txtreci.Text = "";
            cbproductos.Items.Clear();
        }
        public void multiplicar()
        {
            double lvmul = 0;
            foreach (ListViewItem items in lvproducts.Items)
            {
                lvmul = Convert.ToInt32(items.SubItems[1].Text) * Convert.ToDouble(items.SubItems[2].Text);
            }
            lbre.Text = lvmul.ToString();
        }
        public void LlenarCombo()
        {
            SqlCommand cmd = new SqlCommand("SELECT Producto FROM Productos", conexion);
            conexion.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                cbproductos.Items.Add(registro["Producto"].ToString());
            }
            conexion.Close();
        }
        //Cierre de metodos publicos//
        private void Btnadd_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            if (UserLoginCache.Puesto == "Empleado")
            {
                lblEnProducts.Enabled = false;
                btnRegistro.Enabled = false;
                btnDevolucion.Enabled = true;
                btnVentas.Enabled = false;
                sessions.Enabled = false;
            }
            if (UserLoginCache.Puesto == "Dueño")
            {
                lblEnProducts.Enabled = true;
                btnRegistro.Enabled = true;
                btnDevolucion.Enabled = true;
                btnVentas.Enabled = true;
                sessions.Enabled = true;
            }

            Int32 hora = DateTime.Now.Hour;
            if (hora > 6)
            {
                txtsaludo.Text = ("Buenos días,");
            }
            if (hora > 12)
            {
                txtsaludo.Text = ("Buenas Tardes,");
            }
            if (hora > 19)
            {
                txtsaludo.Text = ("Buenas Noches,");
            }
        }
        public void Encabezados()
        {
            //Encabezados del ListView
            lvproducts.View = View.Details;
            lvproducts.Columns.Add("Producto", 100, HorizontalAlignment.Left);
            lvproducts.Columns.Add("Cantidad", 100, HorizontalAlignment.Left);
            lvproducts.Columns.Add("Precio unitario", 100, HorizontalAlignment.Left);
            lvproducts.Columns.Add("Total", 75, HorizontalAlignment.Left);
        }
        private void Btnadd_Click_1(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Por favor ingrese un producto");
            }
            else
            {
                Cobrar();
                Cobrar existe = Application.OpenForms.OfType<Cobrar>().Where(pre => pre.Name == "frmName").SingleOrDefault<Cobrar>();
                if (existe != null)
                {
                }
                else
                {
                    clear();
                    AddDataBD();
                    lvproducts.Clear();
                    txtTotal.Text = "";
                    Encabezados();
                    LlenarCombo();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void btnagr_Click(object sender, EventArgs e)
        {
            if (cbproductos.Text == "" || txtcant.Text == "")
            {
                lbError.Text = "Por favor ingrese el producto y/o cantidad";
            }
            else
            {
                if((Convert.ToString(txtcant.Text)) == (Convert.ToString(lbstock.Text)))
                {
                    MessageBox.Show("La cantidad que ingreso es igual a los productos que tiene en stock, verifique");
                    ListViewItem item = new ListViewItem();
                    item = lvproducts.Items.Add(cbproductos.Text);
                    item.SubItems.Add(txtcant.Text);
                    item.SubItems.Add(txtreci.Text);
                    clear();
                    LlenarCombo();
                    multiplicar();
                    sumar();
                    lbError.Text = "";
                }
                else
                {
                    if ((Convert.ToInt32(txtcant.Text)) > (Convert.ToInt32(lbstock.Text)))
                    {
                        MessageBox.Show("No tiene suficientes articulos, verifique su stock");
                        clear();
                        LlenarCombo();
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        item = lvproducts.Items.Add(cbproductos.Text);
                        item.SubItems.Add(txtcant.Text);
                        item.SubItems.Add(txtreci.Text);
                        clear();
                        multiplicar();
                        sumar();

                        LlenarCombo();
                        lbError.Text = "";
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la apliación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
                Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_Click(object sender, EventArgs e)
        {
        }

        private void lvproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void lblEnProducts_Click(object sender, EventArgs e)
        {

        }

        private void cbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "Select Precio, Stock from Productos where Producto = ('" + cbproductos.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            while (registro.Read())
            {
                txtreci.Text = (registro["Precio"].ToString());
                lbstock.Text = (registro["Stock"].ToString());
            }
            conexion.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
            lvproducts.Clear();
            txtTotal.Text = "";
            Encabezados();
            LlenarCombo();
            lbError.Text = "";
        }

        private void lblCut_Click(object sender, EventArgs e)
        {

        }

        private void lblEnDelVen_Click(object sender, EventArgs e)
        {

        }
        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cbproductos.Text == "" || txtcant.Text == "")
                {
                    lbError.Text = "Por favor ingrese el producto y/o cantidad";
                }
                else if ((Convert.ToString(txtcant.Text)) == (Convert.ToString(lbstock.Text)))
                {
                    MessageBox.Show("La cantidad que ingreso es igual a los productos que tiene en stock, verifique");
                    ListViewItem item = new ListViewItem();
                    item = lvproducts.Items.Add(cbproductos.Text);
                    item.SubItems.Add(txtcant.Text);
                    item.SubItems.Add(txtreci.Text);
                    clear();
                    LlenarCombo();
                    multiplicar();
                    sumar();                    
                    lbError.Text = "";
                }
                else
                {
                    if ((Convert.ToInt32(txtcant.Text)) > (Convert.ToInt32(lbstock.Text)))
                    {
                        MessageBox.Show("No tiene suficientes articulos, verifique su stock");
                        clear();
                        LlenarCombo();
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        item = lvproducts.Items.Add(cbproductos.Text);
                        item.SubItems.Add(txtcant.Text);
                        item.SubItems.Add(txtreci.Text);
                        clear();
                        multiplicar();
                        sumar();

                        LlenarCombo();
                        lbError.Text = "";
                    }
                }
            }
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            if (txtcant.Text != "")
            {
                lbError.Text = "";
            }
        }

        private void cbproductos_TextChanged(object sender, EventArgs e)
        {
            if (cbproductos.Text != "")
            {
                lbError.Text = "";
            }
        }
        private void LoadData()
        {
            lblnombre.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            lbposition.Text = "Puesto: " + UserLoginCache.Puesto;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "¿Desea cerrar sesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
            DialogResult.Yes)
                this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "¿Desea cerrar sesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
                this.Close();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            RegistrarProductos productos = new RegistrarProductos();
            productos.ShowDialog();
            cbproductos.Items.Clear();//Borra los datos de la combobox
            RegistrarProductos existe = Application.OpenForms.OfType<RegistrarProductos>().Where(pre => pre.Name == "frmName").SingleOrDefault<RegistrarProductos>();
            if (existe != null)
            {
            }
            else
            {
                LlenarCombo();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Devolucion ajustes = new Devolucion();
            ajustes.ShowDialog();
        }

        private void cbproductos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                try
                {
                    cnx.Open();
                    string query = "Select Producto, Precio, Stock  from Productos where Folio = ('" + txtprod.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    while (dataReader.Read())
                    {
                        cbproductos.Text = (dataReader["Producto"].ToString());
                        txtreci.Text = (dataReader["Precio"].ToString());
                        lbstock.Text = (dataReader["Stock"].ToString());
                    }
                    txtprod.Text = "";
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " +ex);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Venta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Addsessions addsessions = new Addsessions();
            addsessions.ShowDialog();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Addsessions addsessions = new Addsessions();
            addsessions.ShowDialog();
        }

        private void lvproducts_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvproducts.Items)
            {
                item.Remove();
            }
        }

        private void lblEnProducts_Click_1(object sender, EventArgs e)
        {
            RegistrarProductos productos = new RegistrarProductos();
            this.Hide();
            productos.ShowDialog();
            cbproductos.Items.Clear();//Borra los datos de la combobox
            RegistrarProductos existe = Application.OpenForms.OfType<RegistrarProductos>().Where(pre => pre.Name == "frmName").SingleOrDefault<RegistrarProductos>();
            if (existe != null)
            {
            }
            else
            {
                LlenarCombo();
                this.Show();
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            RegistrosTotales reg = new RegistrosTotales();
            this.Hide();
            reg.ShowDialog();
            RegistrosTotales existe = Application.OpenForms.OfType<RegistrosTotales>().Where(pre => pre.Name == "frmName").SingleOrDefault<RegistrosTotales>();
            if (existe != null)
            {
            }
            else
            {
                this.Show();
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            Devolucion ajustes = new Devolucion();
            this.Hide();
            ajustes.ShowDialog();
            Devolucion existe = Application.OpenForms.OfType<Devolucion>().Where(pre => pre.Name == "frmName").SingleOrDefault<Devolucion>();
            if (existe != null)
            {
            }
            else
            {
                this.Show();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.ShowDialog();
            Registro existe = Application.OpenForms.OfType<Registro>().Where(pre => pre.Name == "frmName").SingleOrDefault<Registro>();
            if (existe != null)
            {
            }
            else
            {
                this.Show();
            }
        }

        private void btnadd_Click_2(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Por favor ingrese un producto");
            }
            else
            {
                Cobrar();
                Cobrar existe = Application.OpenForms.OfType<Cobrar>().Where(pre => pre.Name == "frmName").SingleOrDefault<Cobrar>();
                if (existe != null)
                {
                }
                else
                {
                    clear();
                    AddDataBD();
                    lvproducts.Clear();
                    txtTotal.Text = "";
                    Encabezados();
                    LlenarCombo();
                }
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            clear();
            lvproducts.Clear();
            txtTotal.Text = "";
            Encabezados();
            LlenarCombo();
            lbError.Text = "";           
        }

        private void btnagr_Click_1(object sender, EventArgs e)
        {
            if (cbproductos.Text == "" || txtcant.Text == "")
            {
                lbError.Text = "Por favor ingrese el producto y/o cantidad";
            }
            else
            {
                if ((Convert.ToString(txtcant.Text)) == (Convert.ToString(lbstock.Text)))
                {
                    MessageBox.Show("La cantidad que ingreso es igual a los productos que tiene en stock, verifique");
                    ListViewItem item = new ListViewItem();
                    item = lvproducts.Items.Add(cbproductos.Text);
                    item.SubItems.Add(txtcant.Text);
                    item.SubItems.Add(txtreci.Text);
                    clear();
                    LlenarCombo();
                    multiplicar();
                    sumar();
                    lbError.Text = "";
                }
                else
                {
                    if ((Convert.ToInt32(txtcant.Text)) > (Convert.ToInt32(lbstock.Text)))
                    {
                        MessageBox.Show("No tiene suficientes articulos, verifique su stock");
                        clear();
                        LlenarCombo();
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        item = lvproducts.Items.Add(cbproductos.Text);
                        item.SubItems.Add(txtcant.Text);
                        item.SubItems.Add(txtreci.Text);
                        clear();
                        multiplicar();
                        sumar();

                        LlenarCombo();
                        lbError.Text = "";
                    }
                }
            }
        }

        private void txtcant_KeyPress_1(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cbproductos.Text == "" || txtcant.Text == "")
                {
                    lbError.Text = "Por favor ingrese el producto y/o cantidad";
                }
                else if ((Convert.ToString(txtcant.Text)) == (Convert.ToString(lbstock.Text)))
                {
                    MessageBox.Show("La cantidad que ingreso es igual a los productos que tiene en stock, verifique");
                    ListViewItem item = new ListViewItem();
                    item = lvproducts.Items.Add(cbproductos.Text);
                    item.SubItems.Add(txtcant.Text);
                    item.SubItems.Add(txtreci.Text);
                    clear();
                    LlenarCombo();
                    multiplicar();
                    sumar();
                    lbError.Text = "";
                }
                else
                {
                    if ((Convert.ToInt32(txtcant.Text)) > (Convert.ToInt32(lbstock.Text)))
                    {
                        MessageBox.Show("No tiene suficientes articulos, verifique su stock");
                        clear();
                        LlenarCombo();
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        item = lvproducts.Items.Add(cbproductos.Text);
                        item.SubItems.Add(txtcant.Text);
                        item.SubItems.Add(txtreci.Text);
                        clear();
                        multiplicar();
                        sumar();

                        LlenarCombo();
                        lbError.Text = "";
                    }
                }
            }
        }

        private void cbproductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "Select Precio, Stock from Productos where Producto = ('" + cbproductos.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader registro = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            while (registro.Read())
            {
                txtreci.Text = (registro["Precio"].ToString());
                lbstock.Text = (registro["Stock"].ToString());
            }
            conexion.Close();
        }

        private void txtprod_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                try
                {
                    cnx.Open();
                    string query = "Select Producto, Precio, Stock  from Productos where Folio = ('" + txtprod.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    while (dataReader.Read())
                    {
                        cbproductos.Text = (dataReader["Producto"].ToString());
                        txtreci.Text = (dataReader["Precio"].ToString());
                        lbstock.Text = (dataReader["Stock"].ToString());
                    }
                    txtprod.Text = "";
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void lvproducts_DoubleClick_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lvproducts.SelectedItems)
            {
                lista.Remove();
                sumar();
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar?", "¿Desea cerrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
           DialogResult.Yes)
                Application.Exit();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
