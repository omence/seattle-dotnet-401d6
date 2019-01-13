using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void WinWorks()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard[0, 0] = "O";
            game.Board.GameBoard[1, 0] = "O";
            game.Board.GameBoard[2, 0] = "O";

            //assert
            Assert.True(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void SwitchPlayersWorks()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";

            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            //assert
            game.SwitchPlayer();
            Assert.True(game.PlayerOne.IsTurn);

            game.SwitchPlayer();
            Assert.True(game.PlayerTwo.IsTurn);
        }

        [Fact]
        public void CorrectIndexWorks()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";

            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            Position positionOne = Player.PositionForNumber(1);
            Position positionTwo = Player.PositionForNumber(2);

            game.Board.GameBoard[positionOne.Row, positionOne.Column] = playerOne.Marker;
            game.Board.GameBoard[positionTwo.Row, positionTwo.Column] = playerTwo.Marker;

            //assert
            Assert.Equal("X", game.Board.GameBoard[0, 0]);
            Assert.Equal("O", game.Board.GameBoard[0, 1]);
        }

        [Fact]
        public void DrawWorks()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";

            Player playerTwo = new Player();
            playerTwo.Marker = "O";
            
            

            //act
            Game game = new Game(playerOne, playerTwo);
            game.Play.turns = 9;
            //assert

            Assert.Equal(1, game.Play.draw);
        }
    }
}
