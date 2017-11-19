namespace MatteoVenturiImplementazione
{
    public class Program
    {
        static void Main(string[] args)
        {
            var prendiDati = new PrendiDatiDbService();
            prendiDati.MakeQuery("Stringa");
        }
    }
}
