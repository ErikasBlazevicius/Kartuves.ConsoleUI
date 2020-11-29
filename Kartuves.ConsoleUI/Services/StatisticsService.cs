using Kartuves.BL;
using Kartuves.BL.Interfaces;
using Kartuves.ConsoleUI.Interfaces;
using Kartuves.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartuves.ConsoleUI.Services
{
    public class StatisticsService : IStatisticService
    {
        private readonly IPlayerManager _playerManager;
        private readonly IUiMessageFactory _messageFactory;

        public StatisticsService()
        {
            _playerManager = new PlayerManager();
            _messageFactory = new UiMessageFactory();
        }
        public void Begin()
        {
            _messageFactory.GeneralStatisticsMessage(_playerManager.GetAll());
        }
       

    }
}
