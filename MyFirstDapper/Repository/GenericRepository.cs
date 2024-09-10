using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Repository
{
     //(class) for performing crud, which implements IGenericRepository interface
    public class GenericRepository<T>: IGenericRepository<T> where T : class

    {
         //to interact with the database
        IDbConnection connection;
        private object p;
        private object _connection;
        readonly string connectionString = "SERVER=(LocalDb)\\MSSQLLocalDb; Database=myfirstdapper; Trusted_Connection=True; MultipleActiveResultSets=true ";
        public GenericRepository()
        {
            connection = new SqlConnection(connectionString);
        }

        public T GetbyId (int id)
        {
            return null;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }



        public bool Add(T Entity)
        {
            string tableName = GetTableName();
            string columns = GetColumnNames();
            string values = GetColumnValues();
            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values}) ";

            int affectedRow = 0;
            affectedRow = connection.Execute(query, Entity);

            return affectedRow == 1;

        }

        
       

        public bool Update(T Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string GetTableName()
        {
            string tableName = "";
            var type = typeof(T);
            var tableAttr = type.GetCustomAttribute<TableAttribute>();
            if (tableAttr != null)
            {
                tableName = $"[{tableAttr.Name}]";
            }

            return tableName;
        }

        public string GetColumnNames(bool excludeKey = true)
        {
            string columnNames = "";
            var type = typeof(T);
            var columns = string.Join(",", type.GetProperties()
                .Where(p => !excludeKey || !p.IsDefined(typeof(KeyAttribute)))
                .Select(p =>
                {
                    var columnAttr = p.GetCustomAttribute<ColumnAttribute>();
                    return columnAttr != null ? columnAttr.Name : p.Name;
                }));
            return columns;
        }

        public string GetColumnValues(bool excludeKey = true)
        {
            var columnValues = typeof(T).GetProperties()
            .Where(p => !excludeKey || p.GetCustomAttribute<KeyAttribute>() == null);
            var values = string.Join(",", columnValues.Select(p =>
            {
                return $"@{p.Name}";
            }));

            return values;
        }
    }
}
