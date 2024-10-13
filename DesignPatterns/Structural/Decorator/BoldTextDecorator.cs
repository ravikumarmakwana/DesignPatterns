namespace DesignPatterns.Structural.Decorator
{
    public class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(IText text) : base(text) { }

        public override string GetContent()
        {
            return $"<b>{_text.GetContent()}</b>";
        }
    }
}
