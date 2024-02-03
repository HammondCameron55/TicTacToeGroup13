using System;
using TicTacToeGroup13;


// Tic - Tac - Toe
// Cameron Hammond
// Jimmy Diaz
// Alex Baker
// Gabe Larson
// 2/2/2024

// This program allows the user to play tic tac toe with their closest friend!
class TicTacToeGame
{   
    //This creates the array that holds the game board
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

        //Declare necessary variable
        bool gameOver = false;
        char currentPlayer = 'X';

        //Welcome user
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        //Loop to keep game going till it ends
        while (!gameOver)
        {
            
            Console.WriteLine("Current Player: " + currentPlayer);

            //Calls method to print game board
            sup.GameBoardPrint(gameBoard);

            //Calls method to get the players choice.
            GetPlayerChoice(currentPlayer);

                    

            gameOver = sup.CheckWinner(gameBoard); // Assuming checkWinner method takes gameBoard as an argument

            //Calls method to see if game has ended.
            if (sup.CheckWinner(gameBoard))
            {
                gameOver = true;
                Console.WriteLine($"Player {currentPlayer} wins!");
                sup.GameBoardPrint(gameBoard );
            }
            //Check if board is full
            else if (sup.IsBoardFull(gameBoard))
            {
                Console.WriteLine("The game is a draw.");
                gameOver = true;
                sup.GameBoardPrint(gameBoard);
            }
            //Changes who's turn it is
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
            //Describes the game
            Console.WriteLine("Where would you like to place your mark? Enter the corresponding coordinates:");
            Console.WriteLine("ex. 0,0  would place your mark at the top left and 2,2 would place your mark in the bottom right");
            
            Console.WriteLine("Please enter the horizontal coordinate: 0, 1, or 2");
            
            //Get horizontal coordinate
            userInput = Console.ReadLine();

            if (userInput.Length == 1 && int.TryParse(userInput, out int n1) && int.Parse(userInput) <= 2) {
                across = int.Parse(userInput);
                
                Console.WriteLine("Please enter the vertical coordinate: 0, 1, or 2");
                //Get vertical Coordinate
                userInput = Console.ReadLine();

                //Checks for valid input
                if (userInput.Length == 1 && int.TryParse(userInput, out int n2) && int.Parse(userInput) <= 2) {
                    down = int.Parse(userInput);

                    if (gameBoard[down, across] == ' ')
                    {
                        gameBoard[down, across] = currentPlayer;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("This position is already occupied. Please choose another position.");
                    }
                } 
                else
                {
                    Console.WriteLine("Invalid Input! Please enter a single digit: 0, 1, 2");
                }
            }
            else 
            {
                Console.WriteLine("Invalid Input! Please enter a single digit between 1 and 2");
            }
        }
    }
}
