using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFConcurrencyCheckAttribute
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        [ConcurrencyCheck]
        public string Name { get; set; }
        public string Address { get; set; }
    }



}
