using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherAPI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method displays data from openWeathermap API.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnWeatherData_Click(object sender, EventArgs e)
        {
            string appId = "ENTER APIKEY HERE";        
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", txtCityName.Text.Trim(), appId);

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);
                //
                
                lblTempMin.Text = string.Format("{0}°С", Math.Round(weatherInfo.main.temp_min, 1));
                lblTempMax.Text = string.Format("{0}°С", Math.Round(weatherInfo.main.temp_max, 1));
                imgWeatherIcon.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.weather[0].icon);
                lblDescription.Text = weatherInfo.weather[0].description;
                lblCity_Country.Text = weatherInfo.name + "," + weatherInfo.sys.country;
                imgCountryFlag.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.sys.country.ToLower());
                lblHumidity.Text = weatherInfo.main.humidity.ToString();
                tblWeather.Visible = true;
            }
        }
    }
}