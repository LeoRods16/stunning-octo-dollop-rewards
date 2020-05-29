using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Spin_Demo.iOS
{
    public static class SaveIconLocalStorage
    {
        public static string CopyFileIfNotExists(string fileName, string fileType)
        {
            try
            {
                var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var path = Path.Combine(documentsPath, fileName);
                if (!File.Exists(path))
                {
                    var existingDb = NSBundle.MainBundle.PathForResource(fileName, fileType);
                    File.Copy(existingDb, path);
                }
                return path;
            }
            catch (Exception ex)
            {
            }
            return string.Empty;
        }
    }
}