using CompanyApp.Models;

namespace CompanyApp.Repositories
{
    /// <summary>
    /// Interface for Company related data access
    /// </summary>
    public interface ICompanyRepository
    {
        /// <summary>
        /// Gets the company using Id
        /// </summary>
        /// <param name="id">Id of the company</param>
        /// <returns>Company</returns>
        public Task<Company> GetCompany(int id);

        /// <summary>
        /// Gets all companies
        /// </summary>
        /// <returns>List of companies</returns>
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
