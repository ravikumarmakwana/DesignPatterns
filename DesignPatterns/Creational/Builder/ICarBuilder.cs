namespace DesignPatterns.Creational.Builder
{
    public interface ICarBuilder
    {
        void SetColor(string color);
        void SetName(string name);
        void SetModel(string model);
        Car Build();
    }
}
