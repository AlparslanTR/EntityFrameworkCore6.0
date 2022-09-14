using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public Person person { get; set; }
        public decimal salary { get; set; }
    }
}
