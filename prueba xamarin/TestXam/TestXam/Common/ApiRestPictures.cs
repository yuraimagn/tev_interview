using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using TestXam.Common.DTO;

namespace TestXam.Common
{
    public class ApiRestPictures
    {
        private const string Url = "https://api.unsplash.com/photos/random/?client_id=2d1357b440f43a18499ce6f530d979037e1e0c4f2bba4500243557986b84b09c";
        private readonly HttpClient client = new HttpClient();
        private List<PhotoData> _data;
        public ApiRestPictures()
        {
            _data = new List<PhotoData>();
            for (int i = 0; i < 2; i++)
            {
                var content = client.GetStringAsync(Url).GetAwaiter().GetResult();
                PhotoData photo = JsonConvert.DeserializeObject<PhotoData>(content);
                _data.Add(photo);
            }
        }

        public List<string> GetPhotos()
        {
            List<string> photos = new List<string>();
            List<PhotoData> aux = _data.GetRange(0, 2);
            foreach (PhotoData item in aux)
            {
                photos.Add(item.urls.regular);
            }
            return photos;
        }
    }
}
