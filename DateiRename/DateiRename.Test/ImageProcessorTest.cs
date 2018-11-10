using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Reflection;

namespace DateiRename.Test
{
    [TestClass]
    public class ImageProcessorTest
    {
        private const string TestFilePathAndName = "DateiRename.Test.Resources.174606_DSCN1904.JPG";
        private ImageProcessor _testee;

        [TestInitialize]
        public void Initialize()
        {
            _testee = new ImageProcessor();
        }

        [TestMethod]
        public void GetDateTakenFromImage_WhenDateTakenExists_ThenReturnDateTaken()
        {
            var result = _testee.GetDateTakenFromImage(TestHelper.GetResource(TestFilePathAndName));
        }
    }
}
