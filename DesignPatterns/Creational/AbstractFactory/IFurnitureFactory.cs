namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair GetChair();
        ITable GetTable();
    }
}
