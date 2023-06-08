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
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            fPost fPost = new fPost();
            this.Hide();
            fPost.ShowDialog();
            this.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            fPersonalInfomation fPersonalInfomation = new fPersonalInfomation();
            this.Hide();
            fPersonalInfomation.ShowDialog();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fSearch fSearch = new fSearch();
            this.Hide();
            fSearch.ShowDialog();
            this.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            fManageProduct fManageProduct = new fManageProduct();
            this.Hide();
            fManageProduct.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            fLogin fm = new fLogin();
            fm.Show();
            fm.Hide();
        }
    }
}
