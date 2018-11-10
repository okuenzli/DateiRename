using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DateiRename
{
    internal class ImageProcessor : IImageProcessor
    {
        private const int ImageDateTaken = 36867;
        private const string ReplacementString = "-";
        private const int ReplacementCount = 2;
        private readonly Regex _regex = new Regex(":");


        public DateTime GetDateTakenFromImage(Stream stream)
        {
            using (Image myImage = Image.FromStream(stream, false, false))
            {
                return GetDateTakenFromImage(myImage);
            }
        }

        private DateTime GetDateTakenFromImage(Image image)
        {
            PropertyItem propItem = image.GetPropertyItem(ImageDateTaken);
            var propertyAsString = Encoding.UTF8.GetString(propItem.Value);
            string dateTaken = _regex.Replace(propertyAsString, ReplacementString, ReplacementCount);
            return DateTime.Parse(dateTaken);
        }


    }
}
