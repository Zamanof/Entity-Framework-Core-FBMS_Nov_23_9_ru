﻿namespace EF_Core_04._Code_First._Many_To_Many;

internal class SocialNetwork
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<User> Users { get; set; } = [];
    public override string ToString()
    {
        return Name;
    }
}
