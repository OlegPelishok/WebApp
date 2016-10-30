using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkForAll.Models
{
    public class Order
    {
        public int order_id { get; set; }
        public int client_id { get; set; }
        public int master_service { get; set; }
        public System.DateTime date { get; set; }
        public Order(int order_id, int client_id, int master_service, System.DateTime date)
        {
            this.order_id = order_id;
            this.client_id = client_id;
            this.master_service = master_service;
            this.date = date;
        }

    }
}