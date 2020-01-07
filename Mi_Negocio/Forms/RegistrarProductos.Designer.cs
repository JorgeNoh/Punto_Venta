namespace Mi_Negocio.Forms
{
    partial class RegistrarProductos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProductos));
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtprec = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtAdd = new System.Windows.Forms.Button();
            this.BtUp = new System.Windows.Forms.Button();
            this.BtDel = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BtCan = new System.Windows.Forms.Button();
            this.lblEr = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dtgpro = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtprod
            // 
            this.txtprod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprod.Location = new System.Drawing.Point(135, 307);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(100, 20);
            this.txtprod.TabIndex = 1;
            this.txtprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprod_KeyPress);
            // 
            // txtprec
            // 
            this.txtprec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtprec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprec.Location = new System.Drawing.Point(257, 307);
            this.txtprec.Name = "txtprec";
            this.txtprec.Size = new System.Drawing.Size(100, 20);
            this.txtprec.TabIndex = 2;
            this.txtprec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprec_KeyPress);
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstock.Location = new System.Drawing.Point(376, 307);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 3;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock";
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(92)))));
            this.BtAdd.FlatAppearance.BorderSize = 0;
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAdd.Location = new System.Drawing.Point(16, 345);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(99, 24);
            this.BtAdd.TabIndex = 9;
            this.BtAdd.Text = "Agregar";
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BtUp
            // 
            this.BtUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(13)))));
            this.BtUp.FlatAppearance.BorderSize = 0;
            this.BtUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtUp.Location = new System.Drawing.Point(134, 345);
            this.BtUp.Name = "BtUp";
            this.BtUp.Size = new System.Drawing.Size(99, 24);
            this.BtUp.TabIndex = 10;
            this.BtUp.Text = "Modificar";
            this.BtUp.UseVisualStyleBackColor = false;
            this.BtUp.Click += new System.EventHandler(this.BtUp_Click);
            // 
            // BtDel
            // 
            this.BtDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(54)))), ((int)(((byte)(38)))));
            this.BtDel.FlatAppearance.BorderSize = 0;
            this.BtDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtDel.Location = new System.Drawing.Point(256, 345);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(99, 24);
            this.BtDel.TabIndex = 11;
            this.BtDel.Text = "Eliminar";
            this.BtDel.UseVisualStyleBackColor = false;
            this.BtDel.Click += new System.EventHandler(this.BtDel_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(685, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(24, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 30;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.InitialImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(720, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // BtCan
            // 
            this.BtCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.BtCan.FlatAppearance.BorderSize = 0;
            this.BtCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtCan.Location = new System.Drawing.Point(376, 345);
            this.BtCan.Name = "BtCan";
            this.BtCan.Size = new System.Drawing.Size(99, 24);
            this.BtCan.TabIndex = 12;
            this.BtCan.Text = "Cancelar";
            this.BtCan.UseVisualStyleBackColor = false;
            this.BtCan.Click += new System.EventHandler(this.BtCan_Click);
            // 
            // lblEr
            // 
            this.lblEr.AutoSize = true;
            this.lblEr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.lblEr.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEr.Location = new System.Drawing.Point(130, 30);
            this.lblEr.Name = "lblEr";
            this.lblEr.Size = new System.Drawing.Size(429, 20);
            this.lblEr.TabIndex = 31;
            this.lblEr.Text = "Para modificar y/o eliminar un producto presione el producto";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Error.SetIconAlignment(this.iconButton1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 16;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(612, 327);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(119, 31);
            this.iconButton1.TabIndex = 36;
            this.iconButton1.Text = "Regresar al menú";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dtgpro
            // 
            this.dtgpro.AllowUserToAddRows = false;
            this.dtgpro.AllowUserToDeleteRows = false;
            this.dtgpro.AllowUserToResizeColumns = false;
            this.dtgpro.AllowUserToResizeRows = false;
            this.dtgpro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpro.Location = new System.Drawing.Point(67, 61);
            this.dtgpro.Name = "dtgpro";
            this.dtgpro.ReadOnly = true;
            this.dtgpro.RowHeadersVisible = false;
            this.dtgpro.Size = new System.Drawing.Size(555, 228);
            this.dtgpro.TabIndex = 32;
            this.dtgpro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpro_CellClick);
            this.dtgpro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpro_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 26);
            this.panel1.TabIndex = 33;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Folio";
            // 
            // txtfolio
            // 
            this.txtfolio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtfolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfolio.Location = new System.Drawing.Point(16, 307);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(100, 20);
            this.txtfolio.TabIndex = 34;
            // 
            // RegistrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(743, 381);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgpro);
            this.Controls.Add(this.lblEr);
            this.Controls.Add(this.BtCan);
            this.Controls.Add(this.BtDel);
            this.Controls.Add(this.BtUp);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtprec);
            this.Controls.Add(this.txtprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar";
            this.Load += new System.EventHandler(this.RegistrarProductos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrarProductos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtprec;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtUp;
        private System.Windows.Forms.Button BtDel;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button BtCan;
        private System.Windows.Forms.Label lblEr;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.DataGridView dtgpro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfolio;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}