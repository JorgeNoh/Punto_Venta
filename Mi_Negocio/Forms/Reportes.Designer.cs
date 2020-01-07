namespace Mi_Negocio.Forms
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.CrystalReport11 = new Mi_Negocio.Forms.CrystalReport1();
            this.CrystalReport12 = new Mi_Negocio.Forms.CrystalReport1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fecha2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Fecha1 = new System.Windows.Forms.DateTimePicker();
            this.today = new System.Windows.Forms.Button();
            this.lastweek = new System.Windows.Forms.Button();
            this.lastmonth = new System.Windows.Forms.Button();
            this.thisyear = new System.Windows.Forms.Button();
            this.custom = new System.Windows.Forms.Button();
            this.thismonth = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.panel3.Controls.Add(this.btnRestaurar);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 31);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 332);
            this.panel4.TabIndex = 34;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.InitialImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(966, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(936, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(24, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 31;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(144, 27);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(841, 607);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.thismonth);
            this.panel1.Controls.Add(this.custom);
            this.panel1.Controls.Add(this.thisyear);
            this.panel1.Controls.Add(this.lastmonth);
            this.panel1.Controls.Add(this.lastweek);
            this.panel1.Controls.Add(this.today);
            this.panel1.Controls.Add(this.Fecha1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Fecha2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 634);
            this.panel1.TabIndex = 4;
            // 
            // Fecha2
            // 
            this.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha2.Location = new System.Drawing.Point(28, 396);
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.Size = new System.Drawing.Size(85, 20);
            this.Fecha2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fecha1
            // 
            this.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha1.Location = new System.Drawing.Point(28, 352);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(85, 20);
            this.Fecha1.TabIndex = 1;
            // 
            // today
            // 
            this.today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.today.FlatAppearance.BorderSize = 0;
            this.today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.today.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.today.Location = new System.Drawing.Point(5, 46);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(133, 35);
            this.today.TabIndex = 4;
            this.today.Text = "Hoy";
            this.today.UseVisualStyleBackColor = false;
            this.today.Click += new System.EventHandler(this.today_Click);
            // 
            // lastweek
            // 
            this.lastweek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.lastweek.FlatAppearance.BorderSize = 0;
            this.lastweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastweek.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lastweek.Location = new System.Drawing.Point(5, 96);
            this.lastweek.Name = "lastweek";
            this.lastweek.Size = new System.Drawing.Size(133, 35);
            this.lastweek.TabIndex = 5;
            this.lastweek.Text = "Ultimos 7 días";
            this.lastweek.UseVisualStyleBackColor = false;
            this.lastweek.Click += new System.EventHandler(this.lastweek_Click);
            // 
            // lastmonth
            // 
            this.lastmonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.lastmonth.FlatAppearance.BorderSize = 0;
            this.lastmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastmonth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lastmonth.Location = new System.Drawing.Point(5, 146);
            this.lastmonth.Name = "lastmonth";
            this.lastmonth.Size = new System.Drawing.Size(133, 35);
            this.lastmonth.TabIndex = 7;
            this.lastmonth.Text = "Ultimos 30 días";
            this.lastmonth.UseVisualStyleBackColor = false;
            this.lastmonth.Click += new System.EventHandler(this.lastmonth_Click);
            // 
            // thisyear
            // 
            this.thisyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.thisyear.FlatAppearance.BorderSize = 0;
            this.thisyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thisyear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.thisyear.Location = new System.Drawing.Point(5, 247);
            this.thisyear.Name = "thisyear";
            this.thisyear.Size = new System.Drawing.Size(133, 35);
            this.thisyear.TabIndex = 8;
            this.thisyear.Text = "Este año";
            this.thisyear.UseVisualStyleBackColor = false;
            this.thisyear.Click += new System.EventHandler(this.thisyear_Click);
            // 
            // custom
            // 
            this.custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.custom.FlatAppearance.BorderSize = 0;
            this.custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.custom.Location = new System.Drawing.Point(5, 299);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(133, 35);
            this.custom.TabIndex = 9;
            this.custom.Text = "Personalizado";
            this.custom.UseVisualStyleBackColor = false;
            this.custom.Click += new System.EventHandler(this.custom_Click);
            // 
            // thismonth
            // 
            this.thismonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.thismonth.FlatAppearance.BorderSize = 0;
            this.thismonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thismonth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.thismonth.Location = new System.Drawing.Point(5, 196);
            this.thismonth.Name = "thismonth";
            this.thismonth.Size = new System.Drawing.Size(133, 35);
            this.thismonth.TabIndex = 10;
            this.thismonth.Text = "Este mes";
            this.thismonth.UseVisualStyleBackColor = false;
            this.thismonth.Click += new System.EventHandler(this.thismonth_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 5;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Reportes_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Reportes_MouseLeave);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalReport1 CrystalReport11;
        private CrystalReport1 CrystalReport12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button thismonth;
        private System.Windows.Forms.Button custom;
        private System.Windows.Forms.Button thisyear;
        private System.Windows.Forms.Button lastmonth;
        private System.Windows.Forms.Button lastweek;
        private System.Windows.Forms.Button today;
        private System.Windows.Forms.DateTimePicker Fecha1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Fecha2;
        private System.Windows.Forms.Panel panel2;
    }
}