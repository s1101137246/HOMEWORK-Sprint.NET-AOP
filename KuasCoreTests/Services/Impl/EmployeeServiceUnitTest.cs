using KuasCore.Dao;
using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;

namespace KuasCoreTests.Services
{
    [TestClass]
    public class EmployeeServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public IEmployeeService EmployeeService { get; set; }

        [TestMethod]
        public void TestEmployeeService_GetEmployeeById()
        {
            Employee empolyee = EmployeeService.GetEmployeeById("dennis_yen");
            Assert.IsNotNull(empolyee);

            Console.WriteLine("員工編號為 = " + empolyee.Id);
            Console.WriteLine("員工姓名為 = " + empolyee.Name);
            Console.WriteLine("員工年齡為 = " + empolyee.Age);
        }
    }
}
