using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs62Key
{
    public partial class Form1 : Form
    {
        private Label label1, label2;

        public void Display()
        {
            Application.Run(new Form1());
        }
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Sample";
            this.Width = 250;
            this.Height = 100;

            label1 = new Label();
            label1.Text = "Select with Allow Key.";
            label1.Width = this.Width;

            label2 = new Label();
            label2.Top = label1.Bottom;

            label1.Parent = this;
            label2.Parent = this;

            this.KeyDown += new KeyEventHandler(FormKeyDown);
        }

        public void FormKeyDown(Object sender, KeyEventArgs e)
        {
            String str;
            if (e.KeyCode == Keys.Up)
            {
                str = "UP";
            } 
            else if (e.KeyCode == Keys.Down)
            {
                str = "DOWN";
            } 
            else if (e.KeyCode == Keys.Right)
            {
                str = "RIGHT";
            }
            else if (e.KeyCode == Keys.Left)
            {
                str = "LEFT";
            }
            else
            {
                str = "WRONG KEY";
            }

            label2.Text = str;
        }
    }
}