namespace DesignPatterns.Creational.Factory
{
    public interface IShape
    {
        void Draw();
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }

    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }

    public class Factory
    {
        public IShape GetShape(string type)
        {
            switch (type)
            {
                case "Square": return new Square();
                case "Circle": return new Circle();
                case "Triangle": return new Triangle();
                default: throw new InvalidOperationException("Invalid Shape Type");
            }
        }
    }
}
