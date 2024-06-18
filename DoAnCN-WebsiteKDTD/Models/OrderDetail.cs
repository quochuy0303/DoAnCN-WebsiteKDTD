using System;
using System.Collections.Generic;

namespace DoAnCN_WebsiteKDTD.Models;

public partial class OrderDetail
{
    public long OrderDetailsId { get; set; }

    public long? OrderId { get; set; }

    public long? ProductId { get; set; }

    public long? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
