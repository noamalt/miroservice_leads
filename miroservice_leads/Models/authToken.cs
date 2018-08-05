using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace miroservice_leads.Models
{
    public class authToken
    {

        public string APIToken { get; set; }
        public int? CTAPId { get; set; }

    }
}
