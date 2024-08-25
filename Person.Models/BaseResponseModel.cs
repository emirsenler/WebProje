using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Person.Models
{
    public class BaseResponseModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool status { get; set; }
        public string ResponseMessage { get; set; }
        public string ErrorCode { get; set; }
    }
}
