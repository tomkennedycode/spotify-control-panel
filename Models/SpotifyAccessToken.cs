﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyControlPanel.Models
{
    public class SpotifyAccessToken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string scope { get; set; }
    }
}
