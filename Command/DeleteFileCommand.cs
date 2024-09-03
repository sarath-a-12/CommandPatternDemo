using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DeleteFileCommand(string _filePath ) : ICommand
    {
        private readonly string _filePath = _filePath;

        public string Execute()
        {
            //Write code to delete the file
            return FileReceiver.DeleteFile(_filePath);
        }
    }
}
