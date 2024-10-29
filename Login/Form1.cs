using System.Drawing.Text;
using System.IO.Packaging;
using System.Runtime.InteropServices;


namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }

        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            switch (usuario)
            {
                case "Director":
                    if (contraseña == "12345")
                    {
                        Menu llamar = new Menu();
                        llamar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error en la contraseña del Director");
                        txtUsuario.Text = string.Empty;
                        txtContraseña.Text = string.Empty;

                        if (txtUsuario.Text == "")
                        {
                            txtUsuario.Text = "USUARIO";
                            txtUsuario.ForeColor = Color.DimGray;
                            txtContraseña.Text = "CONTRASEÑA";
                            txtContraseña.ForeColor = Color.DimGray;
                            txtContraseña.UseSystemPasswordChar = false;

                        }
                    }
                    break;

                case "Contador":
                    if (contraseña == "01234")
                    {
                        Menu llamar = new Menu();
                        llamar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error en la contraseña del contador");
                        txtUsuario.Text = string.Empty;
                        txtContraseña.Text = string.Empty;

                        if (txtUsuario.Text == "")
                        {
                            txtUsuario.Text = "USUARIO";
                            txtUsuario.ForeColor = Color.DimGray;
                            txtContraseña.Text = "CONTRASEÑA";
                            txtContraseña.ForeColor = Color.DimGray;
                            txtContraseña.UseSystemPasswordChar = false;

                        }
                    }
                    break;

                case "Usuario":
                    if (contraseña == "54321"   )
                    {
                        Menu llamar = new Menu();
                        llamar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error en la contraseña del usuario");
                        txtUsuario.Text = string.Empty;
                        txtContraseña.Text = string.Empty;

                        if (txtUsuario.Text == "")
                        {
                            txtUsuario.Text = "USUARIO";
                            txtUsuario.ForeColor = Color.DimGray;
                            txtContraseña.Text = "CONTRASEÑA";
                            txtContraseña.ForeColor = Color.DimGray;
                            txtContraseña.UseSystemPasswordChar = false;

                        }
                    }
                    break;

                default:
                    MessageBox.Show(" Usuario no encontrado :( ");
                    txtUsuario.Text = string.Empty;
                    txtContraseña.Text = string.Empty;

                    if (txtUsuario.Text == "")
                    {
                        txtUsuario.Text = "USUARIO";
                        txtUsuario.ForeColor = Color.DimGray;
                        txtContraseña.Text = "CONTRASEÑA";
                        txtContraseña.ForeColor = Color.DimGray;
                        txtContraseña.UseSystemPasswordChar = false;
                        
                    }
                    break;
            }


            /*if((this.txtUsuario.Text == "Director" && this.txtContraseña.Text == "12345") || (this.txtUsuario.Text == "Contador" && this.txtContraseña.Text == "1234"))
            {
                Menu llamar = new Menu();
                llamar.Show();

                this.Hide();
            }

            else

            {
                MessageBox.Show("Error en usuario o en la contraseña");
                txtUsuario.Text = string.Empty;
                txtContraseña.Text = string.Empty;


            }*/
        }

        private void imgSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMinimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
             ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
