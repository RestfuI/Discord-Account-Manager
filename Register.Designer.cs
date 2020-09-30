namespace Discord_Account_Manager
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usernameField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Location = new System.Drawing.Point(81, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 333);
            this.panel1.TabIndex = 0;
            // 
            // registerButton
            // 
            this.registerButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerButton.BorderRadius = 1;
            this.registerButton.ButtonText = "Register";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.DisabledColor = System.Drawing.Color.Gray;
            this.registerButton.Font = new System.Drawing.Font("Whitney Semibold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.registerButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("registerButton.Iconimage")));
            this.registerButton.Iconimage_right = null;
            this.registerButton.Iconimage_right_Selected = null;
            this.registerButton.Iconimage_Selected = null;
            this.registerButton.IconMarginLeft = 0;
            this.registerButton.IconMarginRight = 0;
            this.registerButton.IconRightVisible = false;
            this.registerButton.IconRightZoom = 0D;
            this.registerButton.IconVisible = false;
            this.registerButton.IconZoom = 90D;
            this.registerButton.IsTab = false;
            this.registerButton.Location = new System.Drawing.Point(37, 255);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.registerButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.registerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.registerButton.selected = false;
            this.registerButton.Size = new System.Drawing.Size(284, 37);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Register";
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Textcolor = System.Drawing.Color.White;
            this.registerButton.TextFont = new System.Drawing.Font("Whitney Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Whitney Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 91);
            this.label2.TabIndex = 9;
            this.label2.Text = "Create an account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Whitney Light", 6.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.passwordLabel.Location = new System.Drawing.Point(35, 178);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 11);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Whitney Light", 6.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.usernameLabel.Location = new System.Drawing.Point(35, 109);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(56, 11);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "USERNAME";
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.passwordField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.passwordField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.passwordField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.passwordField.BorderThickness = 1;
            this.passwordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordField.Font = new System.Drawing.Font("Whitney Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.ForeColor = System.Drawing.Color.White;
            this.passwordField.isPassword = true;
            this.passwordField.Location = new System.Drawing.Point(37, 193);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(284, 39);
            this.passwordField.TabIndex = 4;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.usernameField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.usernameField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.usernameField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.usernameField.BorderThickness = 1;
            this.usernameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameField.Font = new System.Drawing.Font("Whitney Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.White;
            this.usernameField.isPassword = false;
            this.usernameField.Location = new System.Drawing.Point(37, 124);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(284, 39);
            this.usernameField.TabIndex = 3;
            this.usernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Whitney Light", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(734, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Copyright 2020 Restful\r\nLicenced under the Apache Licence  2.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Whitney Light", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(896, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "v1.0.0-rc.1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(972, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Create an Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordField;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton registerButton;
        private System.Windows.Forms.Label label1;
    }
}

