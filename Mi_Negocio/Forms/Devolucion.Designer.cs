namespace Mi_Negocio.Forms
{
    partial class Devolucion
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
            System.Windows.Forms.Button btnadd;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.datagr = new System.Windows.Forms.DataGridView();
            this.txcant = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.AllowDrop = true;
            btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(13)))));
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnadd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnadd.Location = new System.Drawing.Point(437, 280);
            btnadd.Name = "btnadd";
            btnadd.Size = new System.Drawing.Size(139, 25);
            btnadd.TabIndex = 34;
            btnadd.Text = "Devolver";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(583, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(24, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 30;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.InitialImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(613, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtno
            // 
            this.txtno.AllowDrop = true;
            this.txtno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtno.Location = new System.Drawing.Point(353, 308);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 32;
            this.txtno.Visible = false;
            // 
            // datagr
            // 
            this.datagr.AllowUserToAddRows = false;
            this.datagr.AllowUserToDeleteRows = false;
            this.datagr.AllowUserToResizeColumns = false;
            this.datagr.AllowUserToResizeRows = false;
            this.datagr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagr.Location = new System.Drawing.Point(85, 66);
            this.datagr.Name = "datagr";
            this.datagr.ReadOnly = true;
            this.datagr.RowHeadersVisible = false;
            this.datagr.Size = new System.Drawing.Size(433, 211);
            this.datagr.TabIndex = 35;
            this.datagr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagr_CellClick);
            // 
            // txcant
            // 
            this.txcant.AllowDrop = true;
            this.txcant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txcant.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txcant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txcant.Location = new System.Drawing.Point(476, 308);
            this.txcant.Name = "txcant";
            this.txcant.Size = new System.Drawing.Size(100, 20);
            this.txcant.TabIndex = 36;
            this.txcant.Visible = false;
            // 
            // txId
            // 
            this.txId.AllowDrop = true;
            this.txId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Location = new System.Drawing.Point(237, 308);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 37;
            this.txId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 27);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cantidad
            // 
            this.cantidad.AllowDrop = true;
            this.cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cantidad.Location = new System.Drawing.Point(161, 283);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 20);
            this.cantidad.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cantidad a devolver:";
            // 
            // price
            // 
            this.price.AllowDrop = true;
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.price.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(353, 334);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 41;
            this.price.Visible = false;
            // 
            // date1
            // 
            this.date1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date1.Location = new System.Drawing.Point(204, 40);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 20);
            this.date1.TabIndex = 43;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Buscar por fecha:";
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
            this.iconButton1.Location = new System.Drawing.Point(12, 327);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(119, 31);
            this.iconButton1.TabIndex = 44;
            this.iconButton1.Text = "Regresar al menú";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(641, 367);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.txcant);
            this.Controls.Add(this.datagr);
            this.Controls.Add(btnadd);
            this.Controls.Add(this.txtno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Devolucion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.DataGridView datagr;
        private System.Windows.Forms.TextBox txcant;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}