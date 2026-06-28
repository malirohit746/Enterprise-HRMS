using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Application.DTOs.Employees;

public class CreateEmployeeRequest
{
    public string EmployeeCode { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public decimal Salary { get; set; }
}
