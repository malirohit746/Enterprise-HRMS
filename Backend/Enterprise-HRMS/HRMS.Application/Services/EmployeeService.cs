using HRMS.Application.DTOs.Employees;
using HRMS.Application.Interfaces;

namespace HRMS.Application.Services;

public class EmployeeService : IEmployeeService
{
    public Task CreateEmployeeAsync(CreateEmployeeRequest request)
    {
        // Business logic will come here later

        return Task.CompletedTask;
    }
}