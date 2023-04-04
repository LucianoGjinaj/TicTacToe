using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] gameBoard = new string[9];
        int currentTurn = 0;

        public string returnSymbol(int turn)
        {
            if(turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public void checkWinner()
        {
            for (int i=0; i<9; i++)
            {
                string combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    MessageBox.Show("Playear O wins the game","We have a winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                    return;
                }else if (combination.Equals("XXX"))
                {
                    MessageBox.Show("Playear X wins the game", "We have a winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                    return;
                }
            }
            checkDraw();
        }

        public void reset()
        {
            button00.Text = "";
            button01.Text = "";
            button02.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            gameBoard = new string[9];
            currentTurn = 0;

        }

        public void checkDraw()
        {
            int counter = 0;
            for(int i = 0; i < gameBoard.Length; i++)
            {
                if(gameBoard[i] != null) { counter++; }
                if(counter == 9)
                {
                    MessageBox.Show("That is a Draw","We don't have a winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                }
            }
        }
        private void button00_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[0] = returnSymbol(currentTurn);
            button00.Text = gameBoard[0];
            checkWinner();
        }

        private void button01_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSymbol(currentTurn);
            button01.Text = gameBoard[1];
            checkWinner();

        }

        private void button02_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            button02.Text = gameBoard[2];
            checkWinner();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);
            button10.Text = gameBoard[3];
            checkWinner();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            button11.Text = gameBoard[4];
            checkWinner();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            button12.Text = gameBoard[5];
            checkWinner();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            button20.Text = gameBoard[6];
            checkWinner();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            button21.Text = gameBoard[7];
            checkWinner();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            button22.Text = gameBoard[8];
            checkWinner();

        }
    }
}
