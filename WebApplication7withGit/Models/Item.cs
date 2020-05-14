using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7withGit.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int ItemNo { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }

        public Origin Origin { get; set; }
        public int OriginId { get; set; }

    }
}