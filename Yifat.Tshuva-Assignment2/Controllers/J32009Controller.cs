using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat.Tshuva_Assignment2.Controllers
{
    public class J32009Controller : ApiController
    {
        /// <summary>by  entering Ottawa specific time this method will calculate the time in other time zones. </summary>
        /// <param name="input">Ottawa time zone considered as the input.</param>
        /// <example>Get api/J32009/localTime/1300"  --> "1100 in Edmonton".</example>
        /// <returns>current time in 7 different time zones.</returns>
        [HttpGet]
        [Route("api/J32009/localTime/{input}")]
        public string[] timeProvinces(int input)
        {
            int victoriaTime = input - 300;
            int edmontonTime = input - 200;
            int winnipegTime = input - 100;
            int halifaxTime = input + 100;
            int  stjohnsTime = input + 130;

            if (victoriaTime < 0)
            {
                victoriaTime += 2400;
            }
            else if (victoriaTime > 2400)
            {
                victoriaTime -= 2400;
            }
            if (edmontonTime < 0)
            {
                edmontonTime += 2400;
            }
            else if (edmontonTime > 2400)
            {
                edmontonTime -= 2400;
            }
            if (winnipegTime < 0)
            {
                winnipegTime += 2400;
            }
            else if (winnipegTime > 2400)
            {
                winnipegTime -= 2400;
            }
            if (halifaxTime < 0)
            {
                halifaxTime += 2400;
            }
            else if (halifaxTime > 2400)
            {
                halifaxTime -= 2400;
            }
            if (stjohnsTime < 0)
            {
                stjohnsTime += 2400;
            }
            else if (stjohnsTime > 2400)
            {
                stjohnsTime -= 2400;
            }



            string[] message = {input.ToString() + " in " + "Ottawa",
                             victoriaTime.ToString() + " in " + "Victoria",
                             edmontonTime.ToString() + " in " + "Edmonton",
                             winnipegTime.ToString() + " in " + "Winnipeg",
                             input.ToString() + " in " + "Toronto",
                             halifaxTime.ToString() + " in " + " Halifax",
                             stjohnsTime.ToString() + " in " + "St.John's" };
            return message;

        }
          
        
    }
}

        


