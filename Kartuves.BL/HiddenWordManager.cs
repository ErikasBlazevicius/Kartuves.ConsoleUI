using Kartuves.BL.Models;
using Kartuves.ConsoleUI.Interfaces;
using Kartuves.DL.Models;
using System.Collections.Generic;
using System.Text;

namespace Kartuves.BL
{
    public class HiddenWordManager : IHiddenWordManager
    {
        private readonly Word _word;
        public HiddenWord HiddenWord { get; set; }

        public HiddenWordManager(Word word)
        {
            _word = word;
            HiddenWord = new HiddenWord(_word.Text.Length);
        }
        public HiddenWord GetHiddenWord()
        {

            return HiddenWord;
        }
        public string GetHiddedWordStructure()
        {

            var sb = new StringBuilder("Zodis: ");
            foreach (var raide in HiddenWord.CorrectGuesses)
            {
                if (string.IsNullOrWhiteSpace(raide))
                {
                    sb.Append("_ ");
                }
                else
                {
                    sb.Append($"{raide} ");
                }
            }
            return sb.ToString();

        }
        public void CheckLetter(string spejimas)
        {
            var zodisArr = _word.Text.ToCharArray();
            var raidesIndeksai = new List<int>();
            for (int i = 0; i < _word.Text.Length; i++)
            {
                if (zodisArr[i].ToString().ToUpper() == spejimas.ToUpper()) raidesIndeksai.Add(i);
            }
            if (raidesIndeksai.Count == 0)
            {
                HiddenWord.IncorrectGuesses.Add(spejimas);
            }
            else
            {
                PridetiRaideITeisingaVietaZodyje(spejimas, raidesIndeksai);
            }
            
        }

        private void PridetiRaideITeisingaVietaZodyje(string spejimas, List<int> raidesIndeksai)
        {
            foreach (int indeksas in raidesIndeksai)
            {
                HiddenWord.CorrectGuesses[indeksas] = spejimas;
            }
        }
    }
}
