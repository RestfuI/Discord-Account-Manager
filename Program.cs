using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Discord_Account_Manager
{
    static class Program
    {
        public static string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DAM (Discord Account Manager)";
        public static string discordData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord";

        public static string discordSessionStorage = discordData + "\\Session Storage";
        public static string discordLocalStorage = discordData + "\\Local Storage";
        public static string usersDirectory = baseDirectory + "\\users";
        public static string configDirectory = baseDirectory + "\\config";
        public static string configFile = configDirectory + "\\main.json";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /**
             * List for all of the Directories.
             * Note: Add All required directories to this list.
             */

            List<string> directories = new List<string>();

            directories.Add(baseDirectory);
            directories.Add(usersDirectory);
            directories.Add(configDirectory);

            /**
             * This will check if the directories exist and create them if they don't.
             */

            foreach (string directory in directories)
            {
                if (!Directory.Exists(directory))
                {
                    try
                    {
                        Directory.CreateDirectory(directory);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Failure:" + e.Message);
                    }
                }
            }

            /**
             * Condition to check if a user account has been created.
             */

            if (File.Exists(configFile) && File.ReadAllText(configFile).Contains("password"))
            {
                Application.Run(new Login(new Register()));
            } else {
                Application.Run(new Register());
            }
        }
    }
}
