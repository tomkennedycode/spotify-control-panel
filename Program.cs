using System;
using SpotifyControlPanel.Models;

namespace SpotifyControlPanel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SpotifyAccessToken accessToken = GetConnection();
        }

        public static SpotifyAccessToken GetConnection()
        {
            SpotifyConnection connection = new SpotifyConnection();
            SpotifyAccessToken token = connection.GetAccessToken();

            return token;
        }
    }
}
