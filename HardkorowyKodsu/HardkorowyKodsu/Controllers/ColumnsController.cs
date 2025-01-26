using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HardkorowyKodsu.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnsController : ControllerBase
    {
        private readonly string _connectionString;

        public ColumnsController()
        {
            _connectionString = Configuration.DbConnection.ConnectionString;
        }

        // GET: api/Columns
        [HttpGet]
        public IEnumerable<string?> GetColumns(string name)
        {
            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                _connection.Open();

                string[] restrictionValues = new string[] { null, null, name, null };

                var columnList = _connection.GetSchema("Columns", restrictionValues).AsEnumerable().Select(dataRow => dataRow.Field<string>("Column_Name")).ToList();

                _connection.Close();

                return columnList;
            }
        }
    }
}
