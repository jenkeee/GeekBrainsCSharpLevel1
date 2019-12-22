using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp7WeatherForecast
{
    /// <summary>
    /// Прогноз погоды
    /// </summary>
    public class WeatherForecast
    {
        private string address;
        public WeatherForecast(string address = "https://xml.meteoservice.ru/export/gismeteo/point/2852.xml")
        {
            this.address = address;
        }
        /// <summary>
        /// Получение прогноза погоды прямо сейчас
        /// </summary>
        /// <returns></returns>
        public (string, string, string, string) GetNow()
        {
            string xmlContent = new WebClient {Encoding = Encoding.UTF8}.DownloadString(address);
            List<WeatherDay> list = ParseForecastXML(xmlContent);
            return (list[0].ToString(), list[1].ToString(), list[2].ToString(), list[3].ToString());
        }
        /// <summary>
        /// Разбор строки xml
        /// </summary>
        /// <param name="xmlContent"></param>
        /// <returns></returns>
        private static List<WeatherDay> ParseForecastXML(string xmlContent)
        {
            XDocument xdoc = XDocument.Parse(xmlContent);
            List<WeatherDay> list = new List<WeatherDay>();
            foreach (var elem in xdoc.Root.Elements().Elements().Elements().Where(r => r.Name == "FORECAST"))
            {
                WeatherDay day = new WeatherDay();
                day.Tod = elem.Attribute("tod").Value switch
                {
                    "0" => "Ночь",
                    "1" => "Утро",
                    "2" => "День",
                    _ => "Вечер",
                };

                foreach (var podElem in elem.Elements())
                {
                    if (podElem.Name == "PHENOMENA")
                    {
                        day.Cloudiness = podElem.Attribute("cloudiness").Value switch
                        {
                            "-1" => "Туман",
                            "0" => "Ясно",
                            "1" => "Малооблачно",
                            "2" => "Облачно",
                            _ => "Пасмурно",
                        };
                        day.Precipitation = podElem.Attribute("precipitation").Value switch
                        {
                            "3" => "Смешанные",
                            "4" => "Дождь",
                            "5" => "Ливень",
                            "6" => "Снег",
                            "7" => "Снег",
                            "8" => "Гроза",
                            "9" => "Нет данных",
                            _ => "Без осадков",
                        };
                        day.RPower = podElem.Attribute("rpower").Value switch
                        {
                            "1" => "Возможны осадки",
                            _ => string.Empty,
                        };
                        day.SPower = podElem.Attribute("spower").Value switch
                        {
                            "1" => "Возможна гроза",
                            _ => string.Empty,
                        };
                    }

                    if (podElem.Name == "TEMPERATURE")
                    {
                        int.TryParse(podElem.Attribute("max").Value, out int max);
                        day.Max = max;
                        int.TryParse(podElem.Attribute("min").Value, out int min);
                        day.Min = min;
                    }

                    if (podElem.Name == "WIND")
                    {
                        int.TryParse(podElem.Attribute("max").Value, out int max);
                        day.WindMax = max;
                        int.TryParse(podElem.Attribute("min").Value, out int min);
                        day.WindMin = min;
                        day.WindDirection = podElem.Attribute("direction").Value switch
                        {
                            "0" => "Северный",
                            "1" => "Северо-восточный",
                            "2" => "Восточный",
                            "3" => "Южно-восточный",
                            "4" => "Южный",
                            "5" => "Южно-западный",
                            "6" => "Западный",
                            _ => "Северо-западный"
                        };
                    }
                }
                list.Add(day);
            }
            return list;
        }
    }



    /// <summary>
    /// Прогноз для одного дня
    /// </summary>
    public struct WeatherDay
    {
        public string Tod { get; set; }
        public string Cloudiness { get; set; }
        public string Precipitation { get; set; }
        public string RPower { get; set; }
        public string SPower { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int WindMax { get; set; }
        public int WindMin { get; set; }
        public string WindDirection { get; set; }
        public override string ToString()
        {
            return $"Время: {Tod} \n\nОблачность: {Cloudiness} \nТип осадков: {Precipitation} {RPower} {SPower} \nТемпература:\nот {Min}°С до {Max}°С \nВетер:\nот {WindMin} до {WindMax} метров в секунду \nНаправление ветра: {WindDirection}";
        }
    }
}
