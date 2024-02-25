using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
        public class MenuController : ApiController
        {

            /// <summary>
            /// Calculates the total calories of a meal based on the user's choices of burger, drink, side, and dessert.
            /// </summary>
            /// <param name="burger">Integer representing the index burger choice</param>
            /// <param name="drink">Integer representing the index drink choice</param>
            /// <param name="side">Integer representing the index side choice</param>
            /// <param name="dessert">Integer representing the index dessert choice</param>
            /// <returns>A string message representing the total calorie count of the meal.</returns>
            /// <example>GET /api/J1/Menu/4/4/4/4 => Your total calorie count is 0 </example>
            /// <example>GET /api/J1/Menu/1/2/3/4 => Your total calorie count is 691 </example>
            // GET: /api/J1/Menu/{burger}/{drink}/{side}/{dessert}
            [HttpGet]
            [Route("/api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
            public string TotalCalories(int burger, int drink, int side, int dessert)
            {
                // All food calory count, incrementing way
                int[] burgerCalories = { 461, 431, 420, 0 };
                int[] drinkCalories = { 130, 160, 118, 0 };
                int[] sideCalories = { 100, 57, 70, 0 };
                int[] dessertCalories = { 167, 266, 75, 0 };

                int CalculateTotalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];

                return "Your total calorie count is " + CalculateTotalCalories;
            }
        }
}
