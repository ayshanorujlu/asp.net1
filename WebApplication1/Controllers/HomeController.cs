using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "1. Drinks\n\n2. Fastfoods\n\n3. Hot Meals";
        }

        public ViewResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Fanta",
                    Price=1.1
                },
                new Drink
                {
                    Id=2,
                    Name="Sirab",
                    Price=0.8
                },
                new Drink
                {
                    Id=3,
                    Name="Cappy",
                    Price=2.2
                },
                new Drink
                {
                    Id=4,
                    Name="RedBull",
                    Price=4.6
                }
               
            };
            var viewModel = new DrinkListViewModel
            {
                Drinks = drinks,
            };

            return View(viewModel);
        }

        public ViewResult FastFoods()
        {
            List<Fastfood> fastfoods = new List<Fastfood>
            {
                new Fastfood
                {
                    Id=1,
                    Name="Twister",
                    Rating=3.9,
                    Price=6.7
                },
                 new Fastfood
                {
                    Id=2,
                    Name="Burger",
                    Rating=4.5,
                    Price=8.5
                },
                new Fastfood
                {
                    Id=3,
                    Name="Doner",
                    Rating=4.8,
                    Price=6
                },
                new Fastfood
                {
                    Id=4,
                    Name="Shaurma",
                    Rating=5,
                    Price=5.2
                }
            };
            var viewModel1 = new FastfoodListViewModel
            {
                FastFoods = fastfoods
            };
            return View(viewModel1);
        }


        public ViewResult HotMeals()
        {
            List<Hotmeal> hotmeals = new List<Hotmeal>
            {
                new Hotmeal
                {
                    Id=1,
                    Name="Tomato Soup",
                    Rating=2.9,
                    Price=3.9
                },
                 new Hotmeal
                {
                    Id=2,
                    Name="Dolma",
                    Rating=4.5,
                    Price=15
                },
                new Hotmeal
                {
                    Id=3,
                    Name="Plov",
                    Rating=3.7,
                    Price=13.9
                }
                  
            };
            var viewModel2 = new HotMealsListViewModel
            {
                HotMeals = hotmeals
            };
            return View(viewModel2);
        }

    



}
}
