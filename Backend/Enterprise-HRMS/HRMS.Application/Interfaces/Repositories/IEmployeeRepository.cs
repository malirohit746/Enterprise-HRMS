using HRMS.Domain.Entities;

namespace HRMS.Application.Interfaces.Repositories;

public interface IEmployeeRepository
{
    Task AddAsync(Employee employee);
}