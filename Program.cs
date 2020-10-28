using System;
using static System.Console;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_TURNS = 9;

            WriteLine("\n----------------------------------");
            WriteLine("Welcome to tic-tac-toe");
            WriteLine("----------------------------------");
            WriteLine("Players will take turns choosing an unoccupied cell.");
            WriteLine("The first player to get 3 in a row (or column or diagonal) wins!\n");

            char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            // will hold the winning player when there is one
            int winner = 0;

            for (int turn = 0; turn < MAX_TURNS; turn++)
            {
                // player X on even turns, player O on odd turns
                char currentPlayer = turn % 2 == 0 ? 'X' : 'O';
                WriteLine("Current Board: ");
                DisplayBoard(board);
                MakeMove(currentPlayer, board);
                if (HasWinner(board))
                {
                    winner = currentPlayer;
                    break;
                }
            }
            //displayBoard(board);

            // print the game outcome
            if (winner == 0)
            {
                WriteLine("\n/----------------\\");
                WriteLine($"| Player 1 wins! |");
                WriteLine("\\----------------/");                
            }
            else if(winner == 1)
            {
                WriteLine("\n/----------------\\");
                WriteLine($"| Player 2 wins! |");
                WriteLine("\\----------------/");
            }
            else
            {
                WriteLine("Looks like a draw");                
            }
        }

        // TODO: write the functions used in main (and any other helper functions you want to use)

        // DisplayBoard
        /**
         * displays the tic-tac-toe board
         * given the contents of the named cells
         *  a | b | c
         * ---+---+---
         *  d | e | f
         * ---+---+--
         *  g | h | i
         */

        //HasWinner
        /**
         * returns true if the board has a winner
         */
        // hint: just return true if you can find three-in-a-row
        // of any character; consider writing the function 'same'
        // described below

        //MakeMove
        /**
         * Continues to ask the player with symbol 'currentPlayer'
         * for input until a valid (unused) cell is selected;
         * then the corresponding cell is updated appropriately
         */
        //hint: you'll want to pass in the board
        // so that you can change it; also, you'll probably have a do-while
        // loop in here and a switch statement inside of that; consider
        // writing the 'updateCell' function described below to help make the
        // body of that cases more simple

        // optional function to help with MakeMove
        //bool UpdateCell(char& cell, char player);
        /**
         * returns true updates the provided cell with the given player
         * if the cell is unoccupied; otherwise, 
         * returns false
         */

        // optional function to help with HasWinner
        //bool Same(char a, char b, char c);
        /**
         *  returns true if a, b, and c are all the same
         */        
    }
}
