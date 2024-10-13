namespace DesignPatterns.Structural.Decorator
{
    public class PlainText : IText
    {
        private readonly string _content;

        public PlainText(string text)
        {
            _content = text;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
