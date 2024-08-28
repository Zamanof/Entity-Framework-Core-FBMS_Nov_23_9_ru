﻿using System;
using System.Collections.Generic;

namespace EF_Core_03._LINQ_For_Entity;

public partial class Theme
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
