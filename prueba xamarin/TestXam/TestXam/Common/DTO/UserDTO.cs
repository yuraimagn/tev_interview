using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestXam.Common.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public UserDTO()
        {
            if(Application.Current.Properties.ContainsKey("email"))
            {
                var val = Application.Current.Properties["email"];
                if(val != null)
                {
                    Email = val.ToString();
                }
            }
            if (Application.Current.Properties.ContainsKey("name"))
            {
                var val = Application.Current.Properties["name"];
                if(val != null)
                {
                    Name = val.ToString();
                }
            }

        }
    }
}
