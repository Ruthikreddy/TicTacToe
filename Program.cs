﻿using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            var ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.InitializeBoard();
        }
    }
}