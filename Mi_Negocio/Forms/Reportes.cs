using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Negocio.Forms
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 reporte = new CrystalReport1();
            reporte.SetParameterValue("@Fecha1", Fecha1.Value.ToString("MM/dd/yyyy"));
            reporte.SetParameterValue("@Fecha2", Fecha2.Value.ToString("MM/dd/yyyy"));
            crystalReportViewer1.ReportSource = reporte;
            Fecha1.Enabled = false;
            Fecha2.Enabled = false;
            button1.Enabled = false;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            Fecha1.Enabled = false;
            Fecha2.Enabled = false;
            button1.Enabled = false;
        }

        private void custom_Click(object sender, EventArgs e)
        {
            Fecha1.Enabled = true;
            Fecha2.Enabled = true;
            button1.Enabled = true;
        }

        private void today_Click(object sender, EventArgs e)
        {
            CrystalReport1 reporte = new CrystalReport1();
            reporte.SetParameterValue("@Fecha1", DateTime.Today.ToString("MM/dd/yyyy"));
            reporte.SetParameterValue("@Fecha2", DateTime.Today.ToString("MM/dd/yyyy"));
            crystalReportViewer1.ReportSource = reporte;
        }

        private void lastweek_Click(object sender, EventArgs e)
        {
            CrystalReport1 reporte = new CrystalReport1();
            reporte.SetParameterValue("@Fecha1", DateTime.Today.AddDays(-7).ToString("MM/dd/yyyy"));
            reporte.SetParameterValue("@Fecha2", DateTime.Today.ToString("MM/dd/yyyy"));
            crystalReportViewer1.ReportSource = reporte;
        }

        private void lastmonth_Click(object sender, EventArgs e)
        {
            CrystalReport1 reporte = new CrystalReport1();
            reporte.SetParameterValue("@Fecha1", DateTime.Today.AddDays(-30).ToString("MM/dd/yyyy"));
            reporte.SetParameterValue("@Fecha2", DateTime.Today.ToString("MM/dd/yyyy"));
            crystalReportViewer1.ReportSource = reporte;
        }

        private void thisyear_Click(object sender, EventArgs e)
        {
            CrystalReport1 reporte = new CrystalReport1();
            reporte.SetParameterValue("@Fecha1", new DateTime(DateTime.Now.Year, 1, 1).ToString("MM/dd/yyyy"));
            reporte.SetParameterValue("@Fecha2", DateTime.Today.ToString("MM/dd/yyyy"));
            crystalReportViewer1.ReportSource = reporte;
        }

        private void thismonth_Click(object sender, EventArgs e)
        {
            CrystalReport1 reporte = new CrystalReport1();
            reporte.SetParameterValue("@Fecha1", new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).ToString("MM/dd/yyyy"));
            reporte.SetParameterValue("@Fecha2", DateTime.Today.ToString("MM/dd/yyyy"));
            crystalReportViewer1.ReportSource = reporte;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {            
        }

        private void Reportes_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Reportes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
