using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyControlPanel.Models
{
    public class User
    {
        public string display_name { get; set; }
        public Object followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }
}
