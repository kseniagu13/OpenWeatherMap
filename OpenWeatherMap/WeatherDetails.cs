using System;
using System.Collections.Generic;
namespace OpenWeatherMap
{
   class WeatherDetails
    {
        public class Weather //selle klassi sees on järgmised omadused:
        {
            public string Main { get; set; }
            public string Description { get; set; }
        }
        public class Sys
        {
            public string Country { get; set; }

        }
        public class Main
        {
            public double Temp { get; set; }
        }
        
        public class root 
        {
          public string Name { get; set; } //name asub üldfili sees, ehk rootis
          public List <Weather> Weather { get; set; }
          public Sys Sys { get; set; }
         public Main Main { get; set; }
        }
        
    }
}
