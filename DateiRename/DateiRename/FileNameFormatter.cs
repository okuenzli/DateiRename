using System;

namespace DateiRename
{
    internal class FileNameFormatter : IFileNameFormatter
    {
        public string FormatFileName(string originalFileName, DateTime dateTaken)
        {
            return $"{dateTaken.ToString("yyyy_MM_dd_HH_mm_ss")}_{originalFileName}";
        }
    }
}
