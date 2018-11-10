using System.Collections.Generic;
using System.IO;

namespace DateiRename
{
    public interface IFileSystemProxy
    {
        IEnumerable<FileInfo> GetAllFilesInDirectory(string path, string filter);
        void Rename(string directoryName, string name, string newDirectoryName, string newFilename);
        void CreateFolderIfNotExists(string fullName);
    }
}