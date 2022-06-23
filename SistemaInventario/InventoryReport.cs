using connectionDb;

namespace SistemaInventario
{
    public partial class InventoryReport : Form

    {
        classData data = new classData();
        public InventoryReport()
        {
            InitializeComponent();
            agvReport.DataSource = data.getObjecto();
        
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            labelHora.Text = ( "Hoy " + DateTime.Now.ToString("MMMM dddd yyy h mm:ss"));
        }
    }
}
