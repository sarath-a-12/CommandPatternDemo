using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class FileReceiver
    {
        public static string UploadFile(string FilePath)
        {
            return ("Uploading File to " + FilePath);
        }
        public static string DownloadFile( string FilePath)
        {
            return ("Downloading File to " + FilePath);
        }
        public static string DeleteFile(string FilePath)
        {
            return ("Deleting File from " + FilePath);
        }
    }
}
