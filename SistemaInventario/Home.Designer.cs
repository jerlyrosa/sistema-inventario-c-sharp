namespace SistemaInventario
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuariosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarObjectoAlInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE INVENTARIO\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(183, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = " SOLUCIONES CREATIVAS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.agregarObjectoAlInventarioToolStripMenuItem,
            this.agregarNuevoUsuarioToolStripMenuItem,
            this.listaDeUsuariosRegistradosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // agregarNuevoUsuarioToolStripMenuItem
            // 
            this.agregarNuevoUsuarioToolStripMenuItem.Name = "agregarNuevoUsuarioToolStripMenuItem";
            this.agregarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.agregarNuevoUsuarioToolStripMenuItem.Text = "Agregar nuevo Usuario";
            this.agregarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // listaDeUsuariosRegistradosToolStripMenuItem
            // 
            this.listaDeUsuariosRegistradosToolStripMenuItem.Name = "listaDeUsuariosRegistradosToolStripMenuItem";
            this.listaDeUsuariosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.listaDeUsuariosRegistradosToolStripMenuItem.Text = "Lista de usuarios registrados";
            this.listaDeUsuariosRegistradosToolStripMenuItem.Click += new System.EventHandler(this.listaDeUsuariosRegistradosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // agregarObjectoAlInventarioToolStripMenuItem
            // 
            this.agregarObjectoAlInventarioToolStripMenuItem.Name = "agregarObjectoAlInventarioToolStripMenuItem";
            this.agregarObjectoAlInventarioToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.agregarObjectoAlInventarioToolStripMenuItem.Text = "Agregar Objecto al Inventario";
            this.agregarObjectoAlInventarioToolStripMenuItem.Click += new System.EventHandler(this.agregarObjectoAlInventarioToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem agregarNuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem listaDeUsuariosRegistradosToolStripMenuItem;
        private ToolStripMenuItem agregarObjectoAlInventarioToolStripMenuItem;
    }
}