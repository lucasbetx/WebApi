using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models.Context;
using WebApi.Models.Entities;

namespace WebApi.Controllers
{
    public class EditorasController : ApiController
    {
        BancoContext db = new BancoContext();
        public IHttpActionResult GetEditoras()
        {
            var editoras = db.Editoras;

            if (editoras.Count() == 0)
                return NotFound();

            return Ok(db.Editoras.ToList());
        }

        public IHttpActionResult PostEditora(Editora editora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Editoras.Add(editora);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = editora.Id }, editora);
        }

        public IHttpActionResult PutEditora(Guid id, Editora editora)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != editora.Id)
                return BadRequest("O Id informado na URL é diferente do código da editora.");

            if (db.Editoras.Count(e => e.Id == editora.Id) == 0)
                return NotFound();

            db.Entry(editora).State = EntityState.Modified;

            foreach (var livro in editora.Livros)
            {
                if (livro.Codigo != 0)
                    db.Entry(livro).State = EntityState.Modified;
                else
                    db.Entry(livro).State = EntityState.Added;
            }

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteEditora(Guid id)
        {
            if (id == Guid.Empty || id == null)
                return BadRequest("O ID é inválido.");

            Editora editora = db.Editoras.Find(id);

            if (editora == null)
                return NotFound();

            //db.Entry(editora).State = EntityState.Deleted;

            db.Editoras.Remove(editora);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
