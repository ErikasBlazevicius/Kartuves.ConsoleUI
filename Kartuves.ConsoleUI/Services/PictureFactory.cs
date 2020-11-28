using Kartuves.ConsoleUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartuves.ConsoleUI.Services
{
    public class PictureFactory : IPictureFactory
    {
        public void DisplayPicture(int incorrectGuesCount)
        {
            Console.Clear();
            switch (incorrectGuesCount)
            {
                case 0:
                    PradinioPiesinioIsvedmas();
                    break;
                case 1:
                    IsvestiGalva();
                    break;
                case 2:
                    IsvestiKakla();
                    break;
                case 3:
                    IsvestiKuna();
                    break;
                case 4:
                    IsvestiRanka1();
                    break;
                case 5:
                    IsvestiRanka2();
                    break;
                case 6:
                    IsvestiKoja1();
                    break;
                case 7:
                    IsvestiKoja2();
                    break;
            }
        }
        private void PradinioPiesinioIsvedmas()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");

        }

        private void IsvestiGalva()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|              o   ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");
        }

        private void IsvestiKakla()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|              o   ");
            Console.WriteLine(@"|              |   ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");
        }

        private void IsvestiKuna()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|              o   ");
            Console.WriteLine(@"|              0   ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");
        }

        private void IsvestiRanka1()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|              o   ");
            Console.WriteLine(@"|             \|   ");
            Console.WriteLine(@"|              0   ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");
        }

        private void IsvestiRanka2()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|              o   ");
            Console.WriteLine(@"|             \|/  ");
            Console.WriteLine(@"|              0   ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");
        }
        private void IsvestiKoja1()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|              o   ");
            Console.WriteLine(@"|             \|/  ");
            Console.WriteLine(@"|              0   ");
            Console.WriteLine(@"|             /    ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");
        }

        private void IsvestiKoja2()
        {
            Console.WriteLine(@"   - - - - - - |   ");
            Console.WriteLine(@"|              o   ");
            Console.WriteLine(@"|             \|/  ");
            Console.WriteLine(@"|              0   ");
            Console.WriteLine(@"|             / \  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"_ _ _ _");

        }
        
    }
}
