using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiRename
{
    public class FileRenameCommandBuilder
    {
        private FileRenameCommandBuilder()
        {

        }

        public static FileRenameCommandBuilder Create()
        {
            return new FileRenameCommandBuilder();
        }

        public FileRenameCommand Build()
        {
            return new FileRenameCommand(new FileSystemProxy(), new ImageProcessor(), new FileNameFormatter(), new DirectoryNameFormatter());
        }
    }
}
