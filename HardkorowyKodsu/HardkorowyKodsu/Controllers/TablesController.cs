using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HardkorowyKodsu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly string _connectionString;

        public TablesController()
        {
            _connectionString = Configuration.DbConnection.ConnectionString;
        }

        // GET: api/Tables
        [HttpGet]
        public IEnumerable<string> GetTablesAndViews()
        {
            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                _connection.Open();

                List<string> tables = new List<string>();
                DataTable dataTable = _connection.GetSchema("Tables");
                foreach (DataRow row in dataTable.Rows)
                {
                    string tablename = (string)row[2];
                    tables.Add(tablename);
                }

                _connection.Close();

                return tables;
            }
        }
    }
}
