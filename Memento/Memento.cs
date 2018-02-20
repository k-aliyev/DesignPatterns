using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Memento
{
    class Memento
    {
        public Memento(string text, int start, int length, Font font)
        {
            Text = text;
            Selection = start;
            SelectionLength = length;
            Font = font;
        }

        public string Text { get; set; }
        public int Selection { get; set; }
        public int SelectionLength { get; set; }
        public Font Font  { get; set; }
    }
}
