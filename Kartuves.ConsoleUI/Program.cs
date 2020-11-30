using Kartuves.ConsoleUI.Interfaces;
using Kartuves.ConsoleUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartuves.ConsoleUI
{
    class Program
    {
        const int choiceStatistika = 1;
        const int choiceZaidimas = 2;
        static void Main(string[] args)
        {

            IUiMessageFactory messageFactory = new UiMessageFactory();
            var welcomeChoice = messageFactory.WelcomeMessage();

            if (welcomeChoice == choiceZaidimas)
            {
                IGameService gameService = new GameService();
                gameService.Begin();
            }
            if (welcomeChoice == choiceStatistika)
            {
                IStatisticService service = new StatisticsService();
                service.Begin();
            }

            
        }
    }
}
