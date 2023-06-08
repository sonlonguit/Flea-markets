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
    public partial class fPersonalInfomation : Form
    {
        public fPersonalInfomation()
        {
            InitializeComponent();
            LoadAccountList();
        }

        private void dtgvPersonalInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void LoadAccountList()
        {
            string query = "EXEC USP_GetAccountByUserName @userName";
            dtgvPersonalInfo.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "Nhat" });

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHome fHome = new fHome();
            fHome.Show();
            fHome.Hide();
        }
    }
}
