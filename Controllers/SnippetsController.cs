using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WikiSnippets.Data;
using WikiSnippets.Models;

namespace WikiSnippets.Controllers{

    /*
        /api/snippets           GET     READ        200 OK          400 Bad Request / 404 Not Found
        /api/snippets/{id}      GET     READ        200 OK          400 Bad Request / 404 Not Found
        /api/snippets           POST    CREATE      201 Created     400 Bad Request / 404 Not Found
        /api/snippets/{id}      PUT     UPDATE      204 No Content  400 Bad Request / 404 Not Found
        /api/snippets/{id}      DELETE  DELETE      200 OK          400 Bad Request / 404 Not Found
    */
    [Route("api/snippets")]
    [ApiController]
    public class SnippetsController : ControllerBase
    {
        private readonly ISnippetRepository _repository;

        public SnippetsController(ISnippetRepository repository)
        {
            _repository = repository;
        }

        //GET api/snippets
        [HttpGet]
        public ActionResult<IEnumerable<Snippet>> GetAllSnippets(){
            var snippetsItems = _repository.GetAllSnippets();

            return Ok(snippetsItems);
        }

        //GET api/snippets/{id}
        [HttpGet("{id}")]
        public ActionResult<Snippet> GetCommandById(int id){
            var snippetItem = _repository.GetSnippetById(id);

            return Ok(snippetItem);
        }
    }
}