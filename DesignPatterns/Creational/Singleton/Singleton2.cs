namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton2
    {
        private static Singleton2 _instance;
        private static readonly Object _instanceLock = new Object();

        private Singleton2() { }

        public static Singleton2 GetInstance()
        {
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new();
                }
            }
            return _instance;
        }
    }
}
