using System;
using System.Collections.Generic;
using System.Text;

namespace TestXam.Common.DTO
{
    public class PhotoData
    {
        public string id { get; set; }
        public string description { get; set; }
        public string alt_description { get; set; }
        public UrlImage urls { get; set; }
    }
}
