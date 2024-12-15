using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMangerment
{
    internal class CompareByFirstName : IComparer
    {
        public int Compare(object x, object y)
        {
            Account acc1 = x as Account;
            Account acc2 = y as Account;
            if (acc1 == null || acc2 == null)
            {
                throw new ArgumentException("Objects being compared must be of type Account");
            }
            return string.Compare(acc1.FirstName, acc2.FirstName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
