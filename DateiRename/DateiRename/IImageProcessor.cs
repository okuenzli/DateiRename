using System;
using System.IO;

namespace DateiRename
{
    public interface IImageProcessor
    {
        DateTime GetDateTakenFromImage(Stream fileStream);
    }
}