using KIC_Lab_4.Interfaces;
using KIC_Lab_4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using System;

namespace KIC_Lab_4.Services
{
    public class SaleService : ISaleService
    {
        public async Task<Sale> GetSaleById(int saleId)
        {
            var sales = await GetSales();

            var sale = sales.Single(x => x.Sales_Id == saleId);

            return sale;
        }

        public async Task<ICollection<Sale>> GetSales()
        {
            using (OracleConnection connection = new OracleConnection(OracleDbContext.ConnectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        await connection.OpenAsync();

                        cmd.CommandText = "select * from Sales_1";
                        var dbDataReader = await cmd.ExecuteReaderAsync();

                        var sales = new List<Sale>();
                        if (dbDataReader.HasRows)
                        {
                            while (await dbDataReader.ReadAsync())
                            {
                                sales.Add(new Sale
                                {
                                    Sales_Id = Convert.ToInt32(dbDataReader["SALES_ID"].ToString()),
                                    CheckNumber = Convert.ToInt32(dbDataReader["CHECK_NO"].ToString()),
                                    Good_Id = Convert.ToInt32(dbDataReader["GOOD_ID"].ToString()),
                                    Date = Convert.ToDateTime(dbDataReader["DATE_SALE"].ToString())
                                });
                            }
                        }

                        await dbDataReader.DisposeAsync();

                        return sales.OrderBy(x => x.Sales_Id).ToList();
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
