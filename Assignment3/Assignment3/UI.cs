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
            Console.WriteLine("\t\t\t\t    Main Menu:");
            SmallMenuBar();
            Console.WriteLine("\t\t\t\t1 - Dart Club (G)");
            Console.WriteLine("\t\t\t\t2 - Timer (VG)");
            Console.WriteLine("\t\t\t\t3 - Exit Program");
            SmallMenuBar();
            Console.WriteLine("\t\t\t\t     Choice?");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }

        public static ConsoleKey DartClubMenu()
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("\t\t\t\t    Dart Club:");
            SmallMenuBar();
            Console.WriteLine("\t\t\t1 - Sort By Eldest");
            Console.WriteLine("\t\t\t2 - Sort By Last Name");
            Console.WriteLine("\t\t\t3 - Sort By Members Who Have Not Paid Their Fees");
            Console.WriteLine("\t\t\t4 - Search By Last Name Or Social Security Number");
            Console.WriteLine("\t\t\t5 - Return To Main Menu");
            SmallMenuBar();
            Console.WriteLine("\t\t\t\t     Choice?");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }

        public static ConsoleKey TimerMenu()
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("\t\t\t\t     Timer:");
            SmallMenuBar();
            Console.WriteLine("\t\t\t\t1 - Generate 10 000 Integers");
            Console.WriteLine("\t\t\t\t2 - Generate 20 000 Integers");
            Console.WriteLine("\t\t\t\t3 - Generate 40 000 Integers");
            Console.WriteLine("\t\t\t\t4 - Return To Main meMu");
            SmallMenuBar();
            Console.WriteLine("\t\t\t\t     Choice?");
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
                "#", "First Name", "Last Name", "Social Security", "Membership Paid?");

            if (members.Count < 1)
            {
                Console.WriteLine("\t\t\t\tNo Entries Found.");
            }
            else
            {
                foreach (var member in members)
                {
                    Console.WriteLine("{0, -5}{1,-20} {2,-20} {3,-20} {4,-20}",
                        index++, member.FirstName, member.LastName, member.SocialSecurityNr, member.membershipFeePaid == true ? "YES" : "NO");
                }
            }
        }

        public static void PrintTimer(string header, TimeSpan time)
        {
            SmallMenuBar();
            Console.WriteLine($"\t\tAction: {header}\n\t\tTime Elapsed: {time} Or {time.TotalSeconds} Seconds");
            SmallMenuBar();
        }

        private static void SmallMenuBar()
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
        }

    }
}
