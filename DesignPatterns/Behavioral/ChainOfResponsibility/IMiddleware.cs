namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public interface IMiddleware
    {
        void Invoke(string message);
    }

    public class LogMiddleware : IMiddleware
    {
        private IMiddleware _next;

        public void SetNext(IMiddleware next)
        {
            _next = next;
        }

        public void Invoke(string message)
        {
            Console.WriteLine($"Log Middleware: {message}");
            _next?.Invoke(message);
        }
    }

    public class EmailMiddleware : IMiddleware
    {
        private IMiddleware _next;

        public void SetNext(IMiddleware next)
        {
            _next = next;
        }

        public void Invoke(string message)
        {
            Console.WriteLine($"Email Middleware: {message}");
            _next?.Invoke(message);
        }
    }

    public class SMSMiddleware: IMiddleware
    {
        private IMiddleware _next;

        public void SetNext(IMiddleware next)
        {
            _next = next;
        }

        public void Invoke(string message)
        {
            Console.WriteLine($"SMS Middleware: {message}");
            _next?.Invoke(message);
        }
    }
}
