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
    public partial class fPost : Form
    {
        public fPost()
        {
            InitializeComponent();
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
