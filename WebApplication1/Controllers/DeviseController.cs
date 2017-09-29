using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DeviseController : ApiController
    {
        public List<Models.Devise> deviseList;

        public DeviseController()
        {
            deviseList = new List<Models.Devise>();
            Models.Devise deviseDollar = new Models.Devise(1, "Dollar", 1.08);
            Models.Devise deviseFSuisse = new Models.Devise(2, "Franc Suisse", 1.07);
            Models.Devise deviseYen = new Models.Devise(3, "Yen", 120);
            deviseList.Add(deviseDollar);
            deviseList.Add(deviseFSuisse);
            deviseList.Add(deviseYen);
        }


        // GET: api/Devise
        public IEnumerable<Devise> Get()
        {
            return deviseList.AsEnumerable();
        }

        // GET: api/Devise/5
        [ResponseType(typeof(Models.Devise))]
        public IHttpActionResult Get(int id)
        {
            Models.Devise devise =
                (from d in deviseList
                 where d.Id == id
                 select d).FirstOrDefault();
            if (devise == null)
            {
                return NotFound();
            }
            return Ok(devise);
        }

        // POST: api/Devise
        [ResponseType(typeof(Models.Devise))]
        public IHttpActionResult Post(Models.Devise devise)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            deviseList.Add(devise);
            return CreatedAtRoute("DefaultApi", new { id = devise.Id }, devise);
        }

        // PUT: api/Devise/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Models.Devise devise)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(id != devise.Id)
            {
                return BadRequest();
            }
            int index = deviseList.FindIndex((d) => d.Id == id);
            if (index < 0)
            {
                return NotFound();
            }
            deviseList[index] = devise;
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Devise/5
        [ResponseType(typeof(Models.Devise))]
        public IHttpActionResult Delete(int id)
        {
            Models.Devise devise =
                (from d in deviseList
                 where d.Id == id
                 select d).FirstOrDefault();
            if (devise == null)
            {
                return NotFound();
            }
            deviseList.Remove(devise);
            return Ok(devise);
        }
    }
}
