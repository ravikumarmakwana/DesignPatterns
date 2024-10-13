namespace DesignPatterns.Creational.Builder
{
    public class CarDirector
    {
        private readonly ICarBuilder _carBuilder;

        public CarDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public Car MakeSUV()
        {
            _carBuilder.SetModel("New");
            _carBuilder.SetColor("Red");
            _carBuilder.SetName("SUV");
            return _carBuilder.Build();
        }

        public Car MakeBMD()
        {
            _carBuilder.SetModel("New");
            _carBuilder.SetColor("White");
            _carBuilder.SetName("BMW");
            return _carBuilder.Build();
        }
    }
}
