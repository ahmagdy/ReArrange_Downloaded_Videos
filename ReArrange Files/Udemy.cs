using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReArrange_Files
{
    public static class Udemy
    {
        public static void ReArrangeFilesFromUdemySite(string path)
        {
            var files = Directory.GetFiles(path);
            string name;
            foreach (var file in files)
            {
                name = file.Substring(file.LastIndexOf(@"\") + 1);
                name = name.Substring(name.LastIndexOf('-') + 1, name.LastIndexOf('.') - name.LastIndexOf('-') - 1) + " - " + name;
                name = name.Remove(name.LastIndexOf('-'), (name.LastIndexOf('.') - name.LastIndexOf('-')));
                File.Move(file, Path.GetDirectoryName(file) + @"\" + name);
            }
            MessageBox.Show("Done");
        }
    }
}
