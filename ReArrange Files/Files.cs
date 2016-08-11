using System.IO;

namespace ReArrange_Files
{
    public static class Files
    {
        public static void MakeFolders(string path)
        {
            // To Get All Files In Directory
            string[] files = Directory.GetFiles(path);
            string folderName; // declare varible will hold a new Folder name
            string tempFolderNum;// declare varible to hold folder number
            //loop through each file in directory
            foreach (var file in files)
            {
                /*
                 * as we mentioned that we can find folder name in the begging in the file name
                 * so we take it 
                 */
                folderName = file.Substring(0, file.IndexOf('-') - 1);
                //take a number of the folder from the file name 
                tempFolderNum = file.Remove(file.LastIndexOf('.'));
                tempFolderNum = tempFolderNum.Substring(tempFolderNum.LastIndexOf('m') + 1, 1) + " - ";
                //We Insert The Folder Number from the file name
                folderName = folderName.Insert(folderName.LastIndexOf(@"\") + 1, tempFolderNum);
                /* 
                 * check if the directory of folder dosen't  exsis to create it
                 * we get the directory from file name then we add a new folderName to it
                 */
                if (!Directory.Exists(Path.GetDirectoryName(file + @"\" + folderName)))
                {
                    Directory.CreateDirectory(folderName);
                }
            }
        }



        public static void MoveFilesToFolders(string path)
        {
            // To Get All Files In Directory
            string[] files = Directory.GetFiles(path);
            string newFolder;// declare varible will hold a path of files
            string tempFolderNum;// declare varible to hold folder number
            //loop through each file in directory
            foreach (var file in files)
            {
                /*
                 * C:\..\What Is Programming\The Rules of Programming Languages - Keywords....
                 * first we take a path of file from begging to firt - that will represent 
                 *                      the folder minus 1 because of  space in the end of path
                 * then we will add the folder number as we do in the folder naming 
                 * then we will add file name to it 
                 * so will looklike this   "FullPath\folder\file"
                 */
                //take a number of the folder from the file name 
                tempFolderNum = file.Remove(file.LastIndexOf('.'));
                tempFolderNum = tempFolderNum.Substring(tempFolderNum.LastIndexOf('m') + 1, 1) + " - ";
                newFolder = file.Substring(0, file.IndexOf('-') - 1);
                newFolder = newFolder.Insert(newFolder.LastIndexOf(@"\") + 1, tempFolderNum);
                newFolder += @"\" + file.Substring(file.LastIndexOf(@"\") + 1);
                //Move the file to new Folder
                File.Move(file, newFolder);
            }
        }


        public static void ReArrangeFiles(string FilePath)
        {
            // To Get All Files In Directory
            string[] files = Directory.GetFiles(FilePath);
            string NewFileName; // declare varible will hold a new name of the file 
            //loop through each file in directory
            foreach (var file in files)
            {
                /*
                 * General Case of the file name will be like this  Folder Name - File Name -mXX-XX .mp4
                 * mXX will represent folder name or set of releated files , -XX the file number in series 
                 * here we take the file name from the full path and without extension '.*'
                 */
                NewFileName = file.Substring(file.LastIndexOf(@"\") + 1, file.LastIndexOf('.') - file.LastIndexOf(@"\") - 1);
                //Remove the folder name from downloaded file 
                NewFileName = NewFileName.Substring(NewFileName.IndexOf('-') + 1);
                // copy file number and move it to the beggining of the file name
                NewFileName = NewFileName.Substring(NewFileName.LastIndexOf('m')) + "- " + NewFileName;
                //remove the file name from the end of file
                NewFileName = NewFileName.Remove(NewFileName.LastIndexOf('m') - 1);
                //In C# we can move cause we don't have rename , replace old path with new path and new file name and add extension
                File.Move(file, Path.GetDirectoryName(file) + @"\" + NewFileName + ".mp4");
            }
        }
    }
}
