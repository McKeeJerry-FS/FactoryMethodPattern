using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Interfaces;


namespace FactoryMethodPattern.Factories
{
    public abstract class AnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("AnimalFactory.MakeAnimal() - You cannot ignore parent rules.");
            IAnimal animal = CreateAnimal();
            animal.AboutMe();
            return animal;
        }
        public abstract IAnimal CreateAnimal();
    }
}
