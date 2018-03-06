﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Cow("Rual"));
            farm.Animals.Add(new Chicken("Donna"));
            farm.Animals.Add(new Chicken("Mary"));
            farm.Animals.Add(new SupperCow("Ben"));
            farm.MakeNoises();
            Farm<Cow> dairyFarm = farm.GetCows();
            dairyFarm.FeedTheAnimals();
            foreach (Cow cow in dairyFarm)
            {
                if(cow is SupperCow)
                {
                    (cow as SupperCow).Fly();
                }
            }
            Console.ReadKey();
        }
    }
}
