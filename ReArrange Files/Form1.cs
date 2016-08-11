using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace ReArrange_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PathTB_KeyDown(object sender, KeyEventArgs e)
        {
            // we will do everything after pressing Enter Button
            if (e.KeyCode == Keys.Enter)
            {
                //check If the directory that we entered in the textbox Exists
                if (Directory.Exists(PathTB.Text))
                {
                    //Check this radion box we will reOrganize a set files with moving it
                    if (radionFiles.Checked)
                    {
                        Files.ReArrangeFiles(PathTB.Text);
                        MessageBox.Show("Done");
                    }
                    //Check this radion box we will goto each folder in the directory and reOrganize files
                    else if (radioFolders.Checked)
                    {
                        //GET All Folders of Folder
                        var dirs = Directory.GetDirectories(PathTB.Text);
                        //Loop through each folder
                        foreach (var dir in dirs)
                        {
                            //reOrganize files of folder
                            Files.ReArrangeFiles(dir);
                        }
                        MessageBox.Show("Done");
                    }
                    //Check this radion box we will create folders and move files to it and Organize files
                    else if (radioTOFolders.Checked)
                    {
                        Files.MakeFolders(PathTB.Text);
                        Files.MoveFilesToFolders(PathTB.Text);
                        var dirs = Directory.GetDirectories(PathTB.Text);
                        foreach (var dir in dirs)
                        {
                            Files.ReArrangeFiles(dir);
                        }
                        MessageBox.Show("Done");
                    }
                    //user must check one of radion buttons
                    else
                    {
                        MessageBox.Show("Select type of Path");
                    }
                }
                //If we don't find the entered path
                else
                {
                    MessageBox.Show("Bad Path");
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.RootFolder = SpecialFolder.Desktop;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                PathTB.Text = fd.SelectedPath;
                MessageBox.Show("Choose any option from radion buttons then press enter on the textbox","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
