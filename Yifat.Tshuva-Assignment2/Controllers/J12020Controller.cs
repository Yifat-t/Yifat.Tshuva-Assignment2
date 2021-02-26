using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat.Tshuva_Assignment2.Controllers
{
    public class J12020Controller : ApiController
    {
        /// <summary>
        /// recive number of differant treats the dog received and return a 
        /// message indicating it's sutisfaction.
        /// </summary>
        /// <param name="small">small is the size of the small treat, it's weight 1 point</param>
        /// <param name="medium">medium is the size of the medium treat, it's weight 2 point</param>
        /// <param name="large">large is the size of the large treat, it's weight 3 point</param>
        /// <example>GET api/J1/Treats/3/3/3 -- small (3 *1) + medium (3 *2) + large (3 * 3) =18 -- "Happy"</example>
        /// <examle>GET api/J1/Treats/1/1/1 -- small (1 *1) + medium (1 *2) + large (1 * 3) =6 -- "Sad" </examle>
        /// <returns>if the dog feels happy or sad</returns>

        [HttpGet]
        [Route("api/J1/Treats/{small}/{medium}/{large}")]

        public string DogTreats(int small , int medium , int large)
        {
            
            if ((small) + (medium * 2) + (large * 3) >= 10)
            {
                return  "happy";
            } 
            
            else
            {
                return "sad";
            }
        }
    }
}
    