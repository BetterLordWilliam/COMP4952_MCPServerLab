using System;
using System.ComponentModel;

namespace StudentMcpServer.Models;

public class Student
{
    public int StudentId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? School { get; set; }

    public override string ToString()
    {
        return $"{StudentId}, {FirstName}, {LastName}, {School}";
    }
}
