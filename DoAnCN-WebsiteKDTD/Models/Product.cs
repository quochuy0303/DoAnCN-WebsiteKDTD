using System;
using System.Collections.Generic;

namespace DoAnCN_WebsiteKDTD.Models;

public partial class Product
{
    public long ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public long? CategoryId { get; set; }

    public long? ManufacturerId { get; set; }

    public long? BrandId { get; set; }

    public decimal? Price { get; set; }

    public long? Quantity { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
