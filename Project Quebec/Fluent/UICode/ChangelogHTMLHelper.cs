using ProjectQuebec.Code.Model;
using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;

namespace ProjectQuebec.Fluent.UICode
{
    public class ChangelogHTMLHelper
    {
        public async static Task<string> ChangelogHTML(ChangelogModel changes)
        {
            string xTheme = "";

            if (App.Current.RequestedTheme == ApplicationTheme.Dark)
                xTheme = "<link href='ms-appx-web:///Data/Changelog/css/heartthrob.dark.css' rel='stylesheet' type='text/css'/>";


            return @"<!DOCTYPE html><html style='height:100%'>
                <head>
                    <meta charset='UTF-8'>
                    <link href='ms-appx-web:///Data/Changelog/css/heartthrob.css' rel='stylesheet' type='text/css'/> " + xTheme + @"
                    <meta name='viewport' content='width=device-width, initial-scale=1'>
                </head>
                <body style='height:100%; padding:0; margin:0;'>
                    <div class='section-wrapper'>
                        " + await ReadContent(changes) + @"
                    </div>
                </body>
            </html>";
        }
        public async static Task<string> ReadContent(ChangelogModel changes)
        {
            string tosend = "";
            string path = @"ms-appx:///Data/Changelog/" + changes.VersionName + ".html";
            
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(path));
            var randomAcessStream = await file.OpenReadAsync();
            Stream stream = randomAcessStream.AsStreamForRead();

            using (StreamReader inputStream = new StreamReader(stream))
            {
                while (inputStream.Peek() >= 0)
                {
                    tosend += inputStream.ReadLine();
                }
            }
            return tosend;
        }
    }
}
