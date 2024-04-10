using System;
using System.Collections.Generic;

abstract class Animal
{
    protected string name;

    public Animal(string Name)
    {
        name = Name;
    }

    public abstract void Talk();
    public virtual void PrintProperties()
    {
        Console.WriteLine("Имя: " + name);
    }
}

abstract class Ungulate : Animal
{
    public Ungulate(string Name) : base(Name) { }
    public abstract void EatGrass();
}

class Cow : Ungulate
{
    public Cow(string Name) : base(Name) { }

    public override void Talk()
    {
        Console.WriteLine("Муу-у-у!");
    }

    public override void EatGrass()
    {
        Console.WriteLine(name + " ест траву.");
    }
}

class Dog : Animal
{
    public Dog(string Name) : base(Name) { }

    public override void Talk()
    {
        Console.WriteLine("Вуф!");
    }
}
class Horse : Ungulate
{
    public Horse(string Name) : base(Name) { }

    public override void Talk()
    {
        Console.WriteLine("И-го-го!");
    }

    public override void EatGrass()
    {
        Console.WriteLine(name + " ест траву.");
    }
}
class Cat : Animal
{
    public Cat(string Name) : base(Name) { }

    public override void Talk()
    {
        Console.WriteLine("Мяу!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal> {
            new Cow("Бесси"),
            new Dog("Шарик"),
            new Horse("Спирит"),
            new Cat("Вискас")
        };

        foreach (var animal in animals)
        {
            animal.Talk();
            animal.PrintProperties();
            if (animal is Ungulate ungulate)
            {
                ungulate.EatGrass();
            }
            Console.WriteLine();
        }
    }
}