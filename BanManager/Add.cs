using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanManager
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("QQ号或封禁理由不能为空");
                return;
            }
            long a;
            if (!long.TryParse(textBox1.Text,out a))
            {
                MessageBox.Show("QQ号里面有非法字符哦");
                return;
            }
            MainForm.person = new BanPerson(long.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
            MainForm.ok = true;
            this.Close();
        }
    }
}
