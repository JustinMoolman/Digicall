using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.IO;
using Xamarin.Forms;
using DigicallTest.LocalDatabase;
using DigicallTest.iOS;

[assembly : Dependency(typeof(LocalFileHelper))]
namespace DigicallTest.iOS
{
    public class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Database");
            if(!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, fileName);
        }
    }
}