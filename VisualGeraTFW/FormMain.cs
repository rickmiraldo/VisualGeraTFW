using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;


namespace VisualGeraTFW
{
    public partial class formMain : Form
    {
        // string cleanInput; // Conteúdo do arquivo de input
        int numLinhasInput; // Número de linhas do arquivo input
        int indexInput = 0; // Index da posição a ser mostrada do arquivo de input
        string formatoArquivo = ".tfw"; // Indica se a saída deverá ser em TFW ou JGW
        string linhaOutput; // Linha de saída para gravação no arquivo de output
        string nomeArquivoOutput; // Nome do arquivo de output
        string cleanInput; // Variável para o arquivo temporário a ser usado para as operações do programa
        
        // public string outputIndex { set; get; }
        // public string outputIndex { get { if (textBoxPs != null) return textBoxPs.Text; else return null; } }

        public formMain()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); // Utilizar ponto como separador decimal ao invés de vírgula
            InitializeComponent();
            File.Delete("log.txt");
            cleanInput = Path.GetTempFileName();
        }

        public void gravaLOG(string msg)
        {
            File.AppendAllText("log.txt", msg + "\r\n");
            return;
        }

        public void calculaLinha(string linha)
        {
            string[] linhaSplit = linha.Split('\t'); // Separa por tabulações

            string nomeImagem = linhaSplit[0]; // Inicializando todas as variáveis
            double eCP = Convert.ToDouble(linhaSplit[1]);
            double nCP = Convert.ToDouble(linhaSplit[2]);
            double hCP = Convert.ToDouble(linhaSplit[3]);
            double omegaCent = Convert.ToDouble(linhaSplit[4]);
            double phiCent = Convert.ToDouble(linhaSplit[5]);
            double kappaCent = Convert.ToDouble(linhaSplit[6]);
            double gpsTime = Convert.ToDouble(linhaSplit[7]);
            double pixelSize = 0;
            double tamanhoX = 0;
            double tamanhoY = 0;
            
            if (textBoxPs.Text != "")
            {
                var result = double.TryParse(textBoxPs.Text, out pixelSize); // Verifica se o conteúdo do text box é um número
            }
            else
            {
                MessageBox.Show("\"Tamanho do pixel\" não é um número válido!");
                return;
            }

            if (textBoxLx.Text != "")
            {
                var result = double.TryParse(textBoxLx.Text, out tamanhoX); // Verifica se o conteúdo do text box é um número
            }
            else
            {
                MessageBox.Show("\"Número de colunas\" não é um número válido!");
                return;
            }

            if (textBoxLy.Text != "")
            {
                var result = double.TryParse(textBoxLy.Text, out tamanhoY); // Verifica se o conteúdo do text box é um número
            }
            else
            {
                MessageBox.Show("\"Número de linhas\" não é um número válido!");
                return;
            }

            // Todas as contas mostradas abaixo

            double kRad = kappaCent * Math.PI / 200;
            if (kRad < 0)
            {
                kRad += 2 * Math.PI;
            }
            //textBoxKrad.Text = Convert.ToString(kRad);

            double gamma = Math.Atan((tamanhoX - 1) / (tamanhoY - 1));
            //textBoxGamma.Text = Convert.ToString(gamma);

            double theta = kRad + gamma + Math.PI / 2;
            //textBoxTheta.Text = Convert.ToString(theta);

            double dist = Convert.ToDouble(textBoxPs.Text) * ((Math.Sqrt(Math.Pow(tamanhoX - 1, 2) + Math.Pow(tamanhoY - 1, 2))) / 2);
            //textBoxDist.Text = Convert.ToString(dist);

            double resultA = Math.Cos(kRad) * pixelSize;
            //textBoxResultA.Text = Convert.ToString(resultA);

            double resultB = Math.Sin(kRad) * pixelSize;
            //textBoxResultB.Text = Convert.ToString(resultB);

            double resultC = eCP + dist * Math.Cos(theta);
            //textBoxResultC.Text = Convert.ToString(resultC);

            double resultD = resultB;
            //textBoxResultD.Text = Convert.ToString(resultD);

            double resultE = -resultA;
            //textBoxResultE.Text = Convert.ToString(resultE);

            double resultF = nCP + dist * Math.Sin(theta);
            //textBoxResultF.Text = Convert.ToString(resultF);

            // Arrumar o resultado final na variável global 'linhaOutput' para gravação em arquivo

            nomeArquivoOutput = (nomeImagem + formatoArquivo);
            gravaLOG("[CÁLCULO] Nome do arquivo: " + nomeArquivoOutput);
            linhaOutput = (Convert.ToString(resultA) + '\r' + '\n' +
                           Convert.ToString(resultD) + '\r' + '\n' +
                           Convert.ToString(resultB) + '\r' + '\n' +
                           Convert.ToString(resultE) + '\r' + '\n' +
                           Convert.ToString(resultC) + '\r' + '\n' +
                           Convert.ToString(resultF));
            gravaLOG("[CÁLCULO] Conteúdo: " + linhaOutput);

            return;
        }

        private void atualizaValoresInput(string linha)
        {
            string[] linhaSplit = linha.Split('\t'); // Separa o conteúdo da linha por tabulação

            visualizaDados.textBoxPhotoID.Text = linhaSplit[0];
            visualizaDados.textBoxEast.Text = linhaSplit[1];
            visualizaDados.textBoxNorth.Text = linhaSplit[2];
            visualizaDados.textBoxHeight.Text = linhaSplit[3];
            visualizaDados.textBoxOmega.Text = linhaSplit[4];
            visualizaDados.textBoxPhi.Text = linhaSplit[5];
            visualizaDados.textBoxKappa.Text = linhaSplit[6];
            visualizaDados.textBoxGPSTime.Text = linhaSplit[7];

            visualizaDados.textBoxResultA.Clear();
            visualizaDados.textBoxResultB.Clear();
            visualizaDados.textBoxResultC.Clear();
            visualizaDados.textBoxResultD.Clear();
            visualizaDados.textBoxResultE.Clear();
            visualizaDados.textBoxResultF.Clear();
            visualizaDados.textBoxTheta.Clear();
            visualizaDados.textBoxGamma.Clear();
            visualizaDados.textBoxKrad.Clear();
            visualizaDados.textBoxDist.Clear();

            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            
        }

        public void buttonProximo_Click(object sender, EventArgs e)
        {
            if ((indexInput + 1) < numLinhasInput)
            {
                indexInput++;

                string linha = File.ReadLines(cleanInput).Skip((indexInput)).Take(1).First();

                atualizaValoresInput(linha);

                //textBoxCurrentIndexInput.Text = (indexInput + 1) + " / " + numLinhasInput;
            }

            
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (indexInput > 0)
            {
                indexInput--;

                string linha = File.ReadLines(cleanInput).Skip((indexInput)).Take(1).First();

                atualizaValoresInput(linha);

                //textBoxCurrentIndexInput.Text = (indexInput + 1) + " / " + numLinhasInput;
            }

            
        }

        private void buttonPrevia_Click(object sender, EventArgs e)
        {
            string linha = File.ReadLines(cleanInput).Skip((indexInput)).Take(1).First(); // Lê o conteúdo da linha mostrada atualmente no index

            calculaLinha(linha);
        }

        private void textBoxLx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != '.' && ch != '\b')
            {
                e.Handled = true;
            }
            comboBoxCamera.Text = "";
            comboBoxGSD.Text = "";
            checkBoxQuickView.Checked = false;
        }

        private void radioButtonTFW_CheckedChanged(object sender, EventArgs e)
        {
            formatoArquivo = ".tfw";
            gravaLOG("[Formato] Alterado para TFW");
        }

        private void radioButtonJGW_CheckedChanged(object sender, EventArgs e)
        {
            formatoArquivo = ".jgw";
            gravaLOG("[Formato] Alterado para JGW");
        }

        private void textBoxOffsetTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != '.' && ch != '\b')
            {
                e.Handled = true;
            }
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // Abre o arquivo
            {
                string pathInput = openFileDialog1.FileName; // Guarda o caminho do arquivo na variável
                gravaLOG("[Arquivo aberto] Caminho: " + pathInput);

                // Deve-se apagar as linhas inválidas do arquivo aberto e gerar um novo arquivo limpo
                // Serão consideradas linhas válidas somente aquelas que começarem com um número

                string tempFile = Path.GetTempFileName(); // Cria um arquivo temporário para manipulação

                gerarArquivoParaFotoÍndiceToolStripMenuItem.Enabled = true; // Habilita opções do menu
                exportarArquivosTFWJGWToolStripMenuItem.Enabled = true;
                //renomearArquivosDeSaídaToolStripMenuItem.Enabled = true;

                using (var lerArquivo = new StreamReader(pathInput)) // lerArquivo é o arquivo original
                using (var gravaArquivo = new StreamWriter(tempFile)) // gravaArquivo é o arquivo modificado
                {
                    string lerLinha;
                    int contOK = 0;
                    int contINV = 0;
                    int contBRA = 0;

                    while ((lerLinha = lerArquivo.ReadLine()) != null) // Lê linha por linha
                    {
                        if (lerLinha.Length > 0) // Lê apenas se a linha não estiver em branco
                        {
                            char[] validChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Define os caracteres válidos

                            if (validChars.Contains(lerLinha[0])) // Verifica se a linha é válida
                            {
                                string linhaConvertida = Regex.Replace(lerLinha, " {2,}", @" "); // Substitui dois ou mais os espaços em um só
                                linhaConvertida = linhaConvertida.Replace(' ', '\t'); // Substitui os espaços por tabulações
                                gravaArquivo.WriteLine(linhaConvertida);
                                contOK++;
                                gravaLOG("[Lendo linha] Gravando linha! Conteúdo: " + lerLinha);
                            }
                            else
                            {
                                gravaLOG("[Lendo linha] Linha inválida, ignorando");
                                contINV++;
                            }
                        }
                        else
                        {
                            gravaLOG("[Lendo linha] Linha em branco, ignorando");
                            contBRA++;
                        }

                    }
                    gravaLOG("[Lendo linha] TERMINADO! Linhas gravadas: " + contOK + " / Linhas em branco: " + contBRA + " / Linhas inválidas: " + contINV);
                }
                
                File.Delete(cleanInput);
                File.Move(tempFile, cleanInput); // Salva o arquivo temporário no diretório do executável para uso futuro

                numLinhasInput = File.ReadAllLines(cleanInput).Length;
                visualizaDados.numLinhasInput = numLinhasInput;
                //labelNumLinhas.Text = numLinhasInput + " registro(s) encontrados";
                toolStripStatusLabelStatus.Text = numLinhasInput + " registro(s) encontrados."; // Mostra o número de registros na statusbar


                // Lê informação apenas da primeira linha do arquivo para conferência
                // Para isso, divide o conteúdo da linha usando a tabulação

                using (var stream = new StreamReader(cleanInput))
                {
                    string linha = stream.ReadLine(); // Lê a primeira linha

                    atualizaValoresInput(linha);

                    visualizaDados.textBoxCurrentIndexInput.Text = "1 / " + numLinhasInput; // Atualiza o contador do index
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void comboBoxCamera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCamera.SelectedItem == "UltraCam Xp")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxLx.Text = "1414";
                    textBoxLy.Text = "2164";
                }
                else
                {
                    textBoxLx.Text = "11310";
                    textBoxLy.Text = "17310";
                }
            }
            else if (comboBoxCamera.SelectedItem == "UltraCam D")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxLx.Text = "938";
                    textBoxLy.Text = "1438";
                }
                else
                {
                    textBoxLx.Text = "7500";
                    textBoxLy.Text = "11500";
                }
            }
            else if (comboBoxCamera.SelectedItem == "UltraCam Lp")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxLx.Text = "991";
                    textBoxLy.Text = "1464";
                }
                else
                {
                    textBoxLx.Text = "7920";
                    textBoxLy.Text = "11704";
                }
            }
            else if (comboBoxCamera.SelectedItem == "Nikon D610")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxLx.Text = "945";
                    textBoxLy.Text = "1416";
                }
                else
                {
                    textBoxLx.Text = "4016";
                    textBoxLy.Text = "6016";
                }
            }
        }

        private void comboBoxGSD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxGSD.SelectedItem == "4 cm")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxPs.Text = "0.31996";
                }
                else
                {
                    textBoxPs.Text = "0.04";
                }
            }
            else if (comboBoxGSD.SelectedItem == "6 cm")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxPs.Text = "0.47994";
                }
                else
                {
                    textBoxPs.Text = "0.06";
                }
            }
            else if (comboBoxGSD.SelectedItem == "8 cm")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxPs.Text = "0.63992";
                }
                else
                {
                    textBoxPs.Text = "0.08";
                }
            }
            else if (comboBoxGSD.SelectedItem == "10 cm")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxPs.Text = "0.7999";
                }
                else
                {
                    textBoxPs.Text = "0.10";
                }
            }
            else if (comboBoxGSD.SelectedItem == "12 cm")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxPs.Text = "0.95988";
                }
                else
                {
                    textBoxPs.Text = "0.12";
                }
            }
            else if (comboBoxGSD.SelectedItem == "16 cm")
            {
                if (checkBoxQuickView.Checked)
                {
                    textBoxPs.Text = "1.27984";
                }
                else
                {
                    textBoxPs.Text = "0.16";
                }
            }
        }

        private void checkBoxQuickView_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxCamera.Text != "Selecione a câmera")
            {
                comboBoxCamera_SelectionChangeCommitted(sender, e);
            }
            if (comboBoxGSD.Text != "Selecione o GSD")
            {
                comboBoxGSD_SelectionChangeCommitted(sender, e);
            }
        }

        private void exportarArquivosTFWJGWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxLx.Text == "" || textBoxLy.Text == "" || textBoxPs.Text == "")
            {
                MessageBox.Show("Parâmetros inválidos!");
                return;
            }
            
            System.IO.StreamReader input = new System.IO.StreamReader(cleanInput);

            string pathToSave = "output";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToSave = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                //MessageBox.Show("Diretório não selecionado. Abortando...");
                return;
            }

            string linha;
            int count = 0;
            double progress = 0;

            toolStripProgressBar2.Visible = true; // Mostra a barra de progresso
            toolStripProgressBar2.Value = 0;
            toolStripStatusLabelStatus.Text = ("Trabalhando...");
            Application.DoEvents(); // Necessário para atualizar a statusbar

            string tempFileIndex = Path.GetTempFileName();
            using (var gravaIndex = new StreamWriter(tempFileIndex))
            {
                while ((linha = input.ReadLine()) != null)
                {
                    count++;
                    calculaLinha(linha);
                    File.WriteAllText(Path.Combine(pathToSave, nomeArquivoOutput), linhaOutput); // Grava arquivo TFW/JGW na pasta output
                    gravaLOG("[OUTPUT] Arquivo " + nomeArquivoOutput + " gravado com sucesso!");

                    progress = Convert.ToDouble(count) / Convert.ToDouble(numLinhasInput) * Convert.ToDouble(100); // Atualiza progress bar
                    toolStripProgressBar2.Value = Convert.ToInt32(progress);

                    //gravaIndex.WriteLine(linhaOutputIndex); // Grava linha no arquivo photoIndex.txt
                }
            }

            //File.Delete("photoIndex.txt");
            //File.Move(tempFileIndex, "photoIndex.txt");
            /*
            textBoxResultA.Clear();
            textBoxResultB.Clear();
            textBoxResultC.Clear();
            textBoxResultD.Clear();
            textBoxResultE.Clear();
            textBoxResultF.Clear();
            textBoxTheta.Clear();
            textBoxGamma.Clear();
            textBoxKrad.Clear();
            textBoxDist.Clear();
            */
            MessageBox.Show("Operação completada! " + count + " arquivos gerados.");
            toolStripStatusLabelStatus.Text = ("Pronto");

            toolStripProgressBar2.Visible = false;

        }

        private void gerarArquivoParaFotoÍndiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPs.Text == "")
            {
                MessageBox.Show("Favor definir o tamanho do pixel.");
                return;
            }
            FormGeraFotoIndice fotoIndice = new FormGeraFotoIndice();
            fotoIndice.pixelSize = textBoxPs.Text;
            fotoIndice.cleanInput = cleanInput;
            fotoIndice.ShowDialog();
        }


        private void verLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("log.txt"))
            {
                System.Diagnostics.Process.Start("log.txt");
            }
            else
            {
                MessageBox.Show("Nenhum log no momento.");
            }
        }

        FormVisualizaDados visualizaDados = new FormVisualizaDados();
        private void visualizarDadosDoArquivoImportadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizaDados.cleanInput = cleanInput;
            //visualizaDados.numLinhasInput = numLinhasInput;

            bool checkLx = textBoxLx.Text != "" & textBoxLx.Text != null;
            bool checkLy = textBoxLy.Text != "" & textBoxLy.Text != null;
            bool checkPs = textBoxPs.Text != "" & textBoxPs.Text != null;

            if (checkLx == true & checkLy == true & checkPs == true)
            {
                string linhaPrevia = File.ReadLines(cleanInput).Skip((indexInput)).Take(1).First(); // Lê linha do índice atual

                string[] linhaSplitPrevia = linhaPrevia.Split('\t'); // Separa por tabulações

                string nomeImagem = linhaSplitPrevia[0]; // Inicializando todas as variáveis
                double eCP = Convert.ToDouble(linhaSplitPrevia[1]);
                double nCP = Convert.ToDouble(linhaSplitPrevia[2]);
                double hCP = Convert.ToDouble(linhaSplitPrevia[3]);
                double omegaCent = Convert.ToDouble(linhaSplitPrevia[4]);
                double phiCent = Convert.ToDouble(linhaSplitPrevia[5]);
                double kappaCent = Convert.ToDouble(linhaSplitPrevia[6]);
                double gpsTime = Convert.ToDouble(linhaSplitPrevia[7]);
                double pixelSize = Convert.ToDouble(textBoxPs.Text);
                double tamanhoX = Convert.ToDouble(textBoxLx.Text);
                double tamanhoY = Convert.ToDouble(textBoxLy.Text);

                double kRad = kappaCent * Math.PI / 200;
                if (kRad < 0)
                {
                    kRad += 2 * Math.PI;
                }
                visualizaDados.textBoxKrad.Text = Convert.ToString(kRad);

                double gamma = Math.Atan((tamanhoX - 1) / (tamanhoY - 1));
                visualizaDados.textBoxGamma.Text = Convert.ToString(gamma);

                double theta = kRad + gamma + Math.PI / 2;
                visualizaDados.textBoxTheta.Text = Convert.ToString(theta);

                double dist = pixelSize * ((Math.Sqrt(Math.Pow(tamanhoX - 1, 2) + Math.Pow(tamanhoY - 1, 2))) / 2);
                visualizaDados.textBoxDist.Text = Convert.ToString(dist);

                double resultA = Math.Cos(kRad) * pixelSize;
                visualizaDados.textBoxResultA.Text = Convert.ToString(resultA);

                double resultB = Math.Sin(kRad) * pixelSize;
                visualizaDados.textBoxResultB.Text = Convert.ToString(resultB);

                double resultC = eCP + dist * Math.Cos(theta);
                visualizaDados.textBoxResultC.Text = Convert.ToString(resultC);

                double resultD = resultB;
                visualizaDados.textBoxResultD.Text = Convert.ToString(resultD);

                double resultE = -resultA;
                visualizaDados.textBoxResultE.Text = Convert.ToString(resultE);

                double resultF = nCP + dist * Math.Sin(theta);
                visualizaDados.textBoxResultF.Text = Convert.ToString(resultF);

            }
            else
            {
                visualizaDados.textBoxResultA.Clear();
                visualizaDados.textBoxResultB.Clear();
                visualizaDados.textBoxResultC.Clear();
                visualizaDados.textBoxResultD.Clear();
                visualizaDados.textBoxResultE.Clear();
                visualizaDados.textBoxResultF.Clear();
                visualizaDados.textBoxKrad.Clear();
                visualizaDados.textBoxGamma.Clear();
                visualizaDados.textBoxDist.Clear();
                visualizaDados.textBoxTheta.Clear();
            }


            visualizaDados.Show();
            
        }

        private void textBoxLx_TextChanged(object sender, EventArgs e)
        {
            visualizaDados.Lx = textBoxLx.Text;
            visualizaDados.Ly = textBoxLy.Text;
            visualizaDados.Ps = textBoxPs.Text;
        }


    }
}
