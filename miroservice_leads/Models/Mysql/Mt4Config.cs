using System;
using System.Collections.Generic;

namespace miroservice_leads.Models.Mysql
{
    public partial class Mt4Config
    {
        public int Config { get; set; }
        public int? ValueInt { get; set; }
        public string ValueStr { get; set; }
    }
}
