using System;

class Person
{
    protected string name;
    protected Person(string name)
    {
        this.name = name;
    }
    public virtual void introduce()
    {
        Console.Write("Меня зовут " + name);
    }
}

class Student : Person
{
    private string guard;
    public Student(string name, string guard) : base(name)
    {
        this.guard = guard;
    }
    public override void introduce()
    {
        Console.Write("Меня зовут " + name + ", я учусь в " + guard + " классе");
    }
}

class Program
{
    static void Main()
    {
        Student a = new Student("Леонид", "-1");
        a.introduce();
    }
}