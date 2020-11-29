using Kartuves.ConsoleUI.Interfaces;
using Kartuves.ConsoleUI.Services;
using Kartuves.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kartuves.ConsoleUI
{
    internal class UiMessageFactory : IUiMessageFactory
    {
        private readonly IPictureFactory _pictureFactory;
        public UiMessageFactory()
        {
            _pictureFactory = new PictureFactory();
        }
        public int WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Sveiki atvyke i Kartuviu zaidima");
            Console.WriteLine();
            Console.WriteLine("Pasirinkite is meniu");
            Console.WriteLine("1. Statistika");
            Console.WriteLine("2. Zaidimas");
           
            int choiceNumber = 0;
            while (choiceNumber == 0)
            {
                var choice = Console.ReadKey().KeyChar;
                int.TryParse(choice.ToString(), out choiceNumber);
                if (choiceNumber == 0)
                {
                    Console.WriteLine($"\n {choiceNumber} Klaida! Galima ivesti tik skaiciu, bandykite is naujo");
                }

            }
            return choiceNumber;
        }
        public string LoginMessage()
        {
            Console.Clear();
            Console.WriteLine("Iveskite savo varda");
            Console.WriteLine();
            return Console.ReadLine();
        }

        public string WordInputMessage()
        {
            Console.WriteLine("\n\nSpekite raide arba zodi:");
            return Console.ReadLine();
        }
        public void LostGameMessage(string zodis)
        {
            Console.WriteLine();
            Console.WriteLine(" Pralaimejote");
            Console.WriteLine($"Zodis buvo: {zodis}");
        }
        public void WinGameMessage(string zodis)
        {
            {
                Console.WriteLine();
                Console.WriteLine("Sveikinimai! zodis teisingas");
                Console.WriteLine();
                Console.WriteLine($"Zodis buvo{zodis}");
            }
        }
        public void KartuvesPictureMessage(int incorrectGuessCount)
        {
            _pictureFactory.DisplayPicture(incorrectGuessCount);
        }
        public bool RepeatGameMessage()
        {
            Console.WriteLine("Pakartoti zaidima? T/N");
            return Console.ReadKey().KeyChar.ToString().ToUpper() == "T";
        }
        public void IncorrectLettersListMessage(List<string> neteisingiSpejimai)
        {
            Console.WriteLine("\n Spetos raides: ");
            foreach (var neteisingasSpejimas in neteisingiSpejimai)
            {
                Console.WriteLine($"{neteisingasSpejimas}");
            }

        }
        public void PlayerStatisticsMessage(Player player)
        {
            Console.WriteLine($"Zaidejas{player.Name} zaide {player.ScoreBoards.Count} kartus");
            Console.WriteLine($"is ju laimejo {player.ScoreBoards.Count(z => z.IsCorrect)}");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void GeneralStatisticsMessage(List<Player> players)
        {
            Console.Clear();
            foreach (var player in players)
            {
                Console.WriteLine($"Zaidejas{player.Name} zaide {player.ScoreBoards.Count} kartus");
                Console.WriteLine($"is ju laimejo {player.ScoreBoards.Count(z => z.IsCorrect)}");
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}