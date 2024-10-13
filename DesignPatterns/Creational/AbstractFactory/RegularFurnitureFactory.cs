namespace DesignPatterns.Creational.AbstractFactory
{
    public class RegularFurnitureFactory : IFurnitureFactory
    {
        public IChair GetChair()
        {
            return new RegularChair();
        }

        public ITable GetTable()
        {
            return new RegularTable();
        }
    }
}
