namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : ICarBuilder
    {
        private readonly Car _car;

        public CarBuilder()
        {
            _car = new();
        }

        public Car Build()
        {
            return _car;
        }

        public void SetColor(string color)
        {
            _car.Color = color;
        }

        public void SetModel(string model)
        {
            _car.Model = model;
        }

        public void SetName(string name)
        {
            _car.Name = name;
        }
    }
}
