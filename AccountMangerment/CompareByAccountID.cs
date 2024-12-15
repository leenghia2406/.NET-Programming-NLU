using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMangerment
{
    internal class CompareByAccountID : IComparer
    {

        int IComparer.Compare(object x, object y)
        {
            Account acc1 = x as Account;
            Account acc2 = y as Account;
            if (acc1 == null && acc2 == null)
            {
                throw new ArgumentException();
            }
            return acc1.AccountID.CompareTo(acc2.AccountID);
        }
    }
}
