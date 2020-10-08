using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{

    class TicTacToeGame
    {

        public char player { get; set; }
        public char computer { get; set; }
        public void InitializeBoard()
        {
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }
        public char ChooseOption()
        {
            Console.Write("Choose X or O : ");
            var input = Convert.ToChar(Console.ReadLine());
            char input = Convert.ToChar(Console.ReadLine());
            //if player selects X
            if (input == 'X')
            {
                playerChar = 'X';
                systemChar = 'O';
            }
            //if player selects O
            else if (input == 'O')
            {
                playerChar = 'O';
                systemChar = 'X';
            }
            return (input == 'X' || input == 'O') ? input : ChooseOption();
        }

    }
}
