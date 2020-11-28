using Kartuves.DL.Models;
using System.Collections.Generic;

namespace Kartuves.ConsoleUI.Interfaces
{
    internal interface IUiMessageFactory
    {
        void GeneralStatisticsMessage(List<Player> players);
        void IncorrectLettersListMessage(List<string> neteisingiSpejimai);
        void KartuvesPictureMessage(int incorrectGuessCount);
        string LoginMessage();
        void LostGameMessage(string zodis);
        void PlayerStatisticsMessage(Player player);
        bool RepeatGameMessage();
        int WelcomeMessage();
        void WinGameMessage(string zodis);
        string WordInputMessage();
    }
}