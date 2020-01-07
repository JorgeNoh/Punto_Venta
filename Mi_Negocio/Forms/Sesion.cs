using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;

namespace Mi_Negocio.Forms
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO" && txtuser.TextLength > 2)
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        Yoaprendoamimanera welcome = new Yoaprendoamimanera();
                        welcome.ShowDialog();
                        Venta mainMenu = new Venta();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecta. \n Porfavor intentelo de nuevo.");
                        txtpass.UseSystemPasswordChar = false;
                        txtpass.Text = "CONTRASEÑA";
                        txtpass.ForeColor = Color.DimGray;
                        txtuser.ForeColor = Color.DimGray;
                        txtuser.Text = "USUARIO";
                    }
                }
            }
            else
            {
                msgError("Por favor ingresa tu nombre de usuario.");
                txtuser.Text = "USUARIO";
                txtpass.UseSystemPasswordChar = false;
                txtpass.Text = "CONTRASEÑA";
            }
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = ("" + msg);            
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text="CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";   
            lblErrorMessage.Visible = false;
            txtpass.ForeColor = Color.DimGray;
            txtuser.ForeColor = Color.DimGray;

            this.Show();
        }

        private void Sesion_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text=="USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar?", "¿Desea cerrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
            DialogResult.Yes)
            this.Close();
        }

        private void Sesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.yoaprendoamimanera.com");
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtuser.Text != "USUARIO" && txtuser.TextLength > 2)
                {
                    if (txtpass.Text != "CONTRASEÑA")
                    {
                        UserModel user = new UserModel();
                        var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                        if (validLogin == true)
                        {
                            this.Hide();
                            Yoaprendoamimanera welcome = new Yoaprendoamimanera();
                            welcome.ShowDialog();
                            Venta mainMenu = new Venta();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                        }
                        else
                        {
                            msgError("Usuario o contraseña incorrecta. \n Porfavor intentelo de nuevo.");
                            txtpass.UseSystemPasswordChar = false;
                            txtpass.Text = "CONTRASEÑA";
                            txtpass.ForeColor = Color.DimGray;
                            txtuser.ForeColor = Color.DimGray;
                            txtuser.Text = "USUARIO";
                        }
                    }
                }
                else
                {
                    msgError("Por favor ingresa tu nombre de usuario.");
                    txtuser.Text = "USUARIO";
                    txtpass.UseSystemPasswordChar = false;
                    txtpass.Text = "CONTRASEÑA";
                }
            }
        }
    }
}
