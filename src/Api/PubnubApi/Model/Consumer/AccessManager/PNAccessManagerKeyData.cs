﻿using System;

namespace PubnubApi
{
    public class PNAccessManagerKeyData
    {
        public bool ReadEnabled { get; set; }

        public bool WriteEnabled { get; set; }

        public bool ManageEnabled { get; set; }

        public bool DeleteEnabled { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
