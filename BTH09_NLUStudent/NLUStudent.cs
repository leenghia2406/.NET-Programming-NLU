using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH09_NLUStudent
{
    internal class NLUStudent
    {
        int Id_student { get; set; }
        string Full_name { get; set; }
        int Phone { get; set; }
        string Email { get; set; }
        int Age { get; set; }
        NLUClass Nlu_class { get; set; }

    }
}
