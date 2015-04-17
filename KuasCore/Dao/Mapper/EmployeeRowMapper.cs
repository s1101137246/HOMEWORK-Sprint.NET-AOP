using KuasCore.Models;
using Spring.Data.Generic;
using System.Data;

namespace KuasCore.Dao.Mapper
{
    class EmployeeRowMapper : IRowMapper<Employee>
    {
        public Employee MapRow(IDataReader dataReader, int rowNum)
        {
            Employee target = new Employee();

            target.Id = dataReader.GetString(dataReader.GetOrdinal("Id"));
            target.Name = dataReader.GetString(dataReader.GetOrdinal("Name"));
            target.Age = dataReader.GetInt32(dataReader.GetOrdinal("Age"));

            return target;
        }

    }
}
