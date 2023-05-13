using ProjectQuebec.Code.FileHandle;

namespace ProjectQuebec.Code.Model
{
    public class Task
    {
        public int TaskLine { get; set; }
        public string TaskDescription { get; set; }
        public string FileName { get; set; }
        public FileObject File { get; set; }
    }
}
