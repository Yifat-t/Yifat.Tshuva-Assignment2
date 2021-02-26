using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat.Tshuva_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// by throwing 2 dice , one after another, the method calculate the number of ways we can get the sum of 10. </summary> 
        /// <param name="m">one dice has m sides</param>
        /// <param name="n">second dice has m sides</param>
        /// <example>Get api/J2/DiceGame/5/4" --> "There are 0 total ways to get the sum 10"</example>
        /// <example>Get api/J2/DiceGame/5/6" --> "There are 2 total ways to get the sum 10."</example>
        /// <returns>number of ways the sum of 10 can be recived.</returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string rollDice(int m, int n)
        {
            var count = 0;
            for (var i=1; i<=m; i++)
            {
                for (var j=1; j<=n; j++)
                {
                    if((i+j)==10)
                    {
                        count = count + 1;
                    }
                }

            }           

            string message = "There are " + count + " total ways to get the sum 10.";
            return message;
        }
    }
}
