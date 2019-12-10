﻿using System.Collections.Generic;

namespace AAS_Modeling
{
    public class LinkAsset : BaseAsset
    {
        public string Url { get; set; }
        public string Documentaion { get; set; }
        public List<string> Parameters { get; set; }
    }
}