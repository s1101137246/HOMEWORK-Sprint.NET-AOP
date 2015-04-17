using KuasCore.Dao;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services
{
    public interface IEmployeeService
    {

        /// <summary>
        ///     取得所有員工資料.
        /// </summary>
        /// <returns>
        ///     所有員工資料
        /// </returns>
        IList<Employee> GetAllEmployees();

        /// <summary>
        ///     依據 ID 取得員工資料.
        /// </summary>
        /// <returns>
        ///     該員工資料
        /// </returns>
        Employee GetEmployeeById(string id);

    }
}
