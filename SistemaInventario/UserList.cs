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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void regresarAlHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
    }
}
