using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherAPI
{
    public class WeatherInfo
    {
        public string name { get; set; }
        public Weather[] weather { get; set; }
        public Temp main { get; set; }
        public SystemInfo sys { get; set; }
    }

    public class Temp
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double humidity { get; set; }
    }

    public class SystemInfo
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
        public float message { get; set; }
    }
    public class Weather
    {

        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}