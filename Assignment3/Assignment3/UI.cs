﻿using Assignment3.G;
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
            int index = 1;
            SmallMenuBar();
            Console.WriteLine($"\t{header}");
            SmallMenuBar();
            Console.WriteLine("\n{0,-5}{1,-20} {2,-20} {3,-20} {4,-20}\n",
                "#", "First Name", "Last Name", "Social Security", "Membership paid?");
            foreach (var member in members)
            {
                Console.WriteLine("{0, -5}{1,-20} {2,-20} {3,-20} {4,-20}",
                    index++, member.FirstName, member.LastName, member.SocialSecurityNr, member.membershipFeePaid == true ? "YES" : "NO");
            }
        }

        private static void SmallMenuBar()
        {
            Console.WriteLine("----------------------------------");
        }

    }
}
