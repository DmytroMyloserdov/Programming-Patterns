namespace Patterns.StructurePatterns.Adapter
{
    public class AdapterCaller
    {
        public static void Call()
        {
            Driver driver = new Driver();
            Auto auto = new Auto();
            Hourse hourse = new Hourse();
            AnimalToTransportAdapter adapter = new AnimalToTransportAdapter(hourse);

            driver.Travel(auto);
            driver.Travel(adapter);
        }
    }
}
