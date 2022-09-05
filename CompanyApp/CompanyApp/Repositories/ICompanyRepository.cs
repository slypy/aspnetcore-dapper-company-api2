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

        /// <summary>
        /// Creates a new company
        /// </summary>
        /// <param name="company">Company to be created</param>
        /// <returns>Created company</returns>
        public Task<Company> CreateCompany(Company company);

        /// <summary>
        /// Updates an existing company
        /// </summary>
        /// <param name="id">Id of a Company to be updated</param>
        /// <param name="company">Company to be updated</param>
        /// <returns>Updated company</returns>
        public Task<Company> UpdateCompany(int id, Company company);
    }
}
