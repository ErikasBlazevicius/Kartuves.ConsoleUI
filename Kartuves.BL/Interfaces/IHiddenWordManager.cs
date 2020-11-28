using Kartuves.BL.Models;
using System;
using System.Collections.Generic;

namespace Kartuves.ConsoleUI.Interfaces
{
    public interface IHiddenWordManager
    {
        HiddenWord HiddenWord { get; set; }

        HiddenWord GetHiddenWord();
        string GetHiddedWordStructure();
        void CheckLetter(string spejimas);
    }
}