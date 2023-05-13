using ProjectQuebec.Code.LanguageSupport;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.Storage;
using Windows.UI.ViewManagement;

namespace ProjectQuebec.Code.FileHandle
{
    public class FileObject : INotifyPropertyChanged
    {
        private int tab;
        private string displayName;
        private string fileName;
        private string fileType;
        private string contentWithoutSaving;
        private Language fileLanguage;
        private StorageFile file;

        public event PropertyChangedEventHandler PropertyChanged;

        public Encoding TextEncoding { get; set; }

        public int Tab
        {
            get { return tab; }
            set { tab = value; }
        }
        
        public string DisplayName
        {
            get { return displayName; }
            set { SetProperty(ref displayName, value); }
        }
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public string FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }
        public string ContentWithoutSaving
        {
            get { return contentWithoutSaving; }
            set { contentWithoutSaving = value; }
        }
        public Language FileLanguage
        {
            get { return fileLanguage; }
            set { fileLanguage = value; }
        }
        public StorageFile File
        {
            get { return file; }
            set { file = value; }
        }

        public FileObject() {
            this.Tab = ApplicationView.GetForCurrentView().Id;
        }
        
        public override string ToString() { return this.DisplayName; }

        /// <summary>
        /// Checks if a property already matches a desired value.  Sets the property and
        /// notifies listeners only when necessary.
        /// </summary>
        /// <typeparam name="T">Type of the property.</typeparam>
        /// <param name="storage">Reference to a property with both getter and setter.</param>
        /// <param name="value">Desired value for the property.</param>
        /// <param name="propertyNames">Name of the property used to notify listeners.  This
        /// value is optional and can be provided automatically when invoked from compilers that
        /// support CallerMemberName.</param>
        /// <returns>True if the value was changed, false if the existing value matched the
        /// desired value.</returns>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value)) return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyNames">Name of the property used to notify listeners.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
