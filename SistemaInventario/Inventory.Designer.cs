namespace SistemaInventario
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.agvOjectos = new System.Windows.Forms.DataGridView();
            this.regresarAlHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.agvOjectos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de objectos";
            // 
            // agvOjectos
            // 
            this.agvOjectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agvOjectos.Location = new System.Drawing.Point(39, 114);
            this.agvOjectos.Name = "agvOjectos";
            this.agvOjectos.RowTemplate.Height = 25;
            this.agvOjectos.Size = new System.Drawing.Size(638, 298);
            this.agvOjectos.TabIndex = 4;
            // 
            // regresarAlHomeToolStripMenuItem
            // 
            this.regresarAlHomeToolStripMenuItem.Name = "regresarAlHomeToolStripMenuItem";
            this.regresarAlHomeToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.regresarAlHomeToolStripMenuItem.Text = "Regresar al home";
            this.regresarAlHomeToolStripMenuItem.Click += new System.EventHandler(this.regresarAlHomeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarAlHomeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.agvOjectos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.agvOjectos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private DataGridView agvOjectos;
        private ToolStripMenuItem regresarAlHomeToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}