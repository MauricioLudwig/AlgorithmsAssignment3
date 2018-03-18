using Assignment3.G;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public static class UI
    {

        public static ConsoleKey MainMenu()
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("\t    Main Menu:");
            SmallMenuBar();
            Console.WriteLine("\t1 - Dart Club (G)");
            Console.WriteLine("\t2 - Timer (VG)");
            Console.WriteLine("\t3 - Exit Program");
            SmallMenuBar();
            Console.WriteLine("\t     Choice?");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }

        public static ConsoleKey DartClubMenu()
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("\t    Dart Club:");
            SmallMenuBar();
            Console.WriteLine("\t1 - Sort by eldest");
            Console.WriteLine("\t2 - Sort by last name");
            Console.WriteLine("\t3 - Sort by members who have not paid their fees");
            Console.WriteLine("\t4 - Search by last name or social security number");
            Console.WriteLine("\t5 - Return to main menu");
            SmallMenuBar();
            Console.WriteLine("\t     Choice?");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }

        public static void PrintMembers(string header, List<Member> members)
        {
            SmallMenuBar();
            Console.WriteLine($"\t{header}");
            SmallMenuBar();
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName} {member.SocialSecurityNr} {member.membershipFeePaid}");
            }
        }

        private static void SmallMenuBar()
        {
            Console.WriteLine("----------------------------------");
        }

    }
}
