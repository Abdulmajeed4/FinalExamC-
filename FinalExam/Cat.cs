
public class Cat : Animal
{
    public Cat(string Name, int Health) : base(Name, Health)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("The cat meows softly!");
    }

    public override void TakeDamage(int damage)
    {
        int Half50 =damage / 2;
        base.TakeDamage(Half50);   
    }

}
