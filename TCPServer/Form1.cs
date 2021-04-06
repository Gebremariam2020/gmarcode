using SimpleTcp;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GroupChatAppDBEntities db = new GroupChatAppDBEntities();
        SimpleTcpServer server;
        private void btnStart_Click(object sender, EventArgs e)
        {
           // Form1 form = new Form1(txtInfo.Text);

            try
            {
                server.Start();
                txtInfo.Text += $"Starting...{Environment.NewLine}";
                btnStart.Enabled = false;
                btnSend.Enabled = true;

            }
            catch (Exception msg)
            {
                MessageBox.Show("Error: " + msg.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataRecieved;

            txtInfo.Text = DashBoard.passingText;
        }

        private void Events_DataRecieved(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} Disconnected. {Environment.NewLine}";
            listBoxClientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            { 
                txtInfo.Text += $"{e.IpPort} Connected. {Environment.NewLine}";
                listBoxClientIP.Items.Add(e.IpPort);

            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                if (server.IsListening)
                {
                    if (!string.IsNullOrEmpty(txtMessage.Text) && listBoxClientIP.SelectedItem != null)
                    {
                        server.Send(listBoxClientIP.SelectedItem.ToString(), txtMessage.Text);
                        txtInfo.Text += $"Server: {txtMessage.Text}{Environment.NewLine}";

                        //var msg = new Sending_Message_Collection_Table
                        //{
                        //    Sending_msg = txtMessage.Text,
                        //    User_Code = LoginForm.vCodeLogin,
                        //};
                        //db.Sending_Message_Collection_Table.Add(msg);
                        //txtMessage.Text = string.Empty;
                        //MessageBox.Show("insereted successfuly");

                        txtMessage.Text = string.Empty;
                    }
                }

            }
            catch (Exception es)
            {

                MessageBox.Show("error message"+es.ToString());
            }   
        }
    }
}
