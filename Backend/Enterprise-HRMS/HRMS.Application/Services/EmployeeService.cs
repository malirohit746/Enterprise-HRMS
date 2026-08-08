using HRMS.Application.DTOs.Employees;
using HRMS.Application.Interfaces;
using HRMS.Application.Interfaces.Repositories;
using HRMS.Domain.Entities;

namespace HRMS.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task CreateEmployeeAsync(CreateEmployeeRequest request)
    {
        var employee = new Employee
        {
            EmployeeCode = request.EmployeeCode,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            Salary = request.Salary,
            HireDate = DateTime.UtcNow
        };

        await _employeeRepository.AddAsync(employee);
    }
}