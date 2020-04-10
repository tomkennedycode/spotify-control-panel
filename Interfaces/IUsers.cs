using System;
using System.Collections.Generic;
using System.Text;
using SpotifyControlPanel.Models;

namespace SpotifyControlPanel.Interfaces
{
    public interface IUsers
    {
        User GetData(string userId);
    }
}
