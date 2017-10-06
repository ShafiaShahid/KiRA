using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiRA.Models
{
    public class User
    {

        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime created_at { get; set; }
        public int? role_id { get; set; }
        public bool enabled  { get; set;  }
        public string username { get; set; }
        public string password { get; set; }
    }
}
