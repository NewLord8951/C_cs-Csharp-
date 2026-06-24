using System;

class Animal
{
    public virtual void Speak() {}
}

class Dog : Animal
{
    public override void Speak()
    {
        base.Speak();
        Console.WriteLine("Гав");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Speak(); 
    }
}