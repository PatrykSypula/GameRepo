using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 20;
            int add = 0;
            bool program = true;
            Game game = new Game();
            game.DrawNumbers(game.Winning());
            while (program)
            {
                Console.Clear();
                Console.WriteLine("{0} USD",money);
                Console.WriteLine("Select what you want to do:");
                Console.WriteLine("1.Buy lottery ticket (5 games - total cost 5 USD)");
                Console.WriteLine("2.Refill your wallet");
                Console.WriteLine("3.Exit game");
                string input = Console.ReadKey().KeyChar.ToString();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        if (money >= 5)
                        {
                            int highestScore = 0;
                            Console.WriteLine("Your numbers are:");
                            for (int i = 0; i < 5; i++)
                            {

                                game.DrawNumbers(game.Players());
                                Console.WriteLine(game.ShowNumbers(game.Players()));
                                if (game.CompareValues() > highestScore)
                                {
                                    highestScore = game.CompareValues();
                                }
                            }
                            Console.WriteLine("\nWinning numbers are:\n{0}", game.ShowNumbers(game.Winning()));
                            Console.WriteLine("\nYour score is {0}", highestScore);
                            switch(highestScore)
                            {
                                case 0:
                                    add = 0;
                                    break;
                                case 1: 
                                    add = 1;
                                    break;
                                case 2: 
                                    add = 5;
                                    break;
                                case 3:
                                    add = 50;
                                    break;
                                case 4:
                                    add = 1000;
                                    break;
                                case 5:
                                    add = 10000;
                                    break;
                                case 6:
                                    add = 100000;
                                    break;
                            }
                            money = money - 5 + add;
                            Console.WriteLine("You won {0} USD", add);
                        }
                        else
                        { 
                            Console.WriteLine("You do not have enough money"); 
                        }
                        Console.WriteLine("\nPress any button to continue");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "2":
                        money = money + 20;
                        Console.Clear();
                        break;
                    case "3":
                        program = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("\nPress any button to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
