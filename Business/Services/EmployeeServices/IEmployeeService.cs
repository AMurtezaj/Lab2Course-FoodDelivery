using Data.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto> GetEmployeeAsync(int id);
        Task<EmployeeDto> CreateEmployeeAsync(EmployeeCreateDto employeeCreateDto);

        Task<EmployeeDto> UpdateEmployeeAsync(EmployeeDto employeeDto);
        Task<EmployeeDto> DeleteEmployeeAsync(int id);

    }
}
