﻿namespace EF_Core_07._Loadings._Lazy_loading;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    public int GroupId { get; set; } // Foreign Key

    public virtual Group Group { get; set; } // Navigation Property

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
