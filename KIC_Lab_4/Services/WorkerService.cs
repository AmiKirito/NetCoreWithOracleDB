using KIC_Lab_4.Interfaces;
using KIC_Lab_4.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KIC_Lab_4.Services
{
    public class WorkerService : IWorkerService
    {
        public async Task<Worker> GetWorkerById(int workerId)
        {
            var workers = await GetWorkers();

            var worker = workers.Single(x => x.Workers_Id == workerId);

            return worker;
        }

        public async Task<ICollection<Worker>> GetWorkers()
        {
            using (OracleConnection connection = new OracleConnection(OracleDbContext.ConnectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        await connection.OpenAsync();

                        cmd.CommandText = "select * from Workers_1";
                        var dbDataReader = await cmd.ExecuteReaderAsync();

                        var workers = new List<Worker>();
                        if (dbDataReader.HasRows)
                        {
                            while (await dbDataReader.ReadAsync())
                            {
                                workers.Add(new Worker
                                {
                                    Workers_Id = Convert.ToInt32(dbDataReader["WORKERS_ID"].ToString()),
                                    Name = dbDataReader["NAME"].ToString(),
                                    Address = dbDataReader["ADDRESS"].ToString(),
                                    Dept_ID = Convert.ToInt32(dbDataReader["DEPT_ID"].ToString()),
                                    Information = dbDataReader["INFORMATION"].ToString(),
                                });
                            }
                        }

                        await dbDataReader.DisposeAsync();

                        return workers.OrderBy(x => x.Name).ToList();
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
