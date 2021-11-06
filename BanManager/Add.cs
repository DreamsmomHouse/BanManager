using System;
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
            if (!long.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("QQ号里面有非法字符哦");
                return;
            }
            MainForm.person = new BanPerson(long.Parse(textBox1.Text), textBox2.Text, textBox4.Text, textBox3.Text);
            MainForm.ok = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox4.Text = ofd.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox3.Text = ofd.FileName;
        }

        private void textBox4_DragDrop(object sender, DragEventArgs e)
        {
            string localFilePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();//文件完整路径
            textBox4.Text = localFilePath;
        }
        private new void DragEnter(object sender, DragEventArgs e)
        {

            string localFilePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            e.Effect = DragDropEffects.Move;
        }

        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            string localFilePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();//文件完整路径
            textBox3.Text = localFilePath;
        }
    }
}
