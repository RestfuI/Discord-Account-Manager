using System.IO;

namespace Discord_Account_Manager.Classes.Utilities
{
    public class Utilities
    {
        /**
         * This will copy all files within the 'sourceDir' to the 'targetDir'
         */
        public void copyFiles(string sourceDir, string targetDir)
        {
            if (!Directory.Exists(targetDir)) Directory.CreateDirectory(targetDir);

            string[] filePaths = Directory.GetFiles(sourceDir);

            foreach (string file in filePaths)
            {
                string name = Path.GetFileName(file);
                File.Copy(file, targetDir + "\\" + name);
            }
        }

        /**
         * TODO: Write Method.
         */
        public void copyDirectory(bool recursive)
        {
            //...
        }
    }
}
