using System.Data;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;

namespace vtnCore.Methods
{
    public class GetRSS
    {
        public static DataTable Get(string RSS, int Items)
        {
            XmlReader reader = XmlReader.Create(RSS);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            DataTable tbl = new DataTable();
            tbl.Columns.Add("Title");
            tbl.Columns.Add("Link");
            tbl.Columns.Add("Description");
            tbl.Columns.Add("Image");
            
            foreach (SyndicationItem item in feed.Items)
            {
                DataRow row = tbl.NewRow();
                row["Title"] = item.Title.Text;
                row["Link"] = item.Links[0].Uri.ToString();
                row["Description"] = item.Summary.Text.Trim();
                if (item.ElementExtensions.Where(p => p.OuterName == "thumbnail").Count() != 0)
                {
                    row["Image"] = item.ElementExtensions.Where(p => p.OuterName == "thumbnail").First().GetObject<XElement>().Attribute("url").Value;
                }
                tbl.Rows.Add(row);
            }
            return tbl.AsEnumerable().Take(Items).CopyToDataTable();
        }
    }
}