namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(FillLB);

        }

         void FillLB()
        {

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                listBox1.Items.Add($"String - {i}");
            }

        }

        async void FillLB2()
        {

            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(1000);
                listBox2.Items.Add($"String - {i}");
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            FillLB2();
        }
    }
}
