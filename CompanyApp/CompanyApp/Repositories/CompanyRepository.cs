using CompanyApp.Context;
using CompanyApp.Models;
using Dapper;

namespace CompanyApp.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;

        public CompanyRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<Company> GetCompany(int id)
        {
            var query = "SELECT * FROM Companies WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QuerySingleOrDefaultAsync<Company>(query, new { id });
                
                return company;
            }
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "SELECT * FROM Companies";

            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                
                return companies;
            }
        }

        public async Task<Company> CreateCompany(Company company)
        {
            var query = "INSERT INTO Companies (Name, Address, Country) " +
                        "VALUES (@Name, @Address, @Country); " +
                        "SELECT * FROM Companies WHERE Id = SCOPE_IDENTITY()";

            using (var connection = _context.CreateConnection())
            {
                var newCompany = await connection.QuerySingleOrDefaultAsync<Company>(query, company);
                
                return newCompany;
            }
        }

        public async Task<Company> UpdateCompany(int id, Company company)
        {
            var query = "UPDATE Companies " +
                        "SET Name = @Name, Address = @Address, Country = @Country " +
                        "WHERE Id = @Id; " +
                        "SELECT Name, Address, Country FROM Companies WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var updatedCompany = await connection.QuerySingleOrDefaultAsync<Company>(query, new { id, company.Name, company.Address, company.Country });
                
                return updatedCompany;
            }
        }
    }
}
