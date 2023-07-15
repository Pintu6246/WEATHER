using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WEATHER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKEY = "7763e14025b1ec6f80842a4fb31706f7";
        private void btn_search_Click(object sender, EventArgs e)
        {
            getweather();
        }
        private void getweather()
        {
            using (WebClient web = new WebClient()) 
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKEY);
                var json=web.DownloadString(url);
                WEATHERINFO.root Info = JsonConvert.DeserializeObject<WEATHERINFO.root>(json);
                pic_icon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lab_condition.Text = Info.weather[0].main;
                lab_details.Text = Info.weather[0].description;
                lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_windspeed.Text=Info.wind.speed.ToString();
                lab_pressure.Text=Info.main.pressure.ToString();
                lab_temp.Text=Info.main.temp.ToString();
                lab_humidity.Text=Info.main.humidity.ToString();
                lab_lat.Text=Info.coord.lat.ToString();
                lab_lon.Text = Info.coord.lon.ToString();
            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day=new DateTime(1970,1,1,0,0,0,DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
    }
}
