using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chợ_Đồ_Cũ.DAO
{
    public class RegisterDAO
    {
        private static RegisterDAO instance;
        public static RegisterDAO Instance
        {
            get { if (instance == null) instance = new RegisterDAO(); return instance; }
            private set { instance = value; }
        }

        private RegisterDAO() { }

        public bool Register(string USERNAME, string DOB, string SEX, string MSSV, string SCHOOL,
            string PHONE, string USERS_NAME, string PASS, string EMAIL)
        {
            string query = "USP_Register @Name, @DoB, @Sex, @MSSV, @School, @Phone, @UserName, @PassWord, @Email";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { USERNAME, DOB, SEX, MSSV, SCHOOL, PHONE, USERS_NAME, PASS, EMAIL });

            return result.Rows.Count > 0;
        }
    }
}
