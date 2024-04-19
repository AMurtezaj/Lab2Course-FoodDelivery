using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public AppDbContext _context;
        public EmployeeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Employee>> SearchByNameAsync(string name)
        {
            return await _context.Employees
                .Where(p => p.FullName.Contains(name))
                .ToListAsync();
        }
    }
}
