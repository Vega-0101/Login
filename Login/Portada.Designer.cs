namespace Login
{
    partial class Portada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            btnPortada = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            imgMinimizar1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimizar1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnPortada);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 451);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(805, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // btnPortada
            // 
            btnPortada.BackColor = Color.MidnightBlue;
            btnPortada.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnPortada.FlatAppearance.BorderSize = 0;
            btnPortada.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnPortada.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            btnPortada.FlatStyle = FlatStyle.Popup;
            btnPortada.ForeColor = Color.Transparent;
            btnPortada.Location = new Point(354, 397);
            btnPortada.Name = "btnPortada";
            btnPortada.Size = new Size(83, 41);
            btnPortada.TabIndex = 1;
            btnPortada.Text = "Iniciar";
            btnPortada.UseVisualStyleBackColor = false;
            btnPortada.Click += btnPortada_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 379);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(772, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // imgMinimizar1
            // 
            imgMinimizar1.Image = (Image)resources.GetObject("imgMinimizar1.Image");
            imgMinimizar1.Location = new Point(746, 9);
            imgMinimizar1.Name = "imgMinimizar1";
            imgMinimizar1.Size = new Size(20, 20);
            imgMinimizar1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMinimizar1.TabIndex = 12;
            imgMinimizar1.TabStop = false;
            imgMinimizar1.Click += imgMinimizar1_Click;
            // 
            // Portada
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgMinimizar1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Portada";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portada";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimizar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPortada;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox imgMinimizar1;
        private PictureBox pictureBox3;
    }
}