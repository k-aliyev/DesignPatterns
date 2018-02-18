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
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].BackColor = Color.White;
            }

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
            Pressed(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pressed(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Pressed(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Pressed(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Pressed(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Pressed(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Pressed(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pressed(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pressed(button9);
        }

        private void Pressed(Button button)
        {
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Black;
            }
            else
            {
                button.BackColor = Color.White;
            }
            invoker.AddCommand(GetCommand());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            invoker.AddCommand(GetCommand());
        }

        private void button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                try
                {
                    SetCommand(invoker.Undo());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Y)
            {
                try
                {
                    SetCommand(invoker.Redo());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
