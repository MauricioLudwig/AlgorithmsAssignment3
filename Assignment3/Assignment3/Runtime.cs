using Assignment3.G;
using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Algorithms;

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
                        dartClub.membershipNotPaid();
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

    }
}