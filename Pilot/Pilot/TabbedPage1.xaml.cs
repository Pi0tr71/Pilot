using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Pilot.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Pilot.Model;
using Newtonsoft.Json.Converters;

namespace Pilot
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            Wczytaj();
            InitializeComponent();
        }
        public class Lista
        {
            public int hour { get; set; }
            public int minute { get; set; }
            public int hourE { get; set; }
            public int minuteE { get; set; }
            public int trybZegar { get; set; }
            public int tryb { get; set; }
            public int wifi { get; set; }
        }
        async void Wczytaj()
        {
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/all");
                //var resoultAll = JsonConvert.DeserializeObject<Lista>(resolutJson);
                IEnumerable<Lista> myDeserializedClass = JsonConvert.DeserializeObject<IEnumerable<Lista>>(resolutJson);
                Console.WriteLine("API ODEBRANE");
                
                List<int> lHour = myDeserializedClass.Select(kacper => kacper.hour).ToList();
                List<int> lMinute = myDeserializedClass.Select(kacper => kacper.minute).ToList();
                List<int> lHourE = myDeserializedClass.Select(kacper => kacper.hourE).ToList();
                List<int> lMinuteE = myDeserializedClass.Select(kacper => kacper.minuteE).ToList();
                List<int> lTrybZegar = myDeserializedClass.Select(kacper => kacper.trybZegar).ToList();
                List<int> lTryb = myDeserializedClass.Select(kacper => kacper.tryb).ToList();
                List<int> lWifi = myDeserializedClass.Select(kacper => kacper.wifi).ToList();
                // By Machel
                Console.WriteLine(lHourE[0]);
                Console.WriteLine(lMinuteE[0]);

                switch (lTrybZegar[0])
                {
                    case 0:
                        button1.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button2.BackgroundColor = Color.Transparent;
                        button3.BackgroundColor = Color.Transparent;
                        button4.BackgroundColor = Color.Transparent;
                        button5.BackgroundColor = Color.Transparent;
                        button6.BackgroundColor = Color.Transparent;
                        break;
                    case 1:
                        button1.BackgroundColor = Color.Transparent;
                        button2.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button3.BackgroundColor = Color.Transparent;
                        button4.BackgroundColor = Color.Transparent;
                        button5.BackgroundColor = Color.Transparent;
                        button6.BackgroundColor = Color.Transparent;
                        break;
                    case 2:
                        button1.BackgroundColor = Color.Transparent;
                        button2.BackgroundColor = Color.Transparent;
                        button3.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button4.BackgroundColor = Color.Transparent;
                        button5.BackgroundColor = Color.Transparent;
                        button6.BackgroundColor = Color.Transparent;
                        break;
                    case 3:
                        button1.BackgroundColor = Color.Transparent;
                        button2.BackgroundColor = Color.Transparent;
                        button3.BackgroundColor = Color.Transparent;
                        button4.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button5.BackgroundColor = Color.Transparent;
                        button6.BackgroundColor = Color.Transparent;
                        break;
                    case 4:
                        button1.BackgroundColor = Color.Transparent;
                        button2.BackgroundColor = Color.Transparent;
                        button3.BackgroundColor = Color.Transparent;
                        button4.BackgroundColor = Color.Transparent;
                        button5.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button6.BackgroundColor = Color.Transparent;
                        break;
                    case 5:
                        button1.BackgroundColor = Color.Transparent;
                        button2.BackgroundColor = Color.Transparent;
                        button3.BackgroundColor = Color.Transparent;
                        button4.BackgroundColor = Color.Transparent;
                        button5.BackgroundColor = Color.Transparent;
                        button6.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        break;
                }
                switch (lTryb[0])
                {
                    case 0:
                        button8.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button9.BackgroundColor = Color.Transparent;
                        button10.BackgroundColor = Color.Transparent;
                        button11.BackgroundColor = Color.Transparent;
                        button12.BackgroundColor = Color.Transparent;
                        button13.BackgroundColor = Color.Transparent;
                        break;
                    case 1:
                        button8.BackgroundColor = Color.Transparent;
                        button9.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button10.BackgroundColor = Color.Transparent;
                        button11.BackgroundColor = Color.Transparent;
                        button12.BackgroundColor = Color.Transparent;
                        button13.BackgroundColor = Color.Transparent;
                        break;
                    case 2:
                        button8.BackgroundColor = Color.Transparent;
                        button9.BackgroundColor = Color.Transparent;
                        button10.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button11.BackgroundColor = Color.Transparent;
                        button12.BackgroundColor = Color.Transparent;
                        button13.BackgroundColor = Color.Transparent;
                        break;
                    case 3:
                        button8.BackgroundColor = Color.Transparent;
                        button9.BackgroundColor = Color.Transparent;
                        button10.BackgroundColor = Color.Transparent;
                        button11.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button12.BackgroundColor = Color.Transparent;
                        button13.BackgroundColor = Color.Transparent;
                        break;
                    case 4:
                        button8.BackgroundColor = Color.Transparent;
                        button9.BackgroundColor = Color.Transparent;
                        button10.BackgroundColor = Color.Transparent;
                        button11.BackgroundColor = Color.Transparent;
                        button12.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        button13.BackgroundColor = Color.Transparent;
                        break;
                    case 5:
                        button8.BackgroundColor = Color.Transparent;
                        button9.BackgroundColor = Color.Transparent;
                        button10.BackgroundColor = Color.Transparent;
                        button11.BackgroundColor = Color.Transparent;
                        button12.BackgroundColor = Color.Transparent;
                        button13.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
                        break;
                }
                TimeSpan startTime = new TimeSpan(lHour[0], lMinute[0], 0);
                TimeSpan stopTime = new TimeSpan(lHourE[0], lMinuteE[0], 0);
                start.Time = startTime;
                stop.Time = stopTime;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }
        }
        int TrybZegara = 0;
        private void button1_Clicked(object sender, EventArgs e)
        {
            TrybZegara = 0;
            button1.BackgroundColor = Color.FromRgba(255,255,255,0.3);
            button2.BackgroundColor = Color.Transparent;
            button3.BackgroundColor = Color.Transparent;
            button4.BackgroundColor = Color.Transparent;
            button5.BackgroundColor = Color.Transparent;
            button6.BackgroundColor = Color.Transparent;

        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            TrybZegara = 1;
            button1.BackgroundColor = Color.Transparent;
            button2.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
            button3.BackgroundColor = Color.Transparent;
            button4.BackgroundColor = Color.Transparent;
            button5.BackgroundColor = Color.Transparent;
            button6.BackgroundColor = Color.Transparent;
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            TrybZegara = 2;
            button1.BackgroundColor = Color.Transparent;
            button2.BackgroundColor = Color.Transparent;
            button3.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
            button4.BackgroundColor = Color.Transparent;
            button5.BackgroundColor = Color.Transparent;
            button6.BackgroundColor = Color.Transparent;
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            TrybZegara = 3;
            button1.BackgroundColor = Color.Transparent;
            button2.BackgroundColor = Color.Transparent;
            button3.BackgroundColor = Color.Transparent;
            button4.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
            button5.BackgroundColor = Color.Transparent;
            button6.BackgroundColor = Color.Transparent;
        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            TrybZegara = 4;
            button1.BackgroundColor = Color.Transparent;
            button2.BackgroundColor = Color.Transparent;
            button3.BackgroundColor = Color.Transparent;
            button4.BackgroundColor = Color.Transparent;
            button5.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
            button6.BackgroundColor = Color.Transparent;
        }

        private void button6_Clicked(object sender, EventArgs e)
        {
            TrybZegara = 5;
            button1.BackgroundColor = Color.Transparent;
            button2.BackgroundColor = Color.Transparent;
            button3.BackgroundColor = Color.Transparent;
            button4.BackgroundColor = Color.Transparent;
            button5.BackgroundColor = Color.Transparent;
            button6.BackgroundColor = Color.FromRgba(255, 255, 255, 0.3);
        }

        async private void button7_Clicked(object sender, EventArgs e)
        {
            button7.BackgroundColor = Color.FromRgba(255, 255, 255, 0.4);
            int hour = start.Time.Hours;
            int minute = start.Time.Minutes;
            int houre = stop.Time.Hours;
            int minutee = stop.Time.Minutes;
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/zegar/"+hour+","+minute+"," + houre + "," + minutee + "," + TrybZegara);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }


        }
        async private void button8_Clicked(object sender, EventArgs e)
        {
            button8.BackgroundColor = Color.FromRgba(255, 255, 255, 0.4);
            button9.BackgroundColor = Color.Transparent;
            button10.BackgroundColor = Color.Transparent;
            button11.BackgroundColor = Color.Transparent;
            button12.BackgroundColor = Color.Transparent;
            button13.BackgroundColor = Color.Transparent;
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/tryb/0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }

        }
        async private void button9_Clicked(object sender, EventArgs e)
        {
            button9.BackgroundColor = Color.FromRgba(255, 255, 255, 0.4);
            button8.BackgroundColor = Color.Transparent;
            button10.BackgroundColor = Color.Transparent;
            button11.BackgroundColor = Color.Transparent;
            button12.BackgroundColor = Color.Transparent;
            button13.BackgroundColor = Color.Transparent;
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/tryb/1");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }

        }
        async private void button10_Clicked(object sender, EventArgs e)
        {
            button10.BackgroundColor = Color.FromRgba(255, 255, 255, 0.4);
            button9.BackgroundColor = Color.Transparent;
            button8.BackgroundColor = Color.Transparent;
            button11.BackgroundColor = Color.Transparent;
            button12.BackgroundColor = Color.Transparent;
            button13.BackgroundColor = Color.Transparent;
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/tryb/2");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }

        }
        async private void button11_Clicked(object sender, EventArgs e)
        {
            button11.BackgroundColor = Color.FromRgba(255, 255, 255, 0.4);
            button9.BackgroundColor = Color.Transparent;
            button10.BackgroundColor = Color.Transparent;
            button8.BackgroundColor = Color.Transparent;
            button12.BackgroundColor = Color.Transparent;
            button13.BackgroundColor = Color.Transparent;
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/tryb/3");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }

        }
        async private void button12_Clicked(object sender, EventArgs e)
        {
            button12.BackgroundColor = Color.FromRgba(255, 255, 255, 0.4);
            button9.BackgroundColor = Color.Transparent;
            button10.BackgroundColor = Color.Transparent;
            button11.BackgroundColor = Color.Transparent;
            button8.BackgroundColor = Color.Transparent;
            button13.BackgroundColor = Color.Transparent;
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/tryb/4");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }

        }
        async private void button13_Clicked(object sender, EventArgs e)
        {
            button13.BackgroundColor = Color.FromRgba(255, 255, 255, 0.4);
            button9.BackgroundColor = Color.Transparent;
            button10.BackgroundColor = Color.Transparent;
            button11.BackgroundColor = Color.Transparent;
            button12.BackgroundColor = Color.Transparent;
            button8.BackgroundColor = Color.Transparent;
            try
            {
                var httpClient = new HttpClient();
                var resolutJson = await httpClient.GetStringAsync("http://192.168.0.104:88/api/tryb/5");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);


            }

        }


        //private void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    var current = Connectivity.NetworkAccess;
        //    if (current == NetworkAccess.Internet)
        //    {
        //        net.Text = current.ToString();
        //    }
        //    else
        //    {
        //        net.Text = current.ToString();
        //    }
        //    var profiles = Connectivity.ConnectionProfiles;
        //    if (profiles.Contains(ConnectionProfile.WiFi))
        //    {           
        //        net2.Text = profiles.ToArray()[0].ToString();
        //    }
        //    else
        //    {
        //        net2.Text = profiles.ToString();
        //    }

        //}
    }
}