using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;

namespace ProjectMontreal.Code
{
    public class FileInteraction
    {
        public StorageFile CurrentFile { get; set; }

        private async void SaveContent(string textToSave)
        {
            textToSave = textToSave.Replace("\r", Environment.NewLine);

            CachedFileManager.DeferUpdates(CurrentFile);
            FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(CurrentFile);
            await FileIO.WriteTextAsync(CurrentFile, textToSave);
        }

        public async void SaveFile(string textToSave)
        {
            if (CurrentFile == null)
            {
                await SaveAsFile(textToSave);
            }

            SaveContent(textToSave);
        }

        public async Task<int> SaveAsFile(string textToSave)
        {
            FileSavePicker savePicker = new FileSavePicker()
            {
                SuggestedFileName = ".txt",
                SuggestedStartLocation = PickerLocationId.Desktop
            };

            savePicker.FileTypeChoices.Add(".txt", new List<string>() { ".txt" });
            CurrentFile = await savePicker.PickSaveFileAsync();

            SaveContent(textToSave);

            return 0;
        }

        //public string ReadFileContent()
        //{

        //}

        //public StorageFile OpenFile()
        //{

        //}

        public void NewFile()
        {

        }
    }
}
