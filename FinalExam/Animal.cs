
    public class Animal
    {
        
        public string Name {get; set;}
        private int Health {get; set;}

        public static int TotalAnimals;

        public Animal(string Name, int Health){
            this.Name = Name;
            this.Health = Health;
            TotalAnimals++;
            
        }

        public virtual void MakeSound(){
            Console.WriteLine("Animal makes a sound!");
        }

        public virtual void TakeDamage(int damage){
            Health -= damage;
            Console.WriteLine($"{Name} Health: " + Health);
        }

        public int GetHealth(){
            return Health;
        }
    }
