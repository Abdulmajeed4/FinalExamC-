
    public class Bird : Animal
    {
    public Bird(string Name, int Health) : base(Name, Health)
    {
    }

    public bool InCage {get; set;}

    public Bird(bool InCage) : base("",0){
        this.InCage = InCage;
    }

    public override void MakeSound()
    {
        Console.WriteLine("The bird chirps melodiously!");
    }

    public void IsHeInCage(){
        if(InCage == true){
            Console.Write("He has in Cage");
        }
        else{
            Console.Write("He not in the Cage");
        }
    }
    
    }