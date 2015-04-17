using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;

namespace KuasCoreTests.Services
{
    [TestClass]
    public class CompanyServiceUnitTest : AbstractDependencyInjectionSpringContextTests
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
        public ICompanyService CompanyService { get; set; }

        [TestMethod]
        public void TestCompanyService_GetCompanyById()
        {
            Company company = CompanyService.GetCompanyById("GSS");
            Assert.IsNotNull(company);

            Console.WriteLine("公司代號為 = " + company.Id);
            Console.WriteLine("公司名稱為 = " + company.Name);
        }
    }
}
