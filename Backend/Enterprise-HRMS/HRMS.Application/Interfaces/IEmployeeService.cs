using HRMS.Application.DTOs.Employees;

namespace HRMS.Application.Interfaces;

public interface IEmployeeService
{
    Task CreateEmployeeAsync(CreateEmployeeRequest request);
}