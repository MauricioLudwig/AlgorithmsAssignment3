using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.G
{
    public class DartClub
    {

        public List<Member> Members { get; set; }

        public DartClub()
        {
            Members = new List<Member>()
            {
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 196706193361, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 196609083982, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 199106019632, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 196912173975, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 197803057418, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 195608281811, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 198104186773, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 198710157754, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 196301173792, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 195607172888, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 198110217323, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 197902116081, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 197411297372, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 197707092271, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 196611095339, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 198604237829, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 198110143032, membershipFeePaid = true },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 195508027579, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 195905205851, membershipFeePaid = false },
                new Member { FirstName = "", LastName = "", SocialSecurityNr = 195406228550, membershipFeePaid = true }
            };
        }

        public void SortByEldest()
        {
        }

        public void SortByLastName()
        {

        }

        public void membershipNotPaid()
        {

        }

        public void searchMember()
        {

        }

    }
}
