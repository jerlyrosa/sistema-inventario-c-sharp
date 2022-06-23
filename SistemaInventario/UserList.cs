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
    public partial class UserList : Form
    {
        classData data = new classData();
        public UserList()
        {
            InitializeComponent();
            dataGridView1.DataSource = data.getUsuarios();
        }

        private void regresarAlHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
    }
}
