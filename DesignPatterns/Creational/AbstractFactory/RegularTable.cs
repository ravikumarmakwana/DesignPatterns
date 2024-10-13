namespace DesignPatterns.Creational.AbstractFactory
{
    public class RegularTable : ITable
    {
        public string GetTableType()
        {
            return "Regular";
        }
    }
}
