namespace DesignPatterns.Structural.Decorator
{
    public abstract class TextDecorator: IText
    {
        protected IText _text;

        public TextDecorator(IText text)
        {
            _text = text;
        }

        public virtual string GetContent()
        {
            return _text.GetContent();
        }
    }
}
