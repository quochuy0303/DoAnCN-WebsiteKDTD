using System;
using System.Collections.Generic;

namespace DoAnCN_WebsiteKDTD.Models;

public partial class Brand
{
    public long BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
