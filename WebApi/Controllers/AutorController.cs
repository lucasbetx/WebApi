using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models.Context;
using WebApi.Models.Entities;
using WebApi.Models.Validations;
using FluentValidation;
using WebApi.Filters;

namespace WebApi.Controllers
{
    public class AutorController : ApiController
    {
        BancoContext db = new BancoContext();

        AutorValidator validator = new AutorValidator();


        //public IHttpActionResult PostAutor(Autor autor)
        //{

        //    //validator.ValidateAndThrow(autor);

        //    //////if (resultado.IsValid)
        //    //////{
        //    ////db.Autores.Add(autor);
        //    //db.SaveChanges();
        //    //return CreatedAtRoute("DefaultApi", new { id = autor.Id }, autor);
        //    //////}

        //    //////var resposta = new HttpResponseMessage(HttpStatusCode.BadRequest)
        //    //////{
        //    //////    Content = new ObjectContent<FluentValidation.Results.ValidationResult>(
        //    //////        resultado,
        //    //////        new System.Net.Http.Formatting.JsonMediaTypeFormatter())
        //    //////};


        //    //////return ResponseMessage(resposta);
        //    /////
        //}


        //public IHttpActionResult PutAutor(int id, Autor autor)
        //{
        //    //validator.ValidateAndThrow(autor);


        //    //if (id != autor.Id)
        //    //{
        //    //    return BadRequest("O Id informado na URL é diferente do id do autor");
        //    //}

        //    ////if (db.Autores.Count(a => a.Id == autor.Id) == 0)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //db.Entry(autor).State = EntityState.Modified;
        //    //db.SaveChanges();

        //    //return StatusCode(HttpStatusCode.NoContent);

        //}
    }
}