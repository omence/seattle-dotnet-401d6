using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
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

        /// <summary>
        /// Display the board
        /// </summary>
		public void DisplayBoard()
		{
            string[,] gameBoard = GameBoard;

            for (int i = 0; i < gameBoard.GetLength(0); i++)
     
            {
          
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    Console.Write($"|{gameBoard[i, j]}| ");
                   
                }
                Console.WriteLine();
            }
		
		}
	}
}
