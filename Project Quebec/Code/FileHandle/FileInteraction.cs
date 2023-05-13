using ProjectQuebec.Code.Util;
using ProjectQuebec.Code.ViewModel;
using ProjectQuebec.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;
using Windows.UI.Popups;

namespace ProjectQuebec.Code.FileHandle
{
    public class FileInteraction
    {
        public void CreateFile(FileObject xFile)
        {
            if (!FileOpend.AllFilesList.Contains(xFile))
            {
                FileOpend.CurrentFile = xFile;
                FileOpend.AllFilesList.Add(xFile);
            }
        }
        public async void SaveAllFiles()
        {
            for (int i = 0; i < FileOpend.AllFilesList.Count; i++)
            {
                await SaveFile(FileOpend.AllFilesList[i]);
            }
        }
        public async Task SaveFile(FileObject xFile)
        {
            FileObject FileToWorkWith = FileOpend.AllFilesList[FileOpend.AllFilesList.IndexOf(xFile)];

            if (FileToWorkWith.File == null)
            {
                FileSavePicker savePicker = new FileSavePicker()
                {
                    SuggestedFileName = FileToWorkWith.FileName,
                    SuggestedStartLocation = PickerLocationId.Desktop
                };

                foreach (var item in xFile.FileLanguage.Extention)
                {
                    savePicker.FileTypeChoices.Add(item, new List<string>() { FileToWorkWith.FileType });
                }

                FileToWorkWith.File = await savePicker.PickSaveFileAsync();
            }
            FileToWorkWith.DisplayName = FileToWorkWith.File.Name;

            CachedFileManager.DeferUpdates(FileToWorkWith.File);
            FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(FileToWorkWith.File);

            string newContentToSave = FileToWorkWith.ContentWithoutSaving.Replace("<newlineformula>", Environment.NewLine);
            await FileIO.WriteTextAsync(FileToWorkWith.File, newContentToSave);
            FileToWorkWith.ContentWithoutSaving = null;
        }

        #region CLOSEFILE
        private void _CloseAllFiles()
        {
            for (int i = 0; i < FileOpend.AllFilesList.Count; i++)
            {
                FileOpend.AllFilesList.Remove(FileOpend.AllFilesList[i]);
            }
        }
        public void CloseAllButUnmodifed()
        {
            for (int i = 0; i < FileOpend.AllFilesList.Count; i++)
            {
                if (!FileOpend.AllFilesList[i].DisplayName.EndsWith("*"))
                    FileOpend.AllFilesList.Remove(FileOpend.AllFilesList[i]);
            }
        }
        public void CloseAllButThis(FileObject file)
        {
            for (int i = 0; i < FileOpend.AllFilesList.Count; i++)
            {
                if (FileOpend.AllFilesList[i] != file)
                    FileOpend.AllFilesList.Remove(FileOpend.AllFilesList[i]);
            }
        }
        public async void CloseAllFiles()
        {
            bool CanClose = true;

            for (int i = 0; i < FileOpend.AllFilesList.Count; i++)
            {
                if (FileOpend.AllFilesList[i].DisplayName.EndsWith("*"))
                    CanClose = false;
            }

            if (CanClose)
                _CloseAllFiles();
            else
            {
                MessageDialog xMenssageDialog = new MessageDialog("There is unsaved files, are you sure you want to close all of them?", "Unsaved files");

                xMenssageDialog.Commands.Clear();
                xMenssageDialog.Commands.Add(new UICommand { Label = "Save all and close", Id = 0 });
                xMenssageDialog.Commands.Add(new UICommand { Label = "Close, don't save", Id = 1 });
                xMenssageDialog.Commands.Add(new UICommand { Label = "Cancel", Id = 2 });
                var xMenssageDialogAnswer = await xMenssageDialog.ShowAsync();

                switch ((int)xMenssageDialogAnswer.Id)
                {
                    case 0:
                        SaveAllFiles();
                        _CloseAllFiles();
                        break;
                    case 1:
                        _CloseAllFiles();
                        break;
                }
            }
        }
        #endregion

        #region OPENFILE
        private int OpenFile(StorageFile file)
        {
            FileObject FileToBeOpened = new FileObject();

            if (file != null)
            {
                FileToBeOpened = StorageFileToFileObj(file);
                FileOpend.AllFilesList.Add(FileToBeOpened);
                RecentListViewModel.Add(file);
            }

            return FileOpend.AllFilesList.IndexOf(FileToBeOpened);
        }
        public async Task<int> OpenFile()
        {
            FileOpenPicker openFilePicker = new FileOpenPicker()
            {
                ViewMode = PickerViewMode.List
            };
            
            foreach (string language in LanguageDataSource.GetAllExtentions())
                openFilePicker.FileTypeFilter.Add(language);

            StorageFile xStoragedFile = await openFilePicker.PickSingleFileAsync();

            return OpenFile(xStoragedFile);
        }
        public async Task<int> OpenFile(string token)
        {
            StorageFile xStoragedFile = await RecentListViewModel.mru.GetFileAsync(token);
            return OpenFile(xStoragedFile);
        }
        public async Task<string> ReadContent(FileObject xFile)
        {
            FileObject FileToWorkWith = FileOpend.AllFilesList[FileOpend.AllFilesList.IndexOf(xFile)];

            if (FileToWorkWith.ContentWithoutSaving == null)
            {
                string tosend = "";
                var randomAcessStream = await FileToWorkWith.File.OpenReadAsync();
                Stream stream = randomAcessStream.AsStreamForRead();
                using (StreamReader inputStream = new StreamReader(stream, Encoding.UTF8))
                {
                    xFile.TextEncoding = await GetEncoding(xFile.File);
                    while (inputStream.Peek() >= 0)
                    {
                        tosend += inputStream.ReadLine() + Environment.NewLine;// + "<hydra986huykkvtn>";
                    }
                }
                return tosend;
            }
            else
                return FileToWorkWith.ContentWithoutSaving.Replace("<newlineformula>", Environment.NewLine);
        }
        public static FileObject StorageFileToFileObj(StorageFile xStorageFile)
        {
            FileObject file = new FileObject()
            {
                File = xStorageFile,
                ContentWithoutSaving = null,
                DisplayName = xStorageFile.Name,
                FileName = xStorageFile.DisplayName,
                FileType = xStorageFile.FileType,
                FileLanguage = LanguageSupport.LanguageSupport.WhatLanguageItIs(xStorageFile.Name),
            };
            return file;
        }
        public async Task<Encoding> GetEncoding(StorageFile storagefile)
        {
            var randomAcessStream = await storagefile.OpenReadAsync();
            Stream stream = randomAcessStream.AsStreamForRead();

            var bom = new char[4];
            using (StreamReader inputStream = new StreamReader(stream, Encoding.UTF8, true))
            {
                inputStream.Peek();
                return inputStream.CurrentEncoding;
            }

            //// Analyze the BOM
            //if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            //if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            //if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            //if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            //if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            //return Encoding.ASCII;
        }
        #endregion
    }
}
