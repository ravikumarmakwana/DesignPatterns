namespace DesignPatterns.Structural.Decorator
{
    public class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(IText text) : base(text) { }

        public override string GetContent()
        {
            return $"<i>{_text.GetContent()}</i>";
        }
    }
}
