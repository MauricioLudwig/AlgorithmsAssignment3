using Assignment3.G;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Runtime
    {

        public void Start()
        {

            bool loop = true;

            while (loop)
            {
                switch (UI.MainMenu())
                {
                    case ConsoleKey.D1:
                        DartClubMenu();
                        break;
                    case ConsoleKey.D2: 
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }

        }

        private static void DartClubMenu()
        {

            DartClub dartClub = new DartClub();
            bool loop = true;

            while (loop)
            {
                switch (UI.DartClubMenu())
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }

        }

    }
}
