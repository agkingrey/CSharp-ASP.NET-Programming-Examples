using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSimulatorKingrey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create an array
            const int ROWS = 3;
            const int COLS = 3;
            int total;
            int topLeftDiagonal;
            int topRightDiagonal;
            int player1WinStatus = 0;
            int player2WinStatus = 0;
            int[,] generator = new int[ROWS,COLS];
            String[,] generatorFinal = new String[ROWS, COLS];

            //creat a random object
            Random rand = new Random();

            //fill the array with eith 0 or 1 and then set the 0 to O and 1 to X
            for (int row = 0; row < ROWS; row++)
            {
               for(int col = 0; col < COLS; col++)
                {
                    generator[row, col] = rand.Next(2);
                    String temp = generator[row, col].ToString();
                    if (temp.Equals("0"))
                    {
                        temp = "O";
                    }
                    if (temp.Equals("1"))
                    {
                        temp = "X";
                    }
                    generatorFinal[row, col] = temp;
                }
            }

            //This is to total up my rows to see if there is a winner
            for (int row = 0; row < ROWS; row++)
            {
                //accumulator
                total = 0;
                for (int col = 0; col < COLS; col++)
                {
                    total += generator[row, col];

                    
                }
                if (total == 0)
                {
                    player1WinStatus++;
                }
                if (total == 3)
                {
                    player2WinStatus++;
                }
            }
            //this totals up my collumns
              for(int col = 0; col < COLS; col++)
              {
                  total = 0;

                  for(int row = 0; row < ROWS; row++)
                  {
                      total+= generator[ row, col];

                      
                  }
                if (total == 0)
                {
                    player1WinStatus++;
                }
                if (total == 3)
                {
                    player2WinStatus++;
                }
             }

            //diagonal sums
            topLeftDiagonal = generator[0, 0] + generator[1, 1] + generator[2, 2];
            if(topLeftDiagonal == 0)
            {
                player1WinStatus++;
            }
            if(topLeftDiagonal == 3)
            {
                player2WinStatus++;
            }

            topRightDiagonal = generator[2, 0] + generator[1, 1] + generator[0, 2];
            if (topRightDiagonal == 0)
            {
                player1WinStatus++;
            }
            if (topRightDiagonal == 3)
            {
                player2WinStatus++;
            }
            
            //if statements for the winner
            if(player1WinStatus > player2WinStatus)
            {
                winnerLbl.Text = "Player O wins";
            }
            else if(player2WinStatus > player1WinStatus)
            {
                winnerLbl.Text = "Player X wins";
            }
            else if(player1WinStatus == player2WinStatus)
            {
                winnerLbl.Text = "Tie game";
            }

            //Put the array element in the label controls
            firstLbl.Text = generatorFinal[0,0].ToString();
            secondLbl.Text = generatorFinal[0,1].ToString();
            thirdLbl.Text = generatorFinal[0,2].ToString();
            fourthLbl.Text = generatorFinal[1,0].ToString();
            fifthLbl.Text = generatorFinal[1,1].ToString();
            sixthLbl.Text = generatorFinal[1,2].ToString();
            seventhLbl.Text = generatorFinal[2,0].ToString();
            eighthLbl.Text = generatorFinal[2,1].ToString();
            ninthLbl.Text = generatorFinal[2,2].ToString();
            
        }

        private void seventhLbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
