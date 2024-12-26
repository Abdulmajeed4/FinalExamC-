
public class Dog : Animal
{
    public Dog(string Name, int Health) : base(Name, Health)
    {
    }

    public bool HasLeash {get; set;}

    public Dog(bool HasLeash) : base("",0){
        this.HasLeash = HasLeash;
    }

    public override void MakeSound()
    {
        Console.WriteLine("The dog barks loudly!");
    }

    public void HasTheLeah(){
        if(HasLeash == true){
            Console.Write("He has the Leash");
        }
        else{
            Console.Write("He do not have the Leash");
        }
        
    }

}
