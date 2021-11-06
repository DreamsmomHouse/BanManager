using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BanManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<BanPerson> persons = new List<BanPerson>();
        public static readonly string path = Application.StartupPath + @"\data";

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                    persons.Add(BanPerson.parse(sr.ReadLine()));
                sr.Close();
                refreshList();
            }
        }
        void save()
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (BanPerson b in persons)
                sw.WriteLine(b.toString());
            sw.Close();
        }
        void refreshList()
        {
            peoplelist.Items.Clear();
            foreach (BanPerson b in persons)
                peoplelist.Items.Add(b.toString().Replace('*',' '));
            save();
        }
        public static bool ok = false;
        public static BanPerson person;
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new Add();
            add.ShowDialog();
            if (ok)
            {
                bool flag = true;
                for (int i = 0; i < persons.Count; i++)
                    if (persons[i].getQQ() == person.getQQ())
                    {
                        flag = false;
                        peoplelist.SelectedIndex = i;
                        MessageBox.Show("这个人之前已经被封禁过一次了哦");
                        break;
                    }
                if (flag)
                {
                    persons.Add(person);
                    refreshList();
                }
            }
            ok = false;
        }
        public static string id;
        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new Search();
            add.ShowDialog();
            if (ok)
            {
                long qq;
                if (long.TryParse(id, out qq))
                {
                    bool flag = true;
                    for (int i = 0; i < persons.Count; i++)
                        if (persons[i].getQQ() == qq)
                        {
                            flag = false;
                            peoplelist.SelectedIndex = i;
                            break;
                        }
                    if (flag) MessageBox.Show("未查询到记录！");
                }
                else MessageBox.Show("你输的QQ号不大对劲啊（解析失败）");
            }
            ok = false;
            peoplelist.Focus();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (peoplelist.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择一条记录");
                return;
            }
            if (MessageBox.Show("确认删除选中记录？", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                persons.RemoveAt(peoplelist.SelectedIndex);
                refreshList();
            }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (peoplelist.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择一条记录");
                return;
            }
            Form add = new Show(persons[peoplelist.SelectedIndex]);
            add.ShowDialog();
        }
    }
}
