using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BanManager
{
    public partial class Show : Form
    {
        BanPerson person;
        public Show(BanPerson ban)
        {
            InitializeComponent();
            person = ban;
            textBox1.Text = ban.getQQ().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(person.getQQSS());
            }
            catch
            {
                MessageBox.Show("错误：无法找到文件\n文件路径填错或者文件被移动");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(person.getEvidence());
            }
            catch
            {
                MessageBox.Show("错误：无法找到文件\n文件路径填错或者文件被移动");
            }
        }
    }
}
