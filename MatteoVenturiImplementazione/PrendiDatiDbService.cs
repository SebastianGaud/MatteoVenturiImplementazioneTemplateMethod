namespace MatteoVenturiImplementazione
{
    public class PrendiDatiDbService : BaseDbService<string, string>
    {
        protected override string Query(string entry)
        {
            var command = CreateStoredProcedureCommand("Comando");

            var reader = command.ExecuteReader();

            return "readerResult";

        }
    }
}
