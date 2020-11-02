using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTacToe
{   
    class Program
    {
        private static bool isGame = true;
        private static bool player = true;
        private static string playerchar;

        private static bool field1chosen = false;
        private static bool field2chosen = false;
        private static bool field3chosen = false;
        private static bool field4chosen = false;
        private static bool field5chosen = false;
        private static bool field6chosen = false;
        private static bool field7chosen = false;
        private static bool field8chosen = false;
        private static bool field9chosen = false;

        private static string[,] board = new string[,]
            {
                {"   ","   ","   ","|","   ","   ","   ","|","   ","   ","   " },
                {"   "," 1 ","   ","|","   "," 2 ","   ","|","   "," 3 ","   " },
                {"___","___","___","|","___","___","___","|","___","___","___" },
                {"   ","   ","   ","|","   ","   ","   ","|","   ","   ","   " },
                {"   "," 4 ","   ","|","   "," 5 ","   ","|","   "," 6 ","   " },
                {"___","___","___","|","___","___","___","|","___","___","___" },
                {"   ","   ","   ","|","   ","   ","   ","|","   ","   ","   " },
                {"   "," 7 ","   ","|","   "," 8 ","   ","|","   "," 9 ","   " },
                {"___","___","___","|","___","___","___","|","___","___","___" }
            };

        static void Main(string[] args)
        { while (true)
            {
                PlotBoard();
                while (isGame)
                {
                    PlayerTurn();
                    CheckGameState();
                }
                Console.WriteLine("End of the game! Press any key to restart");
                Console.ReadKey();
                RestartGame();

    }
        }

        public static void PlotBoard()
        {

               int rowLength = board.GetLength(0);
               int colLength = board.GetLength(1);
               for (int i = 0; i < rowLength; i++)
                {
                   for (int j = 0; j < colLength; j++)
                   {
                       Console.Write(board[i, j]);
                   }
                   Console.Write(Environment.NewLine + Environment.NewLine);
                }
                          

        }
        public static void PlayerTurn()
        {
            if (player)
            {
                playerchar = " X ";
                Console.WriteLine("Player 1: Choose your field!");
                InputField();
                PlotBoard();
                player = !player;
            }

            else
            {
                playerchar = " O ";
                Console.WriteLine("Player 2: Choose your field!");
                InputField();
                PlotBoard();
                player = !player;
            }
        }

        public static void CheckGameState()
        {
            if ((board[1, 1] == board[1, 5] && board[1, 1] == board[1, 9]) ||
                (board[4, 1] == board[4, 5] && board[4, 1] == board[4, 9]) ||
                (board[7, 1] == board[7, 5] && board[7, 1] == board[7, 9]) ||

                (board[1, 1] == board[4, 1] && board[1, 1] == board[7, 1]) ||
                (board[1, 5] == board[4, 5] && board[1, 5] == board[7, 5]) ||
                (board[1, 9] == board[4, 9] && board[1, 1] == board[7, 9]) ||

                (board[1, 1] == board[4, 5] && board[1, 1] == board[7, 9]) ||
                (board[7, 1] == board[4, 5] && board[7, 1] == board[1, 9])   )
            {
                if (player)
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else
                {
                    Console.WriteLine("Player 1 wins!");
                }
                isGame = false;
            }
            else if (field1chosen && field2chosen && field3chosen && field4chosen && field5chosen &&
                    field6chosen && field7chosen && field8chosen && field9chosen)
            {
                isGame = false;
            }
        }

        public static void RestartGame()
        {
            isGame = true;
            board = new string[,]
            {
                {"   ","   ","   ","|","   ","   ","   ","|","   ","   ","   " },
                {"   "," 1 ","   ","|","   "," 2 ","   ","|","   "," 3 ","   " },
                {"___","___","___","|","___","___","___","|","___","___","___" },
                {"   ","   ","   ","|","   ","   ","   ","|","   ","   ","   " },
                {"   "," 4 ","   ","|","   "," 5 ","   ","|","   "," 6 ","   " },
                {"___","___","___","|","___","___","___","|","___","___","___" },
                {"   ","   ","   ","|","   ","   ","   ","|","   ","   ","   " },
                {"   "," 7 ","   ","|","   "," 8 ","   ","|","   "," 9 ","   " },
                {"___","___","___","|","___","___","___","|","___","___","___" }
            };
            field1chosen = false;
            field2chosen = false;
            field3chosen = false;
            field4chosen = false;
            field5chosen = false;
            field6chosen = false;
            field7chosen = false;
            field8chosen = false;
            field9chosen = false;
    }


        public static void InputField()
        {
            
            switch (Console.ReadLine())
            {
                case "1":
                    if (!field1chosen)
                    {
                        board[1, 1] = playerchar;
                        field1chosen = !field1chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }
                    

                case "2":
                    

                    if (!field2chosen)
                    {
                        board[1, 5] = playerchar;
                        field2chosen = !field2chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }


                case "3":


                    if (!field3chosen)
                    {
                        board[1, 9] = playerchar;
                        field3chosen = !field3chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }


                case "4":


                    if (!field4chosen)
                    {
                        board[4, 1] = playerchar;
                        field4chosen = !field4chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }


                case "5":


                    if (!field5chosen)
                    {
                        board[4, 5] = playerchar;
                        field5chosen = !field5chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }

                case "6":


                    if (!field6chosen)
                    {
                        board[4, 9] = playerchar;
                        field6chosen = !field6chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }


                case "7":


                    if (!field7chosen)
                    {
                        board[7, 1] = playerchar;
                        field7chosen = !field7chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }


                case "8":


                    if (!field8chosen)
                    {
                        board[7, 5] = playerchar;
                        field8chosen = !field8chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }


                case "9":


                    if (!field9chosen)
                    {
                        board[7, 9] = playerchar;
                        field9chosen = !field9chosen;
                        break;
                    }
                    else
                    {
                        player = !player;
                        Console.WriteLine("Field has already been chosen!");
                        break;
                    }


                default:
                    Console.WriteLine("Invalid number!");
                    player = !player;
                    break;
            }
        }
    }
}
