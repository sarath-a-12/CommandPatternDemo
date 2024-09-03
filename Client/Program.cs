using Command;
namespace Client
{
    public class Program
    {
        static void Main()
        {
            ICommand uploadCommand = new UploadFileCommand("path/to/upload/file.txt");
            ICommand downloadCommand = new DownloadFileCommand("path/to/download/file.txt");
            ICommand deleteCommand = new DeleteFileCommand("path/to/delete/file.txt");

            FileOperationInvoker invoker = new();
            invoker.SetCommand("upload", uploadCommand);
            invoker.SetCommand("download", downloadCommand);
            invoker.SetCommand("delete", deleteCommand);

            invoker.ExecuteCommand("upload");
            invoker.ExecuteCommand("download");
            invoker.ExecuteCommand("delete");
        }
    }
}
