using System.Drawing.Imaging;
using System.Net;
using System.Windows.Forms;

namespace agencIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string empresa = "";
        public static string agente = "";
        public static int index_empresa = 0;



        public static string obterPromptInicial()
        {
            string descricao_empresa = File.ReadAllText("empresas/" + index_empresa + "/descricao.txt");

            string intro = "A partir de agora, voce fará parte de uma agencia de marketing, e sera especialista e responsavel em ";
            string funcao = "";

            if (agente == "Planejamento")
            {
                funcao = "definir metas, identificar o público-alvo, posicionamento da marca e criar planos de ação alinhados às necessidades do cliente";
            }
            if (agente == "Design")
            {
                funcao = "envolve redatores, designers gráficos, ilustradores e criativos que desenvolvem conteúdo visual e textual para campanhas, anúncios e materiais diversos";
            }
            if (agente == "Publicidade")
            {
                funcao = "gerentes de mídia, especialistas em compra de mídia digital e tradicional, que planejam e executam campanhas publicitárias, otimizando investimentos em canais como Google Ads, Facebook Ads, TV, rádio, entre outros";
            }

            if (agente == "SocialMedia")
            {
                funcao = "profissionais que gerenciam as redes sociais, elaboram conteúdo para plataformas como Instagram, TikTok, LinkedIn, respondem ao público e monitoram engajamento";
            }
            if (agente == "Fotografia")
            {
                funcao = "criar conteúdo audiovisual de alta qualidade para campanhas, vídeos institucionais, comerciais e materiais para redes sociais";
            }
            if (agente == "Relations")
            {
                funcao = "relacionamento com clientes, imprensa e influenciadores, além de produzir conteúdo para comunicação interna e externa";
            }
            if (agente == "Atendimento")
            {
                funcao = "entendem as necessidades do cliente, traduzem essas demandas em ações e fazem o acompanhamento dos resultados";
            }
            if (agente == "Marketing")
            {
                funcao = "otimizam sites e conteúdos para motores de busca, aumentando a visibilidade online da marca";
            }

            return intro + funcao + ". A empresa que voce sera responsavel, se chama " + empresa + ", descrição da empresa: " + descricao_empresa;
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("empresas"))
            {
                Directory.CreateDirectory("empresas");
            }


            //obter empresas
            for (int i = 1; i < 100; i++)
            {
                if (Directory.Exists("empresas/" + i))
                {
                    this.Text = "empresas/" + i + "/nome.txt";
                    string n = File.ReadAllText("empresas/" + i + "/nome.txt");
                    comboBox2.Items.Add(n);
                }
            }








        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                if (!Directory.Exists("empresas/" + i))
                {
                    Directory.CreateDirectory("empresas/" + i);
                    File.WriteAllText("empresas/" + i + "/nome.txt", textBox1.Text);
                    File.WriteAllText("empresas/" + i + "/descricao.txt", textBox2.Text);

                    //File.WriteAllText("empresas/" + i + "/Planejamento.txt", "");
                    //File.WriteAllText("empresas/" + i + "/Design.txt", "");
                    //File.WriteAllText("empresas/" + i + "/Publicidade.txt", "");
                    //File.WriteAllText("empresas/" + i + "/SocialMedia.txt", "");
                    //File.WriteAllText("empresas/" + i + "/Fotografia.txt", "");
                    //File.WriteAllText("empresas/" + i + "/Relations.txt", "");
                    //File.WriteAllText("empresas/" + i + "/Atendimento.txt", "");
                    //File.WriteAllText("empresas/" + i + "/Marketing.txt", "");

                    break;
                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            for (int i = 1; i < 100; i++)
            {
                if (Directory.Exists("empresas/" + i))
                {
                    this.Text = "empresas/" + i + "/nome.txt";
                    string n = File.ReadAllText("empresas/" + i + "/nome.txt");
                    comboBox2.Items.Add(n);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = empresa + " - " + index_empresa + " - " + agente;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            empresa = comboBox2.Text;
            for (int i = 1; i < 100; i++)
            {
                if (Directory.Exists("empresas/" + i))
                {
                    string n = File.ReadAllText("empresas/" + i + "/nome.txt");
                    if (empresa == n)
                    {
                        index_empresa = i;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index_empresa != 0)
            {
                if (comboBox1.Text != "")
                {
                    if (File.Exists("empresas/" + index_empresa + "/" + comboBox1.Text + ".txt"))
                    {
                        MessageBox.Show($"Ja existe um agente de {agente} para a empresa {empresa}");
                    }
                    else
                    {

                        agente = comboBox1.Text;
                        File.WriteAllText("empresas/" + index_empresa + "/" + agente + ".txt", obterPromptInicial());
                        MessageBox.Show($"Agente de {agente} criado para a empresa {empresa}");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um agente");
                }

            }
            else
            {
                MessageBox.Show("Selecione uma empresa");
            }

            textBox3.Text = "";
            richTextBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && empresa != "")
            {
                if (!File.Exists("empresas/" + index_empresa + "/" + comboBox1.Text + ".txt"))
                {
                    MessageBox.Show($"Não existe um agente de {comboBox1.Text} para a empresa {empresa}");
                }
                else
                {
                    agente = comboBox1.Text;
                    MessageBox.Show($"Selecionado o agente de {agente} da empresa {empresa}");

                    richTextBox1.Text = File.ReadAllText("empresas/" + index_empresa + "/" + agente + ".txt");

                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.ScrollToCaret();
                }
            }
            else
            {
                MessageBox.Show($"Selecione o agente e a empresa antes");
            }
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && empresa != "")
            {
                if (!File.Exists("empresas/" + index_empresa + "/" + comboBox1.Text + ".txt"))
                {
                    MessageBox.Show($"Não existe um agente de {comboBox1.Text} para a empresa {empresa}");
                }
                else
                {
                    File.WriteAllText("empresas/" + index_empresa + "/" + comboBox1.Text + ".txt", "");
                    agente = "";
                    MessageBox.Show($"O agente de {agente} da empresa {empresa} foi resetado");

                    textBox3.Text = "";
                    richTextBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show($"Selecione o agente e a empresa antes");
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && empresa != "")
            {
                if (!File.Exists("empresas/" + index_empresa + "/" + comboBox1.Text + ".txt"))
                {
                    MessageBox.Show($"Não existe um agente de {comboBox1.Text} para a empresa {empresa}");
                }
                else
                {
                    File.Delete("empresas/" + index_empresa + "/" + comboBox1.Text + ".txt");
                    agente = "";
                    MessageBox.Show($"O agente de {agente} da empresa {empresa} foi deletado");

                    textBox3.Text = "";
                    richTextBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show($"Selecione o agente e a empresa antes");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (empresa != "")
            {
                if (agente != "")
                {

                }
                else
                {
                    MessageBox.Show("Selecione o agente antes");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione a empresa antes");
                return;
            }





            richTextBox1.Text += "Voce: " + textBox3.Text + "\n\n";

            string pergunta = richTextBox1.Text;
            Random random = new Random();
            int seed = random.Next(0, 9999);
            string url = $"https://text.pollinations.ai/prompt/{Uri.EscapeDataString(obterPromptInicial() + pergunta)}";
            textBox1.Text = "";
            try
            {
                using (WebClient client = new WebClient())
                {
                    //MessageBox.Show(b);
                    richTextBox1.Text += "Agente de " + agente + ": " + client.DownloadString(url) + "\n\n";


                    for (int i = 0; i < 100; i++)
                    {
                        richTextBox1.Text = richTextBox1.Text.Replace("###", "");
                        richTextBox1.Text = richTextBox1.Text.Replace("**", "");
                    }


                    // b = richTextBox1.Text;

                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.ScrollToCaret();

                    File.WriteAllText("empresas/" + index_empresa + "/" + agente + ".txt", richTextBox1.Text);

                    richTextBox1.Text = richTextBox1.Text.Replace(obterPromptInicial(), "");


                    textBox3.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //textBox4
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Baixa a imagem como array de bytes
                    Random random = new Random();
                    int seed = random.Next(0, 9999);

                    byte[] imageBytes = webClient.DownloadData($"https://image.pollinations.ai/prompt/{textBox4.Text}?seed={seed}&width=1500&height=1500&nologo=true");
                    // Converte os bytes em uma imagem
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar imagem: {ex.Message}");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Supondo que pictureBox1 seja o seu PictureBox
            if (pictureBox1.Image != null)
            {
                // Abre uma janela para o usuário escolher onde salvar
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Images|*.png|JPEG Images|*.jpg|Bitmap|*.bmp";
                    saveFileDialog.Title = "Salvar imagem como";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Aqui você escolhe o formato de acordo com a extensão
                        ImageFormat format = ImageFormat.Png;
                        string extension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();

                        switch (extension)
                        {
                            case ".jpg":
                            case ".jpeg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                format = ImageFormat.Bmp;
                                break;
                            // padrão é PNG
                            default:
                                format = ImageFormat.Png;
                                break;
                        }

                        // Salva a imagem
                        pictureBox1.Image.Save(saveFileDialog.FileName, format);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há imagem no PictureBox.");
            }

        }
    }
}
