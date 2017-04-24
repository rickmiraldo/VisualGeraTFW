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

namespace VisualGeraTFW
{
    public partial class FormGeraFotoIndice : Form
    {
        string linhaOutputIndex; // Linha de saída para gravação no arquivo do foto índice
        public string cleanInput { set; get; }
        public string pixelSize { set; get; }
        
        public FormGeraFotoIndice()
        {
            InitializeComponent();
        }

        private void calculaPhotoIndex(string linha)
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
            double offsetTexto = 0;

           
            if (textBoxOffsetTexto.Text != "")
            {
                var result = double.TryParse(textBoxOffsetTexto.Text, out offsetTexto); // Verifica se o conteúdo do text box é um número
            }
            else
            {
                MessageBox.Show("\"Offset de texto\" não é um número válido!");
            }
            

            // Todas as contas mostradas abaixo

            double kRad = kappaCent * Math.PI / 200;
            if (kRad < 0)
            {
                kRad += 2 * Math.PI;
            }

            double gamma = Math.Atan((tamanhoX - 1) / (tamanhoY - 1));

            double theta = kRad + gamma + Math.PI / 2;
            
            double dist = Convert.ToDouble(pixelSize) * ((Math.Sqrt(Math.Pow(tamanhoX - 1, 2) + Math.Pow(tamanhoY - 1, 2))) / 2);

            double resultA = Math.Cos(kRad) * pixelSize;

            double resultB = Math.Sin(kRad) * pixelSize;

            double resultC = eCP + dist * Math.Cos(theta);

            double resultD = resultB;

            double resultE = -resultA;

            double resultF = nCP + dist * Math.Sin(theta);

            
            // Cálculos para o arquivo index para coordenadas do texto
            
            double eTXT = 0;
            double nTXT = 0;

            double kRadTemp = kRad + Math.PI / 4;
            if (kRadTemp >= 2* Math.PI)
            {
                kRadTemp -= 2 * Math.PI;
            }

            if (kRadTemp >= 0 && kRadTemp < Math.PI / 2) // Primeiro quadrante
            {
                double thetaIndex = theta;
                eTXT = eCP + (dist - offsetTexto) * Math.Cos(thetaIndex);
                nTXT = nCP + (dist - offsetTexto) * Math.Sin(thetaIndex);
                //gravaLOG("[CÁLCULO] " + nomeImagem + " está no primeiro quadrante");
            }
            else if (kRadTemp >= Math.PI / 2 && kRadTemp < Math.PI) // Segundo quadrante
            {
                double thetaIndex = kRad + Math.PI / 2 - gamma;
                eTXT = eCP + (dist - offsetTexto) * Math.Cos(thetaIndex);
                nTXT = nCP + (dist - offsetTexto) * Math.Sin(thetaIndex);
                //gravaLOG("[CÁLCULO] " + nomeImagem + " está no segundo quadrante");
            }
            else if (kRadTemp >= Math.PI && kRadTemp < 3 * Math.PI / 2) // Terceiro quadrante
            {
                double thetaIndex = kRad - Math.PI / 2 + gamma;
                eTXT = eCP + (dist - offsetTexto) * Math.Cos(thetaIndex);
                nTXT = nCP + (dist - offsetTexto) * Math.Sin(thetaIndex);
                //gravaLOG("[CÁLCULO] " + nomeImagem + " está no terceiro quadrante");
            }
            else if (kRadTemp >= 3 * Math.PI / 2 && kRadTemp < 2 * Math.PI) // Quarto quadrante
            {
                double thetaIndex = kRad - Math.PI / 2 - gamma;
                eTXT = eCP + (dist - offsetTexto) * Math.Cos(thetaIndex);
                nTXT = nCP + (dist - offsetTexto) * Math.Sin(thetaIndex);
                //gravaLOG("[CÁLCULO] " + nomeImagem + " está no quarto quadrante");
            }

            // Conteúdo da linhaOutputIndex

            linhaOutputIndex = (nomeImagem + '\t' +
                                Convert.ToString(eCP) + '\t' +
                                Convert.ToString(nCP) + '\t' +
                                Convert.ToString(hCP) + '\t' +
                                Convert.ToString(eTXT) + '\t' +
                                Convert.ToString(nTXT));
            
            return;
        }

        private void buttonCriarArquivoFotoIndice_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader input = new System.IO.StreamReader(cleanInput);
            
            if (textBoxOffsetTexto.Text == "")
            {
                MessageBox.Show("Parâmetro inválido.");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) // Salva o arquivo
            {
                string fileToSave = saveFileDialog1.FileName; // Guarda o caminho do arquivo na variável
                
                System.IO.StreamReader inputPhotoIndex = new System.IO.StreamReader(cleanInput);

                string linha;
                int count = 0;

                string tempFileIndex = Path.GetTempFileName();

                using (var gravaIndex = new StreamWriter(tempFileIndex))
                {
                    while ((linha = inputPhotoIndex.ReadLine()) != null)
                    {
                        count++;

                        calculaPhotoIndex(linha);

                        //gravaLOG("[OUTPUT] Arquivo " + nomeArquivoOutput + " gravado com sucesso!");
                        
                        gravaIndex.WriteLine(linhaOutputIndex); // Grava linha no arquivo photoIndex.txt
                    }
                }

                File.Delete(fileToSave);
                File.Move(tempFileIndex, fileToSave);

                MessageBox.Show("Arquivo gerado com sucesso!");

                this.Close();
            }
          
        }

        private void textBoxOffsetTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != '.' && ch != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
