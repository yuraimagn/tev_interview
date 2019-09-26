using System;

namespace TestXam.Common.DTO
{
    public class ExifImage
    {
        public string make { get; set; }
        public string model { get; set; }
        public string exposure_time { get; set; }
        public string aperture { get; set; }
        public string focal_length { get; set; }
        public int? iso { get; set; }
    }
}