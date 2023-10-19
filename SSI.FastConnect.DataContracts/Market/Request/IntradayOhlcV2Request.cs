﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SSI.FastConnect.DataContracts.Market.Request
{
    public class IntradayOhlcV2Request
    {
        public string Symbol { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int PageIndex { get; set; } = 1;
        public int Resolution { get; set; } = 10;
        public int PageSize { get; set; } = 10000;
        public bool Ascending { get; set; }
    }
}