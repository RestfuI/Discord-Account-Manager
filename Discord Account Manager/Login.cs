using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using bCrypt = BCrypt.Net.BCrypt;
using Newtonsoft.Json;
using Discord_Account_Manager.Classes.Authentication;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Discord_Account_Manager
{
    public partial class Login : Form
    {
        Register register;
        public Login(Register parentForm)
        {
            InitializeComponent();
            register = parentForm;
        }

        Client client = new Client();

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        /**
         * This will take the users input and handle validation.
         */
        private async void login()
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
             * Read login config file contents.
             */

            string loginData = File.ReadAllText(Program.configFile);

            /**
             * Deserialization
             */

            client = JsonConvert.DeserializeObject<Client>(loginData);

            /**
             * Check if usernames match.
             */
            if (usernameField.Text.ToLower() != client.username.ToLower())
            {
                usernameLabel.ForeColor = Color.FromArgb(240, 71, 71);
                usernameLabel.Text = "USERNAME - Username does not match.";

                await Task.Delay(1500);

                usernameLabel.ForeColor = Color.FromArgb(142, 146, 151);
                usernameLabel.Text = "USERNAME";

                return;
            }

            /**
             * Check if passwords match.
             */

            if (bCrypt.Verify(passwordField.Text, client.password))
            {
                /**
                 * TODO: Add Notification
                 */

                Manage manage = new Manage(this);
                manage.Show();
                this.Hide();
            }
            else
            {

                passwordLabel.ForeColor = Color.FromArgb(240, 71, 71);
                passwordLabel.Text = "PASSWORD - Password does not match.";

                await Task.Delay(1500);

                passwordLabel.ForeColor = Color.FromArgb(142, 146, 151);
                passwordLabel.Text = "PASSWORD";

                return;
            }
        }

        /**
         * 'githubLinkLabel' Click event
         */

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RestfuI/Discord-Account-Manager/");
        }

        /**
         * 'exitLabel' Click event.
         */
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
