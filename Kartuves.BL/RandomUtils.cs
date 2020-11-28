using Kartuves.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartuves.BL
{
    public class RandomUtils : IRandomUtils
    {
        private readonly Random _rnd = new Random();
        public int Random(int min, int max)
        {

            return _rnd.Next(min, max);
        }
    }
}
