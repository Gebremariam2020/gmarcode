using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class DashBoard : Form
    {
        GroupChatAppDBEntities db = new GroupChatAppDBEntities();

        public DashBoard()
        {
            InitializeComponent();
            List();
        }
        public static string passingText;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int x, int y, int z);

        public void List()
        {
            var query = from a in db.Message_Table
                         where a.GroupName == a.GroupName
                        select a;
            foreach (var c in query)
            {
                 listBoxGroupList.Items.Add(c.GroupName);

            }
        }
        private void Display(object data)
        {
            if (this.panelCenter.Controls.Count > 0)
                this.panelCenter.Controls.RemoveAt(0);
            Form x = data as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.panelCenter.Controls.Add(x);
            this.panelCenter.Tag = x;
            x.Show();

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMaximize.BackColor = Color.White;
            btnNormal.BackColor = Color.Blue;
            btnMaximize.Visible = true;
            btnMinimize.Visible = true;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnMaximize.BackColor = Color.Blue;
            btnNormal.BackColor = Color.White;
            btnNormal.Visible = true;
            btnMinimize.Visible = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         

        private void btnChat_Click(object sender, EventArgs e)
        {
           // Display(new Form1());
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelLeftVertical.Width == 177 && picBoxUser.Width == 177 && btnCreateGroups.Width == 177)
            {
                panelLeftVertical.Width = 50;
                picBoxUser.Width = 50;
                btnCreateGroups.Width = 50;
            }
            else {
                panelLeftVertical.Width = 177;
                picBoxUser.Width = 177;
                btnCreateGroups.Width = 177;
            }

        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnChat_Click_1(object sender, EventArgs e)
        {
            Display(new Form1());
        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {
            Display(new UpdateAccount()); 
        }

        

        private void btnCreateGroups_Click(object sender, EventArgs e)
        {
            Display(new CreateGroup());

        }
        
        private void listBoxGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
             var query = from a in db.Message_Table
                        where a.Messages == a.Messages && a.GroupName == a.GroupName
                        select a;

            foreach (var c in query)
            {
                if (listBoxGroupList.SelectedItem.ToString() == c.GroupName.ToString())
                {

                    passingText = c.GroupName + " =>" + c.Messages;
 
                    Display(new Form1());
                     

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passingText = textBox1.Text;
            //Form1 f = new Form1();
            //f.Show();
        }
    }

     
}
