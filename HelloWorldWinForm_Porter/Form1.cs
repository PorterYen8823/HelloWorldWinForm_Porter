namespace HelloWorldWinForm_Porter
{
    public partial class Form1 : Form
    {

        delegate void UpdateLabel(string labelName, string msg);
        public static void LabelUpdate(string LabelName, string msg)
        {
            Form form = Application.OpenForms["Form1"];
            Label W;
            if (form == null)
                return;

            W = form.Controls.Find(LabelName, true).FirstOrDefault() as Label;

            if (W == null)
                return;

            if (W.InvokeRequired)
            {
                UpdateLabel ph = new UpdateLabel(LabelUpdate);
                W.BeginInvoke(ph, LabelName, msg);
            }
            else
            {
                W.Text = msg;
                W.Refresh();

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private async void btnCount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {

                LabelUpdate("label2", i.ToString());                
                SpinWait.SpinUntil(() => false, 300);
            }
        }
    }
}