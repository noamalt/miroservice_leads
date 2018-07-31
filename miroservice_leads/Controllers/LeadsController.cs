﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miroservice_leads.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;


namespace miroservice_leads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadsController : ControllerBase
    {



        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
        public IActionResult Get()
        {
            using (var context = new CRM3Context())
            {
                var dbcontext = new CRM3Context();
                return Ok(dbcontext.Leads.AsQueryable());
            }

        }

 

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
