using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using KuasCore.Models;
using KuasCore.Services.Impl;
using Core;
using Spring.Context;
using Spring.Context.Support;

namespace KuasCoreTests.Core
{
    [TestClass]
    public class ObjectFactoryUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        [TestMethod]
        public void TestObjectFactory_GetApplicationContext()
        {

            // 利用 Spring Object Name 來依賴尋找找出我們要的 Spring Object.
            IApplicationContext applicationContext = ObjectFactory.GetApplicationContext();
            EmployeeService employeeService = (EmployeeService)applicationContext["employeeService"];

            Employee empolyee = employeeService.GetEmployeeById("dennis_yen");
            Assert.IsNotNull(empolyee);

            Console.WriteLine("員工編號為 = " + empolyee.Id);
            Console.WriteLine("員工姓名為 = " + empolyee.Name);
            Console.WriteLine("員工年齡為 = " + empolyee.Age);

        }

        [TestMethod]
        public void TestObjectFactory_GetObject()
        {

            // 利用 Spring Object Name 來依賴尋找找出我們要的 Spring Object.
            EmployeeService employeeService = (EmployeeService)ObjectFactory.GetObject("employeeService");

            Employee empolyee = employeeService.GetEmployeeById("dennis_yen");
            Assert.IsNotNull(empolyee);

            Console.WriteLine("員工編號為 = " + empolyee.Id);
            Console.WriteLine("員工姓名為 = " + empolyee.Name);
            Console.WriteLine("員工年齡為 = " + empolyee.Age);
        }

    }
}
