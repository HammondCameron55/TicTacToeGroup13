using System;
using TicTacToeGroup13;

class TicTacToeGame
{
    static char[,] gameBoard = new char[3, 3]; // 3x3 game board

    static void Main(string[] args)
    {
        Supporting sup = new Supporting();


        // Initialize game board
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                gameBoard[row, col] = ' ';
            }
        }

        bool gameOver = false;
        char currentPlayer = 'X';
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        while (!gameOver)
        {
            Console.WriteLine("Current Player: " + currentPlayer);
            GetPlayerChoice(currentPlayer);

            
            

            sup.GameBoardPrint(gameBoard); // Assuming gameBoardPrint method takes gameBoard as an argument

            gameOver = sup.CheckWinner(gameBoard); // Assuming checkWinner method takes gameBoard as an argument

            if (sup.CheckWinner(gameBoard))
            {
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer} wins!");
            }
            else
            {
                if (currentPlayer == 'X')
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }
            }
        }
        Console.ReadLine();
    }

    // Method to get player choice and update the game board
    static void GetPlayerChoice(char currentPlayer)
    {
        int across, down;
        bool validInput = false;
        string userInput;

        while (!validInput)
        {
            Console.WriteLine("Where would you like to place your mark? Enter the corresponding coordinates:");
            Console.WriteLine("ex. 0,0  would place your mark at the top left and 2,2 would place your mark in the bottom right");
            Console.WriteLine("Please enter the horizontal coordinate: 0, 1, or 2");
            userInput = Console.ReadLine();
            if (userInput.Length == 1 && int.TryParse(userInput, out int n1) && int.Parse(userInput) <= 2) {
                across = int.Parse(userInput);
                Console.WriteLine("Please enter the vertical coordinate: 0, 1, or 2");
                userInput = Console.ReadLine();
                if (userInput.Length == 1 && int.TryParse(userInput, out int n2) && int.Parse(userInput) <= 2) {
                    down = int.Parse(userInput);

                    if (gameBoard[across, down] == ' ')
                    {
                        gameBoard[across, down] = currentPlayer;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("This position is already occupied. Please choose another position.");
                    }
                } 
                else
                {
                    Console.WriteLine("Invalid Input! Please enter a single digit between 1 and 2");
                }
            }
            else 
            {
                Console.WriteLine("Invalid Input! Please enter a single digit between 1 and 2");
            }
        }
    }
}
