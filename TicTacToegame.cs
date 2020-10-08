using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{

    class TicTacToeGame
    {
        
       
        public void InitializeBoard()
        {
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }


    }
}
