using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhotoDTO
    {
        public int id { get; set; }
        public int albumId { get; set; }
        public String title { get; set; }
        public String url { get; set; }
        public String thumbnailUrl { get; set; }

    }
}
