using System;
using System.Collections.Generic;
using System.Text;

namespace TestXam.Common.DTO
{
    public class PaisDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<string> Pictures { get; set; }
    }
}
