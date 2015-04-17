using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class EmployeeController : ApiController
    {

        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            var employees = EmployeeService.GetAllEmployees();
            return employees;
        }

        [HttpGet]
        [ActionName("byId")]
        public Employee GetEmployeeById(string id)
        {
            var employee = EmployeeService.GetEmployeeById(id);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }

    }
}
