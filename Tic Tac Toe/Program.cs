using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int player = 1;
                int[,] ticTacField = new int[3, 3];

                while (!HasWinner(ticTacField) && HasEmpty(ticTacField))
                {
                    Console.WriteLine($"Player {player}");

                    RenderMap(ticTacField);

                    int vertical, horizontal;
                    do
                    {
                        vertical = GetIntFromUser("V-coord: ", 0, 2);
                        horizontal = GetIntFromUser("H-coord: ", 0, 2);
                    }
                    while (!IsCoordsOk(ticTacField, vertical, horizontal));

                    ticTacField[vertical, horizontal] = player;

                    player = player == 1 ? 2 : 1;

                    Console.Clear();
                }

                if (HasWinner(ticTacField))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"LOOSER: Player {player}");
                    player = player == 1 ? 2 : 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"WINNER WINNER: Player {player}");
                }
                else
                {
                    Console.WriteLine("THE END");
                }

                RenderMap(ticTacField);
            }
            while (PlayAgain());
        }

        static bool PlayAgain()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Wanna play again? ");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                return false;
            }
            Console.Clear();
            return true;
        }

        static bool IsCoordsOk(int[,] field, int v, int h)
        {
            return field[v, h] == 0;
        }

        static void RenderMap(int[,] field, string separator = "|")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                Console.Write(separator);
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    switch (field[i, k])
                    {
                        case 1:
                            Console.Write("X");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        default:
                            Console.Write(" ");
                            break;
                    }
                    Console.Write(separator);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        static bool HasWinner(int[,] field)
        {
            for (int i = 0; i < 3; i++)
            {
                if (field[0, i] != 0 && field[0, i] == field[1, i] && field[1, i] == field[2, i] ||
                    field[i, 0] != 0 && field[i, 0] == field[i, 1] && field[i, 1] == field[i, 2])
                {
                    return true;
                }
            }

            if (field[1, 1] != 0 &&
                (field[0, 0] == field[1, 1] && field[1, 1] == field[2, 2] ||
                 field[0, 2] == field[1, 1] && field[1, 1] == field[2, 0]))
            {
                return true;
            }

            return false;
        }

        static bool HasEmpty(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    if (field[i, k] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static int GetIntFromUser(string question, int min, int max = int.MaxValue)
        {
            bool inputIsNumber = false;
            int number = 0;

            do
            {
                Console.Write(question);
                string input = Console.ReadLine();
                inputIsNumber = int.TryParse(input, out number);

                if (!inputIsNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is not a number! Plese try again!");
                    Console.ResetColor();
                }

                if (inputIsNumber && (number < min || number > max))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is out of bounds! Plese try again!");
                    Console.ResetColor();
                    inputIsNumber = false;
                }
            }
            while (!inputIsNumber);

            return number;

        }
    }
}

