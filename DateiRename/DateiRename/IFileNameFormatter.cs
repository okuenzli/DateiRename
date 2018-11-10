using System;

namespace DateiRename
{
    public interface IFileNameFormatter
    {
        string FormatFileName(string originalFileName, DateTime dateTaken);
    }
}