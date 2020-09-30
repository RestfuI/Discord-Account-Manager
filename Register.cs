using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord_Account_Manager.Classes.Authentication;
using Newtonsoft.Json;
using bCrypt = BCrypt.Net.BCrypt;

namespace Discord_Account_Manager
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            register();
        }

        /**
         * This will take the user input and create an account.
         */
        private async void register()
        {
            /**
             * Check if 'usernameField' is null
             */

            if (usernameField.Text == "")
            {
                usernameLabel.ForeColor = Color.FromArgb(240, 71, 71);
                usernameLabel.Text = "USERNAME - This field is required";

                await Task.Delay(1500);

                usernameLabel.ForeColor = Color.FromArgb(142, 146, 151);
                usernameLabel.Text = "USERNAME";
            }

            /**
             * Check if 'passwordField' is null
             */

            if (passwordField.Text == "")
            {
                passwordLabel.ForeColor = Color.FromArgb(240, 71, 71);
                passwordLabel.Text = "PASSWORD - This field is required";

                await Task.Delay(1500);

                passwordLabel.ForeColor = Color.FromArgb(142, 146, 151);
                passwordLabel.Text = "PASSWORD";
                return;
            }

            /**
             * Check if 'usernameField' is <= 5
             */

            if (usernameField.Text.Length <= 5)
            {
                usernameLabel.ForeColor = Color.FromArgb(240, 71, 71);
                usernameLabel.Text = "USERNAME - This must be greater than 5 characters";

                await Task.Delay(1500);

                usernameLabel.ForeColor = Color.FromArgb(142, 146, 151);
                usernameLabel.Text = "USERNAME";

                return;
            }

            /**
             * Check if 'passwordField' is <= 5
             */

            if (passwordField.Text.Length <= 5)
            {
                passwordLabel.ForeColor = Color.FromArgb(240, 71, 71);
                passwordLabel.Text = "PASSWORD - This must be greater than 5 characters";

                await Task.Delay(1500);

                passwordLabel.ForeColor = Color.FromArgb(142, 146, 151);
                passwordLabel.Text = "PASSWORD";

                return;
            }

            Client client = new Client();

            client.username = usernameField.Text;
            client.password = bCrypt.HashPassword(passwordField.Text);
            client.created = DateTime.Now.ToString(@"dd\/MM\/yyyy hh:mm tt");

            File.WriteAllText(Program.configFile, JsonConvert.SerializeObject(client, Formatting.Indented));

            /**
             * TODO: Add Notification
             */

            Login login = new Login(this);
            login.Show();
            this.Hide();
        }

        /**
         * githubLinkLabel Click event
         */

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RestfuI/Discord-Account-Manager/");
        }
    }
}
