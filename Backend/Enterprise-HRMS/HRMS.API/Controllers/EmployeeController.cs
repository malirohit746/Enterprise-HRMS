    using HRMS.Application.DTOs.Employees;
    using HRMS.Application.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    namespace HRMS.API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeRequest request)
        {
            await _employeeService.CreateEmployeeAsync(request);

            return Ok("Employee created successfully.");
        }
    }