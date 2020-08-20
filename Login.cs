using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _121FeeManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "") { UsernameErrorLable.Visible = true; } else { UsernameErrorLable.Visible = false; }
            if (PasswordTxt.Text == "") { PasswordErrorLabe.Visible = true; } else { PasswordErrorLabe.Visible = false; }
            if (UsernameErrorLable.Visible || PasswordErrorLabe.Visible)
            {
                MessageBox.Show("Feilds with * are mendatory");
            }
            else if (UsernameTxt.Text != signUp.userName)
            {
                MessageBox.Show("Wrong UserName");
            }
            else if (PasswordTxt.Text != signUp.password)
            {
                MessageBox.Show("Wrong Password");
            }
            if(UsernameTxt.Text == signUp.userName && PasswordTxt.Text == signUp.password)
            {
                homeWindow hom = new homeWindow();
                mainClass.ShowWindow(hom, this, MDI.ActiveForm);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "") { UsernameErrorLable.Visible = true; } else { UsernameErrorLable.Visible = false; }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "") { PasswordErrorLabe.Visible = true; } else { PasswordErrorLabe.Visible = false; }
        }
    }
}
