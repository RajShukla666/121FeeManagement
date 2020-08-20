using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _121FeeManagement
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        public static string userName = "blanck";
        public static string password = "opopopopop";
        StringBuilder asb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "") { UsernameErrorLable.Visible = true; } else { UsernameErrorLable.Visible = false; }
            if (PasswordTxt.Text == "") { PasswordErrorLabe.Visible = true; } else { PasswordErrorLabe.Visible = false; }
            if (FirstNameTxt.Text == "") { FirstNameErrorLable.Visible = true; } else { FirstNameErrorLable.Visible = false; }
            if (LastNameTxt.Text == "") { LastNameErrorLable.Visible = true; } else { LastNameErrorLable.Visible = false; }
            if (ConfirmPassword.Text == "") { CPassErrorLable.Visible = true; } else { CPassErrorLable.Visible = false; }
            if (UsernameErrorLable.Visible || PasswordErrorLabe.Visible || FirstNameErrorLable.Visible || LastNameErrorLable.Visible || CPassErrorLable.Visible)
            {
                MessageBox.Show("Feilds with * are mendatory");
            }
            else
            {
                asb.Append("First Name = " + FirstNameTxt.Text + ", Last Name = " + LastNameTxt.Text + ", Username = " + UsernameTxt.Text + ", Password = " + PasswordTxt.Text);
                File.WriteAllText(mainClass.path + "\\cnt", asb.ToString());
                UsernameTxt.Text = userName;
                PasswordTxt.Text = password;
                if (PasswordTxt.Text != ConfirmPassword.Text)
                {
                    MessageBox.Show("Password And Confirm Password Is Not Matched");
                }

                DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    Login log = new Login();
                    mainClass.ShowWindow(log, this, MDI.ActiveForm);
                }
            }
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}
