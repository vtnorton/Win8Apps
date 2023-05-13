using System;

namespace ProjectCachoeiro.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public ErrorViewModel()
        {
            ApplicationUser x = new ApplicationUser();
            
        }
    }
}