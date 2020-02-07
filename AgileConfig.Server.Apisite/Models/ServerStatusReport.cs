﻿using AgileConfig.Server.Apisite.Websocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileConfig.Server.Apisite.Models
{
    public class ServerStatusReport
    {
        public WebsocketCollectionReport WebsocketCollectionReport { get; set; }

        public int AppCount { get; set; }

        public int ConfigCount { get; set; }
    }
}
