using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class FileManager
    {
        static Dictionary<int, Image> images = new Dictionary<int, Image>();

        

        static public Image GetImage(int i) {
            Image image;
            if (!images.ContainsKey(i))
            {
                switch (i)
                {
                    case 1:
                        images.Add(1, Image.FromFile(@"One.png"));
                        break;
                    case 2:
                        images.Add(2, Image.FromFile(@"Two.png"));
                        break;
                    case 3:
                        images.Add(3, Image.FromFile(@"Three.png"));
                        break;
                    case 4:
                        images.Add(4, Image.FromFile(@"Four.jpg"));
                        break;
                    case 5:
                        images.Add(5, Image.FromFile(@"Five.jpg"));
                        break;
                }
            }
            image = images[i];
            return image;
        }
        static public int GetCountOfDictionary()
        {
            return images.Count();
        }
    }
}
