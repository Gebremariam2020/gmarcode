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

namespace TCPServer
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        GroupChatAppDBEntities db = new GroupChatAppDBEntities();
        public static string vcode = "appfact";

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public void VerficationGenerate()
        {
            var result = from s in db.User_Table select s.Verification_Code;
            int verify = result.Count();
            int i = Convert.ToInt32(verify);
            i++;
            lbl_Verfication.Text = vcode + i.ToString();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                VerficationGenerate();
                byte[] file_byte = ImageToByteArray(picBoxUserProfile.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                var st = new User_Table()
                {

                    First_Name = txtFName.Text,
                    Middle_Name = txtMName.Text,
                    Last_Name = txtLName.Text,
                    // Phone_Number = decimal.Parse(txtPhonNo.Text),
                    Verification_Code = lbl_Verfication.Text,
                    Profile_Picture = file_binary.ToArray(),

                };
                db.User_Table.Add(st);
                db.SaveChanges();
                MessageBox.Show("Account has been created !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
                var query = from a in db.User_Table
                            where a.Verification_Code == lbl_Verfication.Text
                            select a;
                foreach (var c in query)
                {
                    vcode = c.Verification_Code;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void picBoxUserProfile_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                open.Filter = "(*.jpg; *.jpeg; *.bmp, *.png)|*.jpg; *.jpeg; *.bmp, *.png ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(open.FileName);
                }
            }
        }
        public void Clear()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
