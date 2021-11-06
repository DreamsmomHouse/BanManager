using System;
using System.Windows.Forms;

namespace BanManager
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.ok = true;
            MainForm.id = textBox1.Text;
            Close();
        }
    }
}
