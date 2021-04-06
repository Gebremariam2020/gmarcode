namespace TCPServer
{
    partial class CreateGroup
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtVCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Verification Code";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtVCode
            // 
            this.txtVCode.Location = new System.Drawing.Point(203, 254);
            this.txtVCode.Multiline = true;
            this.txtVCode.Name = "txtVCode";
            this.txtVCode.Size = new System.Drawing.Size(188, 35);
            this.txtVCode.TabIndex = 20;
            this.txtVCode.TextChanged += new System.EventHandler(this.txtPhonNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descriptioin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(203, 213);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 35);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(306, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Group Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(203, 167);
            this.txtGroupName.Multiline = true;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(188, 35);
            this.txtGroupName.TabIndex = 15;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(433, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreateGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCreateGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCreateGroup.Location = new System.Drawing.Point(194, 312);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(76, 31);
            this.btnCreateGroup.TabIndex = 13;
            this.btnCreateGroup.Text = "Save";
            this.btnCreateGroup.UseVisualStyleBackColor = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCPServer.Properties.Resources.group_icon;
            this.pictureBox1.Location = new System.Drawing.Point(183, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(483, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}