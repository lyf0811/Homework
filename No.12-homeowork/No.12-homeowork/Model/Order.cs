using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace No._12_homeowork.Model
{
    public class Order
    {
        [Key]
        public string ordernum { get; set; }
        public string orderamount{ get; set; }
        public string goodsname { get; set; }
        public string customer { get; set; }

        public List<Orderitem> orderitem { get; set; }

    }
}
