namespace ATM_Cajero
{
    partial class FrmCajero
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCajero));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.PictureA = new System.Windows.Forms.PictureBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnDeposito = new System.Windows.Forms.Button();
            this.BtnRetiro = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(186, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 139);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 102);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Controls.Add(this.TxtMonto);
            this.PanelOpciones.Controls.Add(this.label3);
            this.PanelOpciones.Controls.Add(this.LblSaldo);
            this.PanelOpciones.Controls.Add(this.TxtClave);
            this.PanelOpciones.Controls.Add(this.label2);
            this.PanelOpciones.Controls.Add(this.TxtID);
            this.PanelOpciones.Controls.Add(this.label1);
            this.PanelOpciones.Controls.Add(this.LblTipo);
            this.PanelOpciones.Controls.Add(this.LblTiempo);
            this.PanelOpciones.Controls.Add(this.PictureA);
            this.PanelOpciones.Controls.Add(this.LblDate);
            this.PanelOpciones.Location = new System.Drawing.Point(185, 296);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(345, 209);
            this.PanelOpciones.TabIndex = 3;
            // 
            // LblSaldo
            // 
            this.LblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSaldo.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.ForeColor = System.Drawing.Color.Black;
            this.LblSaldo.Location = new System.Drawing.Point(6, 152);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(331, 23);
            this.LblSaldo.TabIndex = 14;
            this.LblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSaldo.Visible = false;
            // 
            // TxtClave
            // 
            this.TxtClave.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtClave.ForeColor = System.Drawing.Color.Navy;
            this.TxtClave.Location = new System.Drawing.Point(171, 80);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(93, 23);
            this.TxtClave.TabIndex = 13;
            this.TxtClave.Visible = false;
            this.TxtClave.TextChanged += new System.EventHandler(this.TxtClave_TextChanged);
            this.TxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClave_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Clave Personal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtID.ForeColor = System.Drawing.Color.Navy;
            this.TxtID.Location = new System.Drawing.Point(171, 51);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(93, 23);
            this.TxtID.TabIndex = 11;
            this.TxtID.Visible = false;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID de Tarjeta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // LblTipo
            // 
            this.LblTipo.BackColor = System.Drawing.Color.Transparent;
            this.LblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTipo.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(5, 8);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(336, 26);
            this.LblTipo.TabIndex = 9;
            this.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTipo.Visible = false;
            // 
            // LblTiempo
            // 
            this.LblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.LblTiempo.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempo.Location = new System.Drawing.Point(214, 187);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(128, 20);
            this.LblTiempo.TabIndex = 8;
            this.LblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureA
            // 
            this.PictureA.BackColor = System.Drawing.Color.Transparent;
            this.PictureA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureA.BackgroundImage")));
            this.PictureA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureA.Location = new System.Drawing.Point(67, 13);
            this.PictureA.Name = "PictureA";
            this.PictureA.Size = new System.Drawing.Size(205, 171);
            this.PictureA.TabIndex = 7;
            this.PictureA.TabStop = false;
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(6, 187);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(202, 20);
            this.LblDate.TabIndex = 4;
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.BtnConsulta.FlatAppearance.BorderSize = 2;
            this.BtnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Dubai Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.ForeColor = System.Drawing.Color.White;
            this.BtnConsulta.Location = new System.Drawing.Point(101, 308);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(70, 38);
            this.BtnConsulta.TabIndex = 4;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnDeposito
            // 
            this.BtnDeposito.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDeposito.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.BtnDeposito.FlatAppearance.BorderSize = 2;
            this.BtnDeposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeposito.Font = new System.Drawing.Font("Dubai Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeposito.ForeColor = System.Drawing.Color.White;
            this.BtnDeposito.Location = new System.Drawing.Point(101, 358);
            this.BtnDeposito.Name = "BtnDeposito";
            this.BtnDeposito.Size = new System.Drawing.Size(70, 38);
            this.BtnDeposito.TabIndex = 5;
            this.BtnDeposito.Text = "Deposito";
            this.BtnDeposito.UseVisualStyleBackColor = false;
            this.BtnDeposito.Click += new System.EventHandler(this.BtnDeposito_Click);
            // 
            // BtnRetiro
            // 
            this.BtnRetiro.BackColor = System.Drawing.Color.DarkGray;
            this.BtnRetiro.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.BtnRetiro.FlatAppearance.BorderSize = 2;
            this.BtnRetiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetiro.Font = new System.Drawing.Font("Dubai Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetiro.ForeColor = System.Drawing.Color.White;
            this.BtnRetiro.Location = new System.Drawing.Point(101, 408);
            this.BtnRetiro.Name = "BtnRetiro";
            this.BtnRetiro.Size = new System.Drawing.Size(70, 38);
            this.BtnRetiro.TabIndex = 6;
            this.BtnRetiro.Text = "Retiro";
            this.BtnRetiro.UseVisualStyleBackColor = false;
            this.BtnRetiro.Click += new System.EventHandler(this.BtnRetiro_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(57, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(612, 33);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(101, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtMonto
            // 
            this.TxtMonto.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtMonto.ForeColor = System.Drawing.Color.Navy;
            this.TxtMonto.Location = new System.Drawing.Point(171, 119);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(93, 23);
            this.TxtMonto.TabIndex = 16;
            this.TxtMonto.Visible = false;
            this.TxtMonto.TextChanged += new System.EventHandler(this.TxtMonto_TextChanged);
            this.TxtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Monto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 784);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnRetiro);
            this.Controls.Add(this.BtnDeposito);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.PanelOpciones);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelOpciones.ResumeLayout(false);
            this.PanelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnDeposito;
        private System.Windows.Forms.Button BtnRetiro;
        private System.Windows.Forms.PictureBox PictureA;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
    }
}

