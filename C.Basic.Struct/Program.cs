namespace C.Basic.Struct;

using System;

struct Person
{
    public string Name;
    public string Gender;
    public uint Age;
}

enum Direction
{
    North,
    East,
    South,
    West
}

class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person();
        tom.Name = "Tom";
        tom.Gender = "Male";
        tom.Age = 20;
        Console.WriteLine(
            $"The person's name is {tom.Name}, and the gender is {tom.Gender}, and the age is {tom.Age}."
            + $"The person is facing {Direction.North}."
        );
    }
}