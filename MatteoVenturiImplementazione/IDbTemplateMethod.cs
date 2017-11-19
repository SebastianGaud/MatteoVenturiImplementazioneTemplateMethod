namespace MatteoVenturiImplementazione
{
    public interface IDbTemplateMethod<out TReturn, in TEntry>
    {
        TReturn MakeQuery(TEntry entry);
    }
}
