using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly_Game
{
    public partial class Game : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private Boolean P1BeenAroundOnce = false;
        private Boolean P2BeenAroundOnce = false;

        private String Player1, Player2;
        private static String Turn = "Player1";

        private int diceNumber;

        private int P1Space = 0, P2Space = 0;

        private int Player1Money = 0;
        private int Player2Money = 0;

        private const int NormalSpace = 54;
        private const int ConnerSpace = 69;

        private const int TopLeftConnerX = 46;
        private const int TopLeftConnerY = 46;

        private const int TopRightConnerX = 46;

        private const int BottomLeftConnerX = 616;

        const int BottomRightConnerX = 616;
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Enabled = false;
            btnEndGame.Enabled = true;
            btnRollDice.Enabled = true;
            Player1Money = 1500;
            Player2Money = 1500;
            lblP1Money.Text = Player1Money.ToString();
            lblP2Money.Text = Player2Money.ToString();

            pictureBox2.Left = pictureBox1.Left + TopLeftConnerX - (pictureBox2.Size.Width / 2);
            pictureBox2.Top = pictureBox1.Top + TopLeftConnerY - (pictureBox2.Size.Height / 2);
            pictureBox3.Left = pictureBox2.Left;
            pictureBox3.Top = pictureBox2.Top; 

            P1Space = 0;
            P2Space = 0;
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
            btnEndGame.Enabled = false;
            btnRollDice.Enabled = false;

            pictureBox2.Left = pictureBox1.Left + TopLeftConnerX - (pictureBox2.Size.Width / 2);
            pictureBox2.Top = pictureBox1.Top + TopLeftConnerY - (pictureBox2.Size.Height / 2);
            pictureBox2.Top = pictureBox1.Top + TopLeftConnerY - (pictureBox2.Size.Height / 2);
            pictureBox2.Top = pictureBox1.Top + TopLeftConnerY - (pictureBox2.Size.Height / 2);
            pictureBox2.Top = pictureBox1.Top + TopLeftConnerY - (pictureBox2.Size.Height / 2);
            pictureBox3.Left = pictureBox2.Left;
            pictureBox3.Top = pictureBox2.Top;

            Turn = "Player1";
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int diceNumber1 = random.Next(6) + 1;
            int diceNumber2 = random.Next(6)+ 1;
            diceNumber = diceNumber1 + diceNumber2;
            MovePlayer(diceNumber, Turn);
            if (Turn == "Player1")
                Turn = "Player2";
            else
                Turn = "Player1";

            lblTurn.Text = Turn;
        }

        private void MovePlayer(int spaces, String Player){
            if (Turn == "Player1")
            {
                while (spaces >= 1)
                {
                    if (P1BeenAroundOnce)
                    {
                        if (P1Space == 0)
                        {
                            Player1Money = Player1Money + 200;
                        }
                    }

                    if (P1Space < 10)
                    {
                        if (pictureBox2.Left == pictureBox1.Left + TopLeftConnerX - (pictureBox2.Size.Width / 2))
                        {
                            pictureBox2.Left = pictureBox2.Left + ConnerSpace;
                        }
                        else
                        {
                            if (P1Space == 9)
                                pictureBox2.Left = pictureBox2.Left + ConnerSpace;
                            else
                                pictureBox2.Left = pictureBox2.Left + NormalSpace;
                        }
                    }

                    if (P1Space >= 10 && P1Space < 20)
                    {
                        if (pictureBox2.Top == pictureBox1.Top + TopRightConnerX - (pictureBox2.Size.Width / 2))
                            pictureBox2.Top = pictureBox2.Top + ConnerSpace;
                        else
                        {
                            if (P1Space == 19)
                                pictureBox2.Top = pictureBox2.Top + ConnerSpace;
                            else
                                pictureBox2.Top = pictureBox2.Top + NormalSpace;
                        }
                    }
                    if (P1Space >= 20 && P1Space < 30)
                    {
                        if (pictureBox2.Left == pictureBox1.Left + BottomRightConnerX - (pictureBox2.Size.Width / 2))
                            pictureBox2.Left = pictureBox2.Left + (ConnerSpace * -1);
                        else
                        {
                            if (P1Space == 29)
                                pictureBox2.Left = pictureBox2.Left + (ConnerSpace * -1);
                            else
                                pictureBox2.Left = pictureBox2.Left + (NormalSpace * -1);
                        }
                    }
                    if (P1Space >= 30)
                    {
                        if (pictureBox2.Top == pictureBox1.Top + BottomLeftConnerX - (pictureBox2.Size.Width / 2))
                            pictureBox2.Top = pictureBox2.Top + (ConnerSpace * -1);
                        else
                        {
                            if (P1Space == 39)
                            {
                                pictureBox2.Top = pictureBox2.Top + (ConnerSpace * -1);
                                P1Space = -1;
                                P1BeenAroundOnce = true;
                            }
                            else
                                pictureBox2.Top = pictureBox2.Top + (NormalSpace * -1);
                        }
                    }
                    P1Space++;
                    spaces--;
                }

                CheckSpace(P1Space, Player1Money);
                lblP1Money.Text = Player1Money.ToString();
            }
            else if(Player == "Player2")
            {
                while (spaces >= 1)
                {
                    if (P2BeenAroundOnce)
                    {
                        if (P2Space == 0)
                        {
                            Player2Money = Player2Money + 200;
                        }
                    }

                    if (P2Space < 10)
                    {
                        if (pictureBox3.Left == pictureBox1.Left + TopLeftConnerX - (pictureBox3.Size.Width / 2))
                        {
                            pictureBox3.Left = pictureBox3.Left + ConnerSpace;
                        }
                        else
                        {
                            if (P2Space == 9)
                                pictureBox3.Left = pictureBox3.Left + ConnerSpace;
                            else
                                pictureBox3.Left = pictureBox3.Left + NormalSpace;
                        }
                    }

                    if (P2Space >= 10 && P2Space < 20)
                    {
                        if (pictureBox3.Top == pictureBox1.Top + TopRightConnerX - (pictureBox3.Size.Width / 2))
                            pictureBox3.Top = pictureBox3.Top + ConnerSpace;
                        else
                        {
                            if (P2Space == 19)
                                pictureBox3.Top = pictureBox3.Top + ConnerSpace;
                            else
                                pictureBox3.Top = pictureBox3.Top + NormalSpace;
                        }
                    }
                    if (P2Space >= 20 && P2Space < 30)
                    {
                        if (pictureBox3.Left == pictureBox1.Left + BottomRightConnerX - (pictureBox3.Size.Width / 2))
                            pictureBox3.Left = pictureBox3.Left + (ConnerSpace * -1);
                        else
                        {
                            if (P2Space == 29)
                                pictureBox3.Left = pictureBox3.Left + (ConnerSpace * -1);
                            else
                                pictureBox3.Left = pictureBox3.Left + (NormalSpace * -1);
                        }
                    }
                    if (P2Space >= 30)
                    {
                        if (pictureBox3.Top == pictureBox1.Top + BottomLeftConnerX - (pictureBox3.Size.Width / 2))
                            pictureBox3.Top = pictureBox3.Top + (ConnerSpace * -1);
                        else
                        {
                            if (P2Space == 39)
                            {
                                pictureBox3.Top = pictureBox3.Top + (ConnerSpace * -1);
                                P2Space = -1;
                                P1BeenAroundOnce = true;
                            }
                            else
                                pictureBox3.Top = pictureBox3.Top + (NormalSpace * -1);
                        }
                    }
                    P2Space++;
                    spaces--;
                }

                CheckSpace(P2Space, Player2Money);
                lblP2Money.Text = Player2Money.ToString();
            }
        }

        private static void CheckSpace(int space, int money){
            if (space == 2)
            {

            }
            else if (space == 4)
            {
                MessageBox.Show("You have been fined 200M for imcome tax", Turn);
                money = money - 200;
            }
            else if (space == 12)
            {
                MessageBox.Show("You have been fined 150M for not paying your electic bill!", Turn);
                money = money - 150;
            }
        }
    }
}
