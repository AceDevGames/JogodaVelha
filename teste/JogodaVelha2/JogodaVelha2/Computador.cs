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
    public partial class Computador : Form
    {
        public Computador()
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


        private void Ofensivo()
        {
            if (Global.turn == true)
            {
                for (int i = 1; i <= 17; i++)
                {
                    if (i == 17 && Global.turn == true)
                    {
                        Defensivo();
                    }
                    if (Global.A == 2 && Global.B == 2 && Global.C == 0 && Global.turn == true ||
                        Global.E == 2 && Global.I == 2 && Global.A == 0 && Global.turn == true ||
                        Global.G == 2 && Global.H == 2 && Global.A == 0 && Global.turn == true)
                    {
                        Global.A = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                        
                    }

                    if (Global.A == 2 && Global.C == 2 && Global.B == 0 && Global.turn == true ||
                        Global.E == 2 && Global.H == 2 && Global.B == 0 && Global.turn == true)
                    {
                        Global.B = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }

                    if (Global.A == 2 && Global.B == 2 && Global.C == 0 && Global.turn == true ||
                        Global.I == 2 && Global.F == 2 && Global.C == 0 && Global.turn == true ||
                        Global.G == 2 && Global.E == 2 && Global.C == 0 && Global.turn == true)
                    {
                        Global.C = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }

                    if (Global.A == 2 && Global.G == 2 && Global.D == 0 && Global.turn == true ||
                        Global.E == 2 && Global.F == 2 && Global.D == 0 && Global.turn == true)
                    {
                        Global.D = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }

                    if (Global.B == 2 && Global.H == 2 && Global.E == 0 && Global.turn == true ||
                        Global.D == 2 && Global.F == 2 && Global.E == 0 && Global.turn == true)
                    {
                        Global.E = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }

                    if (Global.D == 2 && Global.E == 2 && Global.F == 0 && Global.turn == true ||
                        Global.C == 2 && Global.C == 2 && Global.F == 0 && Global.turn == true)
                    {
                        Global.F = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }


                    if (Global.D == 2 && Global.A == 2 && Global.G == 0 && Global.turn == true ||
                        Global.H == 2 && Global.I == 2 && Global.G == 0 && Global.turn == true ||
                        Global.C == 2 && Global.E == 2 && Global.G == 0 && Global.turn == true)
                    {
                        Global.G = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }

                    if (Global.G == 2 && Global.I == 2 && Global.H == 0 && Global.turn == true ||
                        Global.E == 2 && Global.B == 2 && Global.H == 0 && Global.turn == true)
                    {
                        Global.H = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }

                    if (Global.G == 2 && Global.G == 2 && Global.I == 0 && Global.turn == true ||
                        Global.C == 2 && Global.E == 2 && Global.I == 0 && Global.turn == true)
                    {
                        Global.I = 2;
                        Global.rounds++;
                        Global.turn = false;
                        checkingWinner();
                    }
                }
            }
        }

        private void Defensivo()
        {

            if (Global.turn == true)
            {

                for (int r = 1; r <= 17; r++)
                {
                    if (r == 17 && Global.turn == true)
                    {
                        Randomico();
                    }
                    {


                        if (Global.B == 1 && Global.C == 1 && Global.A == 0 && Global.turn == true ||
                            Global.E == 1 && Global.I == 1 && Global.A == 0 && Global.turn == true ||
                            Global.G == 1 && Global.H == 1 && Global.A == 0 && Global.turn == true)
                        {
                            Global.A = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }

                        if (Global.A == 1 && Global.C == 1 && Global.B == 0 && Global.turn == true ||
                            Global.E == 1 && Global.H == 1 && Global.B == 0 && Global.turn == true)
                        {
                            Global.B = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }

                        if (Global.A == 1 && Global.B == 1 && Global.C == 0 && Global.turn == true ||
                            Global.I == 1 && Global.F == 1 && Global.C == 0 && Global.turn == true ||
                            Global.G == 1 && Global.E == 1 && Global.C == 0 && Global.turn == true)
                        {
                            Global.C = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }

                        if (Global.A == 1 && Global.G == 1 && Global.D == 0 && Global.turn == true ||
                            Global.E == 1 && Global.F == 1 && Global.D == 0 && Global.turn == true)
                        {
                            Global.D = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }

                        if (Global.B == 1 && Global.H == 1 && Global.E == 0 && Global.turn == true ||
                            Global.D == 1 && Global.F == 1 && Global.E == 0 && Global.turn == true)
                        {
                            Global.E = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }

                        if (Global.D == 1 && Global.E == 1 && Global.F == 0 && Global.turn == true ||
                            Global.C == 1 && Global.C == 1 && Global.F == 0 && Global.turn == true)
                        {
                            Global.F = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }


                        if (Global.D == 1 && Global.A == 1 && Global.G == 0 && Global.turn == true ||
                            Global.H == 1 && Global.I == 1 && Global.G == 0 && Global.turn == true ||
                            Global.C == 1 && Global.E == 1 && Global.G == 0 && Global.turn == true)
                        {
                            Global.G = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }

                        if (Global.G == 1 && Global.I == 1 && Global.H == 0 && Global.turn == true ||
                            Global.E == 1 && Global.B == 1 && Global.H == 0 && Global.turn == true)
                        {
                            Global.H = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }

                        if (Global.G == 1 && Global.G == 1 && Global.I == 0 && Global.turn == true ||
                            Global.C == 1 && Global.E == 1 && Global.I == 0 && Global.turn == true)
                        {
                            Global.I = 2;
                            Global.rounds++;
                            Global.turn = false;
                            checkingWinner();
                        }
                    }
                }
            }
        }

        private void Randomico()
        {
            bool looping = false;
            if (Global.turn == true)
            {
                looping = true;

            }

            while (looping != false)
            {
                Random rand = new Random();
                int randomizado = rand.Next(1, 9);

                switch (randomizado)
                {
                    case 1:
                        {
                            if (button1.Text == "" && Global.turn == true)
                            {
                                button1.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 2:
                        {
                            if (button2.Text == "" && Global.turn == true)
                            {
                                button2.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 3:
                        {
                            if (button3.Text == "" && Global.turn == true)
                            {
                                button3.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 4:
                        {
                            if (button4.Text == "" && Global.turn == true)
                            {
                                button4.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 5:
                        {
                            if (button5.Text == "" && Global.turn == true)
                            {
                                button5.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 6:
                        {
                            if (button6.Text == "" && Global.turn == true)
                            {
                                button6.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 7:
                        {
                            if (button7.Text == "" && Global.turn == true)
                            {
                                button7.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 8:
                        {
                            if (button8.Text == "" && Global.turn == true)
                            {
                                button8.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }

                    case 9:
                        {
                            if (button9.Text == "" && Global.turn == true)
                            {
                                button9.Text = "O";
                                Global.rounds++;
                                Global.turn = false;
                                looping = false;
                                checkingWinner();
                            }
                            break;
                        }
                }

                
            }

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

            if (Global.A == 1 && Global.B == 1 && Global.C == 1)
                {
                    Global.player_winner = 1;
                    Vitorias();
                }
            if(Global.D == 1 && Global.E == 1 && Global.F == 1 )
                {
                    Global.player_winner = 1;
                    Vitorias();
                }
            if(Global.G == 1 && Global.H == 1 && Global.I == 1 )
                {
                    Global.player_winner = 1;
                    Vitorias();
                }

            if(Global.A == 1 && Global.D == 1 && Global.G == 1 )
                {
                    Global.player_winner = 1;
                    Vitorias();
                }

            if (Global.B == 1 && Global.E == 1 && Global.H == 1 )
                {
                    Global.player_winner = 1;
                    Vitorias();
                }

            if(Global.C == 1 && Global.F == 1 && Global.I == 1)
                {
                    Global.player_winner = 1;
                    Vitorias();
                }
            if(Global.A == 1 && Global.E == 1 && Global.I == 1 )
                {
                    Global.player_winner = 1;
                    Vitorias();
                }

            if(Global.G == 1 && Global.E == 1 && Global.C == 1)
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

            if (Global.A == 2 && Global.B == 2 && Global.C == 2)
            {
                Global.player_winner = 2;
                Vitorias();
            }

            if(Global.D == 2 && Global.E == 2 && Global.F == 2 )
            {
                Global.player_winner = 2;
                Vitorias();
            }

            if (Global.G == 2 && Global.H == 2 && Global.I == 2 )
            {
                Global.player_winner = 2;
                Vitorias();
            }

            if (Global.A == 2 && Global.D == 2 && Global.G == 2 )
            {
                Global.player_winner = 2;
                Vitorias();
            }

            if (Global.B == 2 && Global.E == 2 && Global.H == 2 )
            {
                Global.player_winner = 2;
                Vitorias();
            }

            if (Global.C == 2 && Global.F == 2 && Global.I == 2 )
            {
                Global.player_winner = 2;
                Vitorias();
            }

            if (Global.A == 2 && Global.E == 2 && Global.I == 2 )
            {
                Global.player_winner = 2;
                Vitorias();
            }

            if (Global.C == 2 && Global.E == 2 && Global.G == 2)
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
                MessageBox.Show("Empate");
                Global.tie++;
                label6.Text = Convert.ToString(Global.tie);
                Global.button_disable = true;
            }

            if (Global.turn == true && Global.player_winner == 0 && Global.rounds != 9)
            {
                Ofensivo();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button1.Text == "")
            {
                button1.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button2.Text == "")
            {
                button2.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button3.Text == "")
            {
                button3.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button4.Text == "")
            {
                button4.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button5.Text == "")
            {
                button5.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button6.Text == "")
            {
                button6.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button7.Text == "")
            {
                button7.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button8.Text == "")
            {
                button8.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.button_disable == false && button9.Text == "")
            {
                button9.Text = "X";
                Global.rounds++;
                Global.turn = true;
                checkingWinner();
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
            Global.rounds = 0;
            Global.button_disable = false;

            if (Global.player_winner == 1 || Global.player_winner == 0)
            {
                Global.turn = false;
                Global.player_winner = 0;
            }
            else
            {
                Global.turn = true;
                Global.player_winner = 0;
                checkingWinner();
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
    }
}
