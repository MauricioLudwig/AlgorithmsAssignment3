using Assignment3.G;
using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Algorithms;
using Assignment3.VG;

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
                        DartClubMenu(); // G assignment
                        break;
                    case ConsoleKey.D2:  // VG assignment
                        TimerMenu();
                        break;
                    case ConsoleKey.D3: // Exit application
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
                    case ConsoleKey.D1: // Sort by eldest member
                        dartClub.SortByEldest();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2: // Sort by last name
                        dartClub.SortByLastName();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3: // List all members who have not paid their membership fees
                        dartClub.membershipNotPaid_FOREACH();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4: // Search by last name or social security number
                        dartClub.searchMember();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5: // Return to main menu
                        loop = false;
                        break;
                    default:
                        break;
                }
            }

        }

        private static void TimerMenu()
        {

            TimerManager timerMgr = new TimerManager();
            bool loop = true;

            while (loop)
            {
                switch (UI.TimerMenu())
                {
                    case ConsoleKey.D1: // Generate 10 000 integers
                        timerMgr.Generate(10000);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2: // Generate 20 000 integers
                        timerMgr.Generate(20000);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3: // Generate 40 000 integers
                        timerMgr.Generate(40000);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4: // Return to main menu
                        loop = false;
                        break;
                    default:
                        break;
                }
            }

        }

    }
}