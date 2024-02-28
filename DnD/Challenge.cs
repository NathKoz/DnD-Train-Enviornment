#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;

class Challenge
{
    public string Name { get; set; }
    public string Answer { get; set; }
    public bool Completed { get; set; }

    public Challenge(string name, string answer)
    {
        Name = name;
        Answer = answer;
        Completed = false;
    }
}