﻿using System;

namespace Farm
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();

            Cat cat = new Cat();
            cat.Meow();
            cat.Eat();
        }
    }
}