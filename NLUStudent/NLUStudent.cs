using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLUStudent
{
    internal class NLUStudent
    {
        public int Id_student { get; set; }
        public string Full_name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public NLUClass Nlu_class { get; set; }

    }
}
