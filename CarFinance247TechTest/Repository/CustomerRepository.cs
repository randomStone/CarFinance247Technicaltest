using System.Data;
using System.Collections.Generic;
using CarFinance247TechTest.Modal;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace CarFinance247TechTest.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string connectionString;


        public CustomerRepository(IConfiguration config){
            connectionString = config.GetConnectionString("default");
        }
        public async Task<IEnumerable<Customer>> getAllCustomers()
        {
            using (var connection = new SqlConnection(connectionString)){
                return await connection.QueryAsync<Customer>(@"SELECT [ID],[FirstName],[Surname],[EMail],[CustomerPassword] From CUSTOMERS").ConfigureAwait(false);
            }
            
        }

       
    }
}