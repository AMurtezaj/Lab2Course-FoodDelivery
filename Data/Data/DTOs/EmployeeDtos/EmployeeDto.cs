using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs.EmployeeDtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool isActive { get; set; }
    }
}
