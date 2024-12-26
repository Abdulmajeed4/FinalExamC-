public class Program{
    public static void Main(string[] args){

        Animal[] animalArray = new Animal[3];

        Dog dog1 = new Dog("Dogy",100);
        Cat cat1 = new Cat("caty",100);
        Bird bird1 = new Bird("Birdy", 100);

        animalArray[0] = dog1;
        animalArray[1] = cat1;
        animalArray[2] = bird1;

        for(int i = 0; i< animalArray.Length; i++){
            animalArray[i].MakeSound();
        }

        dog1.TakeDamage(44);
        cat1.TakeDamage(50);
        bird1.TakeDamage(24);

        Console.WriteLine("Total animals created: " + Animal.TotalAnimals);

    }
}