using System;
using TicTacToeGroup13;
//Make new instance of supporting class
Supporting sup = new Supporting();

char[,] gameBoard = new char[3, 3]; // 3x3 game board


static void Main(string[] args)
    {
        

        bool gameOver = false;

        // welcome user to the game
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // create game board array
        CreateBoard(gameBoard);

        do
        {
            // make current player
            char currentPlayer = 'X';

            

            //Ask each player for their choice
            GetPlayerChoice(char currentPlayer);

            //Print the board
            Console.Write(sup.gameBoardPrint);


            if (sup.checkWinner() == true)
            {
                gameOver = true;
            }

        } while (gameOver = false);
        

        

        //Check for a winner
        


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
        int across = 0;
        int down = 0;
        Console.WriteLine("Where would you like to place your mark? Enter the corresponding coordinates:");
        Console.WriteLine("ex. 0,0  would place your mark at the top left and 2,2 would place your mark in the bottom right");
        Console.WriteLine("Please enter the horizontal coordinate: 0, 1, or 2");
        across = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the vertical coordinate: 0, 1, or 2");
        down = int.Parse(Console.ReadLine());

        if (gameBoard[across, down] == 'X' || gameBoard[across, down] == 'O')
        {
            Console.WriteLine("This position is already occupied. Please choose another position.");
        }
        else
        {
            gameBoard[across, down] = currentPlayer;
        }
    

