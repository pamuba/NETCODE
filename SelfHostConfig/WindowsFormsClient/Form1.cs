using MathServiceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private IMathService basiHttpChannel = null;
        private IMathService wsHttpChannel = null;
        private IMathService nettcpChannel = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = basiHttpChannel.Adds(obj).ToString(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = basiHttpChannel.Subtracts(obj).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basiHttpChannel = new ChannelFactory<MathServiceLibrary.IMathService>
                ("MathService_BasicHttp").CreateChannel();

            wsHttpChannel = new ChannelFactory<MathServiceLibrary.IMathService>
                ("MathService_wsHttp").CreateChannel();

            nettcpChannel = new ChannelFactory<MathServiceLibrary.IMathService>
                ("MathService_netTcp").CreateChannel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = wsHttpChannel.Adds(obj).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = nettcpChannel.Adds(obj).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = wsHttpChannel.Subtracts(obj).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyNumbers obj = new MyNumbers();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = nettcpChannel.Subtracts(obj).ToString();
        }
    }
}
