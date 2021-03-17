using Farm.Animals;

namespace Farm
{
    public class StartUp
    {
        public static void Main()
        {
            Dog dog = new Dog();

            dog.Eat();
            dog.Bark();
        }
    }
}
