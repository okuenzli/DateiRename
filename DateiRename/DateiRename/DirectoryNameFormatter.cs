using System;
using System.IO;

namespace DateiRename
{
    internal class DirectoryNameFormatter : IDirectoryNameFormatter
    {
        public string FormatDirectoryName(string originalDirectoryName, DateTime dateTaken)
        {
            return Path.Combine(originalDirectoryName, dateTaken.ToString("yyyy_MMMM"));
        }
    }
}
