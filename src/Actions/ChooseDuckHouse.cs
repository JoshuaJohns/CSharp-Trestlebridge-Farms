using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IGrazing duck)
        {
            Utils.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House");
            }


            Console.WriteLine();

            // How can I output the type of duck chosen here?
            Console.WriteLine($"Place the {duck.ToString()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.DuckHouses[choice - 1].AddResource(duck);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IPlowing>(duck, choice);

        }
    }
}