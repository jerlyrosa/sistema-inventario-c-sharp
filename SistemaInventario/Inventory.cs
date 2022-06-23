﻿using System;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            agvOjectos.DataSource = data.getObjecto();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);

            Boolean isSuccess = data.deleteObjecto(id);
            if (isSuccess)
            {
                MessageBox.Show("Objecto Borrado satifactoriamnete");

            }else
            {
                MessageBox.Show($"Error al Borar el objecto, no exite tal objeto con el id{id}","Error al borrar objecto");

            }
        }
    }
}
