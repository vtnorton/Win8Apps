using System.Collections.ObjectModel;

namespace ProjectQuebec.Code.FileHandle
{
    public class FileOpend
    {
        public static FileObject CurrentFile = new FileObject();
        public static ObservableCollection<FileObject> AllFilesList = new ObservableCollection<FileObject>();

        public static FileObject GetLastAddedFile()
        {
            if (AllFilesList.Count < 1)
                return null;
            else
                return AllFilesList[AllFilesList.Count - 1];
        }
    }
}
