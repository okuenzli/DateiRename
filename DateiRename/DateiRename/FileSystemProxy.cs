using System;
using System.Collections.Generic;
using System.IO;

namespace DateiRename
{
    internal class FileSystemProxy : IFileSystemProxy
    {
        public IEnumerable<FileInfo> GetAllFilesInDirectory(string path, string filter)
        {
            var directoryInfo = new DirectoryInfo(path);

            return directoryInfo.EnumerateFiles(filter);
        }

        public void Rename(string originalDirectoryName, string originalName, string newDirectoryName, string newFilename)
        {
            File.Move(
                Path.Combine(originalDirectoryName, originalName), 
                Path.Combine(newDirectoryName, newFilename));
        }

        public void CreateFolderIfNotExists(string fullName)
        {
            Directory.CreateDirectory(fullName);
        }
    }
}
