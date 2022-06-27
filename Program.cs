using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Factories;

namespace FactoryMethodPattern
{
    #region Animal Hierarchy
    /*
    Both the Dog and Tiger classes will 
    implement the IAnimal Interface
    */
    
    //public interface IAnimal
    //{
    //    void AboutMe();
    //}

    //public class Dog : IAnimal
    //{
    //    public void AboutMe()
    //    {
    //        Console.WriteLine("The dog says, \"Bow-wow. I prefer barking.\"");
    //    }
    //}

    //public class Tiger : IAnimal
    //{
    //    public void AboutMe()
    //    {
    //        Console.WriteLine("The tiger says, \"Halum. I prefer hunting.\"");
    //    }
    //}

    // All files pertaining to the Interface are now in a folder labeled
    // Interfaces. This is the set up for separating dependencies

    #endregion


    #region Factory Hierarchy
    //public abstract class AnimalFactory
    //{
    //    public abstract IAnimal CreateAnimal();
    //}

    //public class DogFactory : AnimalFactory
    //{
    //    public override IAnimal CreateAnimal()
    //    {
    //        // Creating a Dog Object
    //        return new Dog();
    //    }
    //}

    //public class TigerFactory : AnimalFactory
    //{
    //    public override IAnimal CreateAnimal()
    //    {
    //        return new Tiger();
    //    }
    //}

    // All files pertaining to the Factories are now in 
    // a folder labeled "Factories". 
    #endregion

    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Factory Pattern Demo ***");
            // Creating the Tiger Factory
            AnimalFactory tigerFactory = new TigerFactory();
            // Creating the tiger using the Tiger Factory
            //IAnimal tiger = tigerFactory.CreateAnimal();
            //tiger.AboutMe();
            IAnimal tiger = tigerFactory.MakeAnimal();

            AnimalFactory dogFactory = new DogFactory();
            //IAnimal dog = dogFactory.CreateAnimal();
            //dog.AboutMe();
            IAnimal dog = dogFactory.MakeAnimal();  

            Console.ReadKey();
        }
    }

}