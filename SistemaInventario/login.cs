using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connectionDb;

namespace SistemaInventario
{
    public partial class Login : Form
    {

        classData data = new classData();
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
        


            if (username == "" || password == "")
            {
                MessageBox.Show("Datos Obligatorios", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Boolean isSucess = data.loginUser(Convert.ToString(username), Convert.ToString(password));
            if (isSucess)
            {
            MessageBox.Show("WELCOME " + username);
                new Home().Show();

                this.Hide();
                username = "";
                password = "";

            }
            else
            {
                MessageBox.Show("Correo o contrasena incorrectos", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
