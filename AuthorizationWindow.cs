using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataSet ds = DBUtils.ConnectToDB($"select * from users where login_user = '{loginBox.Text}' and password_user = '{passwordBox.Text}'");
            if (ds.Tables[0].Rows.Count>0)
            {
                MainWindow mw = new MainWindow(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                mw.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль не верны", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
