namespace Patterns.StructurePatterns.Adapter
{
    internal class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
