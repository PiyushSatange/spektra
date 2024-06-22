using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2_Assignment1.Models
{
    [Keyless]
    public class Procedure
    {
        public int emp_ID { get; set; }

        public string? emp_NAME { get; set; }

        public string? DEPT_NAME { get; set; }

        public int SALARY { get; set; }
    }
}
