using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services
{
    public interface ICompanyService
    {

        IList<Company> GetAllCompanies();

        Company GetCompanyById(string id);

    }
}
