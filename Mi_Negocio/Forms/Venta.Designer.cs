namespace Mi_Negocio
{
    partial class Venta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btncancel;
            System.Windows.Forms.Button btnadd;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnDevolucion = new FontAwesome.Sharp.IconButton();
            this.btnRegistro = new FontAwesome.Sharp.IconButton();
            this.lblEnProducts = new FontAwesome.Sharp.IconButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.sessions = new System.Windows.Forms.Label();
            this.txtsaludo = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbposition = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbError = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.lbstock = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbproductos = new System.Windows.Forms.ComboBox();
            this.lvproducts = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbre = new System.Windows.Forms.Label();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.btnagr = new System.Windows.Forms.Button();
            this.txtreci = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btncancel = new System.Windows.Forms.Button();
            btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            btncancel.AutoSize = true;
            btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(54)))), ((int)(((byte)(38)))));
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btncancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btncancel.Location = new System.Drawing.Point(772, 429);
            btncancel.Name = "btncancel";
            btncancel.Size = new System.Drawing.Size(99, 29);
            btncancel.TabIndex = 74;
            btncancel.Text = "Cancelar venta";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnadd
            // 
            btnadd.AutoSize = true;
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnadd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnadd.Location = new System.Drawing.Point(650, 429);
            btnadd.Name = "btnadd";
            btnadd.Size = new System.Drawing.Size(99, 29);
            btnadd.TabIndex = 64;
            btnadd.Text = "Cobrar";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += new System.EventHandler(this.btnadd_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnDevolucion);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.lblEnProducts);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.sessions);
            this.panel1.Controls.Add(this.txtsaludo);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lbposition);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 490);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconSize = 35;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(-1, 303);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnVentas.Rotation = 0D;
            this.btnVentas.Size = new System.Drawing.Size(239, 60);
            this.btnVentas.TabIndex = 43;
            this.btnVentas.Text = "Todas las ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnDevolucion.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnDevolucion.IconColor = System.Drawing.Color.White;
            this.btnDevolucion.IconSize = 35;
            this.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.Location = new System.Drawing.Point(0, 237);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDevolucion.Rotation = 0D;
            this.btnDevolucion.Size = new System.Drawing.Size(238, 60);
            this.btnDevolucion.TabIndex = 42;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistro.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnRegistro.IconColor = System.Drawing.Color.White;
            this.btnRegistro.IconSize = 35;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 171);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRegistro.Rotation = 0D;
            this.btnRegistro.Size = new System.Drawing.Size(238, 60);
            this.btnRegistro.TabIndex = 41;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblEnProducts
            // 
            this.lblEnProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnProducts.FlatAppearance.BorderSize = 0;
            this.lblEnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.lblEnProducts.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnProducts.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.lblEnProducts.IconColor = System.Drawing.Color.White;
            this.lblEnProducts.IconSize = 35;
            this.lblEnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEnProducts.Location = new System.Drawing.Point(-1, 105);
            this.lblEnProducts.Name = "lblEnProducts";
            this.lblEnProducts.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEnProducts.Rotation = 0D;
            this.lblEnProducts.Size = new System.Drawing.Size(239, 60);
            this.lblEnProducts.TabIndex = 39;
            this.lblEnProducts.Text = "Registrar Productos";
            this.lblEnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblEnProducts.UseVisualStyleBackColor = true;
            this.lblEnProducts.Click += new System.EventHandler(this.lblEnProducts_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(5, 395);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // sessions
            // 
            this.sessions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessions.AutoSize = true;
            this.sessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sessions.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessions.ForeColor = System.Drawing.Color.DarkCyan;
            this.sessions.Location = new System.Drawing.Point(33, 397);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(64, 17);
            this.sessions.TabIndex = 17;
            this.sessions.Text = "Sesiones";
            this.sessions.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // txtsaludo
            // 
            this.txtsaludo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsaludo.AutoSize = true;
            this.txtsaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaludo.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtsaludo.Location = new System.Drawing.Point(3, 10);
            this.txtsaludo.Name = "txtsaludo";
            this.txtsaludo.Size = new System.Drawing.Size(101, 20);
            this.txtsaludo.TabIndex = 12;
            this.txtsaludo.Text = "Buenos dias,";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 423);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lbposition
            // 
            this.lbposition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbposition.AutoSize = true;
            this.lbposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbposition.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbposition.Location = new System.Drawing.Point(3, 67);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(59, 20);
            this.lbposition.TabIndex = 8;
            this.lbposition.Text = "Puesto";
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblnombre.Location = new System.Drawing.Point(3, 39);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 7;
            this.lblnombre.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(33, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cerrar Sesión";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(238, 490);
            this.shapeContainer1.TabIndex = 40;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.Teal;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -31;
            this.lineShape1.X2 = 237;
            this.lineShape1.Y1 = 100;
            this.lineShape1.Y2 = 100;
            // 
            // lbError
            // 
            this.lbError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.DarkRed;
            this.lbError.Location = new System.Drawing.Point(293, 365);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 6;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(861, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(24, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 69;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.InitialImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(896, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 68;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(290, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 18);
            this.label7.TabIndex = 78;
            this.label7.Text = "*Si desea remover un producto solo de doble click sobre el";
            // 
            // txtprod
            // 
            this.txtprod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprod.Location = new System.Drawing.Point(526, 430);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(94, 20);
            this.txtprod.TabIndex = 77;
            this.txtprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprod_KeyPress_1);
            // 
            // lbstock
            // 
            this.lbstock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbstock.AutoSize = true;
            this.lbstock.Location = new System.Drawing.Point(847, 319);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(0, 13);
            this.lbstock.TabIndex = 76;
            this.lbstock.UseWaitCursor = true;
            this.lbstock.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 75;
            this.dateTimePicker1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Clave del producto:";
            // 
            // cbproductos
            // 
            this.cbproductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbproductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbproductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproductos.FormattingEnabled = true;
            this.cbproductos.Location = new System.Drawing.Point(349, 19);
            this.cbproductos.Name = "cbproductos";
            this.cbproductos.Size = new System.Drawing.Size(160, 21);
            this.cbproductos.TabIndex = 59;
            this.cbproductos.SelectedIndexChanged += new System.EventHandler(this.cbproductos_SelectedIndexChanged_1);
            // 
            // lvproducts
            // 
            this.lvproducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvproducts.BackColor = System.Drawing.Color.White;
            this.lvproducts.GridLines = true;
            this.lvproducts.HideSelection = false;
            this.lvproducts.Location = new System.Drawing.Point(293, 67);
            this.lvproducts.Name = "lvproducts";
            this.lvproducts.Size = new System.Drawing.Size(564, 281);
            this.lvproducts.TabIndex = 72;
            this.lvproducts.UseCompatibleStateImageBehavior = false;
            this.lvproducts.View = System.Windows.Forms.View.List;
            this.lvproducts.DoubleClick += new System.EventHandler(this.lvproducts_DoubleClick_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Precio:";
            // 
            // lbre
            // 
            this.lbre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbre.AutoSize = true;
            this.lbre.Enabled = false;
            this.lbre.Location = new System.Drawing.Point(639, 457);
            this.lbre.Name = "lbre";
            this.lbre.Size = new System.Drawing.Size(0, 13);
            this.lbre.TabIndex = 70;
            this.lbre.UseWaitCursor = true;
            this.lbre.Visible = false;
            // 
            // txtcant
            // 
            this.txtcant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtcant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtcant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcant.Location = new System.Drawing.Point(592, 19);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(94, 20);
            this.txtcant.TabIndex = 60;
            this.txtcant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcant_KeyPress_1);
            // 
            // btnagr
            // 
            this.btnagr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(92)))));
            this.btnagr.FlatAppearance.BorderSize = 0;
            this.btnagr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnagr.Location = new System.Drawing.Point(296, 429);
            this.btnagr.Name = "btnagr";
            this.btnagr.Size = new System.Drawing.Size(96, 29);
            this.btnagr.TabIndex = 62;
            this.btnagr.Text = "Agregar";
            this.btnagr.UseVisualStyleBackColor = false;
            this.btnagr.Click += new System.EventHandler(this.btnagr_Click_1);
            // 
            // txtreci
            // 
            this.txtreci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtreci.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtreci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreci.Enabled = false;
            this.txtreci.Location = new System.Drawing.Point(756, 19);
            this.txtreci.Name = "txtreci";
            this.txtreci.Size = new System.Drawing.Size(94, 20);
            this.txtreci.TabIndex = 61;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(763, 397);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(94, 20);
            this.txtTotal.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Total:\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Producto:";
            // 
            // Venta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(920, 490);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.lbstock);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(btncancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbproductos);
            this.Controls.Add(this.lvproducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbre);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.btnagr);
            this.Controls.Add(btnadd);
            this.Controls.Add(this.txtreci);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(920, 490);
            this.Name = "Venta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Venta_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbposition;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txtsaludo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label sessions;
        private FontAwesome.Sharp.IconButton lblEnProducts;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnDevolucion;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbproductos;
        private System.Windows.Forms.ListView lvproducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbre;
        public System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Button btnagr;
        public System.Windows.Forms.TextBox txtreci;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

