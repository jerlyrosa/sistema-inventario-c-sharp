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
    public partial class Inventory : Form
    {
        classData data = new classData();

        public Inventory()
        {
            InitializeComponent();
            agvOjectos.DataSource = data.getObjecto();
        }

        private void regresarAlHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
    }
}
