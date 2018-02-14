using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            int[] NumImages = new int[4];
            for (int i = 0; i < 4; i++)
            {
                NumImages[i] = r.Next(1, 5);
            }
            pictureBox1.Image = FileManager.GetImage(NumImages[0]);
            pictureBox2.Image = FileManager.GetImage(NumImages[1]);
            pictureBox3.Image = FileManager.GetImage(NumImages[2]);
            pictureBox4.Image = FileManager.GetImage(NumImages[3]);
            MessageBox.Show(FileManager.GetCountOfDictionary().ToString());
        }
    }
}
