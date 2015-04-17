using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KuasCoreTests.Dao
{

    [TestClass]
    public class EmpolyeeDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        #region 單元測試 Spring 必寫的內容 
        
        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    // assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public IEmployeeDao EmployeeDao { get; set; }

        [TestMethod]
        public void TestEmployeeDao_GetEmployeeById()
        {
            Employee empolyee = EmployeeDao.GetEmployeeById("dennis_yen");
            Assert.IsNotNull(empolyee);
            Console.WriteLine("員工編號為 = " + empolyee.Id);
            Console.WriteLine("員工姓名為 = " + empolyee.Name);
            Console.WriteLine("員工年齡為 = " + empolyee.Age);
        }

    }
}
