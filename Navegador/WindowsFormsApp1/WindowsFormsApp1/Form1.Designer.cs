
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.home = new FontAwesome.Sharp.IconButton();
            this.atras = new FontAwesome.Sharp.IconButton();
            this.delante = new FontAwesome.Sharp.IconButton();
            this.cargar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.cmdfav = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buscar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.cmdfav);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.cargar);
            this.panel1.Controls.Add(this.delante);
            this.panel1.Controls.Add(this.atras);
            this.panel1.Controls.Add(this.home);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 71);
            this.panel1.TabIndex = 0;
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.Black;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.IconSize = 40;
            this.home.Location = new System.Drawing.Point(10, 18);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(49, 41);
            this.home.TabIndex = 0;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // atras
            // 
            this.atras.FlatAppearance.BorderSize = 0;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.atras.IconColor = System.Drawing.Color.ForestGreen;
            this.atras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.atras.IconSize = 40;
            this.atras.Location = new System.Drawing.Point(65, 18);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(49, 41);
            this.atras.TabIndex = 1;
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // delante
            // 
            this.delante.FlatAppearance.BorderSize = 0;
            this.delante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delante.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.delante.IconColor = System.Drawing.Color.ForestGreen;
            this.delante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delante.IconSize = 40;
            this.delante.Location = new System.Drawing.Point(120, 18);
            this.delante.Name = "delante";
            this.delante.Size = new System.Drawing.Size(49, 41);
            this.delante.TabIndex = 2;
            this.delante.UseVisualStyleBackColor = true;
            this.delante.Click += new System.EventHandler(this.delante_Click);
            // 
            // cargar
            // 
            this.cargar.FlatAppearance.BorderSize = 0;
            this.cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.cargar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cargar.IconSize = 40;
            this.cargar.Location = new System.Drawing.Point(175, 18);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(49, 41);
            this.cargar.TabIndex = 3;
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(230, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 41);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdireccion.Location = new System.Drawing.Point(470, 28);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(272, 20);
            this.txtdireccion.TabIndex = 5;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton2.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(276, 18);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(49, 41);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // cmdfav
            // 
            this.cmdfav.FormattingEnabled = true;
            this.cmdfav.Location = new System.Drawing.Point(331, 28);
            this.cmdfav.Name = "cmdfav";
            this.cmdfav.Size = new System.Drawing.Size(121, 21);
            this.cmdfav.TabIndex = 7;
            this.cmdfav.Text = "Favoritos";
            this.cmdfav.SelectedIndexChanged += new System.EventHandler(this.cmdfav_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 82);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(815, 356);
            this.webBrowser1.TabIndex = 1;
            // 
            // buscar
            // 
            this.buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buscar.IconColor = System.Drawing.Color.Black;
            this.buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscar.IconSize = 40;
            this.buscar.Location = new System.Drawing.Point(756, 18);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(49, 41);
            this.buscar.TabIndex = 8;
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador_Ann";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton home;
        private FontAwesome.Sharp.IconButton delante;
        private FontAwesome.Sharp.IconButton atras;
        private System.Windows.Forms.ComboBox cmdfav;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtdireccion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton cargar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private FontAwesome.Sharp.IconButton buscar;
    }
}

