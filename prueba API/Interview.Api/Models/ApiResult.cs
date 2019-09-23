using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.Api.Models
{
    public class ApiResult
    {
        public int CodeMsg { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
        public Object data { get; set; }
    }
}