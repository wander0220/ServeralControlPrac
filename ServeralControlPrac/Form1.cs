using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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

            GroupBox groupBox1 = new GroupBox();
            GroupBox groupBox2 = new GroupBox();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            Button btn = new Button();


            groupBox1.Location = new Point(170, 10);
            groupBox2.Location = new Point(200, 10);
            radio1.Location = new Point(170,30);
            radio2.Location = new Point(170, 60);
            radio1.Location = new Point(170, 30);
            radio2.Location = new Point(170, 60);
            btn.Location = new Point(170, 120);


            CheckBox checkBox1 = new CheckBox();
            CheckBox checkBox2 = new CheckBox();
            CheckBox checkBox3 = new CheckBox();
            Button button = new Button();

            checkBox1.Text = "감자";
            checkBox2.Text = "고구마";
            checkBox3.Text = "토마토";
            button.Text = "클릭";
            button.Name = "check";

            checkBox1.Location = new Point(10, 10);
            checkBox2.Location = new Point(10, 40);
            checkBox3.Location = new Point(10, 70);
            button.Location = new Point(10, 100);

            button.Click += ButtonClick;

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(button);


            RadioButton rb1 = new RadioButton();
            RadioButton rb2 = new RadioButton();
            RadioButton rb3 = new RadioButton();
            Button btn2 = new Button();
            rb1.Text = "감자";
            rb2.Text = "고구마";
            rb3.Text = "토마토";
            btn2.Name = "radio";
            btn2.Text = "클릭";
            rb1.Location = new Point(140, 10);
            rb2.Location = new Point(140, 40);
            rb3.Location = new Point(140, 70);
            btn2.Location = new Point(140, 100);

            btn2.Click += ButtonClick;

            Controls.Add(rb1);
            Controls.Add(rb2);
            Controls.Add(rb3);
            Controls.Add(btn2);
        }

        private void ButtonClick(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "check":
                    ShowCheckboxResult();
                    break;
                case "radio":
                    ShowRadioboxResult();
                    break;
            }
            
        }

        public void ShowCheckboxResult()
        {
            List<string> list = new List<string>();

            foreach (var item in Controls)
            {
                CheckBox checkBox = (CheckBox)item;
                if (checkBox != null && checkBox.Checked)
                {
                    list.Add(checkBox.Text);
                }
                /*if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }*/
            }
            MessageBox.Show(string.Join(",", list));
        }
        public void ShowRadioboxResult()
        {
            foreach (var item in Controls)
            {
                RadioButton radioButton = (RadioButton)item;
                if (radioButton != null && radioButton.Checked)
                {
                    MessageBox.Show(radioButton.Text);
                }
            }
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
