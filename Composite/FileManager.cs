using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    static class FileManager
    {
        static public Composite ReadonlyFile(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);

            Composite composite = new Composite(d.Name);

            DirectoryInfo[] directories = d.GetDirectories();
            FileInfo[] files = d.GetFiles();
            foreach (var directory in directories)
            {
                composite.Add(ReadonlyFile(directory.FullName));
            }
            foreach (var file in files)
            {
                composite.Add(new Leaf(file.Name, (int)file.Length));
            }
                return composite;
        }
        static public string GetSize(int bytes)
        {
            if(((bytes / 1024) / 1024) > 0){
                return $"{((bytes / 1024) / 1024)}MB";
            }
            else if(bytes / 1024 > 0)
            {
                return $"{bytes / 1024}KB";
            }
            else
            {
                return $"{bytes} bytes";
            }
        }
    }
}
