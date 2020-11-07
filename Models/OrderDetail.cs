using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualLabAssignment.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string Username { get; set; }
        public string Carname { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double? UnitPrice { get; set; }

        public double? OrderTotal { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}