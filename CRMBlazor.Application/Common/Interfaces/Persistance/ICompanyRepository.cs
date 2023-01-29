using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Companies;
using CRMBlazor.Domain.Companies.Entities;
using CRMBlazor.Domain.Companies.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    internal interface ICompanyRepository
    {
        Task<Company> CreateComapny(CompanyId id, string name, string description, Address address, string? email, string? phone, string? nip, string? krs, string? regon, string? additionalInfo, CompanyTypeId typeId);
        Task<Company> GetComapny(CompanyId id);
        Task<IReadOnlyList<Company>> GetAllCompanies();
        Task AddCompany(Company company);
        Task DeleteComapny(CompanyId id);
        Task UpdateCompany(Company company);

        Task<CompanyType> CreateComapnyType(CompanyTypeId id, string name, string? description);
        Task<CompanyType> GetComapnyType(CompanyTypeId id);
        Task<IReadOnlyList<CompanyType>> GetAllCompanyTypes();
        Task AddCompanyType(CompanyType companyType);
        Task DeleteComapnyType(CompanyTypeId id);
        Task UpdateCompanyType(CompanyType companyType);
    }
}
