using System;
using System.Data;
using System.Data.SqlClient;

namespace MatteoVenturiImplementazione
{
    public abstract class BaseDbService<TReturn, TEntry> : IDbTemplateMethod<TReturn, TEntry>, IDisposable
    {
        private readonly SqlConnection _connection;

        protected BaseDbService()
        {
            string connectionString = "ABCD";

            _connection = new SqlConnection(connectionString);

        }

        protected SqlCommand CreateStoredProcedureCommand(string commandName)
        {
            return new SqlCommand(commandName, _connection)
            {
                CommandType = CommandType.StoredProcedure
            };
        }

        protected abstract TReturn Query(TEntry entry);

        public TReturn MakeQuery(TEntry entry)
        {
            _connection.Open();
            var result = Query(entry);
            _connection.Close();

            return result;
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
