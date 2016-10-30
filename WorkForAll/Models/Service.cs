using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkForAll.Models
{
    public class Service
    {
        public int service_id { get; set; }
        public int category_id { get; set; }
        public string service_name { get; set; }
        public Service(int service_id, int category_id, string service_name)
        {
            this.service_id = service_id;
            this.category_id = category_id;
            this.service_name = service_name;
        }
    }
}