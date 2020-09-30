using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Discord_Account_Manager.Classes.Utilities;
using System.Diagnostics;

namespace Discord_Account_Manager
{
    public partial class Manage : Form
    {
        public List<string> accounts = new List<string>(Directory.GetDirectories(Program.usersDirectory));
        public Utilities utils = new Utilities();

        Login login;
        public Manage(Login parentForm)
        {
            login = parentForm;
            InitializeComponent();
            loadAccounts();
        }

        /**
         * This will load all the accounts saved.
         */

        void loadAccounts()
        {
            foreach (string account in accounts)
            {
                DirectoryInfo dInfo = new DirectoryInfo(account);

                accountListBox.Items.Add(dInfo.Name);
            }
        }

        /**
         * This will remove the selected account from the list and remove any files related to it.
         */

        void removeAccount()
        {
            if (accountListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an account you'd like to remove.");
                return;
            }

            Directory.Delete(Program.usersDirectory + "\\" + accountListBox.SelectedItem, true);
            accountListBox.Items.Remove(accountListBox.SelectedItem);
        }

        /**
         * This will add the Discord Account the user is logged into to the Manager.
         */

        async void addAccount()
        {
            /**
             * Check if the user is signed into a Discord Account.
             */

            if (Directory.GetFiles(Program.discordLocalStorage + "\\leveldb").Length <= 5)
            {
                MessageBox.Show("You're not logged in to your Discord account. Please login and try again!");

                return;
            }

            /**
             * Check if 'accountNameField' is null
             */

            if (accountNameField.Text == "")
            {
                accountNameLabel.ForeColor = Color.FromArgb(240, 71, 71);
                accountNameLabel.Text = "ACCOUNT NAME - This field is required!";

                await Task.Delay(1500);

                accountNameLabel.ForeColor = Color.FromArgb(142, 146, 151);
                accountNameLabel.Text = "ACCOUNT NAME";

                return;
            }

            /**
             * Check if 'accountNameField' is < 4
             */
            
            if (accountNameField.Text.Length <= 4)
            {
                accountNameLabel.ForeColor = Color.FromArgb(240, 71, 71);
                accountNameLabel.Text = "ACCOUNT NAME - This must be greater than 4 characters!";

                await Task.Delay(1500);

                accountNameLabel.ForeColor = Color.FromArgb(142, 146, 151);
                accountNameLabel.Text = "ACCOUNT NAME";

                return;
            }

            /**
             * Check if 'accountListBox' has an existing record with the same name.
             */

            if (accountListBox.FindString(accountNameField.Text) != -1)
            {
                accountNameLabel.ForeColor = Color.FromArgb(240, 71, 71);
                accountNameLabel.Text = "ACCOUNT NAME - This name already exists!";

                await Task.Delay(1500);

                accountNameLabel.ForeColor = Color.FromArgb(142, 146, 151);
                accountNameLabel.Text = "ACCOUNT NAME";

                return;
            }

            string accountNamePath = Program.usersDirectory + "\\" + accountNameField.Text;

            Directory.CreateDirectory(accountNamePath);
            Directory.CreateDirectory(accountNamePath + "\\Session Storage");
            Directory.CreateDirectory(accountNamePath + "\\Local Storage");
            Directory.CreateDirectory(accountNamePath + "\\Local Storage\\leveldb");

            utils.copyFiles(Program.discordData + "\\Session Storage", accountNamePath + "\\Session Storage");
            utils.copyFiles(Program.discordData + "\\Local Storage\\leveldb", accountNamePath + "\\Local Storage\\leveldb");

            accountListBox.Items.Add(accountNameField.Text);
            accountNameField.ResetText();

        }

        /**
         * 'removeAccountButton' Click event.
         */

        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            removeAccount();
        }

        /**
         * 'addAccountButton' Click event.
         */

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            addAccount();
        }

        /**
         * 'loginButton' Click event.
         */

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (accountListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an account you'd like to login as!");
                return;
            }

            Process[] discord = Process.GetProcessesByName("discord");

            if (discord.Length != 0)
            {
                MessageBox.Show("Discord will now close and reopen");

                foreach (Process process in discord)
                {
                    process.Kill();
                }
            }

            await Task.Delay(5000);

            if (Directory.Exists(Program.discordLocalStorage)) Directory.Delete(Program.discordLocalStorage, true);
            if (Directory.Exists(Program.discordSessionStorage)) Directory.Delete(Program.discordSessionStorage, true);

            string accountPath = Program.usersDirectory + "\\" + accountListBox.SelectedItem;

            Directory.CreateDirectory(Program.discordLocalStorage);
            Directory.CreateDirectory(Program.discordLocalStorage + "\\leveldb");
            Directory.CreateDirectory(Program.discordSessionStorage);

            utils.copyFiles(accountPath + "\\Local Storage\\leveldb", Program.discordLocalStorage + "\\leveldb");
            utils.copyFiles(accountPath + "\\Session Storage", Program.discordSessionStorage);


            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Discord\\Update.exe", "--processStart Discord.exe");
        }

        /**
         * 'exitLabel' Click event.
         */

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * githubLinkLabel Click event
         */

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RestfuI/Discord-Account-Manager/");
        }

        /**
         * 'minLabel' Click event
         */

        private void minLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
