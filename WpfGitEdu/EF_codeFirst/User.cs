using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_codeFirst
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public city City { get; set; }
        public money Money { get; set; }
    }

    public class city
    {
        public string Name { get; set; }
        public int CitizenCount { get; set; }
    }
}
