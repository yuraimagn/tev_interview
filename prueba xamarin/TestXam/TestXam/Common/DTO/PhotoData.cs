using System;
using System.Collections.Generic;
using System.Text;

namespace TestXam.Common.DTO
{
    public class PhotoData
    {
        public string id { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int width { get; set; }
        public int? height { get; set; }
        public string color { get; set; }
        public string description { get; set; }
        public string alt_description { get; set; }
        public UrlImage urls { get; set; }
        public LinkImage links { get; set; }
        public List<string> categories { get; set; }
        public int? likes { get; set; }
        public bool? liked_by_user { get; set; }
        public List<string> current_user_collections { get; set; }
        public UserImage user { get; set; }
        public ExifImage exif { get; set; }
        public LocationImage location { get; set; }
        public int? views { get; set; }
        public int? downloads { get; set; }
    }
}
