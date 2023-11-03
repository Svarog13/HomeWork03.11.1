using System;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("Mammal", "Generic Animal", 5, 50.0f);
        animal.ShowInfo();
        System.Console.WriteLine();

        Tiger tiger = new Tiger("Mammal", "Tiger", 8, 250.0f);
        tiger.ShowInfo();
        System.Console.WriteLine();

        Kangaroo kangaroo = new Kangaroo("Mammal", "Kangaroo", 6, 100.0f);
        kangaroo.ShowInfo();
        System.Console.WriteLine();

        Crocodile crocodile = new Crocodile("Reptile", "Crocodile", 10, 300.0f);
        crocodile.ShowInfo();
        System.Console.WriteLine();
    }
}

class Animal
{
    private string animalClass;
    private string name;
    private int age;
    private float weight;

    public Animal(string animalClass, string name, int age, float weight)
    {
        this.animalClass = animalClass;
        this.name = name;
        this.age = age;
        this.weight = weight;
    }

    public Animal()
    {
        this.animalClass = "No class";
        this.name = "No name";
        this.age = 0;
        this.weight = 0;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"An animal has class: {animalClass}");
        Console.WriteLine($"An animal has name: {name}");
        Console.WriteLine($"An animal has age: {age}");
        Console.WriteLine($"An animal has weight: {weight}");
    }
}

class Tiger : Animal
{
    public Tiger(string animalClass, string name, int age, float weight) : base(animalClass, name, age, weight) { }
}

class Kangaroo : Animal
{
    public Kangaroo(string animalClass, string name, int age, float weight) : base(animalClass, name, age, weight) { }
}

class Crocodile : Animal
{
    public Crocodile(string animalClass, string name, int age, float weight) : base(animalClass, name, age, weight) { }
}