using System;

namespace TicTacToeGroup13
{
    internal class Supporting
    {
        // Method to print board based on information
        public void GameBoardPrint(char[,] gameBoard)
        {
            Console.WriteLine("Current Board:");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(gameBoard[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        // Method to receive game board array as input and return if there was a winner
        public bool CheckWinner(char[,] gameBoard)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (gameBoard[row, 0] == gameBoard[row, 1] && gameBoard[row, 1] == gameBoard[row, 2] && gameBoard[row, 0] != ' ')
                {
                    Console.WriteLine($"Player {gameBoard[row, 0]} wins!");
                    return true;
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (gameBoard[0, col] == gameBoard[1, col] && gameBoard[1, col] == gameBoard[2, col] && gameBoard[0, col] != ' ')
                {
                    Console.WriteLine($"Player {gameBoard[0, col]} wins!");
                    return true;
                }
            }

            // Check diagonals
            if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2] && gameBoard[0, 0] != ' ')
            {
                Console.WriteLine($"Player {gameBoard[0, 0]} wins!");
                return true;
            }

            if (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0] && gameBoard[0, 2] != ' ')
            {
                Console.WriteLine($"Player {gameBoard[0, 2]} wins!");
                return true;
            }

            return false;
        }
    }
}

