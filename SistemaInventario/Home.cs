namespace SistemaInventario
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            this.Hide();
            new Inventory().Show();


        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            new register().Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
 
        }

        private void listaDeUsuariosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserList().Show();

        }
    }
}