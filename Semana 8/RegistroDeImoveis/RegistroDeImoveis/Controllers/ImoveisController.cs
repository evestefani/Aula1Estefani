using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RegistroDeImoveis.Models;

namespace RegistroDeImoveis.Controllers
{
    public class ImoveisController : ApiController
    {
        private RegistroDeImoveisContext db = new RegistroDeImoveisContext();

        // GET: api/Imoveis
        public IQueryable<Imovel> GetImoveis()
        {
            return db.Imoveis;
        }

        // GET: api/Imoveis/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult GetImovel(int id)
        {
            Imovel imovel = db.Imoveis.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            return Ok(imovel);
        }

        // PUT: api/Imoveis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImovel(int id, Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imovel.Id)
            {
                return BadRequest();
            }

            db.Entry(imovel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImovelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Imoveis
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult PostImovel(Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imoveis.Add(imovel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = imovel.Id }, imovel);
        }

        // DELETE: api/Imoveis/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult DeleteImovel(int id)
        {
            Imovel imovel = db.Imoveis.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            db.Imoveis.Remove(imovel);
            db.SaveChanges();

            return Ok(imovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImovelExists(int id)
        {
            return db.Imoveis.Count(e => e.Id == id) > 0;
        }
    }
}