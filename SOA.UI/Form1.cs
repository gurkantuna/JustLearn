using SOA.UI.ProductWebService;
using System;
using System.Windows.Forms;

namespace SOA.UI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnWebService_Click(object sender, EventArgs e) {
            ProductWebServiceSoapClient client = new ProductWebService.ProductWebServiceSoapClient();
            dataGridView1.DataSource = client.GetProducts();
        }

        private void btnWcfService_Click(object sender, EventArgs e) {
            ProductWcfService.ProductWcfServiceClient client = new ProductWcfService.ProductWcfServiceClient();
            dataGridView1.DataSource = client.GetProducts();
        }
    }
}
