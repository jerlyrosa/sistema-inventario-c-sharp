using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class FormAddObjects : Form
    {
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
    }
}
