namespace HelloWorldWinForm_Porter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }
    }
}