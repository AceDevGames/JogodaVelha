using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha2
{
    public partial class Jogador : Form
    {
        public Jogador()
        {
            InitializeComponent();
        }


        // Variáveis globais
        public static class Global
        {
            public static bool turn, button_disable;
            public static int player1_wins = 0, player2_wins = 0, tie = 0, player_winner, rounds = 0, A = 0, B = 0, C = 0, D = 0,
                              E = 0, F = 0, G = 0, H = 0, I = 0, adversario = 1;

        }


        private void checkingWinner()
        {

            // *****************************************************************************************************//
            //                                                                                                      //
            //                                                                                                      //
            //                              Validações do primeiro jogador                                          //
            //                                                                                                      //
            //                                                                                                      //
            // *****************************************************************************************************//



            // Verificações de vitórias do primeiro jogador (X) em todas as direções possiveis:

            if (Global.A == 1 && Global.B == 1 && Global.C == 1 ||
                Global.D == 1 && Global.E == 1 && Global.F == 1 ||
                Global.G == 1 && Global.H == 1 && Global.I == 1 ||

                Global.A == 1 && Global.D == 1 && Global.G == 1 ||
                Global.B == 1 && Global.E == 1 && Global.H == 1 ||
                Global.C == 1 && Global.F == 1 && Global.I == 1 ||

                Global.A == 1 && Global.E == 1 && Global.I == 1 ||
                Global.G == 1 && Global.E == 1 && Global.C == 1)
            {
                Global.player_winner = 1;
                Vitorias();
            }



            // *****************************************************************************************************//
            //                                                                                                      //
            //                                                                                                      //
            //                              Validações do segundo jogador                                           //
            //                                                                                                      //
            //                                                                                                      //
            // *****************************************************************************************************//


            // Verificações de vitórias do segundo jogador (X) em todas as direções possiveis:

            if (Global.A == 2 && Global.B == 2 && Global.C == 2 ||
                Global.D == 2 && Global.E == 2 && Global.F == 2 ||
                Global.G == 2 && Global.H == 2 && Global.I == 2 ||

                Global.A == 2 && Global.D == 2 && Global.G == 2 ||
                Global.B == 2 && Global.E == 2 && Global.H == 2 ||
                Global.C == 2 && Global.F == 2 && Global.I == 2 ||

                Global.A == 2 && Global.E == 2 && Global.I == 2 ||
                Global.C == 2 && Global.E == 2 && Global.G == 2)
            {
                Global.player_winner = 2;
                Vitorias();
            }


            // *****************************************************************************************************//
            //                                                                                                      //
            //                                                                                                      //
            //                              Validando empates                                                       //
            //                                                                                                      //
            //                                                                                                      //
            // *****************************************************************************************************//




            if (Global.player_winner == 0 && Global.rounds == 9)
            {
                Empate();
            }
        }

        private void Empate()
        {
            Global.tie++;
            label6.Text = Convert.ToString(Global.tie);
            MessageBox.Show("Empate");
            Global.button_disable = true;
        }


        private void Vitorias()
        // define o jogador vitorioso e apresenta o resultado

        {
            if (Global.player_winner == 1)
            {
                Global.player1_wins++;
                label4.Text = Convert.ToString(Global.player1_wins);
                MessageBox.Show("Jogador 1 venceu!");
                Global.button_disable = true;
            }
            else if (Global.player_winner == 2)
            {
                Global.player2_wins++;
                label5.Text = Convert.ToString(Global.player2_wins);
                MessageBox.Show("Jogador 2 venceu!");
                Global.button_disable = true;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do primeiro jogador - player 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.A == 0)
            {
                button1.Text = "X";
                Global.A = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do segundo jogador - player 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.A == 0)
            {
                button1.Text = "O";
                Global.A = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.B == 0)
            {
                button2.Text = "X";
                Global.B = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.B == 0)
            {
                button2.Text = "O";
                Global.B = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.C == 0)
            {
                button3.Text = "X";
                Global.C = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.C == 0)
            {
                button3.Text = "O";
                Global.C = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.D == 0)
            {
                button4.Text = "X";
                Global.D = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.D == 0)
            {
                button4.Text = "O";
                Global.D = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }
    

        private void button5_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.E == 0)
            {
                button5.Text = "X";
                Global.E = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.E == 0)
            {
                button5.Text = "O";
                Global.E = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.F == 0)
            {
                button6.Text = "X";
                Global.F = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.F == 0)
            {
                button6.Text = "O";
                Global.F = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.G == 0)
            {
                button7.Text = "X";
                Global.G = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.G == 0)
            {
                button7.Text = "O";
                Global.G = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.H == 0)
            {
                button8.Text = "X";
                Global.H = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.H == 0)
            {
                button8.Text = "O";
                Global.H = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Verificação da jogada do jogador 1(X):

            if (Global.turn == false && Global.button_disable == false && Global.I == 0)
            {
                button9.Text = "X";
                Global.I = 1;
                Global.rounds++;
                checkingWinner();
                Global.turn = true;
            }
            // Verificação da jogada do jogador 2(O):
            if (Global.turn == true && Global.button_disable == false && Global.I == 0)
            {
                button9.Text = "O";
                Global.I = 2;
                Global.rounds++;
                checkingWinner();
                Global.turn = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Global.A = 0;
            Global.B = 0;
            Global.C = 0;
            Global.D = 0;
            Global.E = 0;
            Global.F = 0;
            Global.G = 0;
            Global.H = 0;
            Global.I = 0;
            Global.rounds = 0;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            Global.button_disable = false;

            if (Global.player_winner == 1 || Global.player_winner == 0)
            {
                Global.turn = false;
                Global.player_winner = 0;
            }
            else if (Global.player_winner == 2)
            {
                Global.turn = true;
                Global.player_winner = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto desenvolvido por Rodrigo Acevedo!");
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
