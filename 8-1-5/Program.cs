namespace _8_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Folder folder = new Folder();
            Console.WriteLine("Введите имя папки");
            folder.CreateFolder(Console.ReadLine());
            Console.WriteLine("Папка {0} создана", folder.Folders);
        }
    }

    class Disk
    {
        public string Name;
        public long space;
        public long voidSpace;
        public Disk(string name, long space, long voidSpace)
        {
            Name = name;
            this.space = space;
            this.voidSpace = voidSpace;
        }
    }
    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
        
        public Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }
}
