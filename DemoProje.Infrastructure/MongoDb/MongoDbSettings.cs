﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Persistence.Models
{
    public class MongoDbSettings
    {
        public string ConnectionURI { get; set; } = null;
        public string DatabaseName { get; set; } = null;
    }
}
