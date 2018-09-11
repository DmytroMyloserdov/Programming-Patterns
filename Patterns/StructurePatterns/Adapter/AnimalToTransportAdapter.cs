namespace Patterns.StructurePatterns.Adapter
{
    internal class AnimalToTransportAdapter : ITransport
    {
        IAnimal _animal;

        public AnimalToTransportAdapter(IAnimal animal)
        {
            _animal = animal;
        }

        public void Drive()
        {
            _animal.Move();
        }
    }
}
