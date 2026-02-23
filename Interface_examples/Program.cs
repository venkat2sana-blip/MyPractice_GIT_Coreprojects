// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
       Productservices pobj = new Productservices();
       Console.WriteLine(pobj.Productdetails() + ' '+ pobj.Getallproducts());

        Animal myanimal =new Dog();
        myanimal.display();
        myanimal.animalsound();
    }
}

public interface Iproductservices
{
    string Productdetails();
    string Getallproducts();
}
public class Productservices:Iproductservices
{
    public string Productdetails()
    {
        return "welcome to interfaces";
    }
    public string Getallproducts()
    {
        return "List of all products";
    }

}

// abstraction class implementation

abstract class Animal
{
    public abstract void animalsound();

    public void display()
    {
        Console.WriteLine("Abstract class in general method");
    }
}

//Abstract method - must be implemented by derived classes
//// Concrete method - shared behavior
class Dog : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("Animal sounds are very bad");
    }
}





