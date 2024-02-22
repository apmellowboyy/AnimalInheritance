// base Class 
using System.Security.Cryptography.X509Certificates;

class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}
class Chincilla : Animal
{
    public int age;
    public int age2;
    public int size;
    

    public void setAge(int age)
    {
        this.age = age;
    }
    public void setAge2(int age2)
    {
        this.age2 = age2;
    }
    public virtual int getAge()
    {
        return this.age;
    }
    public virtual int getAge2()
    {
        return this.age2;
    }
    public override string getName()
    {
        return base.getName();
    }
    public override string getType()
    {
        return base.getType();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal Homie = new Animal();
        Homie.setName("Lil Bruddah");
        Homie.setType("Chinchilla");
        Homie.color = "Black";

        Console.WriteLine("CHINCHILLA's FOR SALE...");
        Console.WriteLine();
        Console.WriteLine($"My name is {Homie.getName()}");
        Console.WriteLine($"I am a {Homie.getType()}");
        Console.WriteLine($"I'm a cool shade of {Homie.color}");


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Chincilla hadToChange = new Chincilla();
        hadToChange.setName("Chonky Bloak");
        hadToChange.setType("Chinchilla");
        hadToChange.color = "Beige";
        hadToChange.setAge(1000);
        hadToChange.setAge2(3);
   

        Console.WriteLine("Information On CHONKY BLOAK");
        Console.WriteLine();
        Console.WriteLine($"My name is {hadToChange.getName()}.");
        Console.WriteLine($"I am a {hadToChange.getType()}.");
        Console.WriteLine($"Can't you see I'm {hadToChange.color}.");
        Console.WriteLine($"I am {hadToChange.getAge()} year's old. HAHA I'm kidding I'm actually {hadToChange.getAge2()} year's old.");
    }
}
