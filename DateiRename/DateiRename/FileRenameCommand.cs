using System.IO;

namespace DateiRename
{
    public class FileRenameCommand
    {
        readonly IFileSystemProxy _fileSystemProxy;
        readonly IImageProcessor _imageProcessor;
        readonly IFileNameFormatter _fileNameFormatter;
        readonly IDirectoryNameFormatter _directoryNameFormatter;

        public FileRenameCommand(IFileSystemProxy fileSystemProxy, IImageProcessor imageProcessor, IFileNameFormatter fileNameFormatter, IDirectoryNameFormatter directoryNameFormatter)
        {
            _directoryNameFormatter = directoryNameFormatter;
            _fileNameFormatter = fileNameFormatter;
            _imageProcessor = imageProcessor;
            _fileSystemProxy = fileSystemProxy;
        }

        public void Execute(string path, string filter)
        {
            var files = _fileSystemProxy.GetAllFilesInDirectory(path, filter);
            foreach (FileInfo file in files)
            {
                try
                {
                    string newFilename;
                    string newDirectoryname;
                    using (FileStream fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
                    {
                        var dateTaken = _imageProcessor.GetDateTakenFromImage(fileStream);
                        newFilename = _fileNameFormatter.FormatFileName(file.Name, dateTaken);
                        newDirectoryname = _directoryNameFormatter.FormatDirectoryName(file.DirectoryName, dateTaken);
                    }
                    _fileSystemProxy.CreateFolderIfNotExists(newDirectoryname);
                    _fileSystemProxy.Rename(file.DirectoryName, file.Name, newDirectoryname, newFilename);

                }
                catch
                {
                }
            }
        }
    }
}
