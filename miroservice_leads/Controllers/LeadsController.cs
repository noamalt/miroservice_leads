using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using miroservice_leads.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Builder.Extensions;


namespace miroservice_leads.Controllers
{
    [Route("api/[controller]")]

    public class LeadsController : ControllerBase
    {



        [EnableQuery]
        public IActionResult Get()
        {
            using (var context = new CRM3Context())
            {
                var dbcontext = new CRM3Context();
                return Ok(dbcontext.Leads.AsQueryable());
            }

        }

        // GET api/values

        //[HttpGet]
        //public ActionResult<IEnumerable<Leads>> Get()
        //{

        //    using (var context = new CRM3Context())
        //    {
        //        var leads = context.Leads.Where(l => l.OfficeId == 6).OrderByDescending(l => l.DateEntered).Take(100).ToList();
        //        return leads;
        //    }

        //}

        // GET api/values/5

        [HttpGet("{id}")]
        public ActionResult<Leads> Get(int id)
        {
            using (var context = new CRM3Context())
            {
                var lead = context.Leads.Where(l => l.LeadId == id).Single();
                return lead;
            }
            
        }

        // POST api/values
        [EnableQuery]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


       
    }
}
