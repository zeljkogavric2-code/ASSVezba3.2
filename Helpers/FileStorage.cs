
using System.IO;

namespace LegacyOrderSystem.Helpers
{
    public class FileStorage
    {
        public void Save(string path, string data)
        {
            File.WriteAllText(path, data);
        }
    }
}
