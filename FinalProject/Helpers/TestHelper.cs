using System.IO;
using System.Reflection;

namespace FinalProject.Helpers
{
    public static class TestHelper
    {
        public static string ExeFolder => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}