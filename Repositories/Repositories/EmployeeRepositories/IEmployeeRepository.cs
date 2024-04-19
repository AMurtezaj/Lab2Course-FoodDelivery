using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> SearchByNameAsync(string name)

    }
}
