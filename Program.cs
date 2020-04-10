using System;
using SpotifyControlPanel.Models;
using SpotifyControlPanel.Interfaces;
using SpotifyControlPanel.Classes;

namespace SpotifyControlPanel
{
    class Program
    {
        private static IUsers _users;
        public Program(IUsers users)
        {
            _users = users;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SpotifyAccessToken accessToken = GetConnection();

            string chosenCommand = TakeInput();
            ExecuteCommand(chosenCommand);
        }

        public static string TakeInput()
        {
            Console.WriteLine("Enter your spotify command (type help for further commands)");
            return Console.ReadLine();            
        }

        public static void ExecuteCommand(string command)
        {

        }

        public static SpotifyAccessToken GetConnection()
        {
            SpotifyConnection connection = new SpotifyConnection();
            SpotifyAccessToken token = connection.GetAccessToken();

            return token;
        }
    }
}
