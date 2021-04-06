namespace TCPServer
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeftVertical = new System.Windows.Forms.Panel();
            this.btnCreateGroups = new System.Windows.Forms.Button();
            this.listBoxGroupList = new System.Windows.Forms.ListBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLeftVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftVertical
            // 
            this.panelLeftVertical.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeftVertical.Controls.Add(this.btnCreateGroups);
            this.panelLeftVertical.Controls.Add(this.listBoxGroupList);
            this.panelLeftVertical.Controls.Add(this.btnChat);
            this.panelLeftVertical.Controls.Add(this.picBoxUser);
            this.panelLeftVertical.Controls.Add(this.btnSlide);
            this.panelLeftVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftVertical.Location = new System.Drawing.Point(0, 0);
            this.panelLeftVertical.Name = "panelLeftVertical";
            this.panelLeftVertical.Size = new System.Drawing.Size(177, 483);
            this.panelLeftVertical.TabIndex = 0;
            // 
            // btnCreateGroups
            // 
            this.btnCreateGroups.BackColor = System.Drawing.Color.Turquoise;
            this.btnCreateGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCreateGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateGroups.Location = new System.Drawing.Point(0, 136);
            this.btnCreateGroups.Name = "btnCreateGroups";
            this.btnCreateGroups.Size = new System.Drawing.Size(177, 55);
            this.btnCreateGroups.TabIndex = 12;
            this.btnCreateGroups.Text = "Create Group";
            this.btnCreateGroups.UseVisualStyleBackColor = false;
            this.btnCreateGroups.Click += new System.EventHandler(this.btnCreateGroups_Click);
            // 
            // listBoxGroupList
            // 
            this.listBoxGroupList.FormattingEnabled = true;
            this.listBoxGroupList.Location = new System.Drawing.Point(12, 256);
            this.listBoxGroupList.Name = "listBoxGroupList";
            this.listBoxGroupList.Size = new System.Drawing.Size(159, 225);
            this.listBoxGroupList.TabIndex = 11;
            this.listBoxGroupList.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupList_SelectedIndexChanged);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.Turquoise;
            this.btnChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(0, 197);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(177, 55);
            this.btnChat.TabIndex = 10;
            this.btnChat.Text = "Start Chat";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click_1);
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.Color.Wheat;
            this.picBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxUser.Location = new System.Drawing.Point(0, 40);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(177, 91);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 8;
            this.picBoxUser.TabStop = false;
            this.picBoxUser.Click += new System.EventHandler(this.picBoxUser_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Image = global::TCPServer.Properties.Resources.group_icon;
            this.btnSlide.Location = new System.Drawing.Point(0, 1);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(60, 34);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlide.TabIndex = 1;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.CadetBlue;
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.btnNormal);
            this.PanelTop.Controls.Add(this.btnMaximize);
            this.PanelTop.Controls.Add(this.btnMinimize);
            this.PanelTop.Controls.Add(this.btnClose);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(177, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(827, 33);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server Page";
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.White;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.Color.Black;
            this.btnNormal.Location = new System.Drawing.Point(733, 1);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(46, 36);
            this.btnNormal.TabIndex = 8;
            this.btnNormal.Text = "Nor";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.Location = new System.Drawing.Point(733, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(46, 29);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.Text = "Max";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(691, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 35);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "Min";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(777, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(990, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 450);
            this.panel1.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(177, 33);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(813, 450);
            this.panelCenter.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(177, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 16);
            this.panel3.TabIndex = 3;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.panelLeftVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.panelLeftVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftVertical;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.ListBox listBoxGroupList;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGroups;
    }
}