using Data.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs.ContractDtos
{
    public class ContractDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeDto Employee { get; set; }
    }
}
