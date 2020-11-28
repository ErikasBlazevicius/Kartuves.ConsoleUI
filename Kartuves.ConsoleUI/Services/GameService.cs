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
    public class GameService : IGameService, IRandomize
    {
        private readonly IUiMessageFactory _messageFactory;
        private readonly List<Subject> _subjects;
        private readonly IRandomUtils _randomUtils;
        private readonly IPlayerManager _playerManager;
        private IHiddenWordManager _hiddenWordManager;
        const int bandymai = 7;
        List<Word> panaudotiZodziai = new List<Word>();

        public GameService()
        {
            _messageFactory = new UiMessageFactory();
            _randomUtils = new RandomUtils();
            IReadRepository wordManager = new WordManager();
            _subjects = wordManager.GetAllSubjects();
            _playerManager = new PlayerManager();
        }

        public void Begin()
        {
            var userName = _messageFactory.LoginMessage();
            var user = _playerManager.GetByUserName(userName);
            if (user == null)
            {
                var key =_playerManager.Add(new Player { Name = userName });
                user = _playerManager.Get(key);
            }
            _messageFactory.PlayerStatisticsMessage(user);

            bool kartoti = true;
            while (kartoti)
            {
                
                Console.Clear();
                var tema = SelectSubject();
                var zodis = AtsitikitinioZodzioPasirinkimas(tema);
                if (zodis == null)
                {
                    Console.WriteLine("Temoje nebera zodziu, ar norite riktis kita tema? T/N");
                }
                else
                {
                    _hiddenWordManager = new HiddenWordManager(zodis);
                    bool leidziamaSpeti = true;
                    panaudotiZodziai.Add(zodis);
                    _messageFactory.KartuvesPictureMessage(0);
                    Console.WriteLine();
                    Console.WriteLine(_hiddenWordManager.GetHiddedWordStructure());
                    while (leidziamaSpeti)
                    {
                        string spejimas = _messageFactory.WordInputMessage();
                        bool arSpetasZodis = ArSpetasZodis(spejimas);
                        if (arSpetasZodis)
                        {
                            bool arTeisinga = ArZodisTeisingas(zodis.Text, spejimas);
                            if (arTeisinga)
                            {
                                _messageFactory.WinGameMessage(zodis.Text);
                                

                            }
                            else
                            {
                                _messageFactory.KartuvesPictureMessage(bandymai);
                                _messageFactory.LostGameMessage(zodis.Text);
                            }
                            leidziamaSpeti = false;
                        }
                        else
                        {
                            bool arBuvoSpeta = _hiddenWordManager.HiddenWord.IncorrectGuesses.Contains(spejimas);
                            if (!arBuvoSpeta)
                            {
                                _hiddenWordManager.CheckLetter(spejimas);
                            }
                            if(_hiddenWordManager.HiddenWord.IncorrectGuesses.Count == bandymai)
                            {
                                _messageFactory.KartuvesPictureMessage(bandymai);
                                _messageFactory.LostGameMessage(zodis.Text);
                                leidziamaSpeti = false;
                            }
                            else
                            {
                                Console.Clear();
                                _messageFactory.KartuvesPictureMessage(_hiddenWordManager.HiddenWord.IncorrectGuesses.Count);
                                _messageFactory.IncorrectLettersListMessage(_hiddenWordManager.HiddenWord.IncorrectGuesses);
                                Console.WriteLine(_hiddenWordManager.GetHiddedWordStructure());
                                if (_hiddenWordManager.HiddenWord.HiddenLetterCount == 0)
                                {
                                    _messageFactory.WinGameMessage(zodis.Text);
                                    leidziamaSpeti = false;
                                }
                            }
                        }
                    }
                   
                }

                _playerManager.AddScoreBoard(GetScoreBoard(zodis, user.PlayerId));

                kartoti = _messageFactory.RepeatGameMessage();

            }
        }

        private ScoreBoard GetScoreBoard(Word word, int userId)
        {
            return new ScoreBoard
            {
                PlayerId = userId,
                DatePlayed = DateTime.Now,
                GuessCount = _hiddenWordManager.HiddenWord.IncorrectGuesses.Count + _hiddenWordManager.HiddenWord.CorrectGuesses.Count(z => z != null),
                IsCorrect = _hiddenWordManager.HiddenWord.HiddenLetterCount == 0,
                WordId = word.WordId,
            };
        }
        public static bool ArZodisTeisingas(string zodis, string spejimas)
        {
            return zodis.ToUpper() == spejimas.ToUpper();
        }

        private Word AtsitikitinioZodzioPasirinkimas(Subject tema)
        {
            var zodziai = tema.Words;
            //jeigu temoje neliko zodziu
            if (zodziai.Count == 0) return null;
            var atsitiktinisSk = _randomUtils.Random(0, zodziai.Count);
            return zodziai[atsitiktinisSk];
        }
        private bool ArSpetasZodis(string spejimas)
        {
            return spejimas.Length > 1;
        }

        private Subject SelectSubject()
        {
            Console.WriteLine("Pasirinkite tema:");
            int ivestasTemosNr = 0;
            IveskTemuPavadinimus();
            while (ivestasTemosNr>_subjects.Count || ivestasTemosNr == 0)
              {
                var temosChar = Console.ReadKey().KeyChar;
                int.TryParse(temosChar.ToString(), out ivestasTemosNr);
                if (ivestasTemosNr > _subjects.Count || ivestasTemosNr == 0)
                {
                    Console.WriteLine($"\n{ivestasTemosNr} temos nera, bandykite is naujo");
                }
                Console.Clear();
                Console.WriteLine($"\n Tema: {_subjects[ivestasTemosNr - 1]}");
            }
              
            return _subjects[ivestasTemosNr - 1];

              
        }

        private  void IveskTemuPavadinimus()
        {
            for (int i = 0; i<_subjects.Count; i++)
            {
                Console.WriteLine($"{i+1}.{_subjects[i].Name}");
            }
        }
    }
}
