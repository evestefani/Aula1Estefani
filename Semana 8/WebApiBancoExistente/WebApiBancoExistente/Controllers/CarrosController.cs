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
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public class CarrosController : ApiController
    {
        private DataBaseContext db = new DataBaseContext();

        [HttpGet]
        [Route("Api/Carros/CustomCarroQuery")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from car in listaDeCarros
                                select new {
                                NomeCarro = car.Modelo,
                                CarroId = car.Id
                                };

            return retornoCarros;
        }

        [HttpGet]
        [Route("Api/Carros/CustomMarcaQuery")]
        public object CustomMarcasQuery()
        {
            var listaDeMarcas = db.Marcas.ToList();

            var retornoMarcas = from mar in listaDeMarcas
                                select new{
                                NomeMarca = mar.Nome,
                                MarcaId = mar.Id
                                };

            return retornoMarcas;
        }

        [HttpGet]
        [Route("Api/Carros/CustomUsuarioQuery")]
        public object CustomUsuariosQuery()
        {
            var listaDeUsuarios = db.Usuarios.ToList();

            var retornoUsuarios = from usu in listaDeUsuarios
                                select new{
                                NomeUsuario = usu.Usuario1,
                                UsuarioId = usu.Id
                                };

            return retornoUsuarios;
        }

        [HttpGet]
        [Route("Api/Carros/CustomVendaQuery")]
        public object CustomVendasQuery()
        {
            var listaDeVendas = db.Vendas.ToList();

            var retornoVendas = from ven in listaDeVendas
                                select new{
                                VendaCarro = ven.Carro,
                                VendaId = ven.Id
                                };

            return retornoVendas;
        }


        [HttpGet]
        [Route("Api/Carros/CustomCarrosOnMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listMarcas
                                  join car in listCarros
             on mar.Id equals car.Marca
                                  select new {
                                  CarroId = car.Id,
                                  CarroNome = car.Modelo,
                                  MarcaId = mar.Id,
                                  MarcaNome = mar.Nome
                                  };

            return conteudoRetorno;

        }

        [HttpGet]
        [Route("Api/Carros/CustomCarroOnUsuario")]
        public object CustomCarroOnUsuario(int IdCarro)
        {
            var listCarros = db.Carros.Where(item => item.Id == IdCarro).ToList();
            var listUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from usu in listUsuarios
                                  join car in listCarros
                                  on usu.Id equals car.UsuInc
                                  select new{
                                  CarroId = car.Id,   
                                  UsuarioId = usu.Id,
                                  UsuarioNome = usu.Usuario1
                                  };

            return conteudoRetorno;

        }


        // GET: api/Carros
        public IQueryable<Carro> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carros/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult GetCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            return Ok(carro);
        }

        // PUT: api/Carros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarro(int id, Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carro.Id)
            {
                return BadRequest();
            }

            db.Entry(carro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
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

        // POST: api/Carros
        [ResponseType(typeof(Carro))]
        public IHttpActionResult PostCarro(Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carro.Id }, carro);
        }

        // DELETE: api/Carros/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult DeleteCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carro);
            db.SaveChanges();

            return Ok(carro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}