using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using miroservice_leads.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace miroservice_leads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadsController : ControllerBase
    {

        [EnableQuery(PageSize = 100, AllowedQueryOptions = AllowedQueryOptions.All)]
        public IActionResult Get()
        {
            using (var context = new CRM3Context())
            {
                var dbcontext = new CRM3Context();
                return Ok(dbcontext.Leads.AsQueryable());
            }
        }


        // GET api/values/5

        [HttpGet("{id}", Name = "GetLead")]
        public ActionResult<Leads> Get(int id)
        {
            using (var context = new CRM3Context())
            {
                var lead = context.Leads.Where(l => l.LeadId == id).Single();
                return lead;
            }
        }

        // POST api/values

        [HttpPost]
        public IActionResult Post(Leads lead)
        {
            using (var context = new CRM3Context())
            {
                var dbcontext = new CRM3Context();
                try
                {
                    dbcontext.Leads.Add(lead);
                    dbcontext.SaveChanges();
                    return Ok(lead);
                }
                catch (Exception ex)
                {
                    return BadRequest();
                }


            }



        }

        // PUT api/values/5

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Leads item)
        {
            using (var context = new CRM3Context())
            {
                var dbcontext = new CRM3Context();
                try
                {
                                       

                    var lead= dbcontext.Leads.Where(l => l.LeadId == id).Single();
                    lead.Email = item.Email;
                    lead.FirstName = item.FirstName;
                    lead.LastName = item.LastName;
                    lead.Address = item.Address;
                    lead.Ip = item.Ip;
                    lead.Phone = lead.Phone;

                   
                    dbcontext.Leads.Update(lead);
                    dbcontext.SaveChanges();
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest();
                }


            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var context = new CRM3Context())
            {
                var dbcontext = new CRM3Context();
                try
                {
                    var lead = dbcontext.Leads.Find(id);
                    if (lead == null)
                    {
                        return NotFound();
                    }

                    dbcontext.Leads.Remove(lead);
                    dbcontext.SaveChanges();
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest();
                }


            }



        }

    }
}