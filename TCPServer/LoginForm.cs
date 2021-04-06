using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        GroupChatAppDBEntities chatDB = new GroupChatAppDBEntities();
        public static string vCodeLogin;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var query = from a in chatDB.User_Table
                            where a.Verification_Code == txtVerification.Text
                            select a;

                if (query.FirstOrDefault() != null)
                {
                    if (txtVerification.Text != "")
                    {
                        DashBoard f = new DashBoard();
                        f.Show();
                        this.Hide();
                        vCodeLogin = txtVerification.Text;
                    }
                    else
                        MessageBox.Show(" Invalid Verification code. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(" Incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("error: " + a.ToString());
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            CreateAccount acc = new CreateAccount();
            acc.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVerification.Text = "";
        }
    }
}
