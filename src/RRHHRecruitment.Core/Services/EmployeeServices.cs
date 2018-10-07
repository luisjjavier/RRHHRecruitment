using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRHHRecruitment.Core.Services
{
    public sealed class EmployeeServices
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.Get().ToList();
        }

        public IOperationResult<Employee> CreateEmployee(Employee currentEmployee)
        {
            return _employeeRepository.Create(currentEmployee);
        }

        public List<Employee> GetEmployees(DateTime fromDateTime, DateTime toDateTime)
        {
            return _employeeRepository
                .FindAll(employee => employee.EntryDate >= fromDateTime && employee.EntryDate <= toDateTime).ToList();
        }
    }
}
