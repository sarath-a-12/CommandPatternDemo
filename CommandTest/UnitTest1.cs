using Command;
namespace CommandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeleteTester()
        {
            DeleteFileCommand deleter = new("C:/temp/users/notes.txt");
            Assert.AreEqual( "Deleting File from C:/temp/users/notes.txt" , deleter.Execute() );
        }

        [TestMethod]
        public void UpdateTester()
        {
            UploadFileCommand uploader = new("C:/temp/users/notes1.txt" );
            Assert.AreEqual( "Uploading File to C:/temp/users/notes1.txt" , uploader.Execute() );
        }

        [TestMethod]
        public void DownloadTester()
        {
            DownloadFileCommand downloader = new( "C:/temp/users/notes2.txt" );
            Assert.AreEqual( "Downloading File to C:/temp/users/notes2.txt" , downloader.Execute() );
        }
    }
}
