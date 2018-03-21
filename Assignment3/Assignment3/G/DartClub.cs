using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assignment3.Algorithms;

namespace Assignment3.G
{
    public class DartClub
    {

        public List<Member> Members { get; set; }

        public DartClub()
        {
            Members = new List<Member>()
            {
                new Member { FirstName = "Hermann", LastName = "Kafka", SocialSecurityNr = 196706193361, membershipFeePaid = true },
                new Member { FirstName = "Fyodor", LastName = "Dostoevsky", SocialSecurityNr = 196609083982, membershipFeePaid = true },
                new Member { FirstName = "Leo", LastName = "Tolstoy", SocialSecurityNr = 199106019632, membershipFeePaid = true },
                new Member { FirstName = "Howard", LastName = "Lovecraft", SocialSecurityNr = 196912173975, membershipFeePaid = false },
                new Member { FirstName = "Elmore", LastName = "Leonard", SocialSecurityNr = 197803057418, membershipFeePaid = true },
                new Member { FirstName = "Joseph", LastName = "Conrad", SocialSecurityNr = 195608281811, membershipFeePaid = false },
                new Member { FirstName = "James", LastName = "Pushkin", SocialSecurityNr = 198104186773, membershipFeePaid = true },
                new Member { FirstName = "John", LastName = "Camus", SocialSecurityNr = 198710157754, membershipFeePaid = false },
                new Member { FirstName = "Franz", LastName = "Kafka", SocialSecurityNr = 196301173792, membershipFeePaid = false },
                new Member { FirstName = "Marquis", LastName = "Sade", SocialSecurityNr = 195607172888, membershipFeePaid = true },
                new Member { FirstName = "Marcel", LastName = "Proust", SocialSecurityNr = 198110217323, membershipFeePaid = true },
                new Member { FirstName = "James", LastName = "Joyce", SocialSecurityNr = 197902116081, membershipFeePaid = true },
                new Member { FirstName = "Anton", LastName = "Chekhov", SocialSecurityNr = 197411297372, membershipFeePaid = true },
                new Member { FirstName = "Alexander", LastName = "Pushkin", SocialSecurityNr = 197707092271, membershipFeePaid = false },
                new Member { FirstName = "Damien", LastName = "Kafka", SocialSecurityNr = 196611095339, membershipFeePaid = false },
                new Member { FirstName = "Albert", LastName = "Camus", SocialSecurityNr = 198604237829, membershipFeePaid = false },
                new Member { FirstName = "Cormac", LastName = "McCarthy", SocialSecurityNr = 198110143032, membershipFeePaid = true },
                new Member { FirstName = "Maxim", LastName = "Gorky", SocialSecurityNr = 195508027579, membershipFeePaid = false },
                new Member { FirstName = "Phillip", LastName = "Lovecraft", SocialSecurityNr = 195905205851, membershipFeePaid = false },
                new Member { FirstName = "Adam", LastName = "Kafka", SocialSecurityNr = 195406228550, membershipFeePaid = true }
            };
        }

        public void SortByEldest()
        {
            Console.Clear();
            UI.PrintMembers("\t\t\t    Unsorted", Members);
            var sortedList = QuickSorter.QuickSort(Members.ToArray(), 0, Members.Count - 1, o => o.SocialSecurityNr);
            UI.PrintMembers("\t\t\t    Sorted (Age)", sortedList.ToList());
        }

        public void SortByLastName()
        {
            Console.Clear();
            UI.PrintMembers("\t\t\t    Unsorted", Members);
            var sortedList = QuickSorter.QuickSort(Members.ToArray(), 0, Members.Count - 1, o => o.LastName);
            UI.PrintMembers("\t\t\t    Sorted (Last Name)", sortedList.ToList());
        }

        public void membershipNotPaid_LINQ()
        {
            Console.Clear();
            UI.PrintMembers("\t\t\t    Unsorted", Members);
            UI.PrintMembers("\t\t\tSorted (Members who have not paid their membership fee)", Members.Where(o => !o.membershipFeePaid).Select(o => o).ToList());
        }

        public void membershipNotPaid_FOREACH()
        {
            Console.Clear();
            UI.PrintMembers("\t\t\t    Unsorted", Members);
            var feeNotPaid = new List<Member>();
            foreach (var member in Members)
            {
                if (!member.membershipFeePaid)
                    feeNotPaid.Add(member);
            }
            UI.PrintMembers("Sorted (Members Who Have Not Paid Their Membership Fee (USING FOREACH))", feeNotPaid);
        }

        public void searchMember()
        {

            string input;

            do
            {

                Console.Write("\t\t\t\tInput: ");
                input = Console.ReadLine().Trim();

            } while (String.IsNullOrEmpty(input));

            bool longInput = long.TryParse(input, out long result);

            if (longInput)
            {
                var sortedList = QuickSorter.QuickSort(Members.ToArray(), 0, Members.Count - 1, o => o.SocialSecurityNr);
                var searchResult = LinearSearch(sortedList, o => o.SocialSecurityNr, result);
                UI.PrintMembers("\t\tSearch Result (Social Security Number)", searchResult);
            }
            else
            {
                var sortedList = QuickSorter.QuickSort(Members.ToArray(), 0, Members.Count - 1, o => o.LastName);
                var searchResult = LinearSearch(sortedList, o => o.LastName.ToLower(), input.ToLower());
                UI.PrintMembers("\t\t    Search Result (Last Name)", searchResult);
            }
        }

        private List<T> LinearSearch<T, TProperty>(T[] members, Func<T, TProperty> selector, TProperty searchTerm)
        {
            var searchResult = new List<T>();

            foreach (var member in members)
            {
                if (Comparer<TProperty>.Default.Compare(selector(member), searchTerm) == 0)
                {
                    searchResult.Add(member);
                }
            }

            return searchResult;
        }

    }
}
