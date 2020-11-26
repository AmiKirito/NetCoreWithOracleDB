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
    public class GoodService : IGoodService
    {
        public async Task<bool> CheckIfExists(int goodId)
        {
            var goods = await GetGoods();

            return goods.Any(x => x.Good_Id == goodId);
        }

        public async Task<Good> GetGoodById(int goodId)
        {
            var goods = await GetGoods();

            var good = goods.Single(x => x.Good_Id == goodId);

            return good;
        }

        public async Task<ICollection<Good>> GetGoods()
        {
            using (OracleConnection connection = new OracleConnection(OracleDbContext.ConnectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        await connection.OpenAsync();

                        cmd.CommandText = "select * from Goods_1";
                        var dbDataReader = await cmd.ExecuteReaderAsync();

                        var goods = new List<Good>();
                        if (dbDataReader.HasRows)
                        {
                            while (await dbDataReader.ReadAsync())
                            {
                                goods.Add(new Good { 
                                    Good_Id = Convert.ToInt32(dbDataReader["Good_ID"].ToString()),
                                    Name = dbDataReader["Name"].ToString(),
                                    Price = Convert.ToDecimal(dbDataReader["Price"].ToString()),
                                    Dept_Id = Convert.ToInt32(dbDataReader["Dept_ID"].ToString()),
                                    Description = dbDataReader["Description"].ToString(),
                                    Producer = dbDataReader["Producer"].ToString(),
                                    Quantity = Convert.ToInt32(dbDataReader["Quantity"].ToString()),
                                });
                            }
                        }

                        await dbDataReader.DisposeAsync();

                        return goods.OrderBy(x => x.Good_Id).ToList();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        public async Task SetDescription(GoodDescModel model)
        {
            using (OracleConnection connection = new OracleConnection(OracleDbContext.ConnectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        await connection.OpenAsync();

                        cmd.CommandText = "proc1_1";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("Good_id_this", OracleDbType.Int32).Value = model.Good_Id;
                        cmd.Parameters.Add("NUMB", OracleDbType.Int32).Value = model.Discount;

                        cmd.ExecuteNonQuery();
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
