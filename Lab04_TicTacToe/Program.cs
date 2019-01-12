﻿using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program //made it public so I could access it for testing
    {
        static void Main(string[] args)
        {
            bool loopMenu = true;
            do
            {
                Console.WriteLine("Welcome to TicTacToe!!!");
                Console.WriteLine();
                Console.WriteLine("Make a selection");
                Console.WriteLine("1: Start a new game");
                Console.WriteLine("2: Exit");

                string userChoice = Console.ReadLine();
                int userChoiceInt = Convert.ToInt32(userChoice);

                if (userChoiceInt > 2)
                {
                    Console.WriteLine("That isn't an option");
                    loopMenu = true;
                }
                else if (userChoiceInt < 0)
                {
                    Console.WriteLine("That isn't an option");
                    loopMenu = true;
                }
                else //couldnt do while loop because I could enter bad entry on first entry
                {
                    switch (userChoiceInt)
                    {
                        case 1: //Start
                            //Console.WriteLine("just for testing, in option 1");
                            //set up players
                            Player playerOne = new Player();
                            Player playerTwo = new Player();
                            
                            //ask for name and set
                            Console.WriteLine("What is Player 1's name? ");
                            string playerOneName = Console.ReadLine();
                            playerOne.Name = playerOneName;

                            Console.WriteLine("What is Player 2's name? ");
                            string playerTwoName = Console.ReadLine();
                            playerTwo.Name = playerTwoName;
                            
                            //set x and o
                            playerOne.Marker = "X";
                            playerTwo.Marker = "O";

                            //set who's turn first (player 1, if I have time I'll do a random)
                            playerOne.IsTurn = true;
                            playerTwo.IsTurn = false;

                            Console.WriteLine($"Hello {playerOne.Name}, you are {playerOne.Marker} and it is your turn first");
                            Console.WriteLine($"Hello {playerTwo.Name}, therefore you are   {playerTwo.Marker}");

                            //call game.play
                            Game newGame = new Game(playerOne, playerTwo);
                            newGame.Play();

                            loopMenu = false; //to exit do while loop
                            break;
                        default: // exit
                            Console.WriteLine("just for testing, in option 2");
                            loopMenu = false; //to exit do while loop
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                }
            } while (loopMenu == true);


            //just testing object and its function
            //Board ticTacBoard = new Board();
            //ticTacBoard.DisplayBoard();
            Console.ReadLine(); //so it doesn't auto exit
        }
    }
}
