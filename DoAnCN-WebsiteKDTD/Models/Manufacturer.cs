using System;
using System.Collections.Generic;

namespace DoAnCN_WebsiteKDTD.Models;

public partial class Manufacturer
{
    public long ManufacturerId { get; set; }

    public string ManufacturerName { get; set; } = null!;

    public string? ContactInfo { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
