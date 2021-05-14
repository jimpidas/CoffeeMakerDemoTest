﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMakerDemo
{
    public class StarbuckStor
    {

        private readonly IMakeACoffee service;


        //readonly const

        public StarbuckStor(IMakeACoffee service)
        {
            this.service = service;
        }

        public string OrderCoffee(int sugarPerSpoon, int coffeeCount)
        {
            if (service.CheckIngredientAvailability())
            {
                return service.CoffeeMaking(sugarPerSpoon, coffeeCount);
            }
            else
            {
                return "Sorry! Coffee is not available.";
            }

        }
    }
}