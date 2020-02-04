using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
  public  class PhotoAlbum
    {
        public string id { get; set; }
        public string alt_description { get; set; }
      public Dictionary<string,string> urls { get; set; } = new Dictionary<string, string>();
      public int likes { get; set; }
      
        
    }
}
