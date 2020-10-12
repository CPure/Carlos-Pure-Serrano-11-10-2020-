using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DTO;

namespace DAO
{
    public class AlbumDAO
    {
        public List<AlbumDTO> getDataAlbum()
        {
            List<AlbumDTO> objListAlbum = new List<AlbumDTO>();
            WebClient c = new WebClient();
            String tmp = c.DownloadString("https://jsonplaceholder.typicode.com/albums");
            objListAlbum = JsonConvert.DeserializeObject<List<AlbumDTO>>(tmp);

            return objListAlbum;
        }


    }
}
