
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class EmployeeDao : GenericDao<Employee>, IEmployeeDao
    {

        override protected IRowMapper<Employee> GetRowMapper()
        {
            return new EmployeeRowMapper();
        }

        public IList<Employee> GetAllEmployees()
        {
            string command = @"SELECT * FROM Employee ORDER BY id ASC";
            IList<Employee> employees = ExecuteQueryWithRowMapper(command);
            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            string command = @"SELECT * FROM Employee WHERE Id = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = id;

            IList<Employee> employees = ExecuteQueryWithRowMapper(command, parameters);
            if (employees.Count > 0)
            {
                return employees[0];
            }

            return null;
        }

    }
}
