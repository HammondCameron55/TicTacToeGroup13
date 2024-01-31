using System;

class Program
{
    static char[,] gameBoard = new char[3, 3]; // 3x3 game board

    static void Main(string[] args)
    {
        // welcome user to the game
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // create game board array
        CreateBoard(gameBoard);

        // make current player
        char currentPlayer = 'X';
    }

    // method that creates and initializes the game board
    static void CreateBoard(char[,] board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = ' ';
            }
        }
    }

    // method to get player choice
    static void GetPlayerChoice(char currentPlayer)
    {

    }
}
