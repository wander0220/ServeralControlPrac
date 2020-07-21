using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeralControlPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckBox checkBox1 = new CheckBox();
            CheckBox checkBox2 = new CheckBox();
            CheckBox checkBox3 = new CheckBox();
            Button button = new Button();

            checkBox1.Text = "감자";
            checkBox2.Text = "고구마";
            checkBox3.Text = "토마토";
            button.Text = "클릭";

            checkBox1.Location = new Point(10, 10);
            checkBox2.Location = new Point(10, 40);
            checkBox3.Location = new Point(10, 70);
            button.Location = new Point(10, 100);

            button.Click += ButtonClick;

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(button);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("https://google.co.kr/");
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
