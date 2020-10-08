using System;
using System.Collections.Generic;
using System.Dynamic;
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
            Console.WriteLine("-----");
            Console.WriteLine("" + board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("-----");
            Console.WriteLine("" + board[7] + "|" + board[8] + "|" + board[9]);
        }
        public void MakeMove()
        {
            Console.WriteLine("Choose the desired Index from 1 to 9");
            int index= Convert.ToInt32(Console.ReadLine());
            var isFree = CheckFreeSpace(index);

            if (index<0||index>9)
                {
                    Console.WriteLine("Invalid Index selected please enter Index from 1 to 9");
                    index = Convert.ToInt32(Console.ReadLine());
                }
            if (!isFree)
            {
                Console.WriteLine("The Location is not empty please select a different location");
                index = Convert.ToInt32(Console.ReadLine());
            }
            else
                {
                    board[index] = player;
                    ShowBoard();

                }


        }
        public bool CheckFreeSpace(int index)
        {
            if (board[index] == ' ')
                return true;
            else
                return false;
        }
    }
}
