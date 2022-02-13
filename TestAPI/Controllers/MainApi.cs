using Microsoft.AspNetCore.Mvc;


namespace TestAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]


    public class MainApi : ControllerBase
    {

 
        [HttpPost(Name = "GetWeatherForecast")]
        public ActionResult<List<string>> IntListWork(List<double> lint)
        {
            List<string> slist = new List<string>();
            
            double sum = 0;
            double counter = 0;
            double mean = 0;
            double standard = 0;
            double sd = 0;

            lint.Sort();


            foreach (double i in lint)
            {
                counter++;
                sum += i;
                mean = sum / counter;
                standard += Math.Pow((i - mean),2);
                Console.WriteLine(standard.ToString());
                sd =Math.Sqrt((standard) / (lint.Count-1));
                if(counter<=1)
                {
                    slist.Add("List too small");
                }
                else
                { 
                slist.Add("Element: " + counter + " Current Standard Deviation is : " + sd);
                }
            }
            Console.WriteLine("Sum: " + sum);

            return slist;
        }


    }


}

