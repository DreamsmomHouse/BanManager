
namespace BanManager
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "QQ号（防止改名）：\r\n\r\n封禁原因：\r\n\r\nQQ号截图：\r\n\r\n证据文件路径（多个请压缩）：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 25);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(437, 25);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Location = new System.Drawing.Point(264, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(386, 25);
            this.textBox3.TabIndex = 3;
            this.textBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox3_DragDrop);
            this.textBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.Location = new System.Drawing.Point(264, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(386, 25);
            this.textBox4.TabIndex = 5;
            this.textBox4.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox4_DragDrop);
            this.textBox4.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "注：输入路径，按右边的选择文件按钮和拖放文件到文本框均可";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}