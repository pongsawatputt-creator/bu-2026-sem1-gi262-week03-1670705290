using UnityEngine;

namespace Assignment.StudentSolution.LCT05
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Woof!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
    }

    public class LCT05VirtualOverride
    {
        public void Start()
        {
            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Animal animal = new Animal();
            animal.MakeSound();
        }
    }
}