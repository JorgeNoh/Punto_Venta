namespace Mi_Negocio.Forms
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.datgrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btnsum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbre = new System.Windows.Forms.TextBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.datgrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datgrd
            // 
            this.datgrd.AllowUserToAddRows = false;
            this.datgrd.AllowUserToDeleteRows = false;
            this.datgrd.AllowUserToResizeColumns = false;
            this.datgrd.AllowUserToResizeRows = false;
            this.datgrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrd.Location = new System.Drawing.Point(12, 68);
            this.datgrd.Name = "datgrd";
            this.datgrd.ReadOnly = true;
            this.datgrd.RowHeadersVisible = false;
            this.datgrd.Size = new System.Drawing.Size(598, 209);
            this.datgrd.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Buscar por fecha:";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(121, 42);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 20);
            this.date1.TabIndex = 35;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnsum.FlatAppearance.BorderSize = 0;
            this.btnsum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsum.Location = new System.Drawing.Point(112, 306);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(99, 25);
            this.btnsum.TabIndex = 36;
            this.btnsum.Text = "Sumar ";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Suma total del día:";
            // 
            // Tbre
            // 
            this.Tbre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tbre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbre.Enabled = false;
            this.Tbre.Location = new System.Drawing.Point(324, 309);
            this.Tbre.Name = "Tbre";
            this.Tbre.Size = new System.Drawing.Size(100, 20);
            this.Tbre.TabIndex = 38;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(578, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(24, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 40;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.InitialImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(613, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 26);
            this.panel1.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(484, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 25);
            this.button1.TabIndex = 42;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 16;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 347);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(119, 31);
            this.iconButton1.TabIndex = 43;
            this.iconButton1.Text = "Regresar al menú";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(635, 390);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tbre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datgrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.datgrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datgrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbre;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}