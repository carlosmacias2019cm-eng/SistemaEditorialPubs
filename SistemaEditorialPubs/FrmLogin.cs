namespace SistemaEditorialPubs
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private int intentosFallidos = 0;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool accesoValido = txtUsuario.Text.Trim() == "admin"
                             && txtContraseña.Text == "1234";

            if (accesoValido)
            {
                Hide();

                using (FrmMenu menu = new FrmMenu())
                {
                    menu.ShowDialog();
                }

                Close();
                return;
            }

            intentosFallidos++;
            int restantes = 3 - intentosFallidos;

            if (restantes == 0)
            {
                MessageBox.Show("Fallaste 3 veces. El programa se cerrará.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show($"Datos incorrectos. Te quedan {restantes} intentos.");
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }
    }
}

