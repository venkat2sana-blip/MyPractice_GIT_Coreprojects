// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
       Productservices pobj = new Productservices();
       Console.WriteLine(pobj.Productdetails() + ' '+ pobj.Getallproducts());
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



