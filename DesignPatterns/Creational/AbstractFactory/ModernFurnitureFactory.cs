namespace DesignPatterns.Creational.AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair GetChair()
        {
            return new ModernChair();
        }

        public ITable GetTable()
        {
            return new ModernTable();
        }
    }
}
