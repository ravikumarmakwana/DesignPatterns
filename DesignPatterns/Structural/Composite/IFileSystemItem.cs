namespace DesignPatterns.Structural.Composite
{
    public interface IFileSystemItem
    {
        void Display(string indent = "");
    }

    public class File : IFileSystemItem
    {
        private readonly string _name;

        public File(string name)
        {
            _name = name;
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- File: {_name}");
        }
    }

    public class Folder : IFileSystemItem
    {
        private readonly string _name;
        private readonly IList<IFileSystemItem> _fileSystemItems;

        public Folder(string name)
        {
            _name = name;
            _fileSystemItems = new List<IFileSystemItem>();
        }

        public void Add(IFileSystemItem fileSystemItem)
        {
            _fileSystemItems.Add(fileSystemItem);
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}+ Folder: {_name}");
            foreach (IFileSystemItem fileSystemItem in _fileSystemItems)
            {
                fileSystemItem.Display(indent + " ");
            }
        }
    }
}
