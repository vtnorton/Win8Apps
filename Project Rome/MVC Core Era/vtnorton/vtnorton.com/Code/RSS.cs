using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vtnorton.Model;

namespace Vtnorton.Code
{
    public class RSS
    {
        public async Task<List<FeedItem>> GetRSS(string feedUrl, int items)
        {
            List<FeedItem> articles = new List<FeedItem>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(feedUrl);
                var responseMessage = await client.GetAsync(feedUrl);
                var responseString = await responseMessage.Content.ReadAsStringAsync(Encoding.UTF8);

                XDocument doc = XDocument.Parse(responseString);

                doc.Declaration = new XDeclaration("1.0", "uft-8", null);

                var feedItems = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                                select new FeedItem
                                {
                                    Content = item.Elements().First(i => i.Name.LocalName == "description").Value.GetBetween(" />", "[&#8230;]") + " [...]", //.Replace("[&#8230;]", "[...]")
                                    Link = item.Elements().First(i => i.Name.LocalName == "link").Value,
                                    Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                    ImageURL = item.Elements().First(i => i.Name.LocalName == "description").Value.GetBetween("<img width=\"1920\" height=\"1080\" src=\"", "\"")
                                };
                
                var temp = feedItems.ToList();

                if(temp.Count >= items)
                    articles = temp.GetRange(0, items);
                else
                    articles = temp;
            }

            return articles;
        }
        
    }
    public static class RSSExtension
    {
        public static async Task<string> ReadAsStringAsync(this HttpContent content, Encoding encoding)
        {
            using (var reader = new StreamReader((await content.ReadAsStreamAsync()), encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
