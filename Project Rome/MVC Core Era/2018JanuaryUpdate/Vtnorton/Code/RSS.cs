using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
                var responseString = await responseMessage.Content.ReadAsStringAsync();

                XDocument doc = XDocument.Parse(responseString);
                var feedItems = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                                select new FeedItem
                                {
                                    Content = item.Elements().First(i => i.Name.LocalName == "description").Value.GetBetween(" />", "[&#8230;]") + " [...]", //.Replace("[&#8230;]", "[...]")
                                    Link = item.Elements().First(i => i.Name.LocalName == "link").Value,
                                    Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                    ImageURL = item.Elements().First(i => i.Name.LocalName == "description").Value.GetBetween("<img width=\"296\" height=\"210\" src=\"", "?resize=296%2C210")
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
}
