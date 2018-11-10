using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DateiRename.Test
{
    internal static class TestHelper
    {
        internal static Stream GetResource(string resourceFileName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceFileName);
        }
    }
}
