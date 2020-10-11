using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TicTacToe
{

    class TicTacToeGame
    {
        public char[] board { get; set; }
        public enum Player { User, Computer };
        public const int HEADS = 0;
        public const int TAILS = 1;
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
            Console.WriteLine("" + board[1] + "|" + board[2] + "|" + board[3]);
            Console.WriteLine("-----");
            Console.WriteLine("" + board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("-----");
            Console.WriteLine("" + board[7] + "|" + board[8] + "|" + board[9]);
        }
        public void MakeMove()
        {

            Console.Write("Choose an Index to mark : ");
            var index = Convert.ToInt32(Console.ReadLine());
            var isFree = CheckFreeSpace(index);

            if (index <= 0 || index > 9)
            {
                Console.WriteLine("Invalid Input!\nTry Again");
                MakeMove();
            }
            else if (board[index] != ' ')
            {
                Console.WriteLine("The Location is not empty please select a different location");
                MakeMove();
            }
            else
            {
                board[index] = player;
                ShowBoard();

            }
            if (IsWinner(player))
                Console.WriteLine("Player Won the game.");
        }
        public bool CheckFreeSpace(int index)
        {
            return board[index] == ' ';
        }

        public Player Toss()
        {
            return new Random().Next(0, 2) == 1 ? Player.User : Player.Computer;
        }
        /// <summary>
        /// Checking Input Character and Rules For wining Player
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public bool IsWinner(char ch)
        {
            return ((board[1] == ch && board[2] == ch && board[3] == ch) ||
                    (board[4] == ch && board[5] == ch && board[6] == ch) ||
                    (board[7] == ch && board[8] == ch && board[9] == ch) ||
                    (board[1] == ch && board[4] == ch && board[7] == ch) ||
                    (board[2] == ch && board[5] == ch && board[8] == ch) ||
                    (board[3] == ch && board[6] == ch && board[9] == ch) ||
                    (board[1] == ch && board[5] == ch && board[9] == ch) ||
                    (board[3] == ch && board[5] == ch && board[7] == ch));
        }
          
        
    }
}
