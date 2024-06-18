using System;
using System.Collections.Generic;

namespace DoAnCN_WebsiteKDTD.Models;

public partial class Contact
{
    public long ContactId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateTime? ContactDate { get; set; }
}
