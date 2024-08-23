﻿namespace EF_Core_01._Configuration_file;
internal class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName}";
    }
}