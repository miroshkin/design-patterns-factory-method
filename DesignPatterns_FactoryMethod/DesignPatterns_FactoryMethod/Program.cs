using System;

namespace DesignPatterns_FactoryMethod
{
    class Program
    {
        //original source https://metanit.com/sharp/patterns/2.1.php
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns - Factory Method!");

            Developer panelDeveloper = new PanelDeveloper("Enjoy concrete company");
            House houseOne = panelDeveloper.Build();

            Developer woodDeveloper = new WoodDeveloper("Pinocchio buildings company");
            House houseTwo = woodDeveloper.Build();
        }
    }

    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        abstract public House Build();
    }

    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {

        }

        public override House Build()
        {
            return new PanelHouse();
        }
    }

    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {

        }

        public override House Build()
        {
            return new WoodenHouse();
        }
    }

    abstract class House
    {

    }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house is built");
        }
    }

    class WoodenHouse : House
    {
        public WoodenHouse()
        {
            Console.WriteLine("Wooden house is built");
        }
    }
}
