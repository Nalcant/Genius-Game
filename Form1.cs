using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mestre_Mandou
{
    public partial class Form1 : Form
    {

        //variaveis
        string[] sequenciaEmJogo;
        string[] jogadas;
        string[] sequencia;
        int numJogadas = 1;
        int turno;
        int indiceCor = 0;
        Random random = new Random();


        //Métodos 

        //sequencia inteira da partida 
        public void define_sequencia(int tamanhoSequencia)
        {
            sequencia = new string[tamanhoSequencia];
            for (int i = 0; i < tamanhoSequencia; i++)
            {
                int valorCor = random.Next(0, 4);
                if (valorCor == 0)
                {
                    sequencia[i] = "azul";

                }
                if (valorCor == 1)
                {
                    sequencia[i] = "amarelo";
                }
                if (valorCor == 2)
                {
                    sequencia[i] = "vermelho";
                }
                if (valorCor == 3)
                {
                    sequencia[i] = "verde";
                }
            }
        }
        //montando sequencia para o jogo
        public void defineSequenciaMostrada(int turno)
        {
            if (turno - 1 < sequencia.Length)
            {
                sequenciaEmJogo = new string[turno];

                for (int i = 0; i <= turno - 1; i++)
                {
                    sequenciaEmJogo[i] = sequencia[i];
                }
            }


        }
        //continuando o jogo 
        public void continuaJogo()
        {

            numJogadas++;
            jogadas = new string[numJogadas];
            for (int i = 0; i < numJogadas - 1; i++)
            {
                jogadas[i] = sequenciaEmJogo[i];
            }
            if (numJogadas == sequenciaEmJogo.Length + 1)
            {
                numJogadas = 1;
                turno++;
                defineSequenciaMostrada(turno);
                if (turno <= sequencia.Length)
                {
                    timer1.Enabled = true;

                }
            }
            if (turno == sequencia.Length + 1)
            {
                MessageBox.Show("Parabéns, tente outras dificuldades");
                reiniciador();
            }
        }
        //reiniciando valores do jogo, "reload"

        public void reiniciador()
        {
            sequenciaEmJogo = new string[0];
            jogadas = new string[0];
            sequencia = new string[0];
            numJogadas = 1;
            turno = 1;
        }

        //Processamento no forms 
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (indiceCor < sequenciaEmJogo.Length)
            {
                //apagando cores
                if (ptbPiscaAzul.Visible == true)
                {
                    ptbPiscaAzul.Visible = false;
                }
                if (ptbPiscaAmarelo.Visible == true)
                {
                    ptbPiscaAmarelo.Visible = false;
                }
                if (ptbPiscaVerde.Visible == true)
                {
                    ptbPiscaVerde.Visible = false;
                }
                if (ptbPiscaVermelho.Visible == true)
                {
                    ptbPiscaVermelho.Visible = false;
                }

                //ascendendo cores
                if (sequenciaEmJogo[indiceCor] == "azul")
                {

                    ptbPiscaAzul.Visible = true;
                }

                if (sequenciaEmJogo[indiceCor] == "amarelo")
                {

                    ptbPiscaAmarelo.Visible = true;
                }
                if (sequenciaEmJogo[indiceCor] == "vermelho")
                {

                    ptbPiscaVermelho.Visible = true;
                }
                if (sequenciaEmJogo[indiceCor] == "verde")
                {
                    ptbPiscaVerde.Visible = true;
                }

                //apagando ultima cor 
                if (indiceCor == sequenciaEmJogo.Length)
                {
                    if (ptbPiscaAzul.Visible == true)
                    {
                        ptbPiscaAzul.Visible = false;
                    }
                    if (ptbPiscaAmarelo.Visible == true)
                    {
                        ptbPiscaAmarelo.Visible = false;
                    }
                    if (ptbPiscaVerde.Visible == true)
                    {
                        ptbPiscaVerde.Visible = false;
                    }
                    if (ptbPiscaVermelho.Visible == true)
                    {
                        ptbPiscaVermelho.Visible = false;
                    }
                    timer1.Enabled = false;
                    indiceCor = 0;

                }
                indiceCor++;


            }
            //apagando primeira cor
            else
            {
                if (ptbPiscaAzul.Visible == true)
                {
                    ptbPiscaAzul.Visible = false;
                }
                if (ptbPiscaAmarelo.Visible == true)
                {
                    ptbPiscaAmarelo.Visible = false;
                }
                if (ptbPiscaVerde.Visible == true)
                {
                    ptbPiscaVerde.Visible = false;
                }
                if (ptbPiscaVermelho.Visible == true)
                {
                    ptbPiscaVermelho.Visible = false;
                }
                indiceCor = 0;
                timer1.Enabled = false;
            }

        }

        //dificuldades

        private void btFacil_Click(object sender, EventArgs e)
        {

            define_sequencia(8);
        }
        private void btMedio_Click(object sender, EventArgs e)
        {

            define_sequencia(16);
        }
        private void btDificil_Click(object sender, EventArgs e)
        {

            define_sequencia(32);
        }

        //*********começo do jogo
        private void btStart_Click(object sender, EventArgs e)
        {
            //definir em que turno estamos 
            turno = 1;
            jogadas = new string[numJogadas];
            //mostrar a primeira sequencia 
            defineSequenciaMostrada(turno);
            timer1.Enabled = true;
            //} while (indiceCor >=sequenciaEmJogo.Length)  
        }


        //clique nos botões
        private void ptbAmarelo_Click(object sender, EventArgs e)
        {

            //atribuindo resposta desse turno
            jogadas[numJogadas - 1] = "amarelo";
            //verificando resposta
            if (jogadas[numJogadas - 1] == sequenciaEmJogo[numJogadas - 1])
            {
                continuaJogo();
            }
            else
            {
                MessageBox.Show("Você errou, boa sorte na próxima");
                reiniciador();
            }
        }

        private void ptbAzul_Click(object sender, EventArgs e)
        {
            jogadas[numJogadas - 1] = "azul";

            if (jogadas[numJogadas - 1] == sequenciaEmJogo[numJogadas - 1])
            {

                continuaJogo();
            }
            else
            {
                MessageBox.Show("Você errou, boa sorte na próxima");
                reiniciador();
            }

        }

        private void ptbVerde_Click(object sender, EventArgs e)
        {
            jogadas[numJogadas - 1] = "verde";

            if (jogadas[numJogadas - 1] == sequenciaEmJogo[numJogadas - 1])
            {
                continuaJogo();

            }
            else
            {
                MessageBox.Show("Você errou, boa sorte na próxima");
                reiniciador();
            }

        }

        private void ptbVeremelho_Click(object sender, EventArgs e)
        {
            jogadas[numJogadas - 1] = "vermelho";

            if (jogadas[numJogadas - 1] == sequenciaEmJogo[numJogadas - 1])
            {
                continuaJogo();

            }
            else
            {
                MessageBox.Show("Você errou, boa sorte na próxima");
                reiniciador();
            }


        }
    }
}
