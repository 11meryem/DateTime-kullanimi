using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime bugun = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = bugun.Date.ToString();
            //tarih
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = bugun.Month.ToString();
            //ay
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = bugun.Year.ToString();
            //yıl
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = bugun.Day.ToString();
            //gun
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = bugun.DayOfWeek.ToString();
            //hafta
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = bugun.Hour.ToString();
            //saat
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Text=bugun.Minute.ToString();
            //dakika
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label8.Text = bugun.Second.ToString();
            //saniye
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label9.Text=bugun.Millisecond.ToString();
        }

       
    }
}
