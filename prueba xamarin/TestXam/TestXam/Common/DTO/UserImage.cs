using System;

namespace TestXam.Common.DTO
{
    public class UserImage
    {
        public string id { get; set; }
        public DateTime? updated_at { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string twitter_username { get; set; }
        public string portfolio_url { get; set; }
        public string bio { get; set; }
        public string location { get; set; }
    }
}