namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton1
    {
        private static Singleton1 _instance;
        private Singleton1() { }

        public static Singleton1 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new();
            }
            return _instance;
        }
    }
}
