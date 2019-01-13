using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        /// <summary>
        /// Creates instances of game and plaer classes and runs the game
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Console.WriteLine("Player One what is your name?");
            playerOne.Name = Console.ReadLine();
            playerOne.Marker = "X";
            Console.WriteLine("player two what is your name?");
            playerTwo.Name = Console.ReadLine();
            playerTwo.Marker = "O";

            Game newGame = new Game(playerOne, playerTwo);
            newGame.Play();
            Console.ReadLine();
        }
    }
}
