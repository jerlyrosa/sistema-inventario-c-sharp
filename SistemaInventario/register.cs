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
    public partial class register : Form

    {

        classData database = new classData();
        public register()
        {
            InitializeComponent();
        }

        private void regresarAlHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string address = txtAddress.Text;
            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (name  == "" | lastname == "" | username == "" | email == "" | password == "" | address =="")
            {
                MessageBox.Show("Datos Obligatorios", "Error al iniciar registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (!checkEmail(email))
            {
                MessageBox.Show("Formato de correo incorrecto.", "Error al registrar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!checkPassword(password))
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 20 caracteres, al menos un dígito, una minúscula y una mayúscula.", "Error al registrar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Boolean isSuccess = database.registrarUsuario(name, lastname, address, username, email, password);
            if (isSuccess)
            {
                MessageBox.Show("Usuario Registrado satifactoriamnete");
                return;
            }

            else
            {
                MessageBox.Show("Ya exiten un usuario con ese username", "Error al registrar datos");
                return;

            }

        }


        private Boolean checkPassword(string password)
        {
            string strRegex = @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,20}$";


            System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(strRegex);

            return re.IsMatch(password);
        }

        private Boolean checkEmail(string email)
        {
            string strRegex = @"^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)$";


            System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(strRegex);

            return re.IsMatch(email);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();

        }
    }
}
