using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class UploadFileCommand(string _filePath ) : ICommand
    {
        private readonly string _filePath = _filePath;

        public string Execute()
        {
            //Write code to upload the file
            return FileReceiver.UploadFile(_filePath);
        }
    }
}
