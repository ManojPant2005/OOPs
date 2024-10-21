namespace OOPs
{
    //OOPs : Class | Object
    //Main Concept : Inheritance | Encapsulation | Abstraction | Polymorphism  
    //Inheritance :  Inheriting our parent class, we can able to access all properties and methods of that class.
    //benifit : Reusable code | time manage | reliability | easy modification | Faster development and testing|
    public class Inheritance : Program
    {
        public int Id { get; set; }

        static void Main(string[] args)
        {
            Program program = new Program();
            StartTwo start = new StartTwo();
            
            program.checkAge(12);

            program.Description = "Hie we are learning Inheritance in C#";

            Console.WriteLine(program.Description);

            program.AddTwoNumber(12, 56);
        }
        
    }
}

