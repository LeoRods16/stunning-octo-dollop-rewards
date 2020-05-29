using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Spin_Demo.Droid
{
    public static class SaveIconLocalStorage
    {
        public static string CopyFileIfNotExists(string filename)
        {
            try
            {
                string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
                var libraryPath = Path.Combine(documentsPath, "..", "Icons");

                if (!Directory.Exists(libraryPath))
                {
                    Directory.CreateDirectory(libraryPath);
                }

                var path = Path.Combine(libraryPath, filename);

                //if (!Directory.Exists(dbPath))
                //    Directory.CreateDirectory(dbPath);

                if (!File.Exists(path))
                {
                    using (var br = new BinaryReader(Android.App.Application.Context.Assets.Open(filename)))
                    {
                        using (var bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
                        {
                            byte[] buffer = new byte[2048];
                            int length = 0;
                            while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                bw.Write(buffer, 0, length);
                            }
                        }
                    }
                    return path;
                }
                return path;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
            return string.Empty;
        }
    }
}