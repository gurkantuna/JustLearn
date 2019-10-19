using Repository.UI.ProductWcfService;
using System;
using System.Windows.Forms;

namespace Repository.UI
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ProductWCFServiceClient client = new ProductWCFServiceClient();
            dataGridView1.DataSource = client.GetAll();
        }

        private void button2_Click(object sender, EventArgs e) {
            ProductWCFServiceClient client = new ProductWCFServiceClient();
            var dto = client.GetById(82);
            dto.ProductName = "TestProduct";
            client.Update(dto);
        }

        private void button3_Click(object sender, EventArgs e) {
            ProductWCFServiceClient client = new ProductWCFServiceClient();
            ProductDTO dto = new ProductDTO();
            dto.ProductName = "Test2";
            dto.CategoryID = 2;
            dto.UnitPrice = 100;
            dto.UnitsInStock = 10;
            client.Insert(dto);
        }

        private void button4_Click(object sender, EventArgs e) {
            ProductWCFServiceClient client = new ProductWCFServiceClient();
            var dto = client.GetById(82);
            client.Delete(dto);
        }
    }
}
