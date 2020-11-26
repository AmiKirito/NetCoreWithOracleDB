namespace KIC_Lab_4
{
    public class OracleDbContext
    {
        public const string ConnectionString =
            "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.kyiv.epam.com)));User id=roman; Password=01082000; enlist=false; pooling=false; DBA PRIVILEGE=SYSDBA";
    }
}
