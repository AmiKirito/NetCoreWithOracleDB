using KIC_Lab_4.Interfaces;
using KIC_Lab_4.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace KIC_Lab_4.Services
{
    public class DepartmentService : IDepartmentService
    {
        public async Task<bool> CheckIfExists(int deptId)
        {
            var departments = await GetDepartments();

            return departments.Any(x => x.Dept_ID == deptId);
        }

        public async Task<bool> CheckIfExistsByName(string deptName)
        {
            var departments = await GetDepartments();

            return departments.Any(x => x.Name == deptName);
        }

        public async Task<Department> GetDepartmentById(int deptId)
        {
            var departments = await GetDepartments();

            var department = departments.Single(x => x.Dept_ID == deptId);

            return department;
        }

        public async Task<ICollection<Department>> GetDepartments()
        {
            using (OracleConnection connection = new OracleConnection(OracleDbContext.ConnectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        await connection.OpenAsync();

                        cmd.CommandText = "select * from Departments_1";
                        var dbDataReader = await cmd.ExecuteReaderAsync();

                        var departments = new List<Department>();
                        if (dbDataReader.HasRows)
                        {
                            while (await dbDataReader.ReadAsync())
                            {
                                departments.Add(new Department
                                {
                                    Dept_ID = Convert.ToInt32(dbDataReader["Dept_ID"].ToString()),
                                    Name = dbDataReader["Name"].ToString(),
                                    Info = dbDataReader["Info"].ToString(),
                                });
                            }
                        }

                        await dbDataReader.DisposeAsync();

                        return departments.OrderBy(x => x.Dept_ID).ToList();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        public async Task<string> GetMaxDeptPrice(string deptName)
        {
            using (OracleConnection connection = new OracleConnection(OracleDbContext.ConnectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        await connection.OpenAsync();

                        cmd.CommandText = $"SELECT max_price('{deptName}') FROM dual";
                        cmd.CommandType = CommandType.Text;

                        var result = cmd.ExecuteReader();

                        result.Read();

                        string res = result[$"MAX_PRICE('{deptName}')"].ToString();

                        return res;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }
    }
}
