using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateiRename.Test
{
    [TestClass]
    public class FileRenameCommandTest
    {
        private FileRenameCommand _testee;

        [TestInitialize]
        public void Initialize()
        {
            _testee = new FileRenameCommand(new FileSystemProxy(), new ImageProcessor(), new FileNameFormatter(), new DirectoryNameFormatter());
        }

        [Ignore]
        [TestMethod]
        public void Execute()
        {
            _testee.Execute(@"\\192.168.2.193\photo\Ferien\Deutschland und Dänemark 2018 zum Umbenennen", "*.jpg");
        }
    }
}
