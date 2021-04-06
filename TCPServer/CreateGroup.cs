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
    public partial class CreateGroup : Form
    {
        public CreateGroup()
        {
            InitializeComponent();
        }
        GroupChatAppDBEntities db = new GroupChatAppDBEntities();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear() {
            txtVCode.Text = "";
            txtGroupName.Text = "";
            txtDescription.Text = "";
        }
        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            try
            {

                var st = new Message_Table()
                {
                    GroupName = txtGroupName.Text,
                    Messages = txtDescription.Text,
                    Verification_Code = LoginForm.vCodeLogin,
                };
                db.Message_Table.Add(st);
                db.SaveChanges();
                MessageBox.Show("Group has been created !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Field to create group. Please try again?" + ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPhonNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            txtVCode.Text = LoginForm.vCodeLogin;

        }
    }
}
