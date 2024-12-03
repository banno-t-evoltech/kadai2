using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kadai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputText = textBox1.Text;
            var inputText2 = textBox2.Text;
            var inputText3 = textBox3.Text;
            MessageBox.Show("社員情報が入力されました。" 
                + Environment.NewLine
                + Environment.NewLine
                + "名前 : " + inputText
                + Environment.NewLine
                + "年齢 : " + inputText2 + "歳"
                + Environment.NewLine
                + "身長 : " + inputText3 + "cm"
                , "入力完了!");
        }
    }
}
