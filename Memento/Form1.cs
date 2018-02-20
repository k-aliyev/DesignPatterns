using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        TextFile file;
        public Form1()
        {
            InitializeComponent();
            var font = new Font(FontFamily.GenericSansSerif, 40, FontStyle.Bold);
            richTextBox1.Font = font;
            file = new TextFile();
            toolStripComboBox1.Items.Add(16);
            toolStripComboBox1.Items.Add(18);
            toolStripComboBox1.Items.Add(24);
            toolStripComboBox1.Items.Add(28);
            toolStripComboBox1.Items.Add(34);
            toolStripComboBox1.Items.Add(40);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toMemento()
        {
            file.SaveNew(new Memento(richTextBox1.Text, richTextBox1.SelectionStart, richTextBox1.SelectionLength, richTextBox1.Font));
        }

        private void fromMemento()
        {
            Memento mem = file.LoadLastMemento();
            richTextBox1.Text = mem.Text;
            richTextBox1.SelectionStart = mem.Selection;
            richTextBox1.SelectionLength = mem.SelectionLength;
            richTextBox1.Font = mem.Font;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toMemento();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromMemento();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var font = new Font(FontFamily.GenericSansSerif, Convert.ToSingle(toolStripComboBox1.SelectedItem), FontStyle.Bold);
            richTextBox1.Font = font;
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.SaveToFile("Text.txt");
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                try
                {
                    toMemento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
