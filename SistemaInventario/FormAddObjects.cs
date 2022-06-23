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
    public partial class FormAddObjects : Form
    {
        classData database = new classData();
        public FormAddObjects()
        {
            InitializeComponent();
        }

        private void regresarAlHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;
            string estado = txtState.Text;
            string category = txtCategory.Text;

            if (name == "" | description == "" | estado == "" | category == "" )
            {
                MessageBox.Show("Todos los Datos de los Objectos som obligatrio", "Error al iniciar registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Boolean isSuccess = database.registrarObjecto(name, description, estado, category);
            if (isSuccess)
            {
                MessageBox.Show("Usuario Registrado satifactoriamnete");
                return;
            }

        }
    }
}
