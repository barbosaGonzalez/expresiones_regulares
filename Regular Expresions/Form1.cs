using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regular_Expresions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  mail@mail.com
            RegExp(@"^([\w]+)@([\w]+)\.([\w]+)$", textBox1, pictureBox1, label1, "email");
            //  http://www.google.com
            RegExp(@"^(http://www\.)([\w]+)\.([\w]+)$", textBox2, pictureBox2, label2, "website");
            //  Phone Number like : 0011 XXX XXX XXX
            RegExp(@"^(0443)(([ ][0-9]{3}){3})$", textBox3, pictureBox3, label3, "Phone Number");
            //  XX/XX/XXXX
            RegExp(@"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$", textBox4, pictureBox4, label4, "Birthday");
        }

        public void RegExp(string re, TextBox tb, PictureBox pb, Label lb, string s)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pb.Image = Properties.Resources.Add_32x32_32;
                lb.ForeColor = Color.Green;
                lb.Text = s + " Valid";
            }
            else
            {
                pb.Image = Properties.Resources.Close_32x32_32;
                lb.ForeColor = Color.Red;
                lb.Text = s + " InValid";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Select();
        }
    }
}
