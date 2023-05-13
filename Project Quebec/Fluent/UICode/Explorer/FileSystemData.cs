namespace ProjectQuebec.Fluent.UICode.Explorer
{
    public class FileSystemData
    {
        public FileSystemData(string name) => Name = name;
        public string Name { get; set; }
        public bool IsFolder { get; set; }
    }
}
