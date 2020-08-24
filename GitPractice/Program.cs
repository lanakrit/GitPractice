﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PokerLibrary;
namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("This is A Menu");
                Console.WriteLine("1. Add new game");
                Console.WriteLine("2. Check all avaialble games ");
                Console.WriteLine("3. Remove Game by Index");
                Console.WriteLine("4. Exit >>");

                Menu comand = (Menu)int.Parse(Console.ReadLine());

                switch (comand)
                {
                    case Menu.AddNewGame:
                        {
                            Console.Write("Please enter the name of the discipline");
                            string name = Console.ReadLine();

                            Console.Write("Please enter the number of cards in  the game: ");
                            int cards = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the number of players in  the game: ");
                            int players = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the type of the game");
                            string type = Console.ReadLine();

                            Poker game = new Poker(discipline: name, numberOfCards: cards, numberOfPlayers: players, type: type);

                            PokerKeeper.Add(game);
                        }
                        break;
                    case Menu.CheckGames:
                        {

                        }
                        break;
                    case Menu.RemoveGames:
                        {

                        }
                        break;
                    case Menu.Exit:
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("There is no such index");
                        }
                        break;
                }
            } while (true);
        }

        enum Menu
        {
            NoItem = 0,
            AddNewGame = 1,
            CheckGames = 2,
            RemoveGames = 3,
            Exit = 4
        }
    }
}
