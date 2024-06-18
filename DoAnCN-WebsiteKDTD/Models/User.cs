using System;
using System.Collections.Generic;

namespace DoAnCN_WebsiteKDTD.Models;

public partial class User
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Role { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
