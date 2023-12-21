namespace WCFClient
{
    public partial class Form1 : Form
    {
        MathServiceReference.MathServiceClient client = 
            new MathServiceReference.MathServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MathServiceReference.MyNumbers o1=
                new MathServiceReference.MyNumbers();
            o1.Number1 = Convert.ToInt32(textBox1.Text);
            o1.Number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = client.Adds(o1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}