﻿using System;
using System.Collections.Generic;

namespace EF_Core_02._Database_First_Sacaffolding;

public partial class Faculty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
