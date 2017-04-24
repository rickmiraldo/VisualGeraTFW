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
    public partial class FormVisualizaDados : Form
    {
        public int numLinhasInput { set; get; }
        public int indexInput { set; get; }
        public string cleanInput { set; get; }
        public string Lx { set; get; }
        public string Ly { set; get; }
        public string Ps { set; get; }
        
        public FormVisualizaDados()
        {
            InitializeComponent();
            indexInput = 0;
        }

        private void atualizaValoresInput(string linha)
        {
            string[] linhaSplit = linha.Split('\t'); // Separa o conteúdo da linha por tabulação

            textBoxPhotoID.Text = linhaSplit[0];
            textBoxEast.Text = linhaSplit[1];
            textBoxNorth.Text = linhaSplit[2];
            textBoxHeight.Text = linhaSplit[3];
            textBoxOmega.Text = linhaSplit[4];
            textBoxPhi.Text = linhaSplit[5];
            textBoxKappa.Text = linhaSplit[6];
            textBoxGPSTime.Text = linhaSplit[7];

            bool checkLx = Lx != "" & Lx != null;
            bool checkLy = Ly != "" & Ly != null;
            bool checkPs = Ps != "" & Ps != null;
            
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
                double pixelSize = Convert.ToDouble(Ps);
                double tamanhoX = Convert.ToDouble(Lx);
                double tamanhoY = Convert.ToDouble(Ly);

                double kRad = kappaCent * Math.PI / 200;
                if (kRad < 0)
                {
                    kRad += 2 * Math.PI;
                }
                textBoxKrad.Text = Convert.ToString(kRad);

                double gamma = Math.Atan((tamanhoX - 1) / (tamanhoY - 1));
                textBoxGamma.Text = Convert.ToString(gamma);

                double theta = kRad + gamma + Math.PI / 2;
                textBoxTheta.Text = Convert.ToString(theta);

                double dist = Convert.ToDouble(Ps) * ((Math.Sqrt(Math.Pow(tamanhoX - 1, 2) + Math.Pow(tamanhoY - 1, 2))) / 2);
                textBoxDist.Text = Convert.ToString(dist);

                double resultA = Math.Cos(kRad) * pixelSize;
                textBoxResultA.Text = Convert.ToString(resultA);

                double resultB = Math.Sin(kRad) * pixelSize;
                textBoxResultB.Text = Convert.ToString(resultB);

                double resultC = eCP + dist * Math.Cos(theta);
                textBoxResultC.Text = Convert.ToString(resultC);

                double resultD = resultB;
                textBoxResultD.Text = Convert.ToString(resultD);

                double resultE = -resultA;
                textBoxResultE.Text = Convert.ToString(resultE);

                double resultF = nCP + dist * Math.Sin(theta);
                textBoxResultF.Text = Convert.ToString(resultF);

            }
            else
            {
                textBoxResultA.Clear();
                textBoxResultB.Clear();
                textBoxResultC.Clear();
                textBoxResultD.Clear();
                textBoxResultE.Clear();
                textBoxResultF.Clear();
                textBoxKrad.Clear();
                textBoxGamma.Clear();
                textBoxDist.Clear();
                textBoxTheta.Clear();
            }

            return;
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if ((indexInput + 1) < numLinhasInput)
            {
                indexInput++;

                string linha = File.ReadLines(cleanInput).Skip((indexInput)).Take(1).First();

                atualizaValoresInput(linha);

                textBoxCurrentIndexInput.Text = (indexInput + 1) + " / " + numLinhasInput;
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (indexInput > 0)
            {
                indexInput--;

                string linha = File.ReadLines(cleanInput).Skip((indexInput)).Take(1).First();

                atualizaValoresInput(linha);

                textBoxCurrentIndexInput.Text = (indexInput + 1) + " / " + numLinhasInput;
            }
        }

        private void FormVisualizaDados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


    }
}
