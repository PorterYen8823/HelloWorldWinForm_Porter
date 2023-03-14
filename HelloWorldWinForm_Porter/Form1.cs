using System.Threading;

namespace HelloWorldWinForm_Porter
{
    public partial class Form1 : Form
    {

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        delegate void deleUpdateLabel(string msg);
        public void UpdateLabel2(string msg)
        {
            if (this.label2.InvokeRequired)
            {

                // deleUpdateLabel deleUL = new deleUpdateLabel(UpdateLabel2);
                this.Invoke(new deleUpdateLabel(UpdateLabel2), msg);
            }
            else
            {
                label2.Text = msg;

            }
        }

        delegate void deleUpdatelblCurrentTime();
        public void UpdatelblCurrentTime()
        {
            if (this.InvokeRequired)
            {

                deleUpdatelblCurrentTime delUTime = new deleUpdatelblCurrentTime(UpdatelblCurrentTime);
                this.BeginInvoke(delUTime);
            }
            else
            {
                this.lblCurrentTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
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


        private void DisplayNumber()
        {
            for (int i = 0; i <= 10; i++)
            {
                UpdateLabel2(i.ToString());
                SpinWait.SpinUntil(() => false, 100);
            }
        }
        private void DisplayNumber2()
        {
            for (int i = 0; i <= 10; i++)
            {
                label2.Invoke(new Action(() => label2.Text = i.ToString()));
                SpinWait.SpinUntil(() => false, 100);
            }
        }

        private void DisplayNumber3()
        {
            for (int i = 0; i <= 10; i++)
            {
                label2.Invoke((MethodInvoker)(() => label2.Text = i.ToString()));
                SpinWait.SpinUntil(() => false, 100);
            }
        }

        private void DisplayTimer(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {

                UpdatelblCurrentTime();
                SpinWait.SpinUntil(() => false, 1000);
            }
        }


        private void btnCount_Click(object sender, EventArgs e)
        {
            Task.Run(() => DisplayNumber());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // display Timer until form close
            cancellationTokenSource.Token.Register(() => { });
            Task.Run(() => DisplayTimer(cancellationTokenSource.Token));
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() => DisplayNumber2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() => DisplayNumber3());
        }
    }
}