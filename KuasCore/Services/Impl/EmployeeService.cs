using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class EmployeeService : IEmployeeService
    {

        public IEmployeeDao EmployeeDao { get; set; }

        public IList<Employee> GetAllEmployees()
        {
            return EmployeeDao.GetAllEmployees();
        }

        public Employee GetEmployeeById(string id)
        {
            return EmployeeDao.GetEmployeeById(id);
        }

    }

}
