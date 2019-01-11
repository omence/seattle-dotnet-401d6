using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{
            string[,] gameBoard = GameBoard;

            for (int i = 0; i < gameBoard.Length; i++)
            {
                for (int j = 0; j < gameBoard[i].Length; j++)
                {
                    Console.WriteLine($"|{gameBoard[i][j]}|");
                }
                
            }
		
		}
	}
}
