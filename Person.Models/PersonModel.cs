using System;

namespace Person.Models
{
    public class PersonModel
    {
        public class request : BaseRequestModel //istek parametreler
        {
            public string UserName { get; set; }
            public string Password { get; set; }  

        }

        public class Return : BaseResponseModel //cevap
        {
            public ReturnData data { get; set; }
        }
        public class ReturnData 
        {
            public string UserName { get; set; }
            public string Password { get; set; }

        }
    }
}
