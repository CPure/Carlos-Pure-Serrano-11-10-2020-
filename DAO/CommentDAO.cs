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
    public class CommentDAO
    {
        public List<CommentDTO> getDataComment(int id)
        {
            List<CommentDTO> objListComment = new List<CommentDTO>();
            WebClient c = new WebClient();
            String tmp = c.DownloadString("https://jsonplaceholder.typicode.com/comments");
            objListComment = JsonConvert.DeserializeObject<List<CommentDTO>>(tmp);

            return objListComment.Where(x => x.postId == id).ToList();
        }
    }
}
