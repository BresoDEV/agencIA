using System.Net;
using System.Text.Encodings.Web;
using System.Windows.Forms;

namespace gpt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string b = "";
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Voce: " + textBox1.Text+ "\n\n";

            b = richTextBox1.Text;
            Random random = new Random();
            int seed = random.Next(0, 9999);
            string url = $"https://text.pollinations.ai/prompt/{Uri.EscapeDataString(b)}";
            textBox1.Text = "";
            try
            {
                using (WebClient client = new WebClient())
                {
                    //MessageBox.Show(b);
                    richTextBox1.Text += "Bot: " + client.DownloadString(url) + "\n\n";

                    richTextBox1.Text = richTextBox1.Text.Replace("Get reliable dedicated VPS hosting with high bandwidth from Clawcloud, starting at $10/mo. [Learn more](https://pollinations.ai/redirect/2144039)", "");

                    b = richTextBox1.Text;

                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.ScrollToCaret();



                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = "";
            richTextBox1.Text = b;
            textBox1.Text = b;
        }
    }
}
