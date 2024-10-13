using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        //Singleton1 singleton11 = Singleton1.GetInstance();
        //Singleton1 singleton12 = Singleton1.GetInstance();

        //if (singleton11 == singleton12)
        //{
        //    Console.WriteLine("Single Instance Only!!!");
        //}

        //Singleton2 singleton21 = Singleton2.GetInstance();
        //Singleton2 singleton22 = Singleton2.GetInstance();

        //if (singleton21 == singleton22)
        //{
        //    Console.WriteLine("Single Instance Only!!!");
        //}

        //ICarBuilder carBuilder = new CarBuilder();
        //CarDirector carDirector = new CarDirector(carBuilder);

        //Car suv = carDirector.MakeSUV();
        //suv.Display();

        //Car bmd = carDirector.MakeBMD();
        //bmd.Display();

        //Product product1 = new Product()
        //{
        //    ProductId = 1,
        //    Name = "Test",
        //    Quantity = 10
        //};

        //product1.Display();

        //Product product2 = product1.Clone();
        //product2.Display();

        //Console.WriteLine("Update Quantity of Product 2");
        //product2.Quantity += 25;

        //product1.Display();
        //product2.Display();

        //Factory factory = new Factory();
        //IShape circle = factory.GetShape("Circle");
        //IShape triangle = factory.GetShape("Triangle");
        //circle.Draw();
        //triangle.Draw();

        FurnitureFactory factory = new FurnitureFactory(FurnitureType.Modern);

        IChair chair = factory.GetChair();
        ITable table = factory.GetTable();
        Console.WriteLine($"{chair.GetChairType()} Chair, {table.GetTableType()} Table");
    }
}