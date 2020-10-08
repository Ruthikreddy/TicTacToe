using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{

    class TicTacToeGame
    {
        public char[] board { get; set; }
        public char player = ' ';
        public char computer = ' ';
        /// <summary>
        /// Creating the TicTacToe game Board of size 3 x 3
        /// </summary>
        public void InitializeBoard()
        {
            board = new char[10];

            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }
        /// <summary>
        /// Choosing Option for between X and O for Player and Computer
        /// </summary>
        /// <returns></returns>
        public char ChooseOption()
        {
            Console.Write("Choose X or O : ");
            var input = Convert.ToChar(Console.ReadLine());

            return (input == 'X' || input == 'O') ? input : ChooseOption();
        }
        /// <summary>
        /// Printing the Board of size 3 X 3
        /// </summary>
        public void ShowBoard()
        {
            Console.WriteLine(""+board[1]+"|"+ board[2]+"|"+ board[3]);
            Console.WriteLine("" + board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("" + board[7] + "|" + board[8] + "|" + board[9]);


        }

    }
}
