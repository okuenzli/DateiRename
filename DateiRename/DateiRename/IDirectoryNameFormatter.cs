using System;

namespace DateiRename
{
    public interface IDirectoryNameFormatter
    {
        string FormatDirectoryName(string originalDirectoryName, DateTime dateTaken);
    }
}