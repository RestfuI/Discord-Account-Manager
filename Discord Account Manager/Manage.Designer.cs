namespace Discord_Account_Manager
{
    partial class Manage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.accountNameField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.addAccountButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.removeAccountButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.minLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // accountListBox
            // 
            this.accountListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.accountListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountListBox.Font = new System.Drawing.Font("Whitney", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountListBox.ForeColor = System.Drawing.Color.White;
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.ItemHeight = 15;
            this.accountListBox.Location = new System.Drawing.Point(23, 46);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(349, 347);
            this.accountListBox.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.topPanel.Controls.Add(this.minLabel);
            this.topPanel.Controls.Add(this.exitLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(793, 21);
            this.topPanel.TabIndex = 1;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Font = new System.Drawing.Font("Whitney Light", 8.999999F);
            this.exitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.exitLabel.Location = new System.Drawing.Point(776, 1);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(13, 14);
            this.exitLabel.TabIndex = 16;
            this.exitLabel.Text = "x";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // accountNameField
            // 
            this.accountNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.accountNameField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.accountNameField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.accountNameField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.accountNameField.BorderThickness = 1;
            this.accountNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accountNameField.Font = new System.Drawing.Font("Whitney Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameField.ForeColor = System.Drawing.Color.White;
            this.accountNameField.isPassword = false;
            this.accountNameField.Location = new System.Drawing.Point(378, 172);
            this.accountNameField.Margin = new System.Windows.Forms.Padding(4);
            this.accountNameField.Name = "accountNameField";
            this.accountNameField.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.accountNameField.Size = new System.Drawing.Size(399, 39);
            this.accountNameField.TabIndex = 12;
            this.accountNameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountNameLabel.Font = new System.Drawing.Font("Whitney Light", 7.999999F);
            this.accountNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.accountNameLabel.Location = new System.Drawing.Point(377, 156);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(91, 12);
            this.accountNameLabel.TabIndex = 13;
            this.accountNameLabel.Text = "ACCOUNT NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Whitney Light", 17F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(376, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "ACCOUNT MANAGER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Whitney Light", 8.999998F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(378, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "HERE YOU CAN ADD / REMOVE ACCOUNTS";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.topPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
            this.addAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.addAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAccountButton.BorderRadius = 1;
            this.addAccountButton.ButtonText = "Add Account";
            this.addAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAccountButton.DisabledColor = System.Drawing.Color.Gray;
            this.addAccountButton.Font = new System.Drawing.Font("Whitney Semibold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addAccountButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("addAccountButton.Iconimage")));
            this.addAccountButton.Iconimage_right = null;
            this.addAccountButton.Iconimage_right_Selected = null;
            this.addAccountButton.Iconimage_Selected = null;
            this.addAccountButton.IconMarginLeft = 0;
            this.addAccountButton.IconMarginRight = 0;
            this.addAccountButton.IconRightVisible = false;
            this.addAccountButton.IconRightZoom = 0D;
            this.addAccountButton.IconVisible = false;
            this.addAccountButton.IconZoom = 90D;
            this.addAccountButton.IsTab = false;
            this.addAccountButton.Location = new System.Drawing.Point(379, 227);
            this.addAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.addAccountButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
            this.addAccountButton.OnHoverTextColor = System.Drawing.Color.White;
            this.addAccountButton.selected = false;
            this.addAccountButton.Size = new System.Drawing.Size(400, 46);
            this.addAccountButton.TabIndex = 16;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addAccountButton.Textcolor = System.Drawing.Color.White;
            this.addAccountButton.TextFont = new System.Drawing.Font("Whitney Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // removeAccountButton
            // 
            this.removeAccountButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.removeAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.removeAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeAccountButton.BorderRadius = 1;
            this.removeAccountButton.ButtonText = "Remove Account";
            this.removeAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeAccountButton.DisabledColor = System.Drawing.Color.Gray;
            this.removeAccountButton.Font = new System.Drawing.Font("Whitney Semibold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAccountButton.Iconcolor = System.Drawing.Color.Transparent;
            this.removeAccountButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("removeAccountButton.Iconimage")));
            this.removeAccountButton.Iconimage_right = null;
            this.removeAccountButton.Iconimage_right_Selected = null;
            this.removeAccountButton.Iconimage_Selected = null;
            this.removeAccountButton.IconMarginLeft = 0;
            this.removeAccountButton.IconMarginRight = 0;
            this.removeAccountButton.IconRightVisible = false;
            this.removeAccountButton.IconRightZoom = 0D;
            this.removeAccountButton.IconVisible = false;
            this.removeAccountButton.IconZoom = 90D;
            this.removeAccountButton.IsTab = false;
            this.removeAccountButton.Location = new System.Drawing.Point(379, 289);
            this.removeAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeAccountButton.Name = "removeAccountButton";
            this.removeAccountButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.removeAccountButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.removeAccountButton.OnHoverTextColor = System.Drawing.Color.White;
            this.removeAccountButton.selected = false;
            this.removeAccountButton.Size = new System.Drawing.Size(400, 46);
            this.removeAccountButton.TabIndex = 17;
            this.removeAccountButton.Text = "Remove Account";
            this.removeAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeAccountButton.Textcolor = System.Drawing.Color.White;
            this.removeAccountButton.TextFont = new System.Drawing.Font("Whitney Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.removeAccountButton.Click += new System.EventHandler(this.removeAccountButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.BorderRadius = 1;
            this.loginButton.ButtonText = "Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Font = new System.Drawing.Font("Whitney Semibold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = false;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = false;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(379, 347);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(400, 46);
            this.loginButton.TabIndex = 18;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Whitney Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.githubLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubLinkLabel.Font = new System.Drawing.Font("Whitney Light", 9.25F, System.Drawing.FontStyle.Bold);
            this.githubLinkLabel.LinkColor = System.Drawing.Color.White;
            this.githubLinkLabel.Location = new System.Drawing.Point(20, 400);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(269, 15);
            this.githubLinkLabel.TabIndex = 19;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "Github Repository - Discord Account Manager";
            this.githubLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLinkLabel_LinkClicked);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Whitney Light", 8.999999F);
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.minLabel.Location = new System.Drawing.Point(759, 2);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(11, 14);
            this.minLabel.TabIndex = 17;
            this.minLabel.Text = "-";
            this.minLabel.Click += new System.EventHandler(this.minLabel_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(793, 424);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.removeAccountButton);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.accountNameField);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.accountListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage";
            this.Text = "Manage";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ListBox accountListBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox accountNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label exitLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuFlatButton removeAccountButton;
        private Bunifu.Framework.UI.BunifuFlatButton addAccountButton;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.Label minLabel;
    }
}