using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DTO;
using System.Net;

namespace DAO
{
    public class PhotoDAO
    {
        public List<PhotoDTO> getDataPhoto(int id)
        {
            List<PhotoDTO> objListPhoto = new List<PhotoDTO>();
            WebClient c = new WebClient();
            String tmp = c.DownloadString("https://jsonplaceholder.typicode.com/photos");
            objListPhoto = JsonConvert.DeserializeObject<List<PhotoDTO>>(tmp);
            
            return objListPhoto.Where(x => x.albumId == id).ToList();
        }

    }
}
