using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horoscope
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private string textNo = "";

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "01";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "02";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "03";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "04";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "05";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "06";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "07";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "08";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "09";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textNo = "12";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Newdivination div = new TokyoDiv();
            switch (count)
            {
                case 0:
                    timer1.Interval = 2000;
                    label1.Text = div.Concentration(0);
                    break;

                case 1:
                    label1.Text = div.Concentration(1);
                    break;

                case 2:
                    label1.Text = div.Concentration(2);
                    richTextBox1.Text = div.Divine(textNo);
                    timer1.Enabled = false;
                    count = -1;
                    break;
            }
            count++;
        }
    }

    public class Divination
    {
        public string Divine(string no)
        {
            string divmsg = "";
            string file_name = "..\\..\\unsei" + no + ".txt";
            StreamReader sr = new StreamReader(file_name);
            string s;
            while ((s = sr.ReadLine()) != null) 
            {
                divmsg = divmsg + s + "\n";
            }
            sr.Close();
            return divmsg;
        }

    }

    abstract public class Newdivination :Divination
    {
        abstract public string Concentration(int no);
       
    }
    public class TokyoDiv:Newdivination
    {
        override public string Concentration(int no)
        {
            string[] msg = { "そうですねぇ。", "ふむふむ", "これが今日の運勢です。" };
            return msg[no];
        }
    }
    public class OsakaDiv : Newdivination
    {
        override public string Concentration(int no)
        {
            string[] msg = { "そうやねぇ。", "どうかなー", "今日の運勢はこんな感じやな。" };
            return msg[no];
        }
    }
}
