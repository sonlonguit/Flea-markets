using Chợ_Đồ_Cũ.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chợ_Đồ_Cũ
{
    public partial class fManageProduct : Form
    {
        public fManageProduct()
        {
            InitializeComponent();
            LoadProductList();
        }

        private void fManageProduct_Load(object sender, EventArgs e)
        {

        }
        void LoadProductList()
        {
            string query = "select * from PRODUCT";
            dtgvProduct.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void tbnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHome fHome = new fHome();
            fHome.Show();
            fHome.Hide();
        }
    }
}
