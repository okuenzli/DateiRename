using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateiRename.Test
{
    [TestClass]
    public class FileNameFormatterTest
    {
        private FileNameFormatter _testee;

        [TestInitialize]
        public void Initialize()
        {
            _testee = new FileNameFormatter();
        }

        [TestMethod]
        public void FormatFileName()
        {
            var result = _testee.FormatFileName("Originalname", new DateTime(2018, 4, 3, 15, 33, 55));
            Assert.AreEqual("2018_04_03_15_33_55_Originalname", result);
        }
    }
}
