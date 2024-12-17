using System;
using System.Collections.Generic;

namespace LW_3.Models;

public partial class Post
{
    public int Id { get; set; }

    public int IdOfUser { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateOnly DateOfPublication { get; set; }

    public virtual User IdOfUserNavigation { get; set; } = null!;
}
