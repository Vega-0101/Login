namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            BtnInicio = new Button();
            lkrecuperar = new LinkLabel();
            pictureBox1 = new PictureBox();
            imgMinimizar1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimizar1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 330);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(341, 96);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 1;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DimGray;
            linkLabel2.Location = new Point(273, 96);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(502, 25);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "                                                                                                  ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.DimGray;
            linkLabel3.Location = new Point(273, 181);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(502, 25);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "                                                                                                  ";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = Color.DarkGray;
            txtUsuario.Location = new Point(279, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(488, 24);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.ForeColor = Color.DarkGray;
            txtContraseña.Location = new Point(279, 170);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(488, 24);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(454, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            // 
            // BtnInicio
            // 
            BtnInicio.BackColor = Color.FromArgb(15, 15, 15);
            BtnInicio.FlatAppearance.BorderColor = Color.DarkGray;
            BtnInicio.FlatAppearance.BorderSize = 0;
            BtnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnInicio.FlatStyle = FlatStyle.Flat;
            BtnInicio.ForeColor = Color.LightGray;
            BtnInicio.Location = new Point(299, 231);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(444, 62);
            BtnInicio.TabIndex = 3;
            BtnInicio.Text = "INICIAR SESIÓN";
            BtnInicio.UseVisualStyleBackColor = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // lkrecuperar
            // 
            lkrecuperar.AutoSize = true;
            lkrecuperar.LinkColor = Color.DarkGray;
            lkrecuperar.Location = new Point(398, 294);
            lkrecuperar.Name = "lkrecuperar";
            lkrecuperar.Size = new Size(242, 25);
            lkrecuperar.TabIndex = 0;
            lkrecuperar.TabStop = true;
            lkrecuperar.Text = "¿Has olvidado la contraseña?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(775, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += imgSalir_Click;
            // 
            // imgMinimizar1
            // 
            imgMinimizar1.Image = (Image)resources.GetObject("imgMinimizar1.Image");
            imgMinimizar1.Location = new Point(747, 9);
            imgMinimizar1.Name = "imgMinimizar1";
            imgMinimizar1.Size = new Size(20, 20);
            imgMinimizar1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMinimizar1.TabIndex = 11;
            imgMinimizar1.TabStop = false;
            imgMinimizar1.Click += imgMinimizar1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 330);
            Controls.Add(imgMinimizar1);
            Controls.Add(pictureBox1);
            Controls.Add(lkrecuperar);
            Controls.Add(BtnInicio);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimizar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Button BtnInicio;
        private LinkLabel lkrecuperar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox imgMinimizar1;
    }
}
