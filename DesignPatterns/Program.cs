using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Structural.Composite;

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

        //FurnitureFactory factory = new FurnitureFactory(FurnitureType.Modern);

        //IChair chair = factory.GetChair();
        //ITable table = factory.GetTable();
        //Console.WriteLine($"{chair.GetChairType()} Chair, {table.GetTableType()} Table");

        //XmlDataSource dataSource = new XmlDataSource();
        //XmlToJsonAdapter adapter = new XmlToJsonAdapter(dataSource);

        //string jsos = adapter.GetJson();
        //Console.WriteLine(jsos);

        //AudioPlayer audioPlayer = new AudioPlayer();

        //audioPlayer.Play("mp3", "song.mp3");
        //audioPlayer.Play("mp4", "video.mp4");
        //audioPlayer.Play("vlc", "movie.vlc");
        //audioPlayer.Play("avi", "documentary.avi"); // Invalid format

        //IText text = new PlainText("Hello, World!");
        //TextDecorator boldTextDecorator = new BoldTextDecorator(text);
        //Console.WriteLine(boldTextDecorator.GetContent());
        //TextDecorator italicTextDecorator = new ItalicTextDecorator(text);
        //Console.WriteLine(italicTextDecorator.GetContent());

        //DVDPlayer dvdPlayer = new DVDPlayer();
        //Amplifier amplifier = new Amplifier();
        //Projector projector = new Projector();
        //Lights lights = new Lights();

        //HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, amplifier, projector, lights);

        //homeTheater.WatchMovie("End Game");
        //Console.WriteLine();
        //homeTheater.EndMovie();


        //Customer customer1 = new Customer() { Name = "Customer 1" };
        //Customer customer2 = new Customer() { Name = "Customer 2" };
        //Customer customer3 = new Customer() { Name = "Customer 3" };
        //Customer customer4 = new Customer() { Name = "Customer 4" };

        //Product product1 = new Product("iPhone", 160000);
        //Product product2 = new Product("Samsung Galaxy Fold 6", 200000);

        //product1.Subscribe(customer1);
        //product1.Subscribe(customer2);
        //product1.Subscribe(customer3);

        //product2.Subscribe(customer2);
        //product2.Subscribe(customer3);

        //product1.Price -= 5000;

        //Console.WriteLine();
        //product2.Price += 5000;

        //product1.Unsubscribe(customer2);
        //product1.Unsubscribe(customer3);

        //product1.Subscribe(customer4);
        //Console.WriteLine();
        //product1.Price -= 40000;

        //CashOnDeliveryPayment cashOnDeliveryPayment = new();
        //CreditCardPayment creditCardPayment = new("1234 1212 1212 1212");
        //GooglePayPayment googlePayPayment = new("googlepay@google.com");

        //ShopingCart cart = new ShopingCart();

        //cart.Checkout(100);

        //cart.SetPaymentStrategy(googlePayPayment);
        //cart.Checkout(500);

        //cart.SetPaymentStrategy(cashOnDeliveryPayment);
        //cart.Checkout(50000);

        //cart.SetPaymentStrategy(creditCardPayment);
        //cart.Checkout(40);

        //Light light = new Light();

        //ICommand turnOn = new TurnOnCommand(light);
        //ICommand turnOff = new TurnOffCommand(light);

        //RemoteControl remoteControl = new RemoteControl();

        //remoteControl.SetCommand(turnOn);
        //remoteControl.Execute();

        //remoteControl.SetCommand(turnOff);
        //remoteControl.Execute();


        //IFileSystemItem file1 = new DesignPatterns.Structural.Composite.File("File 1.txt");
        //IFileSystemItem file2 = new DesignPatterns.Structural.Composite.File("File 2.txt");
        //IFileSystemItem file3 = new DesignPatterns.Structural.Composite.File("File 3.txt");
        //IFileSystemItem file4 = new DesignPatterns.Structural.Composite.File("File 4.txt");

        //Folder mainFolder = new DesignPatterns.Structural.Composite.Folder("Main Folder");
        //Folder subFolder = new DesignPatterns.Structural.Composite.Folder("Sub Folder");

        //mainFolder.Add(file1);
        //mainFolder.Add(file2);
        //mainFolder.Add(subFolder);

        //subFolder.Add(file3);
        //subFolder.Add(file4);

        //mainFolder.Display();

        EmailMiddleware emailMiddleware = new EmailMiddleware();
        SMSMiddleware sMSMiddleware = new SMSMiddleware();
        LogMiddleware logMiddleware = new LogMiddleware();

        logMiddleware.SetNext(sMSMiddleware);
        sMSMiddleware.SetNext(emailMiddleware);

        logMiddleware.Invoke("Hello World!");
    }
}