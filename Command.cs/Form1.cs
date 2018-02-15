using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command.cs
{
    public partial class Form1 : Form
    {
        Invoker invoker;
        List<Button> buttons = new List<Button>(); 
        public Form1()
        {
            InitializeComponent();
            invoker = new Invoker();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool DifferentColor(Button b)
        {
            if (b.BackColor != Color.White)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Command GetCommand()
        {
            Point p = new Point();
            Command command = new Command();

            for (int i = 0; i < buttons.Count; i++)
            {
                p.num = i;
                p.pressed = DifferentColor(buttons[i]);
                command.AddPoint(p);
            }

            return command;
        }

        private void SetCommand(Command command)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (command.points[i].pressed)
                {
                    buttons[i].BackColor = Color.Black;
                }
                else
                {
                    buttons[i].BackColor = Color.White;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Pressed()
        {
            invoker.AddCommand(GetCommand());
        }
    }
}
