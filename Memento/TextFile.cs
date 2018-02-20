using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextFile
    {
        List<Memento> mementos = new List<Memento>();

        public TextFile()
        {

        }

        public void SaveNew(Memento memento)
        {
            if(mementos.Count > 256)
            {
                mementos.RemoveAt(0);
            }
            mementos.Add(memento);
        }

        public Memento LoadMementoIndex(int i)
        {
            if(i < mementos.Count)
            return mementos[i];

            throw new IndexOutOfRangeException();
        }

        public Memento LoadLastMemento()
        {
            return mementos[mementos.Count - 1];
        }

        public void SaveToFile(string path)
        {
            File.AppendAllText(path, mementos[mementos.Count - 1].Text);
        }
    }
}
