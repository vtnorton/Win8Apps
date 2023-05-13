using System;
using System.IO;
using System.Web;
using System.Web.Http;
using vtnServices.Code;
using vtnServices.Models;

namespace vtnServices.Controllers
{
    public class MailController : ApiController
    {
        //GET: api/Mail
        //[Route("post/{mail}")]
        //public string Get([FromBody] Emails email)
        //{
        //    return InsertMail.Insert(email);
        //}
        //public string Get(string id, string mail, string linkedin, string twitter, string face,
        //    string observation, string fist, string last)
        public string Get(string id, string mail)
        {
            using (StreamWriter _swWriter = new StreamWriter(HttpContext.Current.Server.MapPath(@"~/emails/onenote.txt"), true))
            {
                _swWriter.WriteLine("teste42");
                return "09de";
            }
            //if (mail.Contains("HAKUNAMATATA"))
            //    mail = mail.Replace("HAKUNAMATATA", ".");

            //if (observation.Contains("HAKUNAMATATA"))
            //    observation = observation.Replace("HAKUNAMATATA", ".");

            //if (linkedin.Contains("HAKUNAMATATA"))
            //    linkedin = linkedin.Replace("HAKUNAMATATA", ".");
            //if (twitter.Contains("HAKUNAMATATA"))
            //    twitter = twitter.Replace("HAKUNAMATATA", ".");
            //if (face.Contains("HAKUNAMATATA"))
            //    face = face.Replace("HAKUNAMATATA", ".");

            //Emails email = new Emails()
            //{
            //    Email = mail,
            //    LikedingProfile = linkedin,
            //    TwitterProfile = twitter,
            //    FacebookProfile = face,
            //    Observation = HttpUtility.UrlDecode(observation),
            //    FirstName = fist,
            //    LastName = last,
            //    ListID = int.Parse(id)
            //};

            //return InsertMail.Insert(email);
        }

        //public string Get(string id, string mail)
        //{
        //    if (mail.Contains("HAKUNAMATATA"))
        //        mail = mail.Replace("HAKUNAMATATA", ".");

        //    Emails email = new Emails()
        //    {
        //        Email = mail,
        //        ListID = int.Parse(id)
        //    };

        //    return InsertMail.Insert(email);
        //}

        //[HttpPost]
        //public void Post([FromBody]Emails email)
        //{
        //    using (StreamWriter _swWriter = new StreamWriter(HttpContext.Current.Server.MapPath(@"~/emails/onenote.txt"), true))
        //    {
        //        _swWriter.WriteLine("teste42");
        //    }
        //    //InsertMail.InsertPost(email);
        //}
    }
}
