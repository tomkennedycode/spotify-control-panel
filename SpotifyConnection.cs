using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpotifyControlPanel.Models;

namespace SpotifyControlPanel
{
    class SpotifyConnection
    {
        public SpotifyAccessToken GetAccessToken()
        {
            try
            {
                SpotifyAccessToken token = new SpotifyAccessToken();
                string url5 = "https://accounts.spotify.com/api/token";

                //Get details
                //Console.WriteLine("What is the client id");
                //var clientid = Console.ReadLine();
                //Console.WriteLine("What is the client secret id");
                //var clientsecret = Console.ReadLine();
                var clientid = "";
                var clientsecret = "";
                var encode_clientid_clientsecret = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", clientid, clientsecret)));

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url5);

                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Accept = "application/json";
                webRequest.Headers.Add("Authorization: Basic " + encode_clientid_clientsecret);

                var request = ("grant_type=client_credentials");
                byte[] req_bytes = Encoding.ASCII.GetBytes(request);
                webRequest.ContentLength = req_bytes.Length;

                Stream strm = webRequest.GetRequestStream();
                strm.Write(req_bytes, 0, req_bytes.Length);
                strm.Close();

                HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse();
                String json = "";
                using (Stream respStr = resp.GetResponseStream())
                {
                    using (StreamReader rdr = new StreamReader(respStr, Encoding.UTF8))
                    {
                        //should get back a string i can then turn to json and parse for accesstoken
                        json = rdr.ReadToEnd();
                        rdr.Close();
                    }
                };

                token = JsonConvert.DeserializeObject<SpotifyAccessToken>(json);                

                return token;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return new SpotifyAccessToken(); 
            }
        }
    }
}
