using Chợ_Đồ_Cũ.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chợ_Đồ_Cũ
{
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string USERNAME = txbFullName.Text;
            string DOB = dateBirth.Text;
            string SEX = txbSex.Text;
            string MSSV = txbMSSV.Text;
            string SCHOOL = txbSchool.Text;
            string PHONE = txbPhoneNum.Text;
            string USERS_NAME = txbUserName.Text;
            string PASS = txbPassWord.Text;
            string EMAIL = txbEmail.Text;
            Register(USERNAME, DOB, SEX, MSSV, SCHOOL, PHONE, USERS_NAME, PASS, EMAIL);
            /*if (Register(USERNAME, DOB, SEX, MSSV, SCHOOL, PHONE, USERS_NAME, PASS, EMAIL))
            {
                fLogin f = new fLogin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }*/
        }
        bool Register(string USERNAME, string DOB, string SEX, string MSSV, string SCHOOL,
        string PHONE, string USERS_NAME, string PASS, string EMAIL)
        {
            return RegisterDAO.Instance.Register(USERNAME, DOB, SEX, MSSV, SCHOOL, PHONE, USERS_NAME, PASS, EMAIL);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.Show();
            fLogin.Hide();
        }
    }   
    
}
