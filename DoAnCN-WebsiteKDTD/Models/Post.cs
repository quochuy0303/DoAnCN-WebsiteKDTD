using System;
using System.Collections.Generic;

namespace DoAnCN_WebsiteKDTD.Models;

public partial class Post
{
    public long PostId { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public long? AuthorId { get; set; }

    public DateTime? PublishDate { get; set; }

    public virtual User? Author { get; set; }
}
