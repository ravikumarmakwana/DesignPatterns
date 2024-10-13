namespace DesignPatterns.Creational.AbstractFactory
{
    public class FurnitureFactory
    {
        private readonly IFurnitureFactory _factory;

        public FurnitureFactory(FurnitureType furnitureType)
        {
            if(furnitureType == FurnitureType.Modern)
            {
                _factory = new ModernFurnitureFactory();
            }
            else
            {
                _factory = new RegularFurnitureFactory();
            }
        }

        public IChair GetChair()
        {
            return _factory.GetChair();
        }

        public ITable GetTable()
        {
            return _factory.GetTable();
        }
    }
}
